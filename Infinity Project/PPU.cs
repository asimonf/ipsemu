using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using BigwaveColor = Bigwave.Graphx.X8R8G8B8Color;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;

namespace Infinity_Project
{
    public class PictureProcesingUnit : IDisposable
    {
        public class TileMapEntry
        {
            public bool VerticalFlip, HorizontalFlip, PriorityBit;
            public int PalleteBase, CharacterBase;
            public byte[] PixelData;
            public byte ColorKey;

            public TileMapEntry(int entry, int planeAmount, int CharacterLocation, byte[] VRam, byte[] CGRam)
            {
                PixelData = new byte[64];

                byte[,] TileData = new byte[8, planeAmount];

                VerticalFlip = (entry & 0x8000) > 0;
                HorizontalFlip = (entry & 0x4000) > 0;
                PriorityBit = (entry & 0x2000) > 0;

                PalleteBase = ((entry >> 10) & 0x07) * (2 << planeAmount);
                CharacterBase = ((entry & 0x03FF) * (8 * planeAmount)) + CharacterLocation;

                ColorKey = (byte)PalleteBase;

                for (int x = 0; x < 8; x++)
                {
                    for (int k = 0; k < planeAmount; k++)
                    {
                        int Index = (k % 2) + (x << 1) + ((k >> 1) << 4);

                        TileData[x, k] = VRam[CharacterBase + Index];
                    }

                    for (int l = 0; l < 8; l++)
                    {
                        int ColorIndex = 0;

                        int PixelNumber = 1 << l;

                        for (int k = 0; k < planeAmount; k++)
                        {
                            ColorIndex |= ((TileData[x, k] & PixelNumber) >> l) << k;
                        }

                        ColorIndex <<= 1;

                        ColorIndex += PalleteBase;

                        PixelData[(x * 8 + l)] = (byte)ColorIndex;
                    }
                }
            }

        }

        public class BG
        {
            public bool Enabled = true;
            public int TileSize = 8;
            public int TileSizeShift = 3;
            public byte VerticalTileMapSize = 32;
            public byte HorizontalTileMapSize = 32;
            public ushort HorizontalScroll;
            public bool HorizontalScrollHighByte = false;
            public ushort VerticalScroll;
            public bool VerticalScrollHighByte = false;
            public bool SubScreenEnabled;
            public bool MainScreenEnabled;
            public int CharacterLocation;
            public int TileMapLocation;
            public bool AffectedByColorConstant = false;

            private PictureProcesingUnit PPU;

            private Dictionary<int, TileMapEntry> BuiltEntries;

            short[] colors = new short[64];

            public static BigwaveColor[][] ColorData;
            public static BigwaveColor[] ColorScheme;

            unsafe static BG()
            {
                ColorData = new BigwaveColor[16][];
                ColorScheme = new BigwaveColor[65536];

                for (uint i = 0; i < 16; i++)
                {
                    ColorData[i] = new BigwaveColor[65536];

                    for (uint j = 0; j < 65536; j++)
                    {
                        uint red = j & 0x1f;
                        uint green = (j >> 5) & 0x1f;
                        uint blue = (j >> 10) & 0x1f;

                        red = (uint)Math.Round((((double)i + 1.0) / 16.0) * (double)red);
                        green = (uint)Math.Round((((double)i + 1) / 16.0) * (double)green);
                        blue = (uint)Math.Round((((double)i + 1) / 16.0) * (double)blue);

                        BigwaveColor c = new BigwaveColor();

                        c.data[2] = (byte)(red << 3);
                        c.data[1] = (byte)(green << 3);
                        c.data[0] = (byte)(blue << 3);

                        ColorData[i][j] = c;
                    }
                }

                ColorScheme = ColorData[0];
            }

            public BG(PictureProcesingUnit PPU)
            {
                this.PPU = PPU;
                this.BuiltEntries = new Dictionary<int, TileMapEntry>();
            }

            public unsafe void RenderMainScreenOpaque(int _scanline, int planeAmount, bool PriorityCheck)
            {
                int mapOffset = 0;
                int prevMapOffset = 1;

                int prevEntry = -1;
                short prevPixelColor = -1;
                BigwaveColor PixelColorTranslation = new BigwaveColor();

                TileMapEntry tme = null;

                int vPos = (_scanline + this.VerticalScroll); // % (this.TileSize * this.VerticalTileMapSize);
                while (vPos > this.TileSize * this.VerticalTileMapSize)
                    vPos -= this.TileSize * this.VerticalTileMapSize;

                int vOffset = vPos >> TileSizeShift;
                
                //if (vOffset > 32)
                //    vOffset += 32;

                vOffset *= 32;

                int* pixels = this.PPU.frameBufferPtr + (_scanline * 256);

                int vPixelOffset = vPos % this.TileSize;

                int hPos = (this.HorizontalScroll);// % (this.TileSize * this.HorizontalTileMapSize);

                for (int i = 0; i < 256; i++)
                {
                    while (hPos > this.TileSize * this.HorizontalTileMapSize)
                        hPos -= (this.TileSize * this.HorizontalTileMapSize);
                        
                    int hOffset = hPos >> TileSizeShift;

                    int hPixelOffset = hPos % this.TileSize;

                    if (hOffset > 32)
                        hOffset += 32 * 32;

                    mapOffset = ((hOffset) + (vOffset)) * 2;

                    if (mapOffset != prevMapOffset)
                    {
                        int entry = this.PPU._bus.VRam[mapOffset + this.TileMapLocation] | this.PPU._bus.VRam[mapOffset + this.TileMapLocation + 1] << 8;

                        if (entry != prevEntry)
                        {
                            if (!BuiltEntries.ContainsKey(entry))
                            {
                                tme = new TileMapEntry(entry, planeAmount, CharacterLocation, PPU._bus.VRam, PPU._bus.CGRam);
                                BuiltEntries.Add(entry, tme);
                            }
                            else
                            {
                                tme = BuiltEntries[entry];
                            }

                            prevEntry = entry;
                        }
                        prevMapOffset = mapOffset;
                    }

                    if (tme.PriorityBit == PriorityCheck)
                    {
                        int pixelOffset;

                        if (!tme.HorizontalFlip)
                            if (!tme.VerticalFlip)
                                pixelOffset = 7 - (hPixelOffset) + (vPixelOffset) * this.TileSize;
                            else
                                pixelOffset = 7 - (hPixelOffset) + (7 - vPixelOffset) * this.TileSize;
                        else
                            if (!tme.VerticalFlip)
                                pixelOffset = (hPixelOffset) + (vPixelOffset) * this.TileSize;
                            else
                                pixelOffset = (hPixelOffset) + (7 - vPixelOffset) * this.TileSize;

                        byte PixelColor = tme.PixelData[pixelOffset];

                        if (PixelColor != tme.ColorKey)
                        {
                            if (prevPixelColor != PixelColor)
                            {
                                PixelColorTranslation = BG.ColorScheme[(PPU._bus.CGRam[PixelColor] | (PPU._bus.CGRam[PixelColor + 1] << 8))];

                                if (this.AffectedByColorConstant)
                                    fixed (BigwaveColor* color = &this.PPU.ColorConstant)
                                    {
                                        if (this.PPU.SubstractMode)
                                            PixelColorTranslation.Substract(color);
                                        else
                                            PixelColorTranslation.Add(color);
                                    }

                                //PixelColorTranslation.Inverse();

                                prevPixelColor = PixelColor;
                            }

                            *pixels = PixelColorTranslation.color;
                        }
                    }
                    hPos++;
                    pixels++;
                }
            }

            //public unsafe void RenderMainScreenOpaque(int planeAmount, bool PriorityCheck)
            //{                
            //    int mapOffset = 0;
            //    int prevMapOffset = 1;

            //    int prevEntry = -1;
            //    short prevPixelColor = -1;
            //    Color PixelColorTranslation = new Color();

            //    TileMapEntry tme = null;

            //    int[] pixels = this.PPU._frameBufferPtr;

            //    //fixed (int* pixels = this.PPU._frameBufferPtr)
            //    //{
            //        for (int j = 0; j < 224; j++)
            //        {
            //            for (int i = 0; i < 256; i++)
            //            {
            //                int hPos = (i + this.HorizontalScroll) % 8 * this.HorizontalTileMapSize;
            //                //if (hPos > 8 * this.HorizontalTileMapSize)
            //                //    hPos -= 8 * this.HorizontalTileMapSize;

            //                int vPos = j + this.VerticalScroll % 8 * this.VerticalTileMapSize;
            //                //if (vPos > 8 * this.VerticalTileMapSize)
            //                //    vPos -= 8 * this.VerticalTileMapSize;

            //                mapOffset = ((hPos >> 3) + (vPos >> 3) * 32) * 2;

            //                if (mapOffset != prevMapOffset)
            //                {
            //                    int entry = this.PPU._bus.VRam[mapOffset + this.TileMapLocation];
            //                    entry |= this.PPU._bus.VRam[mapOffset + this.TileMapLocation + 1] << 8;

            //                    if (entry != prevEntry)
            //                    {
            //                        if (!BuiltEntries.ContainsKey(entry))
            //                        {
            //                            tme = new TileMapEntry(entry, planeAmount, CharacterLocation, PPU._bus.VRam, PPU._bus.CGRam);
            //                            BuiltEntries.Add(entry, tme);
            //                        }
            //                        else
            //                        {
            //                            tme = BuiltEntries[entry];
            //                        }

            //                        prevEntry = entry;
            //                    }
            //                    prevMapOffset = mapOffset;
            //                }

            //                //if (tme.PriorityBit == PriorityCheck)
            //                //{
            //                    int pixelOffset = 7 - (hPos % 8) + (vPos % 8) * 8;

            //                    byte PixelColor = tme.PixelData[pixelOffset];

            //                    //if (PixelColor != tme.PalleteBase)
            //                    //{
            //                        if (prevPixelColor != PixelColor)
            //                        {
            //                            PixelColorTranslation = BG.ColorScheme[PixelColor];

            //                            if (this.AffectedByColorConstant)
            //                                if (this.PPU.SubstractMode)
            //                                    PixelColorTranslation = SdlColor.Subtract(PixelColorTranslation, this.PPU.ColorConstant);
            //                                else
            //                                    PixelColorTranslation = SdlColor.Add(PixelColorTranslation, this.PPU.ColorConstant);

            //                            prevPixelColor = PixelColor;
            //                        }

            //                        pixels[i + j * 256] = PixelColorTranslation.ToArgb();
            //                    //}
            //                //}
            //            }
            //        }
            //    //}
            //}
        }

        // Atributos

        //private Bitmap _fBuffer;
        //private BitmapData _frameBufferPtr;

        unsafe internal int* frameBufferPtr;
        internal Surface frameBufferSurface;
        internal GraphicsStream surfaceStream;
        internal Device dev;

        private VertexBuffer _vertexBuffer;
        private Texture _frameBufferTexture;
        private Font _fps;
        private Sprite hudRenderer;

        private int _frameCount;
        private int _frameSkip = 2;

        public int FrameCount
        {
            get { return _frameCount; }
            set { _frameCount = value; }
        }

        public int FrameSkip
        {
            get { return _frameSkip; }
            set { _frameSkip = value; }
        }

        internal bool InVBlank;
        internal bool DisableScreen;
        internal bool PriorityBit;
        internal int Brightness;
        internal int BGMode;

        internal BG BG1;
        internal BG BG2;
        internal BG BG3;
        internal BG BG4;

        internal BigwaveColor ColorConstant = new BigwaveColor();
        internal bool AffectBackground = false;
        internal bool SubstractMode = false;
        private Bus _bus;

        public PictureProcesingUnit(Bus bus, Device dev)
        {
            this._bus = bus;
            this.dev = dev;
            //this._fBuffer = frameBuffer;
            //this._cleanBuffer = new int[256 * 224];

            //for (int j = 0; j < 256 * 224; j++)
            //{
            //    this._cleanBuffer[j] = j;//(j / 256) + j % 256;
            //}

            this._fps = new Font(dev, new System.Drawing.Font("arial", 12));
            this._vertexBuffer = new VertexBuffer(typeof(CustomVertex.TransformedTextured), 4, dev, Usage.None, CustomVertex.TransformedTextured.Format, Pool.Managed);
            this._frameBufferTexture = new Texture(dev, 256, 256, 1, Usage.Dynamic, Format.X8R8G8B8, Pool.Default);
            this.frameBufferSurface = dev.CreateOffscreenPlainSurface(256, 256, Format.X8R8G8B8, Pool.SystemMemory);
            hudRenderer = new Sprite(dev);

            {
                int index = 0;

                CustomVertex.TransformedTextured[] verts = _vertexBuffer.Lock(0, 0) as CustomVertex.TransformedTextured[];

                verts[index++] = new CustomVertex.TransformedTextured(0, 0, 0.5f, 1, 0, 0);
                verts[index++] = new CustomVertex.TransformedTextured(dev.PresentationParameters.DeviceWindow.ClientSize.Width, 0, 0.5f, 1, 1, 0);
                verts[index++] = new CustomVertex.TransformedTextured(0, dev.PresentationParameters.DeviceWindow.ClientSize.Height, 0.5f, 1, 0, 0.875f);
                verts[index++] = new CustomVertex.TransformedTextured(dev.PresentationParameters.DeviceWindow.ClientSize.Width, dev.PresentationParameters.DeviceWindow.ClientSize.Height, 0.5f, 1, 1, 0.875f);

                _vertexBuffer.Unlock();
            }

            BG1 = new BG(this);
            BG2 = new BG(this);
            BG3 = new BG(this);
            BG4 = new BG(this);
        }

        private Type _intType = typeof(int);

        public unsafe void DrawScanline(int scanlineNumber)
        {
            int backColor = 0;

            if (this.AffectBackground)
                if (this.SubstractMode)
                    backColor = BigwaveColor.Substract(BG.ColorScheme[this._bus.CGRam[0] | (this._bus.CGRam[1] << 8)], this.ColorConstant);
                else
                    backColor = BigwaveColor.Add(BG.ColorScheme[this._bus.CGRam[0] | (this._bus.CGRam[1] << 8)], this.ColorConstant);
            else
                backColor = BG.ColorScheme[this._bus.CGRam[0] | (this._bus.CGRam[1] << 8)].color;

            //int* ptr = (int*)this._frameBufferPtr.Scan0.ToPointer();

            for (int i = 0; i < 256; i++)
            {
                this.frameBufferPtr[i + scanlineNumber * 256] = backColor;
            }

            switch (this.BGMode)
            {
                case 0x00:
                    this.BGData(scanlineNumber, this.BG4, false, 1);
                    this.BGData(scanlineNumber, this.BG3, false, 1);
                    this.BGData(scanlineNumber, this.BG4, true, 1);
                    this.BGData(scanlineNumber, this.BG3, true, 1);
                    this.BGData(scanlineNumber, this.BG2, false, 1);
                    this.BGData(scanlineNumber, this.BG1, false, 1);
                    this.BGData(scanlineNumber, this.BG2, true, 1);
                    this.BGData(scanlineNumber, this.BG1, true, 1);
                    break;
                case 0x01:
                    if (PriorityBit)
                    {
                        this.BGData(scanlineNumber, this.BG3, false, 2);
                        this.BGData(scanlineNumber, this.BG2, false, 4);
                        this.BGData(scanlineNumber, this.BG1, false, 4);
                        this.BGData(scanlineNumber, this.BG2, true, 4);
                        this.BGData(scanlineNumber, this.BG1, true, 4);
                        this.BGData(scanlineNumber, this.BG3, true, 2);
                    }
                    else
                    {
                        this.BGData(scanlineNumber, this.BG3, false, 2);
                        this.BGData(scanlineNumber, this.BG3, true, 2);
                        this.BGData(scanlineNumber, this.BG2, false, 4);
                        this.BGData(scanlineNumber, this.BG1, false, 4);
                        this.BGData(scanlineNumber, this.BG2, true, 4);
                        this.BGData(scanlineNumber, this.BG1, true, 4);
                    }
                    break;
                case 0x02:
                    this.BGData(scanlineNumber, this.BG2, false, 4);
                    this.BGData(scanlineNumber, this.BG1, false, 4);
                    this.BGData(scanlineNumber, this.BG2, true, 4);
                    this.BGData(scanlineNumber, this.BG1, true, 4);
                    break;
            }
        }

        private void BGData(int scanlineNumber, BG BG, bool PriorityCheck, int BitplaneAmount)
        {
            if (!BG.Enabled)
                return;

            //if (this._frameCount % this._frameSkip != 0)
            //    return;

            BG.RenderMainScreenOpaque(scanlineNumber, BitplaneAmount, PriorityCheck);
        }

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion

        public void Reset()
        {
            
        }

        public void RenderScreen()
        {
            dev.UpdateSurface(this.frameBufferSurface, this._frameBufferTexture.GetSurfaceLevel(0));

            dev.BeginScene();

            dev.VertexFormat = CustomVertex.TransformedTextured.Format;
            dev.SetStreamSource(0, this._vertexBuffer, 0);
            dev.SetTexture(0, this._frameBufferTexture);
            dev.SamplerState[0].MinFilter = TextureFilter.Linear;
            dev.SamplerState[0].MagFilter = TextureFilter.Linear;
            dev.DrawPrimitives(PrimitiveType.TriangleStrip, 0, 2);

            hudRenderer.Begin(SpriteFlags.AlphaBlend);
            _fps.DrawText(hudRenderer, HighResolutionTimer.Instance.FramesPerSecond.ToString(), 10, 40, System.Drawing.Color.White);
            hudRenderer.End();

            dev.EndScene();
            dev.Present();
        }

        internal unsafe void LockFrameBuffer()
        {
            surfaceStream = this.frameBufferSurface.LockRectangle(LockFlags.Discard);
            this.frameBufferPtr = (int*)surfaceStream.InternalDataPointer;
        }

        internal void UnlockFrameBuffer()
        {
            this.frameBufferSurface.UnlockRectangle();
        }
    }
}

