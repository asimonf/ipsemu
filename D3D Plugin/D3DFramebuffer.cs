using System;
using System.Collections.Generic;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D.CustomVertex;
using Infinity_Project;
using System.Windows.Forms;
using Microsoft.DirectX.Generic;
using System.Runtime.InteropServices;
using System.Drawing;

namespace D3D_Plugin
{
    public class D3DFramebuffer : IFramebuffer
    {
        private Device _dev;
        private Texture _fbTexture;
        private Surface _offscreenSurface;
        private GraphicsBuffer _offscreenStream;
        private VertexBuffer _vBuffer;
        private Sprite _hud;
        private Microsoft.DirectX.Direct3D.Font _hudFont;
        private PresentParameters _params;
        private ConfigurationDialog _confDialog;
        private ConfigurationData _confData;
        private Control _host;

        private Effect _preprocessingEffect = null;
        private Effect _stretchEffect = null;
        private Effect _postprocessingEffect = null;

        private Matrix _worldMatrix;
        private Matrix _viewMatrix;
        private Matrix _projMatrix;

        private Matrix _resultingMatrix;

        private VertexDeclaration _decl = null;

        public D3DFramebuffer(Control host)
        {
            _confDialog = new ConfigurationDialog();
            _confData = _confDialog.confData;

            if (!_confData.Fullscreen)
                host.ClientSize = new System.Drawing.Size(_confData.windowedDisplayMode.Width, _confData.windowedDisplayMode.Height);
            else
                host.ClientSize = new System.Drawing.Size(_confData.fullscreenDisplayMode.Width, _confData.fullscreenDisplayMode.Height);
            
            _params = new PresentParameters();

            _params.IsWindowed = !_confData.Fullscreen;
            _params.SwapEffect = SwapEffect.Discard;
            _params.PresentationInterval = PresentInterval.One;
            _params.DeviceWindowHandle = host.Handle;
            
            _host = host;
        }

        public void Initialize()
        {
            _dev = new Device(_confData.Adapter, DeviceType.Hardware, _host.Handle, CreateFlags.HardwareVertexProcessing, _params);

            this._offscreenSurface = _dev.CreateOffscreenPlainSurface(256, 256, Format.A8R8G8B8, Pool.SystemMemory);
            this._fbTexture = new Texture(_dev, 256, 256, 1, Usage.Dynamic, Format.A8R8G8B8, Pool.Default);
            this._vBuffer = VertexBuffer.CreateGeneric<PositionTextured>(_dev, 4, Usage.None, PositionTextured.Format, Pool.Managed, new EventHandler(this._vBuffer_Created));
            _hud = new Sprite(_dev);
            _hudFont = new Microsoft.DirectX.Direct3D.Font(_dev, new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel));

            //_decl = new VertexDeclaration(_dev, elements);

            this._projMatrix = Matrix.OrthoLeftHanded(640, 480, 0.0f, 1f);
            this._viewMatrix = Matrix.Identity;
            this._worldMatrix = Matrix.Identity;
            //this._worldMatrix.M11 = 2;
            //this._worldMatrix.M22 = 2;
            //this._worldMatrix.M33 = 2;
            this._worldMatrix.M44 = 1;

            this._resultingMatrix = _projMatrix * _viewMatrix * _worldMatrix;

            //_preprocessingEffect = Effect.FromFile(_dev, "preprocessing.fx", null, null, "", ShaderFlags.None, null);
            //_stretchEffect = Effect.FromFile(_dev, "stretching.fx", null, null, "", ShaderFlags.None, null);
            //_postprocessingEffect = Effect.FromFile(_dev, "postprocessing.fx", null, null, "", ShaderFlags.None, null);

            //switch (_confData.preprocessingFilter)
            //{
            //    case PreprocessingFilter.PointSampling:
            //        _preprocessingEffect.Technique = "Combine_2xSaI";
            //        break;
            //    case PreprocessingFilter.BilinearSampling:
            //    case PreprocessingFilter.AnisotropicSampling:
            //        _preprocessingEffect.Technique = "Bilinear";
            //        break;
            //}

            //switch (_confData.stretchingFilter)
            //{
            //    case StretchingFilter.PointSampling:
            //        _stretchEffect.Technique = "Point";
            //        break;
            //    case StretchingFilter.BilinearSampling:
            //    case StretchingFilter.AnisotropicSampling:
            //        _stretchEffect.Technique = "Bilinear";
            //        break;
            //    case StretchingFilter.f2xSAI:
            //        _stretchEffect.Technique = "2xSAI";
            //        break;
            //    case StretchingFilter.Scale2x:
            //        _stretchEffect.Technique = "Scale2x";
            //        break;
            //}

            //unsafe
            //{
                //GraphicsBuffer<int> buff = _offscreenSurface.Lock(null, LockFlags.Discard).GetBuffer<int>();
                //int* ptr = (int*)this.Lock();
                //for (int i = 0; i < 256 * 256; i++)
                //{
                //    *ptr = i;
                //    ptr++;
                //}
                //this.Unlock();
                //_offscreenSurface.Unlock();
            //}
            //switch (_confData.postprocessingFilter)
            //{
            //    case PostprocessingFilter.None:
            //        _postprocessingEffect.Technique = "None";
            //        break;
            //}
        }

        void _vBuffer_Created(object sender, EventArgs e)
        {
            VertexBuffer buff = (VertexBuffer)sender;

            GraphicsBuffer<PositionTextured> verts = buff.Lock<PositionTextured>(0, 0, LockFlags.Discard);

            verts.Write(new PositionTextured(-320, -240, 0.5f, 0, 0.875f));
            verts.Write(new PositionTextured(320, -240, 0.5f, 1, 0.875f));
            verts.Write(new PositionTextured(-320, 240, 0.5f, 0, 0));
            verts.Write(new PositionTextured(320, 240, 0.5f, 1, 0));

            buff.Unlock();
        }

        #region IFramebuffer Members

        public unsafe void Render()
        {
            _dev.UpdateSurface(this._offscreenSurface, null, _fbTexture.GetSurfaceLevel(0), null);
            _dev.Clear(ClearFlags.Target, Color.Blue, 1f, 0);
            _dev.BeginScene();

            _dev.RenderState.Lighting = false;
            _dev.RenderState.CullMode = Cull.None;

            _dev.SetStreamSource(0, this._vBuffer, 0);
            _dev.SetTexture(0, this._fbTexture);
            _dev.VertexFormat = PositionTextured.Format;

            _dev.Transform.World = this._worldMatrix;
            _dev.Transform.View = this._viewMatrix;
            _dev.Transform.Projection = this._projMatrix;

            _dev.DrawPrimitives(PrimitiveType.TriangleStrip, 0, 2);

            _dev.EndScene();
            _dev.Present();
        }

        public unsafe void Idle()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public unsafe IntPtr Lock()
        {
            _offscreenStream = this._offscreenSurface.Lock(null, LockFlags.Discard);
            return _offscreenStream.GetBuffer<int>().DataBuffer;
        }

        public unsafe void Unlock()
        {
            _offscreenSurface.Unlock();
        }

        public void ShowConfigurationDialog(Control Owner)
        {
            this._confDialog.ShowDialog(Owner);
        }

        public void LoadConfigurationData()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
