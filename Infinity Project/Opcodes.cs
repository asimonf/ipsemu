using System;
using System.Collections.Generic;
using System.Text;

namespace Infinity_Project
{
	public partial class CentralProcesingUnit
	{
		private void GenerateOpcodeTable()
		{
			#region Opcodes E1M1X1
			_opcodeTable[1, 1, 1, 0x00] = new OpcodeHandler(BRK_E1M1X1_00);
			_opcodeTable[1, 1, 1, 0x01] = new OpcodeHandler(ORA_E1M1X1_01);
			_opcodeTable[1, 1, 1, 0x02] = new OpcodeHandler(COP_E1M1X1_02);
			_opcodeTable[1, 1, 1, 0x03] = new OpcodeHandler(ORA_E1M1X1_03);
			_opcodeTable[1, 1, 1, 0x04] = new OpcodeHandler(TSB_E1M1X1_04);
			_opcodeTable[1, 1, 1, 0x05] = new OpcodeHandler(ORA_E1M1X1_05);
			_opcodeTable[1, 1, 1, 0x06] = new OpcodeHandler(ASL_E1M1X1_06);
			_opcodeTable[1, 1, 1, 0x07] = new OpcodeHandler(ORA_E1M1X1_07);
			_opcodeTable[1, 1, 1, 0x08] = new OpcodeHandler(PHP_E1M1X1_08);
			_opcodeTable[1, 1, 1, 0x09] = new OpcodeHandler(ORA_E1M1X1_09);
			_opcodeTable[1, 1, 1, 0x0A] = new OpcodeHandler(ASL_E1M1X1_0A);
			_opcodeTable[1, 1, 1, 0x0B] = new OpcodeHandler(PHD_E1M1X1_0B);
			_opcodeTable[1, 1, 1, 0x0C] = new OpcodeHandler(TSB_E1M1X1_0C);
			_opcodeTable[1, 1, 1, 0x0D] = new OpcodeHandler(ORA_E1M1X1_0D);
			_opcodeTable[1, 1, 1, 0x0E] = new OpcodeHandler(ASL_E1M1X1_0E);
			_opcodeTable[1, 1, 1, 0x0F] = new OpcodeHandler(ORA_E1M1X1_0F);
			_opcodeTable[1, 1, 1, 0x10] = new OpcodeHandler(BPL_E1M1X1_10);
			_opcodeTable[1, 1, 1, 0x11] = new OpcodeHandler(ORA_E1M1X1_11);
			_opcodeTable[1, 1, 1, 0x12] = new OpcodeHandler(ORA_E1M1X1_12);
			_opcodeTable[1, 1, 1, 0x13] = new OpcodeHandler(ORA_E1M1X1_13);
			_opcodeTable[1, 1, 1, 0x14] = new OpcodeHandler(TRB_E1M1X1_14);
			_opcodeTable[1, 1, 1, 0x15] = new OpcodeHandler(ORA_E1M1X1_15);
			_opcodeTable[1, 1, 1, 0x16] = new OpcodeHandler(ASL_E1M1X1_16);
			_opcodeTable[1, 1, 1, 0x17] = new OpcodeHandler(ORA_E1M1X1_17);
			_opcodeTable[1, 1, 1, 0x18] = new OpcodeHandler(CLC_E1M1X1_18);
			_opcodeTable[1, 1, 1, 0x19] = new OpcodeHandler(ORA_E1M1X1_19);
			_opcodeTable[1, 1, 1, 0x1A] = new OpcodeHandler(INC_E1M1X1_1A);
			_opcodeTable[1, 1, 1, 0x1B] = new OpcodeHandler(TCS_E1M1X1_1B);
			_opcodeTable[1, 1, 1, 0x1C] = new OpcodeHandler(TRB_E1M1X1_1C);
			_opcodeTable[1, 1, 1, 0x1D] = new OpcodeHandler(ORA_E1M1X1_1D);
			_opcodeTable[1, 1, 1, 0x1E] = new OpcodeHandler(ASL_E1M1X1_1E);
			_opcodeTable[1, 1, 1, 0x1F] = new OpcodeHandler(ORA_E1M1X1_1F);
			_opcodeTable[1, 1, 1, 0x20] = new OpcodeHandler(JSR_E1M1X1_20);
			_opcodeTable[1, 1, 1, 0x21] = new OpcodeHandler(AND_E1M1X1_21);
			_opcodeTable[1, 1, 1, 0x22] = new OpcodeHandler(JSR_E1M1X1_22);
			_opcodeTable[1, 1, 1, 0x23] = new OpcodeHandler(AND_E1M1X1_23);
			_opcodeTable[1, 1, 1, 0x24] = new OpcodeHandler(BIT_E1M1X1_24);
			_opcodeTable[1, 1, 1, 0x25] = new OpcodeHandler(AND_E1M1X1_25);
			_opcodeTable[1, 1, 1, 0x26] = new OpcodeHandler(ROL_E1M1X1_26);
			_opcodeTable[1, 1, 1, 0x27] = new OpcodeHandler(AND_E1M1X1_27);
			_opcodeTable[1, 1, 1, 0x28] = new OpcodeHandler(PLP_E1M1X1_28);
			_opcodeTable[1, 1, 1, 0x29] = new OpcodeHandler(AND_E1M1X1_29);
			_opcodeTable[1, 1, 1, 0x2A] = new OpcodeHandler(ROL_E1M1X1_2A);
			_opcodeTable[1, 1, 1, 0x2B] = new OpcodeHandler(PLD_E1M1X1_2B);
			_opcodeTable[1, 1, 1, 0x2C] = new OpcodeHandler(BIT_E1M1X1_2C);
			_opcodeTable[1, 1, 1, 0x2D] = new OpcodeHandler(AND_E1M1X1_2D);
			_opcodeTable[1, 1, 1, 0x2E] = new OpcodeHandler(ROL_E1M1X1_2E);
			_opcodeTable[1, 1, 1, 0x2F] = new OpcodeHandler(AND_E1M1X1_2F);
			_opcodeTable[1, 1, 1, 0x30] = new OpcodeHandler(BMI_E1M1X1_30);
			_opcodeTable[1, 1, 1, 0x31] = new OpcodeHandler(AND_E1M1X1_31);
			_opcodeTable[1, 1, 1, 0x32] = new OpcodeHandler(AND_E1M1X1_32);
			_opcodeTable[1, 1, 1, 0x33] = new OpcodeHandler(AND_E1M1X1_33);
			_opcodeTable[1, 1, 1, 0x34] = new OpcodeHandler(BIT_E1M1X1_34);
			_opcodeTable[1, 1, 1, 0x35] = new OpcodeHandler(AND_E1M1X1_35);
			_opcodeTable[1, 1, 1, 0x36] = new OpcodeHandler(ROL_E1M1X1_36);
			_opcodeTable[1, 1, 1, 0x37] = new OpcodeHandler(AND_E1M1X1_37);
			_opcodeTable[1, 1, 1, 0x38] = new OpcodeHandler(SEC_E1M1X1_38);
			_opcodeTable[1, 1, 1, 0x39] = new OpcodeHandler(AND_E1M1X1_39);
			_opcodeTable[1, 1, 1, 0x3A] = new OpcodeHandler(DEC_E1M1X1_3A);
			_opcodeTable[1, 1, 1, 0x3B] = new OpcodeHandler(TSC_E1M1X1_3B);
			_opcodeTable[1, 1, 1, 0x3C] = new OpcodeHandler(BIT_E1M1X1_3C);
			_opcodeTable[1, 1, 1, 0x3D] = new OpcodeHandler(AND_E1M1X1_3D);
			_opcodeTable[1, 1, 1, 0x3E] = new OpcodeHandler(ROL_E1M1X1_3E);
			_opcodeTable[1, 1, 1, 0x3F] = new OpcodeHandler(AND_E1M1X1_3F);
			_opcodeTable[1, 1, 1, 0x40] = new OpcodeHandler(RTI_E1M1X1_40);
			_opcodeTable[1, 1, 1, 0x41] = new OpcodeHandler(EOR_E1M1X1_41);
			_opcodeTable[1, 1, 1, 0x42] = new OpcodeHandler(WDM_E1M1X1_42);
			_opcodeTable[1, 1, 1, 0x43] = new OpcodeHandler(EOR_E1M1X1_43);
			_opcodeTable[1, 1, 1, 0x44] = new OpcodeHandler(MVP_E1M1X1_44);
			_opcodeTable[1, 1, 1, 0x45] = new OpcodeHandler(EOR_E1M1X1_45);
			_opcodeTable[1, 1, 1, 0x46] = new OpcodeHandler(LSR_E1M1X1_46);
			_opcodeTable[1, 1, 1, 0x47] = new OpcodeHandler(EOR_E1M1X1_47);
			_opcodeTable[1, 1, 1, 0x48] = new OpcodeHandler(PHA_E1M1X1_48);
			_opcodeTable[1, 1, 1, 0x49] = new OpcodeHandler(EOR_E1M1X1_49);
			_opcodeTable[1, 1, 1, 0x4A] = new OpcodeHandler(LSR_E1M1X1_4A);
			_opcodeTable[1, 1, 1, 0x4B] = new OpcodeHandler(PHK_E1M1X1_4B);
			_opcodeTable[1, 1, 1, 0x4C] = new OpcodeHandler(JMP_E1M1X1_4C);
			_opcodeTable[1, 1, 1, 0x4D] = new OpcodeHandler(EOR_E1M1X1_4D);
			_opcodeTable[1, 1, 1, 0x4E] = new OpcodeHandler(LSR_E1M1X1_4E);
			_opcodeTable[1, 1, 1, 0x4F] = new OpcodeHandler(EOR_E1M1X1_4F);
			_opcodeTable[1, 1, 1, 0x50] = new OpcodeHandler(BVC_E1M1X1_50);
			_opcodeTable[1, 1, 1, 0x51] = new OpcodeHandler(EOR_E1M1X1_51);
			_opcodeTable[1, 1, 1, 0x52] = new OpcodeHandler(EOR_E1M1X1_52);
			_opcodeTable[1, 1, 1, 0x53] = new OpcodeHandler(EOR_E1M1X1_53);
			_opcodeTable[1, 1, 1, 0x54] = new OpcodeHandler(MVN_E1M1X1_54);
			_opcodeTable[1, 1, 1, 0x55] = new OpcodeHandler(EOR_E1M1X1_55);
			_opcodeTable[1, 1, 1, 0x56] = new OpcodeHandler(LSR_E1M1X1_56);
			_opcodeTable[1, 1, 1, 0x57] = new OpcodeHandler(EOR_E1M1X1_57);
			_opcodeTable[1, 1, 1, 0x58] = new OpcodeHandler(CLI_E1M1X1_58);
			_opcodeTable[1, 1, 1, 0x59] = new OpcodeHandler(EOR_E1M1X1_59);
			_opcodeTable[1, 1, 1, 0x5A] = new OpcodeHandler(PHY_E1M1X1_5A);
			_opcodeTable[1, 1, 1, 0x5B] = new OpcodeHandler(TCD_E1M1X1_5B);
			_opcodeTable[1, 1, 1, 0x5C] = new OpcodeHandler(JMP_E1M1X1_5C);
			_opcodeTable[1, 1, 1, 0x5D] = new OpcodeHandler(EOR_E1M1X1_5D);
			_opcodeTable[1, 1, 1, 0x5E] = new OpcodeHandler(LSR_E1M1X1_5E);
			_opcodeTable[1, 1, 1, 0x5F] = new OpcodeHandler(EOR_E1M1X1_5F);
			_opcodeTable[1, 1, 1, 0x60] = new OpcodeHandler(RTS_E1M1X1_60);
			_opcodeTable[1, 1, 1, 0x61] = new OpcodeHandler(ADC_E1M1X1_61);
			_opcodeTable[1, 1, 1, 0x62] = new OpcodeHandler(PER_E1M1X1_62);
			_opcodeTable[1, 1, 1, 0x63] = new OpcodeHandler(ADC_E1M1X1_63);
			_opcodeTable[1, 1, 1, 0x64] = new OpcodeHandler(STZ_E1M1X1_64);
			_opcodeTable[1, 1, 1, 0x65] = new OpcodeHandler(ADC_E1M1X1_65);
			_opcodeTable[1, 1, 1, 0x66] = new OpcodeHandler(ROR_E1M1X1_66);
			_opcodeTable[1, 1, 1, 0x67] = new OpcodeHandler(ADC_E1M1X1_67);
			_opcodeTable[1, 1, 1, 0x68] = new OpcodeHandler(PLA_E1M1X1_68);
			_opcodeTable[1, 1, 1, 0x69] = new OpcodeHandler(ADC_E1M1X1_69);
			_opcodeTable[1, 1, 1, 0x6A] = new OpcodeHandler(ROR_E1M1X1_6A);
			_opcodeTable[1, 1, 1, 0x6B] = new OpcodeHandler(RTL_E1M1X1_6B);
			_opcodeTable[1, 1, 1, 0x6C] = new OpcodeHandler(JMP_E1M1X1_6C);
			_opcodeTable[1, 1, 1, 0x6D] = new OpcodeHandler(ADC_E1M1X1_6D);
			_opcodeTable[1, 1, 1, 0x6E] = new OpcodeHandler(ROR_E1M1X1_6E);
			_opcodeTable[1, 1, 1, 0x6F] = new OpcodeHandler(ADC_E1M1X1_6F);
			_opcodeTable[1, 1, 1, 0x70] = new OpcodeHandler(BVS_E1M1X1_70);
			_opcodeTable[1, 1, 1, 0x71] = new OpcodeHandler(ADC_E1M1X1_71);
			_opcodeTable[1, 1, 1, 0x72] = new OpcodeHandler(ADC_E1M1X1_72);
			_opcodeTable[1, 1, 1, 0x73] = new OpcodeHandler(ADC_E1M1X1_73);
			_opcodeTable[1, 1, 1, 0x74] = new OpcodeHandler(STZ_E1M1X1_74);
			_opcodeTable[1, 1, 1, 0x75] = new OpcodeHandler(ADC_E1M1X1_75);
			_opcodeTable[1, 1, 1, 0x76] = new OpcodeHandler(ROR_E1M1X1_76);
			_opcodeTable[1, 1, 1, 0x77] = new OpcodeHandler(ADC_E1M1X1_77);
			_opcodeTable[1, 1, 1, 0x78] = new OpcodeHandler(SEI_E1M1X1_78);
			_opcodeTable[1, 1, 1, 0x79] = new OpcodeHandler(ADC_E1M1X1_79);
			_opcodeTable[1, 1, 1, 0x7A] = new OpcodeHandler(PLY_E1M1X1_7A);
			_opcodeTable[1, 1, 1, 0x7B] = new OpcodeHandler(TDC_E1M1X1_7B);
			_opcodeTable[1, 1, 1, 0x7C] = new OpcodeHandler(JMP_E1M1X1_7C);
			_opcodeTable[1, 1, 1, 0x7D] = new OpcodeHandler(ADC_E1M1X1_7D);
			_opcodeTable[1, 1, 1, 0x7E] = new OpcodeHandler(ROR_E1M1X1_7E);
			_opcodeTable[1, 1, 1, 0x7F] = new OpcodeHandler(ADC_E1M1X1_7F);
			_opcodeTable[1, 1, 1, 0x80] = new OpcodeHandler(BRA_E1M1X1_80);
			_opcodeTable[1, 1, 1, 0x81] = new OpcodeHandler(STA_E1M1X1_81);
			_opcodeTable[1, 1, 1, 0x82] = new OpcodeHandler(BRL_E1M1X1_82);
			_opcodeTable[1, 1, 1, 0x83] = new OpcodeHandler(STA_E1M1X1_83);
			_opcodeTable[1, 1, 1, 0x84] = new OpcodeHandler(STY_E1M1X1_84);
			_opcodeTable[1, 1, 1, 0x85] = new OpcodeHandler(STA_E1M1X1_85);
			_opcodeTable[1, 1, 1, 0x86] = new OpcodeHandler(STX_E1M1X1_86);
			_opcodeTable[1, 1, 1, 0x87] = new OpcodeHandler(STA_E1M1X1_87);
			_opcodeTable[1, 1, 1, 0x88] = new OpcodeHandler(DEY_E1M1X1_88);
			_opcodeTable[1, 1, 1, 0x89] = new OpcodeHandler(BIT_E1M1X1_89);
			_opcodeTable[1, 1, 1, 0x8A] = new OpcodeHandler(TXA_E1M1X1_8A);
			_opcodeTable[1, 1, 1, 0x8B] = new OpcodeHandler(PHB_E1M1X1_8B);
			_opcodeTable[1, 1, 1, 0x8C] = new OpcodeHandler(STY_E1M1X1_8C);
			_opcodeTable[1, 1, 1, 0x8D] = new OpcodeHandler(STA_E1M1X1_8D);
			_opcodeTable[1, 1, 1, 0x8E] = new OpcodeHandler(STX_E1M1X1_8E);
			_opcodeTable[1, 1, 1, 0x8F] = new OpcodeHandler(STA_E1M1X1_8F);
			_opcodeTable[1, 1, 1, 0x90] = new OpcodeHandler(BCC_E1M1X1_90);
			_opcodeTable[1, 1, 1, 0x91] = new OpcodeHandler(STA_E1M1X1_91);
			_opcodeTable[1, 1, 1, 0x92] = new OpcodeHandler(STA_E1M1X1_92);
			_opcodeTable[1, 1, 1, 0x93] = new OpcodeHandler(STA_E1M1X1_93);
			_opcodeTable[1, 1, 1, 0x94] = new OpcodeHandler(STY_E1M1X1_94);
			_opcodeTable[1, 1, 1, 0x95] = new OpcodeHandler(STA_E1M1X1_95);
			_opcodeTable[1, 1, 1, 0x96] = new OpcodeHandler(STX_E1M1X1_96);
			_opcodeTable[1, 1, 1, 0x97] = new OpcodeHandler(STA_E1M1X1_97);
			_opcodeTable[1, 1, 1, 0x98] = new OpcodeHandler(TYA_E1M1X1_98);
			_opcodeTable[1, 1, 1, 0x99] = new OpcodeHandler(STA_E1M1X1_99);
			_opcodeTable[1, 1, 1, 0x9A] = new OpcodeHandler(TXS_E1M1X1_9A);
			_opcodeTable[1, 1, 1, 0x9B] = new OpcodeHandler(TXY_E1M1X1_9B);
			_opcodeTable[1, 1, 1, 0x9C] = new OpcodeHandler(STZ_E1M1X1_9C);
			_opcodeTable[1, 1, 1, 0x9D] = new OpcodeHandler(STA_E1M1X1_9D);
			_opcodeTable[1, 1, 1, 0x9E] = new OpcodeHandler(STZ_E1M1X1_9E);
			_opcodeTable[1, 1, 1, 0x9F] = new OpcodeHandler(STA_E1M1X1_9F);
			_opcodeTable[1, 1, 1, 0xA0] = new OpcodeHandler(LDY_E1M1X1_A0);
			_opcodeTable[1, 1, 1, 0xA1] = new OpcodeHandler(LDA_E1M1X1_A1);
			_opcodeTable[1, 1, 1, 0xA2] = new OpcodeHandler(LDX_E1M1X1_A2);
			_opcodeTable[1, 1, 1, 0xA3] = new OpcodeHandler(LDA_E1M1X1_A3);
			_opcodeTable[1, 1, 1, 0xA4] = new OpcodeHandler(LDY_E1M1X1_A4);
			_opcodeTable[1, 1, 1, 0xA5] = new OpcodeHandler(LDA_E1M1X1_A5);
			_opcodeTable[1, 1, 1, 0xA6] = new OpcodeHandler(LDX_E1M1X1_A6);
			_opcodeTable[1, 1, 1, 0xA7] = new OpcodeHandler(LDA_E1M1X1_A7);
			_opcodeTable[1, 1, 1, 0xA8] = new OpcodeHandler(TAY_E1M1X1_A8);
			_opcodeTable[1, 1, 1, 0xA9] = new OpcodeHandler(LDA_E1M1X1_A9);
			_opcodeTable[1, 1, 1, 0xAA] = new OpcodeHandler(TAX_E1M1X1_AA);
			_opcodeTable[1, 1, 1, 0xAB] = new OpcodeHandler(PLB_E1M1X1_AB);
			_opcodeTable[1, 1, 1, 0xAC] = new OpcodeHandler(LDY_E1M1X1_AC);
			_opcodeTable[1, 1, 1, 0xAD] = new OpcodeHandler(LDA_E1M1X1_AD);
			_opcodeTable[1, 1, 1, 0xAE] = new OpcodeHandler(LDX_E1M1X1_AE);
			_opcodeTable[1, 1, 1, 0xAF] = new OpcodeHandler(LDA_E1M1X1_AF);
			_opcodeTable[1, 1, 1, 0xB0] = new OpcodeHandler(BCS_E1M1X1_B0);
			_opcodeTable[1, 1, 1, 0xB1] = new OpcodeHandler(LDA_E1M1X1_B1);
			_opcodeTable[1, 1, 1, 0xB2] = new OpcodeHandler(LDA_E1M1X1_B2);
			_opcodeTable[1, 1, 1, 0xB3] = new OpcodeHandler(LDA_E1M1X1_B3);
			_opcodeTable[1, 1, 1, 0xB4] = new OpcodeHandler(LDY_E1M1X1_B4);
			_opcodeTable[1, 1, 1, 0xB5] = new OpcodeHandler(LDA_E1M1X1_B5);
			_opcodeTable[1, 1, 1, 0xB6] = new OpcodeHandler(LDX_E1M1X1_B6);
			_opcodeTable[1, 1, 1, 0xB7] = new OpcodeHandler(LDA_E1M1X1_B7);
			_opcodeTable[1, 1, 1, 0xB8] = new OpcodeHandler(CLV_E1M1X1_B8);
			_opcodeTable[1, 1, 1, 0xB9] = new OpcodeHandler(LDA_E1M1X1_B9);
			_opcodeTable[1, 1, 1, 0xBA] = new OpcodeHandler(TSX_E1M1X1_BA);
			_opcodeTable[1, 1, 1, 0xBB] = new OpcodeHandler(TYX_E1M1X1_BB);
			_opcodeTable[1, 1, 1, 0xBC] = new OpcodeHandler(LDY_E1M1X1_BC);
			_opcodeTable[1, 1, 1, 0xBD] = new OpcodeHandler(LDA_E1M1X1_BD);
			_opcodeTable[1, 1, 1, 0xBE] = new OpcodeHandler(LDX_E1M1X1_BE);
			_opcodeTable[1, 1, 1, 0xBF] = new OpcodeHandler(LDA_E1M1X1_BF);
			_opcodeTable[1, 1, 1, 0xC0] = new OpcodeHandler(CPY_E1M1X1_C0);
			_opcodeTable[1, 1, 1, 0xC1] = new OpcodeHandler(CMP_E1M1X1_C1);
			_opcodeTable[1, 1, 1, 0xC2] = new OpcodeHandler(REP_E1M1X1_C2);
			_opcodeTable[1, 1, 1, 0xC3] = new OpcodeHandler(CMP_E1M1X1_C3);
			_opcodeTable[1, 1, 1, 0xC4] = new OpcodeHandler(CPY_E1M1X1_C4);
			_opcodeTable[1, 1, 1, 0xC5] = new OpcodeHandler(CMP_E1M1X1_C5);
			_opcodeTable[1, 1, 1, 0xC6] = new OpcodeHandler(DEC_E1M1X1_C6);
			_opcodeTable[1, 1, 1, 0xC7] = new OpcodeHandler(CMP_E1M1X1_C7);
			_opcodeTable[1, 1, 1, 0xC8] = new OpcodeHandler(INY_E1M1X1_C8);
			_opcodeTable[1, 1, 1, 0xC9] = new OpcodeHandler(CMP_E1M1X1_C9);
			_opcodeTable[1, 1, 1, 0xCA] = new OpcodeHandler(DEX_E1M1X1_CA);
			_opcodeTable[1, 1, 1, 0xCB] = new OpcodeHandler(WAI_E1M1X1_CB);
			_opcodeTable[1, 1, 1, 0xCC] = new OpcodeHandler(CPY_E1M1X1_CC);
			_opcodeTable[1, 1, 1, 0xCD] = new OpcodeHandler(CMP_E1M1X1_CD);
			_opcodeTable[1, 1, 1, 0xCE] = new OpcodeHandler(DEC_E1M1X1_CE);
			_opcodeTable[1, 1, 1, 0xCF] = new OpcodeHandler(CMP_E1M1X1_CF);
			_opcodeTable[1, 1, 1, 0xD0] = new OpcodeHandler(BNE_E1M1X1_D0);
			_opcodeTable[1, 1, 1, 0xD1] = new OpcodeHandler(CMP_E1M1X1_D1);
			_opcodeTable[1, 1, 1, 0xD2] = new OpcodeHandler(CMP_E1M1X1_D2);
			_opcodeTable[1, 1, 1, 0xD3] = new OpcodeHandler(CMP_E1M1X1_D3);
			_opcodeTable[1, 1, 1, 0xD4] = new OpcodeHandler(PEI_E1M1X1_D4);
			_opcodeTable[1, 1, 1, 0xD5] = new OpcodeHandler(CMP_E1M1X1_D5);
			_opcodeTable[1, 1, 1, 0xD6] = new OpcodeHandler(DEC_E1M1X1_D6);
			_opcodeTable[1, 1, 1, 0xD7] = new OpcodeHandler(CMP_E1M1X1_D7);
			_opcodeTable[1, 1, 1, 0xD8] = new OpcodeHandler(CLD_E1M1X1_D8);
			_opcodeTable[1, 1, 1, 0xD9] = new OpcodeHandler(CMP_E1M1X1_D9);
			_opcodeTable[1, 1, 1, 0xDA] = new OpcodeHandler(PHX_E1M1X1_DA);
			_opcodeTable[1, 1, 1, 0xDB] = new OpcodeHandler(STP_E1M1X1_DB);
			_opcodeTable[1, 1, 1, 0xDC] = new OpcodeHandler(JMP_E1M1X1_DC);
			_opcodeTable[1, 1, 1, 0xDD] = new OpcodeHandler(CMP_E1M1X1_DD);
			_opcodeTable[1, 1, 1, 0xDE] = new OpcodeHandler(DEC_E1M1X1_DE);
			_opcodeTable[1, 1, 1, 0xDF] = new OpcodeHandler(CMP_E1M1X1_DF);
			_opcodeTable[1, 1, 1, 0xE0] = new OpcodeHandler(CPX_E1M1X1_E0);
			_opcodeTable[1, 1, 1, 0xE1] = new OpcodeHandler(SBC_E1M1X1_E1);
			_opcodeTable[1, 1, 1, 0xE2] = new OpcodeHandler(SEP_E1M1X1_E2);
			_opcodeTable[1, 1, 1, 0xE3] = new OpcodeHandler(SBC_E1M1X1_E3);
			_opcodeTable[1, 1, 1, 0xE4] = new OpcodeHandler(CPX_E1M1X1_E4);
			_opcodeTable[1, 1, 1, 0xE5] = new OpcodeHandler(SBC_E1M1X1_E5);
			_opcodeTable[1, 1, 1, 0xE6] = new OpcodeHandler(INC_E1M1X1_E6);
			_opcodeTable[1, 1, 1, 0xE7] = new OpcodeHandler(SBC_E1M1X1_E7);
			_opcodeTable[1, 1, 1, 0xE8] = new OpcodeHandler(INX_E1M1X1_E8);
			_opcodeTable[1, 1, 1, 0xE9] = new OpcodeHandler(SBC_E1M1X1_E9);
			_opcodeTable[1, 1, 1, 0xEA] = new OpcodeHandler(NOP_E1M1X1_EA);
			_opcodeTable[1, 1, 1, 0xEB] = new OpcodeHandler(XBA_E1M1X1_EB);
			_opcodeTable[1, 1, 1, 0xEC] = new OpcodeHandler(CPX_E1M1X1_EC);
			_opcodeTable[1, 1, 1, 0xED] = new OpcodeHandler(SBC_E1M1X1_ED);
			_opcodeTable[1, 1, 1, 0xEE] = new OpcodeHandler(INC_E1M1X1_EE);
			_opcodeTable[1, 1, 1, 0xEF] = new OpcodeHandler(SBC_E1M1X1_EF);
			_opcodeTable[1, 1, 1, 0xF0] = new OpcodeHandler(BEQ_E1M1X1_F0);
			_opcodeTable[1, 1, 1, 0xF1] = new OpcodeHandler(SBC_E1M1X1_F1);
			_opcodeTable[1, 1, 1, 0xF2] = new OpcodeHandler(SBC_E1M1X1_F2);
			_opcodeTable[1, 1, 1, 0xF3] = new OpcodeHandler(SBC_E1M1X1_F3);
			_opcodeTable[1, 1, 1, 0xF4] = new OpcodeHandler(PEA_E1M1X1_F4);
			_opcodeTable[1, 1, 1, 0xF5] = new OpcodeHandler(SBC_E1M1X1_F5);
			_opcodeTable[1, 1, 1, 0xF6] = new OpcodeHandler(INC_E1M1X1_F6);
			_opcodeTable[1, 1, 1, 0xF7] = new OpcodeHandler(SBC_E1M1X1_F7);
			_opcodeTable[1, 1, 1, 0xF8] = new OpcodeHandler(SED_E1M1X1_F8);
			_opcodeTable[1, 1, 1, 0xF9] = new OpcodeHandler(SBC_E1M1X1_F9);
			_opcodeTable[1, 1, 1, 0xFA] = new OpcodeHandler(PLX_E1M1X1_FA);
			_opcodeTable[1, 1, 1, 0xFB] = new OpcodeHandler(XCE_E1M1X1_FB);
			_opcodeTable[1, 1, 1, 0xFC] = new OpcodeHandler(JSR_E1M1X1_FC);
			_opcodeTable[1, 1, 1, 0xFD] = new OpcodeHandler(SBC_E1M1X1_FD);
			_opcodeTable[1, 1, 1, 0xFE] = new OpcodeHandler(INC_E1M1X1_FE);
			_opcodeTable[1, 1, 1, 0xFF] = new OpcodeHandler(SBC_E1M1X1_FF);
			#endregion

			#region Opcodes E0M1X1
			_opcodeTable[0, 1, 1, 0x00] = new OpcodeHandler(BRK_E0M1X1_00);
			_opcodeTable[0, 1, 1, 0x01] = new OpcodeHandler(ORA_E0M1X1_01);
			_opcodeTable[0, 1, 1, 0x02] = new OpcodeHandler(COP_E0M1X1_02);
			_opcodeTable[0, 1, 1, 0x03] = new OpcodeHandler(ORA_E0M1X1_03);
			_opcodeTable[0, 1, 1, 0x04] = new OpcodeHandler(TSB_E0M1X1_04);
			_opcodeTable[0, 1, 1, 0x05] = new OpcodeHandler(ORA_E0M1X1_05);
			_opcodeTable[0, 1, 1, 0x06] = new OpcodeHandler(ASL_E0M1X1_06);
			_opcodeTable[0, 1, 1, 0x07] = new OpcodeHandler(ORA_E0M1X1_07);
			_opcodeTable[0, 1, 1, 0x08] = new OpcodeHandler(PHP_E0M1X1_08);
			_opcodeTable[0, 1, 1, 0x09] = new OpcodeHandler(ORA_E0M1X1_09);
			_opcodeTable[0, 1, 1, 0x0A] = new OpcodeHandler(ASL_E0M1X1_0A);
			_opcodeTable[0, 1, 1, 0x0B] = new OpcodeHandler(PHD_E0M1X1_0B);
			_opcodeTable[0, 1, 1, 0x0C] = new OpcodeHandler(TSB_E0M1X1_0C);
			_opcodeTable[0, 1, 1, 0x0D] = new OpcodeHandler(ORA_E0M1X1_0D);
			_opcodeTable[0, 1, 1, 0x0E] = new OpcodeHandler(ASL_E0M1X1_0E);
			_opcodeTable[0, 1, 1, 0x0F] = new OpcodeHandler(ORA_E0M1X1_0F);
			_opcodeTable[0, 1, 1, 0x10] = new OpcodeHandler(BPL_E0M1X1_10);
			_opcodeTable[0, 1, 1, 0x11] = new OpcodeHandler(ORA_E0M1X1_11);
			_opcodeTable[0, 1, 1, 0x12] = new OpcodeHandler(ORA_E0M1X1_12);
			_opcodeTable[0, 1, 1, 0x13] = new OpcodeHandler(ORA_E0M1X1_13);
			_opcodeTable[0, 1, 1, 0x14] = new OpcodeHandler(TRB_E0M1X1_14);
			_opcodeTable[0, 1, 1, 0x15] = new OpcodeHandler(ORA_E0M1X1_15);
			_opcodeTable[0, 1, 1, 0x16] = new OpcodeHandler(ASL_E0M1X1_16);
			_opcodeTable[0, 1, 1, 0x17] = new OpcodeHandler(ORA_E0M1X1_17);
			_opcodeTable[0, 1, 1, 0x18] = new OpcodeHandler(CLC_E0M1X1_18);
			_opcodeTable[0, 1, 1, 0x19] = new OpcodeHandler(ORA_E0M1X1_19);
			_opcodeTable[0, 1, 1, 0x1A] = new OpcodeHandler(INC_E0M1X1_1A);
			_opcodeTable[0, 1, 1, 0x1B] = new OpcodeHandler(TCS_E0M1X1_1B);
			_opcodeTable[0, 1, 1, 0x1C] = new OpcodeHandler(TRB_E0M1X1_1C);
			_opcodeTable[0, 1, 1, 0x1D] = new OpcodeHandler(ORA_E0M1X1_1D);
			_opcodeTable[0, 1, 1, 0x1E] = new OpcodeHandler(ASL_E0M1X1_1E);
			_opcodeTable[0, 1, 1, 0x1F] = new OpcodeHandler(ORA_E0M1X1_1F);
			_opcodeTable[0, 1, 1, 0x20] = new OpcodeHandler(JSR_E0M1X1_20);
			_opcodeTable[0, 1, 1, 0x21] = new OpcodeHandler(AND_E0M1X1_21);
			_opcodeTable[0, 1, 1, 0x22] = new OpcodeHandler(JSR_E0M1X1_22);
			_opcodeTable[0, 1, 1, 0x23] = new OpcodeHandler(AND_E0M1X1_23);
			_opcodeTable[0, 1, 1, 0x24] = new OpcodeHandler(BIT_E0M1X1_24);
			_opcodeTable[0, 1, 1, 0x25] = new OpcodeHandler(AND_E0M1X1_25);
			_opcodeTable[0, 1, 1, 0x26] = new OpcodeHandler(ROL_E0M1X1_26);
			_opcodeTable[0, 1, 1, 0x27] = new OpcodeHandler(AND_E0M1X1_27);
			_opcodeTable[0, 1, 1, 0x28] = new OpcodeHandler(PLP_E0M1X1_28);
			_opcodeTable[0, 1, 1, 0x29] = new OpcodeHandler(AND_E0M1X1_29);
			_opcodeTable[0, 1, 1, 0x2A] = new OpcodeHandler(ROL_E0M1X1_2A);
			_opcodeTable[0, 1, 1, 0x2B] = new OpcodeHandler(PLD_E0M1X1_2B);
			_opcodeTable[0, 1, 1, 0x2C] = new OpcodeHandler(BIT_E0M1X1_2C);
			_opcodeTable[0, 1, 1, 0x2D] = new OpcodeHandler(AND_E0M1X1_2D);
			_opcodeTable[0, 1, 1, 0x2E] = new OpcodeHandler(ROL_E0M1X1_2E);
			_opcodeTable[0, 1, 1, 0x2F] = new OpcodeHandler(AND_E0M1X1_2F);
			_opcodeTable[0, 1, 1, 0x30] = new OpcodeHandler(BMI_E0M1X1_30);
			_opcodeTable[0, 1, 1, 0x31] = new OpcodeHandler(AND_E0M1X1_31);
			_opcodeTable[0, 1, 1, 0x32] = new OpcodeHandler(AND_E0M1X1_32);
			_opcodeTable[0, 1, 1, 0x33] = new OpcodeHandler(AND_E0M1X1_33);
			_opcodeTable[0, 1, 1, 0x34] = new OpcodeHandler(BIT_E0M1X1_34);
			_opcodeTable[0, 1, 1, 0x35] = new OpcodeHandler(AND_E0M1X1_35);
			_opcodeTable[0, 1, 1, 0x36] = new OpcodeHandler(ROL_E0M1X1_36);
			_opcodeTable[0, 1, 1, 0x37] = new OpcodeHandler(AND_E0M1X1_37);
			_opcodeTable[0, 1, 1, 0x38] = new OpcodeHandler(SEC_E0M1X1_38);
			_opcodeTable[0, 1, 1, 0x39] = new OpcodeHandler(AND_E0M1X1_39);
			_opcodeTable[0, 1, 1, 0x3A] = new OpcodeHandler(DEC_E0M1X1_3A);
			_opcodeTable[0, 1, 1, 0x3B] = new OpcodeHandler(TSC_E0M1X1_3B);
			_opcodeTable[0, 1, 1, 0x3C] = new OpcodeHandler(BIT_E0M1X1_3C);
			_opcodeTable[0, 1, 1, 0x3D] = new OpcodeHandler(AND_E0M1X1_3D);
			_opcodeTable[0, 1, 1, 0x3E] = new OpcodeHandler(ROL_E0M1X1_3E);
			_opcodeTable[0, 1, 1, 0x3F] = new OpcodeHandler(AND_E0M1X1_3F);
			_opcodeTable[0, 1, 1, 0x40] = new OpcodeHandler(RTI_E0M1X1_40);
			_opcodeTable[0, 1, 1, 0x41] = new OpcodeHandler(EOR_E0M1X1_41);
			_opcodeTable[0, 1, 1, 0x42] = new OpcodeHandler(WDM_E0M1X1_42);
			_opcodeTable[0, 1, 1, 0x43] = new OpcodeHandler(EOR_E0M1X1_43);
			_opcodeTable[0, 1, 1, 0x44] = new OpcodeHandler(MVP_E0M1X1_44);
			_opcodeTable[0, 1, 1, 0x45] = new OpcodeHandler(EOR_E0M1X1_45);
			_opcodeTable[0, 1, 1, 0x46] = new OpcodeHandler(LSR_E0M1X1_46);
			_opcodeTable[0, 1, 1, 0x47] = new OpcodeHandler(EOR_E0M1X1_47);
			_opcodeTable[0, 1, 1, 0x48] = new OpcodeHandler(PHA_E0M1X1_48);
			_opcodeTable[0, 1, 1, 0x49] = new OpcodeHandler(EOR_E0M1X1_49);
			_opcodeTable[0, 1, 1, 0x4A] = new OpcodeHandler(LSR_E0M1X1_4A);
			_opcodeTable[0, 1, 1, 0x4B] = new OpcodeHandler(PHK_E0M1X1_4B);
			_opcodeTable[0, 1, 1, 0x4C] = new OpcodeHandler(JMP_E0M1X1_4C);
			_opcodeTable[0, 1, 1, 0x4D] = new OpcodeHandler(EOR_E0M1X1_4D);
			_opcodeTable[0, 1, 1, 0x4E] = new OpcodeHandler(LSR_E0M1X1_4E);
			_opcodeTable[0, 1, 1, 0x4F] = new OpcodeHandler(EOR_E0M1X1_4F);
			_opcodeTable[0, 1, 1, 0x50] = new OpcodeHandler(BVC_E0M1X1_50);
			_opcodeTable[0, 1, 1, 0x51] = new OpcodeHandler(EOR_E0M1X1_51);
			_opcodeTable[0, 1, 1, 0x52] = new OpcodeHandler(EOR_E0M1X1_52);
			_opcodeTable[0, 1, 1, 0x53] = new OpcodeHandler(EOR_E0M1X1_53);
			_opcodeTable[0, 1, 1, 0x54] = new OpcodeHandler(MVN_E0M1X1_54);
			_opcodeTable[0, 1, 1, 0x55] = new OpcodeHandler(EOR_E0M1X1_55);
			_opcodeTable[0, 1, 1, 0x56] = new OpcodeHandler(LSR_E0M1X1_56);
			_opcodeTable[0, 1, 1, 0x57] = new OpcodeHandler(EOR_E0M1X1_57);
			_opcodeTable[0, 1, 1, 0x58] = new OpcodeHandler(CLI_E0M1X1_58);
			_opcodeTable[0, 1, 1, 0x59] = new OpcodeHandler(EOR_E0M1X1_59);
			_opcodeTable[0, 1, 1, 0x5A] = new OpcodeHandler(PHY_E0M1X1_5A);
			_opcodeTable[0, 1, 1, 0x5B] = new OpcodeHandler(TCD_E0M1X1_5B);
			_opcodeTable[0, 1, 1, 0x5C] = new OpcodeHandler(JMP_E0M1X1_5C);
			_opcodeTable[0, 1, 1, 0x5D] = new OpcodeHandler(EOR_E0M1X1_5D);
			_opcodeTable[0, 1, 1, 0x5E] = new OpcodeHandler(LSR_E0M1X1_5E);
			_opcodeTable[0, 1, 1, 0x5F] = new OpcodeHandler(EOR_E0M1X1_5F);
			_opcodeTable[0, 1, 1, 0x60] = new OpcodeHandler(RTS_E0M1X1_60);
			_opcodeTable[0, 1, 1, 0x61] = new OpcodeHandler(ADC_E0M1X1_61);
			_opcodeTable[0, 1, 1, 0x62] = new OpcodeHandler(PER_E0M1X1_62);
			_opcodeTable[0, 1, 1, 0x63] = new OpcodeHandler(ADC_E0M1X1_63);
			_opcodeTable[0, 1, 1, 0x64] = new OpcodeHandler(STZ_E0M1X1_64);
			_opcodeTable[0, 1, 1, 0x65] = new OpcodeHandler(ADC_E0M1X1_65);
			_opcodeTable[0, 1, 1, 0x66] = new OpcodeHandler(ROR_E0M1X1_66);
			_opcodeTable[0, 1, 1, 0x67] = new OpcodeHandler(ADC_E0M1X1_67);
			_opcodeTable[0, 1, 1, 0x68] = new OpcodeHandler(PLA_E0M1X1_68);
			_opcodeTable[0, 1, 1, 0x69] = new OpcodeHandler(ADC_E0M1X1_69);
			_opcodeTable[0, 1, 1, 0x6A] = new OpcodeHandler(ROR_E0M1X1_6A);
			_opcodeTable[0, 1, 1, 0x6B] = new OpcodeHandler(RTL_E0M1X1_6B);
			_opcodeTable[0, 1, 1, 0x6C] = new OpcodeHandler(JMP_E0M1X1_6C);
			_opcodeTable[0, 1, 1, 0x6D] = new OpcodeHandler(ADC_E0M1X1_6D);
			_opcodeTable[0, 1, 1, 0x6E] = new OpcodeHandler(ROR_E0M1X1_6E);
			_opcodeTable[0, 1, 1, 0x6F] = new OpcodeHandler(ADC_E0M1X1_6F);
			_opcodeTable[0, 1, 1, 0x70] = new OpcodeHandler(BVS_E0M1X1_70);
			_opcodeTable[0, 1, 1, 0x71] = new OpcodeHandler(ADC_E0M1X1_71);
			_opcodeTable[0, 1, 1, 0x72] = new OpcodeHandler(ADC_E0M1X1_72);
			_opcodeTable[0, 1, 1, 0x73] = new OpcodeHandler(ADC_E0M1X1_73);
			_opcodeTable[0, 1, 1, 0x74] = new OpcodeHandler(STZ_E0M1X1_74);
			_opcodeTable[0, 1, 1, 0x75] = new OpcodeHandler(ADC_E0M1X1_75);
			_opcodeTable[0, 1, 1, 0x76] = new OpcodeHandler(ROR_E0M1X1_76);
			_opcodeTable[0, 1, 1, 0x77] = new OpcodeHandler(ADC_E0M1X1_77);
			_opcodeTable[0, 1, 1, 0x78] = new OpcodeHandler(SEI_E0M1X1_78);
			_opcodeTable[0, 1, 1, 0x79] = new OpcodeHandler(ADC_E0M1X1_79);
			_opcodeTable[0, 1, 1, 0x7A] = new OpcodeHandler(PLY_E0M1X1_7A);
			_opcodeTable[0, 1, 1, 0x7B] = new OpcodeHandler(TDC_E0M1X1_7B);
			_opcodeTable[0, 1, 1, 0x7C] = new OpcodeHandler(JMP_E0M1X1_7C);
			_opcodeTable[0, 1, 1, 0x7D] = new OpcodeHandler(ADC_E0M1X1_7D);
			_opcodeTable[0, 1, 1, 0x7E] = new OpcodeHandler(ROR_E0M1X1_7E);
			_opcodeTable[0, 1, 1, 0x7F] = new OpcodeHandler(ADC_E0M1X1_7F);
			_opcodeTable[0, 1, 1, 0x80] = new OpcodeHandler(BRA_E0M1X1_80);
			_opcodeTable[0, 1, 1, 0x81] = new OpcodeHandler(STA_E0M1X1_81);
			_opcodeTable[0, 1, 1, 0x82] = new OpcodeHandler(BRL_E0M1X1_82);
			_opcodeTable[0, 1, 1, 0x83] = new OpcodeHandler(STA_E0M1X1_83);
			_opcodeTable[0, 1, 1, 0x84] = new OpcodeHandler(STY_E0M1X1_84);
			_opcodeTable[0, 1, 1, 0x85] = new OpcodeHandler(STA_E0M1X1_85);
			_opcodeTable[0, 1, 1, 0x86] = new OpcodeHandler(STX_E0M1X1_86);
			_opcodeTable[0, 1, 1, 0x87] = new OpcodeHandler(STA_E0M1X1_87);
			_opcodeTable[0, 1, 1, 0x88] = new OpcodeHandler(DEY_E0M1X1_88);
			_opcodeTable[0, 1, 1, 0x89] = new OpcodeHandler(BIT_E0M1X1_89);
			_opcodeTable[0, 1, 1, 0x8A] = new OpcodeHandler(TXA_E0M1X1_8A);
			_opcodeTable[0, 1, 1, 0x8B] = new OpcodeHandler(PHB_E0M1X1_8B);
			_opcodeTable[0, 1, 1, 0x8C] = new OpcodeHandler(STY_E0M1X1_8C);
			_opcodeTable[0, 1, 1, 0x8D] = new OpcodeHandler(STA_E0M1X1_8D);
			_opcodeTable[0, 1, 1, 0x8E] = new OpcodeHandler(STX_E0M1X1_8E);
			_opcodeTable[0, 1, 1, 0x8F] = new OpcodeHandler(STA_E0M1X1_8F);
			_opcodeTable[0, 1, 1, 0x90] = new OpcodeHandler(BCC_E0M1X1_90);
			_opcodeTable[0, 1, 1, 0x91] = new OpcodeHandler(STA_E0M1X1_91);
			_opcodeTable[0, 1, 1, 0x92] = new OpcodeHandler(STA_E0M1X1_92);
			_opcodeTable[0, 1, 1, 0x93] = new OpcodeHandler(STA_E0M1X1_93);
			_opcodeTable[0, 1, 1, 0x94] = new OpcodeHandler(STY_E0M1X1_94);
			_opcodeTable[0, 1, 1, 0x95] = new OpcodeHandler(STA_E0M1X1_95);
			_opcodeTable[0, 1, 1, 0x96] = new OpcodeHandler(STX_E0M1X1_96);
			_opcodeTable[0, 1, 1, 0x97] = new OpcodeHandler(STA_E0M1X1_97);
			_opcodeTable[0, 1, 1, 0x98] = new OpcodeHandler(TYA_E0M1X1_98);
			_opcodeTable[0, 1, 1, 0x99] = new OpcodeHandler(STA_E0M1X1_99);
			_opcodeTable[0, 1, 1, 0x9A] = new OpcodeHandler(TXS_E0M1X1_9A);
			_opcodeTable[0, 1, 1, 0x9B] = new OpcodeHandler(TXY_E0M1X1_9B);
			_opcodeTable[0, 1, 1, 0x9C] = new OpcodeHandler(STZ_E0M1X1_9C);
			_opcodeTable[0, 1, 1, 0x9D] = new OpcodeHandler(STA_E0M1X1_9D);
			_opcodeTable[0, 1, 1, 0x9E] = new OpcodeHandler(STZ_E0M1X1_9E);
			_opcodeTable[0, 1, 1, 0x9F] = new OpcodeHandler(STA_E0M1X1_9F);
			_opcodeTable[0, 1, 1, 0xA0] = new OpcodeHandler(LDY_E0M1X1_A0);
			_opcodeTable[0, 1, 1, 0xA1] = new OpcodeHandler(LDA_E0M1X1_A1);
			_opcodeTable[0, 1, 1, 0xA2] = new OpcodeHandler(LDX_E0M1X1_A2);
			_opcodeTable[0, 1, 1, 0xA3] = new OpcodeHandler(LDA_E0M1X1_A3);
			_opcodeTable[0, 1, 1, 0xA4] = new OpcodeHandler(LDY_E0M1X1_A4);
			_opcodeTable[0, 1, 1, 0xA5] = new OpcodeHandler(LDA_E0M1X1_A5);
			_opcodeTable[0, 1, 1, 0xA6] = new OpcodeHandler(LDX_E0M1X1_A6);
			_opcodeTable[0, 1, 1, 0xA7] = new OpcodeHandler(LDA_E0M1X1_A7);
			_opcodeTable[0, 1, 1, 0xA8] = new OpcodeHandler(TAY_E0M1X1_A8);
			_opcodeTable[0, 1, 1, 0xA9] = new OpcodeHandler(LDA_E0M1X1_A9);
			_opcodeTable[0, 1, 1, 0xAA] = new OpcodeHandler(TAX_E0M1X1_AA);
			_opcodeTable[0, 1, 1, 0xAB] = new OpcodeHandler(PLB_E0M1X1_AB);
			_opcodeTable[0, 1, 1, 0xAC] = new OpcodeHandler(LDY_E0M1X1_AC);
			_opcodeTable[0, 1, 1, 0xAD] = new OpcodeHandler(LDA_E0M1X1_AD);
			_opcodeTable[0, 1, 1, 0xAE] = new OpcodeHandler(LDX_E0M1X1_AE);
			_opcodeTable[0, 1, 1, 0xAF] = new OpcodeHandler(LDA_E0M1X1_AF);
			_opcodeTable[0, 1, 1, 0xB0] = new OpcodeHandler(BCS_E0M1X1_B0);
			_opcodeTable[0, 1, 1, 0xB1] = new OpcodeHandler(LDA_E0M1X1_B1);
			_opcodeTable[0, 1, 1, 0xB2] = new OpcodeHandler(LDA_E0M1X1_B2);
			_opcodeTable[0, 1, 1, 0xB3] = new OpcodeHandler(LDA_E0M1X1_B3);
			_opcodeTable[0, 1, 1, 0xB4] = new OpcodeHandler(LDY_E0M1X1_B4);
			_opcodeTable[0, 1, 1, 0xB5] = new OpcodeHandler(LDA_E0M1X1_B5);
			_opcodeTable[0, 1, 1, 0xB6] = new OpcodeHandler(LDX_E0M1X1_B6);
			_opcodeTable[0, 1, 1, 0xB7] = new OpcodeHandler(LDA_E0M1X1_B7);
			_opcodeTable[0, 1, 1, 0xB8] = new OpcodeHandler(CLV_E0M1X1_B8);
			_opcodeTable[0, 1, 1, 0xB9] = new OpcodeHandler(LDA_E0M1X1_B9);
			_opcodeTable[0, 1, 1, 0xBA] = new OpcodeHandler(TSX_E0M1X1_BA);
			_opcodeTable[0, 1, 1, 0xBB] = new OpcodeHandler(TYX_E0M1X1_BB);
			_opcodeTable[0, 1, 1, 0xBC] = new OpcodeHandler(LDY_E0M1X1_BC);
			_opcodeTable[0, 1, 1, 0xBD] = new OpcodeHandler(LDA_E0M1X1_BD);
			_opcodeTable[0, 1, 1, 0xBE] = new OpcodeHandler(LDX_E0M1X1_BE);
			_opcodeTable[0, 1, 1, 0xBF] = new OpcodeHandler(LDA_E0M1X1_BF);
			_opcodeTable[0, 1, 1, 0xC0] = new OpcodeHandler(CPY_E0M1X1_C0);
			_opcodeTable[0, 1, 1, 0xC1] = new OpcodeHandler(CMP_E0M1X1_C1);
			_opcodeTable[0, 1, 1, 0xC2] = new OpcodeHandler(REP_E0M1X1_C2);
			_opcodeTable[0, 1, 1, 0xC3] = new OpcodeHandler(CMP_E0M1X1_C3);
			_opcodeTable[0, 1, 1, 0xC4] = new OpcodeHandler(CPY_E0M1X1_C4);
			_opcodeTable[0, 1, 1, 0xC5] = new OpcodeHandler(CMP_E0M1X1_C5);
			_opcodeTable[0, 1, 1, 0xC6] = new OpcodeHandler(DEC_E0M1X1_C6);
			_opcodeTable[0, 1, 1, 0xC7] = new OpcodeHandler(CMP_E0M1X1_C7);
			_opcodeTable[0, 1, 1, 0xC8] = new OpcodeHandler(INY_E0M1X1_C8);
			_opcodeTable[0, 1, 1, 0xC9] = new OpcodeHandler(CMP_E0M1X1_C9);
			_opcodeTable[0, 1, 1, 0xCA] = new OpcodeHandler(DEX_E0M1X1_CA);
			_opcodeTable[0, 1, 1, 0xCB] = new OpcodeHandler(WAI_E0M1X1_CB);
			_opcodeTable[0, 1, 1, 0xCC] = new OpcodeHandler(CPY_E0M1X1_CC);
			_opcodeTable[0, 1, 1, 0xCD] = new OpcodeHandler(CMP_E0M1X1_CD);
			_opcodeTable[0, 1, 1, 0xCE] = new OpcodeHandler(DEC_E0M1X1_CE);
			_opcodeTable[0, 1, 1, 0xCF] = new OpcodeHandler(CMP_E0M1X1_CF);
			_opcodeTable[0, 1, 1, 0xD0] = new OpcodeHandler(BNE_E0M1X1_D0);
			_opcodeTable[0, 1, 1, 0xD1] = new OpcodeHandler(CMP_E0M1X1_D1);
			_opcodeTable[0, 1, 1, 0xD2] = new OpcodeHandler(CMP_E0M1X1_D2);
			_opcodeTable[0, 1, 1, 0xD3] = new OpcodeHandler(CMP_E0M1X1_D3);
			_opcodeTable[0, 1, 1, 0xD4] = new OpcodeHandler(PEI_E0M1X1_D4);
			_opcodeTable[0, 1, 1, 0xD5] = new OpcodeHandler(CMP_E0M1X1_D5);
			_opcodeTable[0, 1, 1, 0xD6] = new OpcodeHandler(DEC_E0M1X1_D6);
			_opcodeTable[0, 1, 1, 0xD7] = new OpcodeHandler(CMP_E0M1X1_D7);
			_opcodeTable[0, 1, 1, 0xD8] = new OpcodeHandler(CLD_E0M1X1_D8);
			_opcodeTable[0, 1, 1, 0xD9] = new OpcodeHandler(CMP_E0M1X1_D9);
			_opcodeTable[0, 1, 1, 0xDA] = new OpcodeHandler(PHX_E0M1X1_DA);
			_opcodeTable[0, 1, 1, 0xDB] = new OpcodeHandler(STP_E0M1X1_DB);
			_opcodeTable[0, 1, 1, 0xDC] = new OpcodeHandler(JMP_E0M1X1_DC);
			_opcodeTable[0, 1, 1, 0xDD] = new OpcodeHandler(CMP_E0M1X1_DD);
			_opcodeTable[0, 1, 1, 0xDE] = new OpcodeHandler(DEC_E0M1X1_DE);
			_opcodeTable[0, 1, 1, 0xDF] = new OpcodeHandler(CMP_E0M1X1_DF);
			_opcodeTable[0, 1, 1, 0xE0] = new OpcodeHandler(CPX_E0M1X1_E0);
			_opcodeTable[0, 1, 1, 0xE1] = new OpcodeHandler(SBC_E0M1X1_E1);
			_opcodeTable[0, 1, 1, 0xE2] = new OpcodeHandler(SEP_E0M1X1_E2);
			_opcodeTable[0, 1, 1, 0xE3] = new OpcodeHandler(SBC_E0M1X1_E3);
			_opcodeTable[0, 1, 1, 0xE4] = new OpcodeHandler(CPX_E0M1X1_E4);
			_opcodeTable[0, 1, 1, 0xE5] = new OpcodeHandler(SBC_E0M1X1_E5);
			_opcodeTable[0, 1, 1, 0xE6] = new OpcodeHandler(INC_E0M1X1_E6);
			_opcodeTable[0, 1, 1, 0xE7] = new OpcodeHandler(SBC_E0M1X1_E7);
			_opcodeTable[0, 1, 1, 0xE8] = new OpcodeHandler(INX_E0M1X1_E8);
			_opcodeTable[0, 1, 1, 0xE9] = new OpcodeHandler(SBC_E0M1X1_E9);
			_opcodeTable[0, 1, 1, 0xEA] = new OpcodeHandler(NOP_E0M1X1_EA);
			_opcodeTable[0, 1, 1, 0xEB] = new OpcodeHandler(XBA_E0M1X1_EB);
			_opcodeTable[0, 1, 1, 0xEC] = new OpcodeHandler(CPX_E0M1X1_EC);
			_opcodeTable[0, 1, 1, 0xED] = new OpcodeHandler(SBC_E0M1X1_ED);
			_opcodeTable[0, 1, 1, 0xEE] = new OpcodeHandler(INC_E0M1X1_EE);
			_opcodeTable[0, 1, 1, 0xEF] = new OpcodeHandler(SBC_E0M1X1_EF);
			_opcodeTable[0, 1, 1, 0xF0] = new OpcodeHandler(BEQ_E0M1X1_F0);
			_opcodeTable[0, 1, 1, 0xF1] = new OpcodeHandler(SBC_E0M1X1_F1);
			_opcodeTable[0, 1, 1, 0xF2] = new OpcodeHandler(SBC_E0M1X1_F2);
			_opcodeTable[0, 1, 1, 0xF3] = new OpcodeHandler(SBC_E0M1X1_F3);
			_opcodeTable[0, 1, 1, 0xF4] = new OpcodeHandler(PEA_E0M1X1_F4);
			_opcodeTable[0, 1, 1, 0xF5] = new OpcodeHandler(SBC_E0M1X1_F5);
			_opcodeTable[0, 1, 1, 0xF6] = new OpcodeHandler(INC_E0M1X1_F6);
			_opcodeTable[0, 1, 1, 0xF7] = new OpcodeHandler(SBC_E0M1X1_F7);
			_opcodeTable[0, 1, 1, 0xF8] = new OpcodeHandler(SED_E0M1X1_F8);
			_opcodeTable[0, 1, 1, 0xF9] = new OpcodeHandler(SBC_E0M1X1_F9);
			_opcodeTable[0, 1, 1, 0xFA] = new OpcodeHandler(PLX_E0M1X1_FA);
			_opcodeTable[0, 1, 1, 0xFB] = new OpcodeHandler(XCE_E0M1X1_FB);
			_opcodeTable[0, 1, 1, 0xFC] = new OpcodeHandler(JSR_E0M1X1_FC);
			_opcodeTable[0, 1, 1, 0xFD] = new OpcodeHandler(SBC_E0M1X1_FD);
			_opcodeTable[0, 1, 1, 0xFE] = new OpcodeHandler(INC_E0M1X1_FE);
			_opcodeTable[0, 1, 1, 0xFF] = new OpcodeHandler(SBC_E0M1X1_FF);
			#endregion

			#region Opcodes E0M0X1
			_opcodeTable[0, 0, 1, 0x00] = new OpcodeHandler(BRK_E0M0X1_00);
			_opcodeTable[0, 0, 1, 0x01] = new OpcodeHandler(ORA_E0M0X1_01);
			_opcodeTable[0, 0, 1, 0x02] = new OpcodeHandler(COP_E0M0X1_02);
			_opcodeTable[0, 0, 1, 0x03] = new OpcodeHandler(ORA_E0M0X1_03);
			_opcodeTable[0, 0, 1, 0x04] = new OpcodeHandler(TSB_E0M0X1_04);
			_opcodeTable[0, 0, 1, 0x05] = new OpcodeHandler(ORA_E0M0X1_05);
			_opcodeTable[0, 0, 1, 0x06] = new OpcodeHandler(ASL_E0M0X1_06);
			_opcodeTable[0, 0, 1, 0x07] = new OpcodeHandler(ORA_E0M0X1_07);
			_opcodeTable[0, 0, 1, 0x08] = new OpcodeHandler(PHP_E0M0X1_08);
			_opcodeTable[0, 0, 1, 0x09] = new OpcodeHandler(ORA_E0M0X1_09);
			_opcodeTable[0, 0, 1, 0x0A] = new OpcodeHandler(ASL_E0M0X1_0A);
			_opcodeTable[0, 0, 1, 0x0B] = new OpcodeHandler(PHD_E0M0X1_0B);
			_opcodeTable[0, 0, 1, 0x0C] = new OpcodeHandler(TSB_E0M0X1_0C);
			_opcodeTable[0, 0, 1, 0x0D] = new OpcodeHandler(ORA_E0M0X1_0D);
			_opcodeTable[0, 0, 1, 0x0E] = new OpcodeHandler(ASL_E0M0X1_0E);
			_opcodeTable[0, 0, 1, 0x0F] = new OpcodeHandler(ORA_E0M0X1_0F);
			_opcodeTable[0, 0, 1, 0x10] = new OpcodeHandler(BPL_E0M0X1_10);
			_opcodeTable[0, 0, 1, 0x11] = new OpcodeHandler(ORA_E0M0X1_11);
			_opcodeTable[0, 0, 1, 0x12] = new OpcodeHandler(ORA_E0M0X1_12);
			_opcodeTable[0, 0, 1, 0x13] = new OpcodeHandler(ORA_E0M0X1_13);
			_opcodeTable[0, 0, 1, 0x14] = new OpcodeHandler(TRB_E0M0X1_14);
			_opcodeTable[0, 0, 1, 0x15] = new OpcodeHandler(ORA_E0M0X1_15);
			_opcodeTable[0, 0, 1, 0x16] = new OpcodeHandler(ASL_E0M0X1_16);
			_opcodeTable[0, 0, 1, 0x17] = new OpcodeHandler(ORA_E0M0X1_17);
			_opcodeTable[0, 0, 1, 0x18] = new OpcodeHandler(CLC_E0M0X1_18);
			_opcodeTable[0, 0, 1, 0x19] = new OpcodeHandler(ORA_E0M0X1_19);
			_opcodeTable[0, 0, 1, 0x1A] = new OpcodeHandler(INC_E0M0X1_1A);
			_opcodeTable[0, 0, 1, 0x1B] = new OpcodeHandler(TCS_E0M0X1_1B);
			_opcodeTable[0, 0, 1, 0x1C] = new OpcodeHandler(TRB_E0M0X1_1C);
			_opcodeTable[0, 0, 1, 0x1D] = new OpcodeHandler(ORA_E0M0X1_1D);
			_opcodeTable[0, 0, 1, 0x1E] = new OpcodeHandler(ASL_E0M0X1_1E);
			_opcodeTable[0, 0, 1, 0x1F] = new OpcodeHandler(ORA_E0M0X1_1F);
			_opcodeTable[0, 0, 1, 0x20] = new OpcodeHandler(JSR_E0M0X1_20);
			_opcodeTable[0, 0, 1, 0x21] = new OpcodeHandler(AND_E0M0X1_21);
			_opcodeTable[0, 0, 1, 0x22] = new OpcodeHandler(JSR_E0M0X1_22);
			_opcodeTable[0, 0, 1, 0x23] = new OpcodeHandler(AND_E0M0X1_23);
			_opcodeTable[0, 0, 1, 0x24] = new OpcodeHandler(BIT_E0M0X1_24);
			_opcodeTable[0, 0, 1, 0x25] = new OpcodeHandler(AND_E0M0X1_25);
			_opcodeTable[0, 0, 1, 0x26] = new OpcodeHandler(ROL_E0M0X1_26);
			_opcodeTable[0, 0, 1, 0x27] = new OpcodeHandler(AND_E0M0X1_27);
			_opcodeTable[0, 0, 1, 0x28] = new OpcodeHandler(PLP_E0M0X1_28);
			_opcodeTable[0, 0, 1, 0x29] = new OpcodeHandler(AND_E0M0X1_29);
			_opcodeTable[0, 0, 1, 0x2A] = new OpcodeHandler(ROL_E0M0X1_2A);
			_opcodeTable[0, 0, 1, 0x2B] = new OpcodeHandler(PLD_E0M0X1_2B);
			_opcodeTable[0, 0, 1, 0x2C] = new OpcodeHandler(BIT_E0M0X1_2C);
			_opcodeTable[0, 0, 1, 0x2D] = new OpcodeHandler(AND_E0M0X1_2D);
			_opcodeTable[0, 0, 1, 0x2E] = new OpcodeHandler(ROL_E0M0X1_2E);
			_opcodeTable[0, 0, 1, 0x2F] = new OpcodeHandler(AND_E0M0X1_2F);
			_opcodeTable[0, 0, 1, 0x30] = new OpcodeHandler(BMI_E0M0X1_30);
			_opcodeTable[0, 0, 1, 0x31] = new OpcodeHandler(AND_E0M0X1_31);
			_opcodeTable[0, 0, 1, 0x32] = new OpcodeHandler(AND_E0M0X1_32);
			_opcodeTable[0, 0, 1, 0x33] = new OpcodeHandler(AND_E0M0X1_33);
			_opcodeTable[0, 0, 1, 0x34] = new OpcodeHandler(BIT_E0M0X1_34);
			_opcodeTable[0, 0, 1, 0x35] = new OpcodeHandler(AND_E0M0X1_35);
			_opcodeTable[0, 0, 1, 0x36] = new OpcodeHandler(ROL_E0M0X1_36);
			_opcodeTable[0, 0, 1, 0x37] = new OpcodeHandler(AND_E0M0X1_37);
			_opcodeTable[0, 0, 1, 0x38] = new OpcodeHandler(SEC_E0M0X1_38);
			_opcodeTable[0, 0, 1, 0x39] = new OpcodeHandler(AND_E0M0X1_39);
			_opcodeTable[0, 0, 1, 0x3A] = new OpcodeHandler(DEC_E0M0X1_3A);
			_opcodeTable[0, 0, 1, 0x3B] = new OpcodeHandler(TSC_E0M0X1_3B);
			_opcodeTable[0, 0, 1, 0x3C] = new OpcodeHandler(BIT_E0M0X1_3C);
			_opcodeTable[0, 0, 1, 0x3D] = new OpcodeHandler(AND_E0M0X1_3D);
			_opcodeTable[0, 0, 1, 0x3E] = new OpcodeHandler(ROL_E0M0X1_3E);
			_opcodeTable[0, 0, 1, 0x3F] = new OpcodeHandler(AND_E0M0X1_3F);
			_opcodeTable[0, 0, 1, 0x40] = new OpcodeHandler(RTI_E0M0X1_40);
			_opcodeTable[0, 0, 1, 0x41] = new OpcodeHandler(EOR_E0M0X1_41);
			_opcodeTable[0, 0, 1, 0x42] = new OpcodeHandler(WDM_E0M0X1_42);
			_opcodeTable[0, 0, 1, 0x43] = new OpcodeHandler(EOR_E0M0X1_43);
			_opcodeTable[0, 0, 1, 0x44] = new OpcodeHandler(MVP_E0M0X1_44);
			_opcodeTable[0, 0, 1, 0x45] = new OpcodeHandler(EOR_E0M0X1_45);
			_opcodeTable[0, 0, 1, 0x46] = new OpcodeHandler(LSR_E0M0X1_46);
			_opcodeTable[0, 0, 1, 0x47] = new OpcodeHandler(EOR_E0M0X1_47);
			_opcodeTable[0, 0, 1, 0x48] = new OpcodeHandler(PHA_E0M0X1_48);
			_opcodeTable[0, 0, 1, 0x49] = new OpcodeHandler(EOR_E0M0X1_49);
			_opcodeTable[0, 0, 1, 0x4A] = new OpcodeHandler(LSR_E0M0X1_4A);
			_opcodeTable[0, 0, 1, 0x4B] = new OpcodeHandler(PHK_E0M0X1_4B);
			_opcodeTable[0, 0, 1, 0x4C] = new OpcodeHandler(JMP_E0M0X1_4C);
			_opcodeTable[0, 0, 1, 0x4D] = new OpcodeHandler(EOR_E0M0X1_4D);
			_opcodeTable[0, 0, 1, 0x4E] = new OpcodeHandler(LSR_E0M0X1_4E);
			_opcodeTable[0, 0, 1, 0x4F] = new OpcodeHandler(EOR_E0M0X1_4F);
			_opcodeTable[0, 0, 1, 0x50] = new OpcodeHandler(BVC_E0M0X1_50);
			_opcodeTable[0, 0, 1, 0x51] = new OpcodeHandler(EOR_E0M0X1_51);
			_opcodeTable[0, 0, 1, 0x52] = new OpcodeHandler(EOR_E0M0X1_52);
			_opcodeTable[0, 0, 1, 0x53] = new OpcodeHandler(EOR_E0M0X1_53);
			_opcodeTable[0, 0, 1, 0x54] = new OpcodeHandler(MVN_E0M0X1_54);
			_opcodeTable[0, 0, 1, 0x55] = new OpcodeHandler(EOR_E0M0X1_55);
			_opcodeTable[0, 0, 1, 0x56] = new OpcodeHandler(LSR_E0M0X1_56);
			_opcodeTable[0, 0, 1, 0x57] = new OpcodeHandler(EOR_E0M0X1_57);
			_opcodeTable[0, 0, 1, 0x58] = new OpcodeHandler(CLI_E0M0X1_58);
			_opcodeTable[0, 0, 1, 0x59] = new OpcodeHandler(EOR_E0M0X1_59);
			_opcodeTable[0, 0, 1, 0x5A] = new OpcodeHandler(PHY_E0M0X1_5A);
			_opcodeTable[0, 0, 1, 0x5B] = new OpcodeHandler(TCD_E0M0X1_5B);
			_opcodeTable[0, 0, 1, 0x5C] = new OpcodeHandler(JMP_E0M0X1_5C);
			_opcodeTable[0, 0, 1, 0x5D] = new OpcodeHandler(EOR_E0M0X1_5D);
			_opcodeTable[0, 0, 1, 0x5E] = new OpcodeHandler(LSR_E0M0X1_5E);
			_opcodeTable[0, 0, 1, 0x5F] = new OpcodeHandler(EOR_E0M0X1_5F);
			_opcodeTable[0, 0, 1, 0x60] = new OpcodeHandler(RTS_E0M0X1_60);
			_opcodeTable[0, 0, 1, 0x61] = new OpcodeHandler(ADC_E0M0X1_61);
			_opcodeTable[0, 0, 1, 0x62] = new OpcodeHandler(PER_E0M0X1_62);
			_opcodeTable[0, 0, 1, 0x63] = new OpcodeHandler(ADC_E0M0X1_63);
			_opcodeTable[0, 0, 1, 0x64] = new OpcodeHandler(STZ_E0M0X1_64);
			_opcodeTable[0, 0, 1, 0x65] = new OpcodeHandler(ADC_E0M0X1_65);
			_opcodeTable[0, 0, 1, 0x66] = new OpcodeHandler(ROR_E0M0X1_66);
			_opcodeTable[0, 0, 1, 0x67] = new OpcodeHandler(ADC_E0M0X1_67);
			_opcodeTable[0, 0, 1, 0x68] = new OpcodeHandler(PLA_E0M0X1_68);
			_opcodeTable[0, 0, 1, 0x69] = new OpcodeHandler(ADC_E0M0X1_69);
			_opcodeTable[0, 0, 1, 0x6A] = new OpcodeHandler(ROR_E0M0X1_6A);
			_opcodeTable[0, 0, 1, 0x6B] = new OpcodeHandler(RTL_E0M0X1_6B);
			_opcodeTable[0, 0, 1, 0x6C] = new OpcodeHandler(JMP_E0M0X1_6C);
			_opcodeTable[0, 0, 1, 0x6D] = new OpcodeHandler(ADC_E0M0X1_6D);
			_opcodeTable[0, 0, 1, 0x6E] = new OpcodeHandler(ROR_E0M0X1_6E);
			_opcodeTable[0, 0, 1, 0x6F] = new OpcodeHandler(ADC_E0M0X1_6F);
			_opcodeTable[0, 0, 1, 0x70] = new OpcodeHandler(BVS_E0M0X1_70);
			_opcodeTable[0, 0, 1, 0x71] = new OpcodeHandler(ADC_E0M0X1_71);
			_opcodeTable[0, 0, 1, 0x72] = new OpcodeHandler(ADC_E0M0X1_72);
			_opcodeTable[0, 0, 1, 0x73] = new OpcodeHandler(ADC_E0M0X1_73);
			_opcodeTable[0, 0, 1, 0x74] = new OpcodeHandler(STZ_E0M0X1_74);
			_opcodeTable[0, 0, 1, 0x75] = new OpcodeHandler(ADC_E0M0X1_75);
			_opcodeTable[0, 0, 1, 0x76] = new OpcodeHandler(ROR_E0M0X1_76);
			_opcodeTable[0, 0, 1, 0x77] = new OpcodeHandler(ADC_E0M0X1_77);
			_opcodeTable[0, 0, 1, 0x78] = new OpcodeHandler(SEI_E0M0X1_78);
			_opcodeTable[0, 0, 1, 0x79] = new OpcodeHandler(ADC_E0M0X1_79);
			_opcodeTable[0, 0, 1, 0x7A] = new OpcodeHandler(PLY_E0M0X1_7A);
			_opcodeTable[0, 0, 1, 0x7B] = new OpcodeHandler(TDC_E0M0X1_7B);
			_opcodeTable[0, 0, 1, 0x7C] = new OpcodeHandler(JMP_E0M0X1_7C);
			_opcodeTable[0, 0, 1, 0x7D] = new OpcodeHandler(ADC_E0M0X1_7D);
			_opcodeTable[0, 0, 1, 0x7E] = new OpcodeHandler(ROR_E0M0X1_7E);
			_opcodeTable[0, 0, 1, 0x7F] = new OpcodeHandler(ADC_E0M0X1_7F);
			_opcodeTable[0, 0, 1, 0x80] = new OpcodeHandler(BRA_E0M0X1_80);
			_opcodeTable[0, 0, 1, 0x81] = new OpcodeHandler(STA_E0M0X1_81);
			_opcodeTable[0, 0, 1, 0x82] = new OpcodeHandler(BRL_E0M0X1_82);
			_opcodeTable[0, 0, 1, 0x83] = new OpcodeHandler(STA_E0M0X1_83);
			_opcodeTable[0, 0, 1, 0x84] = new OpcodeHandler(STY_E0M0X1_84);
			_opcodeTable[0, 0, 1, 0x85] = new OpcodeHandler(STA_E0M0X1_85);
			_opcodeTable[0, 0, 1, 0x86] = new OpcodeHandler(STX_E0M0X1_86);
			_opcodeTable[0, 0, 1, 0x87] = new OpcodeHandler(STA_E0M0X1_87);
			_opcodeTable[0, 0, 1, 0x88] = new OpcodeHandler(DEY_E0M0X1_88);
			_opcodeTable[0, 0, 1, 0x89] = new OpcodeHandler(BIT_E0M0X1_89);
			_opcodeTable[0, 0, 1, 0x8A] = new OpcodeHandler(TXA_E0M0X1_8A);
			_opcodeTable[0, 0, 1, 0x8B] = new OpcodeHandler(PHB_E0M0X1_8B);
			_opcodeTable[0, 0, 1, 0x8C] = new OpcodeHandler(STY_E0M0X1_8C);
			_opcodeTable[0, 0, 1, 0x8D] = new OpcodeHandler(STA_E0M0X1_8D);
			_opcodeTable[0, 0, 1, 0x8E] = new OpcodeHandler(STX_E0M0X1_8E);
			_opcodeTable[0, 0, 1, 0x8F] = new OpcodeHandler(STA_E0M0X1_8F);
			_opcodeTable[0, 0, 1, 0x90] = new OpcodeHandler(BCC_E0M0X1_90);
			_opcodeTable[0, 0, 1, 0x91] = new OpcodeHandler(STA_E0M0X1_91);
			_opcodeTable[0, 0, 1, 0x92] = new OpcodeHandler(STA_E0M0X1_92);
			_opcodeTable[0, 0, 1, 0x93] = new OpcodeHandler(STA_E0M0X1_93);
			_opcodeTable[0, 0, 1, 0x94] = new OpcodeHandler(STY_E0M0X1_94);
			_opcodeTable[0, 0, 1, 0x95] = new OpcodeHandler(STA_E0M0X1_95);
			_opcodeTable[0, 0, 1, 0x96] = new OpcodeHandler(STX_E0M0X1_96);
			_opcodeTable[0, 0, 1, 0x97] = new OpcodeHandler(STA_E0M0X1_97);
			_opcodeTable[0, 0, 1, 0x98] = new OpcodeHandler(TYA_E0M0X1_98);
			_opcodeTable[0, 0, 1, 0x99] = new OpcodeHandler(STA_E0M0X1_99);
			_opcodeTable[0, 0, 1, 0x9A] = new OpcodeHandler(TXS_E0M0X1_9A);
			_opcodeTable[0, 0, 1, 0x9B] = new OpcodeHandler(TXY_E0M0X1_9B);
			_opcodeTable[0, 0, 1, 0x9C] = new OpcodeHandler(STZ_E0M0X1_9C);
			_opcodeTable[0, 0, 1, 0x9D] = new OpcodeHandler(STA_E0M0X1_9D);
			_opcodeTable[0, 0, 1, 0x9E] = new OpcodeHandler(STZ_E0M0X1_9E);
			_opcodeTable[0, 0, 1, 0x9F] = new OpcodeHandler(STA_E0M0X1_9F);
			_opcodeTable[0, 0, 1, 0xA0] = new OpcodeHandler(LDY_E0M0X1_A0);
			_opcodeTable[0, 0, 1, 0xA1] = new OpcodeHandler(LDA_E0M0X1_A1);
			_opcodeTable[0, 0, 1, 0xA2] = new OpcodeHandler(LDX_E0M0X1_A2);
			_opcodeTable[0, 0, 1, 0xA3] = new OpcodeHandler(LDA_E0M0X1_A3);
			_opcodeTable[0, 0, 1, 0xA4] = new OpcodeHandler(LDY_E0M0X1_A4);
			_opcodeTable[0, 0, 1, 0xA5] = new OpcodeHandler(LDA_E0M0X1_A5);
			_opcodeTable[0, 0, 1, 0xA6] = new OpcodeHandler(LDX_E0M0X1_A6);
			_opcodeTable[0, 0, 1, 0xA7] = new OpcodeHandler(LDA_E0M0X1_A7);
			_opcodeTable[0, 0, 1, 0xA8] = new OpcodeHandler(TAY_E0M0X1_A8);
			_opcodeTable[0, 0, 1, 0xA9] = new OpcodeHandler(LDA_E0M0X1_A9);
			_opcodeTable[0, 0, 1, 0xAA] = new OpcodeHandler(TAX_E0M0X1_AA);
			_opcodeTable[0, 0, 1, 0xAB] = new OpcodeHandler(PLB_E0M0X1_AB);
			_opcodeTable[0, 0, 1, 0xAC] = new OpcodeHandler(LDY_E0M0X1_AC);
			_opcodeTable[0, 0, 1, 0xAD] = new OpcodeHandler(LDA_E0M0X1_AD);
			_opcodeTable[0, 0, 1, 0xAE] = new OpcodeHandler(LDX_E0M0X1_AE);
			_opcodeTable[0, 0, 1, 0xAF] = new OpcodeHandler(LDA_E0M0X1_AF);
			_opcodeTable[0, 0, 1, 0xB0] = new OpcodeHandler(BCS_E0M0X1_B0);
			_opcodeTable[0, 0, 1, 0xB1] = new OpcodeHandler(LDA_E0M0X1_B1);
			_opcodeTable[0, 0, 1, 0xB2] = new OpcodeHandler(LDA_E0M0X1_B2);
			_opcodeTable[0, 0, 1, 0xB3] = new OpcodeHandler(LDA_E0M0X1_B3);
			_opcodeTable[0, 0, 1, 0xB4] = new OpcodeHandler(LDY_E0M0X1_B4);
			_opcodeTable[0, 0, 1, 0xB5] = new OpcodeHandler(LDA_E0M0X1_B5);
			_opcodeTable[0, 0, 1, 0xB6] = new OpcodeHandler(LDX_E0M0X1_B6);
			_opcodeTable[0, 0, 1, 0xB7] = new OpcodeHandler(LDA_E0M0X1_B7);
			_opcodeTable[0, 0, 1, 0xB8] = new OpcodeHandler(CLV_E0M0X1_B8);
			_opcodeTable[0, 0, 1, 0xB9] = new OpcodeHandler(LDA_E0M0X1_B9);
			_opcodeTable[0, 0, 1, 0xBA] = new OpcodeHandler(TSX_E0M0X1_BA);
			_opcodeTable[0, 0, 1, 0xBB] = new OpcodeHandler(TYX_E0M0X1_BB);
			_opcodeTable[0, 0, 1, 0xBC] = new OpcodeHandler(LDY_E0M0X1_BC);
			_opcodeTable[0, 0, 1, 0xBD] = new OpcodeHandler(LDA_E0M0X1_BD);
			_opcodeTable[0, 0, 1, 0xBE] = new OpcodeHandler(LDX_E0M0X1_BE);
			_opcodeTable[0, 0, 1, 0xBF] = new OpcodeHandler(LDA_E0M0X1_BF);
			_opcodeTable[0, 0, 1, 0xC0] = new OpcodeHandler(CPY_E0M0X1_C0);
			_opcodeTable[0, 0, 1, 0xC1] = new OpcodeHandler(CMP_E0M0X1_C1);
			_opcodeTable[0, 0, 1, 0xC2] = new OpcodeHandler(REP_E0M0X1_C2);
			_opcodeTable[0, 0, 1, 0xC3] = new OpcodeHandler(CMP_E0M0X1_C3);
			_opcodeTable[0, 0, 1, 0xC4] = new OpcodeHandler(CPY_E0M0X1_C4);
			_opcodeTable[0, 0, 1, 0xC5] = new OpcodeHandler(CMP_E0M0X1_C5);
			_opcodeTable[0, 0, 1, 0xC6] = new OpcodeHandler(DEC_E0M0X1_C6);
			_opcodeTable[0, 0, 1, 0xC7] = new OpcodeHandler(CMP_E0M0X1_C7);
			_opcodeTable[0, 0, 1, 0xC8] = new OpcodeHandler(INY_E0M0X1_C8);
			_opcodeTable[0, 0, 1, 0xC9] = new OpcodeHandler(CMP_E0M0X1_C9);
			_opcodeTable[0, 0, 1, 0xCA] = new OpcodeHandler(DEX_E0M0X1_CA);
			_opcodeTable[0, 0, 1, 0xCB] = new OpcodeHandler(WAI_E0M0X1_CB);
			_opcodeTable[0, 0, 1, 0xCC] = new OpcodeHandler(CPY_E0M0X1_CC);
			_opcodeTable[0, 0, 1, 0xCD] = new OpcodeHandler(CMP_E0M0X1_CD);
			_opcodeTable[0, 0, 1, 0xCE] = new OpcodeHandler(DEC_E0M0X1_CE);
			_opcodeTable[0, 0, 1, 0xCF] = new OpcodeHandler(CMP_E0M0X1_CF);
			_opcodeTable[0, 0, 1, 0xD0] = new OpcodeHandler(BNE_E0M0X1_D0);
			_opcodeTable[0, 0, 1, 0xD1] = new OpcodeHandler(CMP_E0M0X1_D1);
			_opcodeTable[0, 0, 1, 0xD2] = new OpcodeHandler(CMP_E0M0X1_D2);
			_opcodeTable[0, 0, 1, 0xD3] = new OpcodeHandler(CMP_E0M0X1_D3);
			_opcodeTable[0, 0, 1, 0xD4] = new OpcodeHandler(PEI_E0M0X1_D4);
			_opcodeTable[0, 0, 1, 0xD5] = new OpcodeHandler(CMP_E0M0X1_D5);
			_opcodeTable[0, 0, 1, 0xD6] = new OpcodeHandler(DEC_E0M0X1_D6);
			_opcodeTable[0, 0, 1, 0xD7] = new OpcodeHandler(CMP_E0M0X1_D7);
			_opcodeTable[0, 0, 1, 0xD8] = new OpcodeHandler(CLD_E0M0X1_D8);
			_opcodeTable[0, 0, 1, 0xD9] = new OpcodeHandler(CMP_E0M0X1_D9);
			_opcodeTable[0, 0, 1, 0xDA] = new OpcodeHandler(PHX_E0M0X1_DA);
			_opcodeTable[0, 0, 1, 0xDB] = new OpcodeHandler(STP_E0M0X1_DB);
			_opcodeTable[0, 0, 1, 0xDC] = new OpcodeHandler(JMP_E0M0X1_DC);
			_opcodeTable[0, 0, 1, 0xDD] = new OpcodeHandler(CMP_E0M0X1_DD);
			_opcodeTable[0, 0, 1, 0xDE] = new OpcodeHandler(DEC_E0M0X1_DE);
			_opcodeTable[0, 0, 1, 0xDF] = new OpcodeHandler(CMP_E0M0X1_DF);
			_opcodeTable[0, 0, 1, 0xE0] = new OpcodeHandler(CPX_E0M0X1_E0);
			_opcodeTable[0, 0, 1, 0xE1] = new OpcodeHandler(SBC_E0M0X1_E1);
			_opcodeTable[0, 0, 1, 0xE2] = new OpcodeHandler(SEP_E0M0X1_E2);
			_opcodeTable[0, 0, 1, 0xE3] = new OpcodeHandler(SBC_E0M0X1_E3);
			_opcodeTable[0, 0, 1, 0xE4] = new OpcodeHandler(CPX_E0M0X1_E4);
			_opcodeTable[0, 0, 1, 0xE5] = new OpcodeHandler(SBC_E0M0X1_E5);
			_opcodeTable[0, 0, 1, 0xE6] = new OpcodeHandler(INC_E0M0X1_E6);
			_opcodeTable[0, 0, 1, 0xE7] = new OpcodeHandler(SBC_E0M0X1_E7);
			_opcodeTable[0, 0, 1, 0xE8] = new OpcodeHandler(INX_E0M0X1_E8);
			_opcodeTable[0, 0, 1, 0xE9] = new OpcodeHandler(SBC_E0M0X1_E9);
			_opcodeTable[0, 0, 1, 0xEA] = new OpcodeHandler(NOP_E0M0X1_EA);
			_opcodeTable[0, 0, 1, 0xEB] = new OpcodeHandler(XBA_E0M0X1_EB);
			_opcodeTable[0, 0, 1, 0xEC] = new OpcodeHandler(CPX_E0M0X1_EC);
			_opcodeTable[0, 0, 1, 0xED] = new OpcodeHandler(SBC_E0M0X1_ED);
			_opcodeTable[0, 0, 1, 0xEE] = new OpcodeHandler(INC_E0M0X1_EE);
			_opcodeTable[0, 0, 1, 0xEF] = new OpcodeHandler(SBC_E0M0X1_EF);
			_opcodeTable[0, 0, 1, 0xF0] = new OpcodeHandler(BEQ_E0M0X1_F0);
			_opcodeTable[0, 0, 1, 0xF1] = new OpcodeHandler(SBC_E0M0X1_F1);
			_opcodeTable[0, 0, 1, 0xF2] = new OpcodeHandler(SBC_E0M0X1_F2);
			_opcodeTable[0, 0, 1, 0xF3] = new OpcodeHandler(SBC_E0M0X1_F3);
			_opcodeTable[0, 0, 1, 0xF4] = new OpcodeHandler(PEA_E0M0X1_F4);
			_opcodeTable[0, 0, 1, 0xF5] = new OpcodeHandler(SBC_E0M0X1_F5);
			_opcodeTable[0, 0, 1, 0xF6] = new OpcodeHandler(INC_E0M0X1_F6);
			_opcodeTable[0, 0, 1, 0xF7] = new OpcodeHandler(SBC_E0M0X1_F7);
			_opcodeTable[0, 0, 1, 0xF8] = new OpcodeHandler(SED_E0M0X1_F8);
			_opcodeTable[0, 0, 1, 0xF9] = new OpcodeHandler(SBC_E0M0X1_F9);
			_opcodeTable[0, 0, 1, 0xFA] = new OpcodeHandler(PLX_E0M0X1_FA);
			_opcodeTable[0, 0, 1, 0xFB] = new OpcodeHandler(XCE_E0M0X1_FB);
			_opcodeTable[0, 0, 1, 0xFC] = new OpcodeHandler(JSR_E0M0X1_FC);
			_opcodeTable[0, 0, 1, 0xFD] = new OpcodeHandler(SBC_E0M0X1_FD);
			_opcodeTable[0, 0, 1, 0xFE] = new OpcodeHandler(INC_E0M0X1_FE);
			_opcodeTable[0, 0, 1, 0xFF] = new OpcodeHandler(SBC_E0M0X1_FF);
			#endregion

			#region Opcodes E0M1X0
			_opcodeTable[0, 1, 0, 0x00] = new OpcodeHandler(BRK_E0M1X0_00);
			_opcodeTable[0, 1, 0, 0x01] = new OpcodeHandler(ORA_E0M1X0_01);
			_opcodeTable[0, 1, 0, 0x02] = new OpcodeHandler(COP_E0M1X0_02);
			_opcodeTable[0, 1, 0, 0x03] = new OpcodeHandler(ORA_E0M1X0_03);
			_opcodeTable[0, 1, 0, 0x04] = new OpcodeHandler(TSB_E0M1X0_04);
			_opcodeTable[0, 1, 0, 0x05] = new OpcodeHandler(ORA_E0M1X0_05);
			_opcodeTable[0, 1, 0, 0x06] = new OpcodeHandler(ASL_E0M1X0_06);
			_opcodeTable[0, 1, 0, 0x07] = new OpcodeHandler(ORA_E0M1X0_07);
			_opcodeTable[0, 1, 0, 0x08] = new OpcodeHandler(PHP_E0M1X0_08);
			_opcodeTable[0, 1, 0, 0x09] = new OpcodeHandler(ORA_E0M1X0_09);
			_opcodeTable[0, 1, 0, 0x0A] = new OpcodeHandler(ASL_E0M1X0_0A);
			_opcodeTable[0, 1, 0, 0x0B] = new OpcodeHandler(PHD_E0M1X0_0B);
			_opcodeTable[0, 1, 0, 0x0C] = new OpcodeHandler(TSB_E0M1X0_0C);
			_opcodeTable[0, 1, 0, 0x0D] = new OpcodeHandler(ORA_E0M1X0_0D);
			_opcodeTable[0, 1, 0, 0x0E] = new OpcodeHandler(ASL_E0M1X0_0E);
			_opcodeTable[0, 1, 0, 0x0F] = new OpcodeHandler(ORA_E0M1X0_0F);
			_opcodeTable[0, 1, 0, 0x10] = new OpcodeHandler(BPL_E0M1X0_10);
			_opcodeTable[0, 1, 0, 0x11] = new OpcodeHandler(ORA_E0M1X0_11);
			_opcodeTable[0, 1, 0, 0x12] = new OpcodeHandler(ORA_E0M1X0_12);
			_opcodeTable[0, 1, 0, 0x13] = new OpcodeHandler(ORA_E0M1X0_13);
			_opcodeTable[0, 1, 0, 0x14] = new OpcodeHandler(TRB_E0M1X0_14);
			_opcodeTable[0, 1, 0, 0x15] = new OpcodeHandler(ORA_E0M1X0_15);
			_opcodeTable[0, 1, 0, 0x16] = new OpcodeHandler(ASL_E0M1X0_16);
			_opcodeTable[0, 1, 0, 0x17] = new OpcodeHandler(ORA_E0M1X0_17);
			_opcodeTable[0, 1, 0, 0x18] = new OpcodeHandler(CLC_E0M1X0_18);
			_opcodeTable[0, 1, 0, 0x19] = new OpcodeHandler(ORA_E0M1X0_19);
			_opcodeTable[0, 1, 0, 0x1A] = new OpcodeHandler(INC_E0M1X0_1A);
			_opcodeTable[0, 1, 0, 0x1B] = new OpcodeHandler(TCS_E0M1X0_1B);
			_opcodeTable[0, 1, 0, 0x1C] = new OpcodeHandler(TRB_E0M1X0_1C);
			_opcodeTable[0, 1, 0, 0x1D] = new OpcodeHandler(ORA_E0M1X0_1D);
			_opcodeTable[0, 1, 0, 0x1E] = new OpcodeHandler(ASL_E0M1X0_1E);
			_opcodeTable[0, 1, 0, 0x1F] = new OpcodeHandler(ORA_E0M1X0_1F);
			_opcodeTable[0, 1, 0, 0x20] = new OpcodeHandler(JSR_E0M1X0_20);
			_opcodeTable[0, 1, 0, 0x21] = new OpcodeHandler(AND_E0M1X0_21);
			_opcodeTable[0, 1, 0, 0x22] = new OpcodeHandler(JSR_E0M1X0_22);
			_opcodeTable[0, 1, 0, 0x23] = new OpcodeHandler(AND_E0M1X0_23);
			_opcodeTable[0, 1, 0, 0x24] = new OpcodeHandler(BIT_E0M1X0_24);
			_opcodeTable[0, 1, 0, 0x25] = new OpcodeHandler(AND_E0M1X0_25);
			_opcodeTable[0, 1, 0, 0x26] = new OpcodeHandler(ROL_E0M1X0_26);
			_opcodeTable[0, 1, 0, 0x27] = new OpcodeHandler(AND_E0M1X0_27);
			_opcodeTable[0, 1, 0, 0x28] = new OpcodeHandler(PLP_E0M1X0_28);
			_opcodeTable[0, 1, 0, 0x29] = new OpcodeHandler(AND_E0M1X0_29);
			_opcodeTable[0, 1, 0, 0x2A] = new OpcodeHandler(ROL_E0M1X0_2A);
			_opcodeTable[0, 1, 0, 0x2B] = new OpcodeHandler(PLD_E0M1X0_2B);
			_opcodeTable[0, 1, 0, 0x2C] = new OpcodeHandler(BIT_E0M1X0_2C);
			_opcodeTable[0, 1, 0, 0x2D] = new OpcodeHandler(AND_E0M1X0_2D);
			_opcodeTable[0, 1, 0, 0x2E] = new OpcodeHandler(ROL_E0M1X0_2E);
			_opcodeTable[0, 1, 0, 0x2F] = new OpcodeHandler(AND_E0M1X0_2F);
			_opcodeTable[0, 1, 0, 0x30] = new OpcodeHandler(BMI_E0M1X0_30);
			_opcodeTable[0, 1, 0, 0x31] = new OpcodeHandler(AND_E0M1X0_31);
			_opcodeTable[0, 1, 0, 0x32] = new OpcodeHandler(AND_E0M1X0_32);
			_opcodeTable[0, 1, 0, 0x33] = new OpcodeHandler(AND_E0M1X0_33);
			_opcodeTable[0, 1, 0, 0x34] = new OpcodeHandler(BIT_E0M1X0_34);
			_opcodeTable[0, 1, 0, 0x35] = new OpcodeHandler(AND_E0M1X0_35);
			_opcodeTable[0, 1, 0, 0x36] = new OpcodeHandler(ROL_E0M1X0_36);
			_opcodeTable[0, 1, 0, 0x37] = new OpcodeHandler(AND_E0M1X0_37);
			_opcodeTable[0, 1, 0, 0x38] = new OpcodeHandler(SEC_E0M1X0_38);
			_opcodeTable[0, 1, 0, 0x39] = new OpcodeHandler(AND_E0M1X0_39);
			_opcodeTable[0, 1, 0, 0x3A] = new OpcodeHandler(DEC_E0M1X0_3A);
			_opcodeTable[0, 1, 0, 0x3B] = new OpcodeHandler(TSC_E0M1X0_3B);
			_opcodeTable[0, 1, 0, 0x3C] = new OpcodeHandler(BIT_E0M1X0_3C);
			_opcodeTable[0, 1, 0, 0x3D] = new OpcodeHandler(AND_E0M1X0_3D);
			_opcodeTable[0, 1, 0, 0x3E] = new OpcodeHandler(ROL_E0M1X0_3E);
			_opcodeTable[0, 1, 0, 0x3F] = new OpcodeHandler(AND_E0M1X0_3F);
			_opcodeTable[0, 1, 0, 0x40] = new OpcodeHandler(RTI_E0M1X0_40);
			_opcodeTable[0, 1, 0, 0x41] = new OpcodeHandler(EOR_E0M1X0_41);
			_opcodeTable[0, 1, 0, 0x42] = new OpcodeHandler(WDM_E0M1X0_42);
			_opcodeTable[0, 1, 0, 0x43] = new OpcodeHandler(EOR_E0M1X0_43);
			_opcodeTable[0, 1, 0, 0x44] = new OpcodeHandler(MVP_E0M1X0_44);
			_opcodeTable[0, 1, 0, 0x45] = new OpcodeHandler(EOR_E0M1X0_45);
			_opcodeTable[0, 1, 0, 0x46] = new OpcodeHandler(LSR_E0M1X0_46);
			_opcodeTable[0, 1, 0, 0x47] = new OpcodeHandler(EOR_E0M1X0_47);
			_opcodeTable[0, 1, 0, 0x48] = new OpcodeHandler(PHA_E0M1X0_48);
			_opcodeTable[0, 1, 0, 0x49] = new OpcodeHandler(EOR_E0M1X0_49);
			_opcodeTable[0, 1, 0, 0x4A] = new OpcodeHandler(LSR_E0M1X0_4A);
			_opcodeTable[0, 1, 0, 0x4B] = new OpcodeHandler(PHK_E0M1X0_4B);
			_opcodeTable[0, 1, 0, 0x4C] = new OpcodeHandler(JMP_E0M1X0_4C);
			_opcodeTable[0, 1, 0, 0x4D] = new OpcodeHandler(EOR_E0M1X0_4D);
			_opcodeTable[0, 1, 0, 0x4E] = new OpcodeHandler(LSR_E0M1X0_4E);
			_opcodeTable[0, 1, 0, 0x4F] = new OpcodeHandler(EOR_E0M1X0_4F);
			_opcodeTable[0, 1, 0, 0x50] = new OpcodeHandler(BVC_E0M1X0_50);
			_opcodeTable[0, 1, 0, 0x51] = new OpcodeHandler(EOR_E0M1X0_51);
			_opcodeTable[0, 1, 0, 0x52] = new OpcodeHandler(EOR_E0M1X0_52);
			_opcodeTable[0, 1, 0, 0x53] = new OpcodeHandler(EOR_E0M1X0_53);
			_opcodeTable[0, 1, 0, 0x54] = new OpcodeHandler(MVN_E0M1X0_54);
			_opcodeTable[0, 1, 0, 0x55] = new OpcodeHandler(EOR_E0M1X0_55);
			_opcodeTable[0, 1, 0, 0x56] = new OpcodeHandler(LSR_E0M1X0_56);
			_opcodeTable[0, 1, 0, 0x57] = new OpcodeHandler(EOR_E0M1X0_57);
			_opcodeTable[0, 1, 0, 0x58] = new OpcodeHandler(CLI_E0M1X0_58);
			_opcodeTable[0, 1, 0, 0x59] = new OpcodeHandler(EOR_E0M1X0_59);
			_opcodeTable[0, 1, 0, 0x5A] = new OpcodeHandler(PHY_E0M1X0_5A);
			_opcodeTable[0, 1, 0, 0x5B] = new OpcodeHandler(TCD_E0M1X0_5B);
			_opcodeTable[0, 1, 0, 0x5C] = new OpcodeHandler(JMP_E0M1X0_5C);
			_opcodeTable[0, 1, 0, 0x5D] = new OpcodeHandler(EOR_E0M1X0_5D);
			_opcodeTable[0, 1, 0, 0x5E] = new OpcodeHandler(LSR_E0M1X0_5E);
			_opcodeTable[0, 1, 0, 0x5F] = new OpcodeHandler(EOR_E0M1X0_5F);
			_opcodeTable[0, 1, 0, 0x60] = new OpcodeHandler(RTS_E0M1X0_60);
			_opcodeTable[0, 1, 0, 0x61] = new OpcodeHandler(ADC_E0M1X0_61);
			_opcodeTable[0, 1, 0, 0x62] = new OpcodeHandler(PER_E0M1X0_62);
			_opcodeTable[0, 1, 0, 0x63] = new OpcodeHandler(ADC_E0M1X0_63);
			_opcodeTable[0, 1, 0, 0x64] = new OpcodeHandler(STZ_E0M1X0_64);
			_opcodeTable[0, 1, 0, 0x65] = new OpcodeHandler(ADC_E0M1X0_65);
			_opcodeTable[0, 1, 0, 0x66] = new OpcodeHandler(ROR_E0M1X0_66);
			_opcodeTable[0, 1, 0, 0x67] = new OpcodeHandler(ADC_E0M1X0_67);
			_opcodeTable[0, 1, 0, 0x68] = new OpcodeHandler(PLA_E0M1X0_68);
			_opcodeTable[0, 1, 0, 0x69] = new OpcodeHandler(ADC_E0M1X0_69);
			_opcodeTable[0, 1, 0, 0x6A] = new OpcodeHandler(ROR_E0M1X0_6A);
			_opcodeTable[0, 1, 0, 0x6B] = new OpcodeHandler(RTL_E0M1X0_6B);
			_opcodeTable[0, 1, 0, 0x6C] = new OpcodeHandler(JMP_E0M1X0_6C);
			_opcodeTable[0, 1, 0, 0x6D] = new OpcodeHandler(ADC_E0M1X0_6D);
			_opcodeTable[0, 1, 0, 0x6E] = new OpcodeHandler(ROR_E0M1X0_6E);
			_opcodeTable[0, 1, 0, 0x6F] = new OpcodeHandler(ADC_E0M1X0_6F);
			_opcodeTable[0, 1, 0, 0x70] = new OpcodeHandler(BVS_E0M1X0_70);
			_opcodeTable[0, 1, 0, 0x71] = new OpcodeHandler(ADC_E0M1X0_71);
			_opcodeTable[0, 1, 0, 0x72] = new OpcodeHandler(ADC_E0M1X0_72);
			_opcodeTable[0, 1, 0, 0x73] = new OpcodeHandler(ADC_E0M1X0_73);
			_opcodeTable[0, 1, 0, 0x74] = new OpcodeHandler(STZ_E0M1X0_74);
			_opcodeTable[0, 1, 0, 0x75] = new OpcodeHandler(ADC_E0M1X0_75);
			_opcodeTable[0, 1, 0, 0x76] = new OpcodeHandler(ROR_E0M1X0_76);
			_opcodeTable[0, 1, 0, 0x77] = new OpcodeHandler(ADC_E0M1X0_77);
			_opcodeTable[0, 1, 0, 0x78] = new OpcodeHandler(SEI_E0M1X0_78);
			_opcodeTable[0, 1, 0, 0x79] = new OpcodeHandler(ADC_E0M1X0_79);
			_opcodeTable[0, 1, 0, 0x7A] = new OpcodeHandler(PLY_E0M1X0_7A);
			_opcodeTable[0, 1, 0, 0x7B] = new OpcodeHandler(TDC_E0M1X0_7B);
			_opcodeTable[0, 1, 0, 0x7C] = new OpcodeHandler(JMP_E0M1X0_7C);
			_opcodeTable[0, 1, 0, 0x7D] = new OpcodeHandler(ADC_E0M1X0_7D);
			_opcodeTable[0, 1, 0, 0x7E] = new OpcodeHandler(ROR_E0M1X0_7E);
			_opcodeTable[0, 1, 0, 0x7F] = new OpcodeHandler(ADC_E0M1X0_7F);
			_opcodeTable[0, 1, 0, 0x80] = new OpcodeHandler(BRA_E0M1X0_80);
			_opcodeTable[0, 1, 0, 0x81] = new OpcodeHandler(STA_E0M1X0_81);
			_opcodeTable[0, 1, 0, 0x82] = new OpcodeHandler(BRL_E0M1X0_82);
			_opcodeTable[0, 1, 0, 0x83] = new OpcodeHandler(STA_E0M1X0_83);
			_opcodeTable[0, 1, 0, 0x84] = new OpcodeHandler(STY_E0M1X0_84);
			_opcodeTable[0, 1, 0, 0x85] = new OpcodeHandler(STA_E0M1X0_85);
			_opcodeTable[0, 1, 0, 0x86] = new OpcodeHandler(STX_E0M1X0_86);
			_opcodeTable[0, 1, 0, 0x87] = new OpcodeHandler(STA_E0M1X0_87);
			_opcodeTable[0, 1, 0, 0x88] = new OpcodeHandler(DEY_E0M1X0_88);
			_opcodeTable[0, 1, 0, 0x89] = new OpcodeHandler(BIT_E0M1X0_89);
			_opcodeTable[0, 1, 0, 0x8A] = new OpcodeHandler(TXA_E0M1X0_8A);
			_opcodeTable[0, 1, 0, 0x8B] = new OpcodeHandler(PHB_E0M1X0_8B);
			_opcodeTable[0, 1, 0, 0x8C] = new OpcodeHandler(STY_E0M1X0_8C);
			_opcodeTable[0, 1, 0, 0x8D] = new OpcodeHandler(STA_E0M1X0_8D);
			_opcodeTable[0, 1, 0, 0x8E] = new OpcodeHandler(STX_E0M1X0_8E);
			_opcodeTable[0, 1, 0, 0x8F] = new OpcodeHandler(STA_E0M1X0_8F);
			_opcodeTable[0, 1, 0, 0x90] = new OpcodeHandler(BCC_E0M1X0_90);
			_opcodeTable[0, 1, 0, 0x91] = new OpcodeHandler(STA_E0M1X0_91);
			_opcodeTable[0, 1, 0, 0x92] = new OpcodeHandler(STA_E0M1X0_92);
			_opcodeTable[0, 1, 0, 0x93] = new OpcodeHandler(STA_E0M1X0_93);
			_opcodeTable[0, 1, 0, 0x94] = new OpcodeHandler(STY_E0M1X0_94);
			_opcodeTable[0, 1, 0, 0x95] = new OpcodeHandler(STA_E0M1X0_95);
			_opcodeTable[0, 1, 0, 0x96] = new OpcodeHandler(STX_E0M1X0_96);
			_opcodeTable[0, 1, 0, 0x97] = new OpcodeHandler(STA_E0M1X0_97);
			_opcodeTable[0, 1, 0, 0x98] = new OpcodeHandler(TYA_E0M1X0_98);
			_opcodeTable[0, 1, 0, 0x99] = new OpcodeHandler(STA_E0M1X0_99);
			_opcodeTable[0, 1, 0, 0x9A] = new OpcodeHandler(TXS_E0M1X0_9A);
			_opcodeTable[0, 1, 0, 0x9B] = new OpcodeHandler(TXY_E0M1X0_9B);
			_opcodeTable[0, 1, 0, 0x9C] = new OpcodeHandler(STZ_E0M1X0_9C);
			_opcodeTable[0, 1, 0, 0x9D] = new OpcodeHandler(STA_E0M1X0_9D);
			_opcodeTable[0, 1, 0, 0x9E] = new OpcodeHandler(STZ_E0M1X0_9E);
			_opcodeTable[0, 1, 0, 0x9F] = new OpcodeHandler(STA_E0M1X0_9F);
			_opcodeTable[0, 1, 0, 0xA0] = new OpcodeHandler(LDY_E0M1X0_A0);
			_opcodeTable[0, 1, 0, 0xA1] = new OpcodeHandler(LDA_E0M1X0_A1);
			_opcodeTable[0, 1, 0, 0xA2] = new OpcodeHandler(LDX_E0M1X0_A2);
			_opcodeTable[0, 1, 0, 0xA3] = new OpcodeHandler(LDA_E0M1X0_A3);
			_opcodeTable[0, 1, 0, 0xA4] = new OpcodeHandler(LDY_E0M1X0_A4);
			_opcodeTable[0, 1, 0, 0xA5] = new OpcodeHandler(LDA_E0M1X0_A5);
			_opcodeTable[0, 1, 0, 0xA6] = new OpcodeHandler(LDX_E0M1X0_A6);
			_opcodeTable[0, 1, 0, 0xA7] = new OpcodeHandler(LDA_E0M1X0_A7);
			_opcodeTable[0, 1, 0, 0xA8] = new OpcodeHandler(TAY_E0M1X0_A8);
			_opcodeTable[0, 1, 0, 0xA9] = new OpcodeHandler(LDA_E0M1X0_A9);
			_opcodeTable[0, 1, 0, 0xAA] = new OpcodeHandler(TAX_E0M1X0_AA);
			_opcodeTable[0, 1, 0, 0xAB] = new OpcodeHandler(PLB_E0M1X0_AB);
			_opcodeTable[0, 1, 0, 0xAC] = new OpcodeHandler(LDY_E0M1X0_AC);
			_opcodeTable[0, 1, 0, 0xAD] = new OpcodeHandler(LDA_E0M1X0_AD);
			_opcodeTable[0, 1, 0, 0xAE] = new OpcodeHandler(LDX_E0M1X0_AE);
			_opcodeTable[0, 1, 0, 0xAF] = new OpcodeHandler(LDA_E0M1X0_AF);
			_opcodeTable[0, 1, 0, 0xB0] = new OpcodeHandler(BCS_E0M1X0_B0);
			_opcodeTable[0, 1, 0, 0xB1] = new OpcodeHandler(LDA_E0M1X0_B1);
			_opcodeTable[0, 1, 0, 0xB2] = new OpcodeHandler(LDA_E0M1X0_B2);
			_opcodeTable[0, 1, 0, 0xB3] = new OpcodeHandler(LDA_E0M1X0_B3);
			_opcodeTable[0, 1, 0, 0xB4] = new OpcodeHandler(LDY_E0M1X0_B4);
			_opcodeTable[0, 1, 0, 0xB5] = new OpcodeHandler(LDA_E0M1X0_B5);
			_opcodeTable[0, 1, 0, 0xB6] = new OpcodeHandler(LDX_E0M1X0_B6);
			_opcodeTable[0, 1, 0, 0xB7] = new OpcodeHandler(LDA_E0M1X0_B7);
			_opcodeTable[0, 1, 0, 0xB8] = new OpcodeHandler(CLV_E0M1X0_B8);
			_opcodeTable[0, 1, 0, 0xB9] = new OpcodeHandler(LDA_E0M1X0_B9);
			_opcodeTable[0, 1, 0, 0xBA] = new OpcodeHandler(TSX_E0M1X0_BA);
			_opcodeTable[0, 1, 0, 0xBB] = new OpcodeHandler(TYX_E0M1X0_BB);
			_opcodeTable[0, 1, 0, 0xBC] = new OpcodeHandler(LDY_E0M1X0_BC);
			_opcodeTable[0, 1, 0, 0xBD] = new OpcodeHandler(LDA_E0M1X0_BD);
			_opcodeTable[0, 1, 0, 0xBE] = new OpcodeHandler(LDX_E0M1X0_BE);
			_opcodeTable[0, 1, 0, 0xBF] = new OpcodeHandler(LDA_E0M1X0_BF);
			_opcodeTable[0, 1, 0, 0xC0] = new OpcodeHandler(CPY_E0M1X0_C0);
			_opcodeTable[0, 1, 0, 0xC1] = new OpcodeHandler(CMP_E0M1X0_C1);
			_opcodeTable[0, 1, 0, 0xC2] = new OpcodeHandler(REP_E0M1X0_C2);
			_opcodeTable[0, 1, 0, 0xC3] = new OpcodeHandler(CMP_E0M1X0_C3);
			_opcodeTable[0, 1, 0, 0xC4] = new OpcodeHandler(CPY_E0M1X0_C4);
			_opcodeTable[0, 1, 0, 0xC5] = new OpcodeHandler(CMP_E0M1X0_C5);
			_opcodeTable[0, 1, 0, 0xC6] = new OpcodeHandler(DEC_E0M1X0_C6);
			_opcodeTable[0, 1, 0, 0xC7] = new OpcodeHandler(CMP_E0M1X0_C7);
			_opcodeTable[0, 1, 0, 0xC8] = new OpcodeHandler(INY_E0M1X0_C8);
			_opcodeTable[0, 1, 0, 0xC9] = new OpcodeHandler(CMP_E0M1X0_C9);
			_opcodeTable[0, 1, 0, 0xCA] = new OpcodeHandler(DEX_E0M1X0_CA);
			_opcodeTable[0, 1, 0, 0xCB] = new OpcodeHandler(WAI_E0M1X0_CB);
			_opcodeTable[0, 1, 0, 0xCC] = new OpcodeHandler(CPY_E0M1X0_CC);
			_opcodeTable[0, 1, 0, 0xCD] = new OpcodeHandler(CMP_E0M1X0_CD);
			_opcodeTable[0, 1, 0, 0xCE] = new OpcodeHandler(DEC_E0M1X0_CE);
			_opcodeTable[0, 1, 0, 0xCF] = new OpcodeHandler(CMP_E0M1X0_CF);
			_opcodeTable[0, 1, 0, 0xD0] = new OpcodeHandler(BNE_E0M1X0_D0);
			_opcodeTable[0, 1, 0, 0xD1] = new OpcodeHandler(CMP_E0M1X0_D1);
			_opcodeTable[0, 1, 0, 0xD2] = new OpcodeHandler(CMP_E0M1X0_D2);
			_opcodeTable[0, 1, 0, 0xD3] = new OpcodeHandler(CMP_E0M1X0_D3);
			_opcodeTable[0, 1, 0, 0xD4] = new OpcodeHandler(PEI_E0M1X0_D4);
			_opcodeTable[0, 1, 0, 0xD5] = new OpcodeHandler(CMP_E0M1X0_D5);
			_opcodeTable[0, 1, 0, 0xD6] = new OpcodeHandler(DEC_E0M1X0_D6);
			_opcodeTable[0, 1, 0, 0xD7] = new OpcodeHandler(CMP_E0M1X0_D7);
			_opcodeTable[0, 1, 0, 0xD8] = new OpcodeHandler(CLD_E0M1X0_D8);
			_opcodeTable[0, 1, 0, 0xD9] = new OpcodeHandler(CMP_E0M1X0_D9);
			_opcodeTable[0, 1, 0, 0xDA] = new OpcodeHandler(PHX_E0M1X0_DA);
			_opcodeTable[0, 1, 0, 0xDB] = new OpcodeHandler(STP_E0M1X0_DB);
			_opcodeTable[0, 1, 0, 0xDC] = new OpcodeHandler(JMP_E0M1X0_DC);
			_opcodeTable[0, 1, 0, 0xDD] = new OpcodeHandler(CMP_E0M1X0_DD);
			_opcodeTable[0, 1, 0, 0xDE] = new OpcodeHandler(DEC_E0M1X0_DE);
			_opcodeTable[0, 1, 0, 0xDF] = new OpcodeHandler(CMP_E0M1X0_DF);
			_opcodeTable[0, 1, 0, 0xE0] = new OpcodeHandler(CPX_E0M1X0_E0);
			_opcodeTable[0, 1, 0, 0xE1] = new OpcodeHandler(SBC_E0M1X0_E1);
			_opcodeTable[0, 1, 0, 0xE2] = new OpcodeHandler(SEP_E0M1X0_E2);
			_opcodeTable[0, 1, 0, 0xE3] = new OpcodeHandler(SBC_E0M1X0_E3);
			_opcodeTable[0, 1, 0, 0xE4] = new OpcodeHandler(CPX_E0M1X0_E4);
			_opcodeTable[0, 1, 0, 0xE5] = new OpcodeHandler(SBC_E0M1X0_E5);
			_opcodeTable[0, 1, 0, 0xE6] = new OpcodeHandler(INC_E0M1X0_E6);
			_opcodeTable[0, 1, 0, 0xE7] = new OpcodeHandler(SBC_E0M1X0_E7);
			_opcodeTable[0, 1, 0, 0xE8] = new OpcodeHandler(INX_E0M1X0_E8);
			_opcodeTable[0, 1, 0, 0xE9] = new OpcodeHandler(SBC_E0M1X0_E9);
			_opcodeTable[0, 1, 0, 0xEA] = new OpcodeHandler(NOP_E0M1X0_EA);
			_opcodeTable[0, 1, 0, 0xEB] = new OpcodeHandler(XBA_E0M1X0_EB);
			_opcodeTable[0, 1, 0, 0xEC] = new OpcodeHandler(CPX_E0M1X0_EC);
			_opcodeTable[0, 1, 0, 0xED] = new OpcodeHandler(SBC_E0M1X0_ED);
			_opcodeTable[0, 1, 0, 0xEE] = new OpcodeHandler(INC_E0M1X0_EE);
			_opcodeTable[0, 1, 0, 0xEF] = new OpcodeHandler(SBC_E0M1X0_EF);
			_opcodeTable[0, 1, 0, 0xF0] = new OpcodeHandler(BEQ_E0M1X0_F0);
			_opcodeTable[0, 1, 0, 0xF1] = new OpcodeHandler(SBC_E0M1X0_F1);
			_opcodeTable[0, 1, 0, 0xF2] = new OpcodeHandler(SBC_E0M1X0_F2);
			_opcodeTable[0, 1, 0, 0xF3] = new OpcodeHandler(SBC_E0M1X0_F3);
			_opcodeTable[0, 1, 0, 0xF4] = new OpcodeHandler(PEA_E0M1X0_F4);
			_opcodeTable[0, 1, 0, 0xF5] = new OpcodeHandler(SBC_E0M1X0_F5);
			_opcodeTable[0, 1, 0, 0xF6] = new OpcodeHandler(INC_E0M1X0_F6);
			_opcodeTable[0, 1, 0, 0xF7] = new OpcodeHandler(SBC_E0M1X0_F7);
			_opcodeTable[0, 1, 0, 0xF8] = new OpcodeHandler(SED_E0M1X0_F8);
			_opcodeTable[0, 1, 0, 0xF9] = new OpcodeHandler(SBC_E0M1X0_F9);
			_opcodeTable[0, 1, 0, 0xFA] = new OpcodeHandler(PLX_E0M1X0_FA);
			_opcodeTable[0, 1, 0, 0xFB] = new OpcodeHandler(XCE_E0M1X0_FB);
			_opcodeTable[0, 1, 0, 0xFC] = new OpcodeHandler(JSR_E0M1X0_FC);
			_opcodeTable[0, 1, 0, 0xFD] = new OpcodeHandler(SBC_E0M1X0_FD);
			_opcodeTable[0, 1, 0, 0xFE] = new OpcodeHandler(INC_E0M1X0_FE);
			_opcodeTable[0, 1, 0, 0xFF] = new OpcodeHandler(SBC_E0M1X0_FF);
			#endregion

			#region Opcodes E0M0X0
			_opcodeTable[0, 0, 0, 0x00] = new OpcodeHandler(BRK_E0M0X0_00);
			_opcodeTable[0, 0, 0, 0x01] = new OpcodeHandler(ORA_E0M0X0_01);
			_opcodeTable[0, 0, 0, 0x02] = new OpcodeHandler(COP_E0M0X0_02);
			_opcodeTable[0, 0, 0, 0x03] = new OpcodeHandler(ORA_E0M0X0_03);
			_opcodeTable[0, 0, 0, 0x04] = new OpcodeHandler(TSB_E0M0X0_04);
			_opcodeTable[0, 0, 0, 0x05] = new OpcodeHandler(ORA_E0M0X0_05);
			_opcodeTable[0, 0, 0, 0x06] = new OpcodeHandler(ASL_E0M0X0_06);
			_opcodeTable[0, 0, 0, 0x07] = new OpcodeHandler(ORA_E0M0X0_07);
			_opcodeTable[0, 0, 0, 0x08] = new OpcodeHandler(PHP_E0M0X0_08);
			_opcodeTable[0, 0, 0, 0x09] = new OpcodeHandler(ORA_E0M0X0_09);
			_opcodeTable[0, 0, 0, 0x0A] = new OpcodeHandler(ASL_E0M0X0_0A);
			_opcodeTable[0, 0, 0, 0x0B] = new OpcodeHandler(PHD_E0M0X0_0B);
			_opcodeTable[0, 0, 0, 0x0C] = new OpcodeHandler(TSB_E0M0X0_0C);
			_opcodeTable[0, 0, 0, 0x0D] = new OpcodeHandler(ORA_E0M0X0_0D);
			_opcodeTable[0, 0, 0, 0x0E] = new OpcodeHandler(ASL_E0M0X0_0E);
			_opcodeTable[0, 0, 0, 0x0F] = new OpcodeHandler(ORA_E0M0X0_0F);
			_opcodeTable[0, 0, 0, 0x10] = new OpcodeHandler(BPL_E0M0X0_10);
			_opcodeTable[0, 0, 0, 0x11] = new OpcodeHandler(ORA_E0M0X0_11);
			_opcodeTable[0, 0, 0, 0x12] = new OpcodeHandler(ORA_E0M0X0_12);
			_opcodeTable[0, 0, 0, 0x13] = new OpcodeHandler(ORA_E0M0X0_13);
			_opcodeTable[0, 0, 0, 0x14] = new OpcodeHandler(TRB_E0M0X0_14);
			_opcodeTable[0, 0, 0, 0x15] = new OpcodeHandler(ORA_E0M0X0_15);
			_opcodeTable[0, 0, 0, 0x16] = new OpcodeHandler(ASL_E0M0X0_16);
			_opcodeTable[0, 0, 0, 0x17] = new OpcodeHandler(ORA_E0M0X0_17);
			_opcodeTable[0, 0, 0, 0x18] = new OpcodeHandler(CLC_E0M0X0_18);
			_opcodeTable[0, 0, 0, 0x19] = new OpcodeHandler(ORA_E0M0X0_19);
			_opcodeTable[0, 0, 0, 0x1A] = new OpcodeHandler(INC_E0M0X0_1A);
			_opcodeTable[0, 0, 0, 0x1B] = new OpcodeHandler(TCS_E0M0X0_1B);
			_opcodeTable[0, 0, 0, 0x1C] = new OpcodeHandler(TRB_E0M0X0_1C);
			_opcodeTable[0, 0, 0, 0x1D] = new OpcodeHandler(ORA_E0M0X0_1D);
			_opcodeTable[0, 0, 0, 0x1E] = new OpcodeHandler(ASL_E0M0X0_1E);
			_opcodeTable[0, 0, 0, 0x1F] = new OpcodeHandler(ORA_E0M0X0_1F);
			_opcodeTable[0, 0, 0, 0x20] = new OpcodeHandler(JSR_E0M0X0_20);
			_opcodeTable[0, 0, 0, 0x21] = new OpcodeHandler(AND_E0M0X0_21);
			_opcodeTable[0, 0, 0, 0x22] = new OpcodeHandler(JSR_E0M0X0_22);
			_opcodeTable[0, 0, 0, 0x23] = new OpcodeHandler(AND_E0M0X0_23);
			_opcodeTable[0, 0, 0, 0x24] = new OpcodeHandler(BIT_E0M0X0_24);
			_opcodeTable[0, 0, 0, 0x25] = new OpcodeHandler(AND_E0M0X0_25);
			_opcodeTable[0, 0, 0, 0x26] = new OpcodeHandler(ROL_E0M0X0_26);
			_opcodeTable[0, 0, 0, 0x27] = new OpcodeHandler(AND_E0M0X0_27);
			_opcodeTable[0, 0, 0, 0x28] = new OpcodeHandler(PLP_E0M0X0_28);
			_opcodeTable[0, 0, 0, 0x29] = new OpcodeHandler(AND_E0M0X0_29);
			_opcodeTable[0, 0, 0, 0x2A] = new OpcodeHandler(ROL_E0M0X0_2A);
			_opcodeTable[0, 0, 0, 0x2B] = new OpcodeHandler(PLD_E0M0X0_2B);
			_opcodeTable[0, 0, 0, 0x2C] = new OpcodeHandler(BIT_E0M0X0_2C);
			_opcodeTable[0, 0, 0, 0x2D] = new OpcodeHandler(AND_E0M0X0_2D);
			_opcodeTable[0, 0, 0, 0x2E] = new OpcodeHandler(ROL_E0M0X0_2E);
			_opcodeTable[0, 0, 0, 0x2F] = new OpcodeHandler(AND_E0M0X0_2F);
			_opcodeTable[0, 0, 0, 0x30] = new OpcodeHandler(BMI_E0M0X0_30);
			_opcodeTable[0, 0, 0, 0x31] = new OpcodeHandler(AND_E0M0X0_31);
			_opcodeTable[0, 0, 0, 0x32] = new OpcodeHandler(AND_E0M0X0_32);
			_opcodeTable[0, 0, 0, 0x33] = new OpcodeHandler(AND_E0M0X0_33);
			_opcodeTable[0, 0, 0, 0x34] = new OpcodeHandler(BIT_E0M0X0_34);
			_opcodeTable[0, 0, 0, 0x35] = new OpcodeHandler(AND_E0M0X0_35);
			_opcodeTable[0, 0, 0, 0x36] = new OpcodeHandler(ROL_E0M0X0_36);
			_opcodeTable[0, 0, 0, 0x37] = new OpcodeHandler(AND_E0M0X0_37);
			_opcodeTable[0, 0, 0, 0x38] = new OpcodeHandler(SEC_E0M0X0_38);
			_opcodeTable[0, 0, 0, 0x39] = new OpcodeHandler(AND_E0M0X0_39);
			_opcodeTable[0, 0, 0, 0x3A] = new OpcodeHandler(DEC_E0M0X0_3A);
			_opcodeTable[0, 0, 0, 0x3B] = new OpcodeHandler(TSC_E0M0X0_3B);
			_opcodeTable[0, 0, 0, 0x3C] = new OpcodeHandler(BIT_E0M0X0_3C);
			_opcodeTable[0, 0, 0, 0x3D] = new OpcodeHandler(AND_E0M0X0_3D);
			_opcodeTable[0, 0, 0, 0x3E] = new OpcodeHandler(ROL_E0M0X0_3E);
			_opcodeTable[0, 0, 0, 0x3F] = new OpcodeHandler(AND_E0M0X0_3F);
			_opcodeTable[0, 0, 0, 0x40] = new OpcodeHandler(RTI_E0M0X0_40);
			_opcodeTable[0, 0, 0, 0x41] = new OpcodeHandler(EOR_E0M0X0_41);
			_opcodeTable[0, 0, 0, 0x42] = new OpcodeHandler(WDM_E0M0X0_42);
			_opcodeTable[0, 0, 0, 0x43] = new OpcodeHandler(EOR_E0M0X0_43);
			_opcodeTable[0, 0, 0, 0x44] = new OpcodeHandler(MVP_E0M0X0_44);
			_opcodeTable[0, 0, 0, 0x45] = new OpcodeHandler(EOR_E0M0X0_45);
			_opcodeTable[0, 0, 0, 0x46] = new OpcodeHandler(LSR_E0M0X0_46);
			_opcodeTable[0, 0, 0, 0x47] = new OpcodeHandler(EOR_E0M0X0_47);
			_opcodeTable[0, 0, 0, 0x48] = new OpcodeHandler(PHA_E0M0X0_48);
			_opcodeTable[0, 0, 0, 0x49] = new OpcodeHandler(EOR_E0M0X0_49);
			_opcodeTable[0, 0, 0, 0x4A] = new OpcodeHandler(LSR_E0M0X0_4A);
			_opcodeTable[0, 0, 0, 0x4B] = new OpcodeHandler(PHK_E0M0X0_4B);
			_opcodeTable[0, 0, 0, 0x4C] = new OpcodeHandler(JMP_E0M0X0_4C);
			_opcodeTable[0, 0, 0, 0x4D] = new OpcodeHandler(EOR_E0M0X0_4D);
			_opcodeTable[0, 0, 0, 0x4E] = new OpcodeHandler(LSR_E0M0X0_4E);
			_opcodeTable[0, 0, 0, 0x4F] = new OpcodeHandler(EOR_E0M0X0_4F);
			_opcodeTable[0, 0, 0, 0x50] = new OpcodeHandler(BVC_E0M0X0_50);
			_opcodeTable[0, 0, 0, 0x51] = new OpcodeHandler(EOR_E0M0X0_51);
			_opcodeTable[0, 0, 0, 0x52] = new OpcodeHandler(EOR_E0M0X0_52);
			_opcodeTable[0, 0, 0, 0x53] = new OpcodeHandler(EOR_E0M0X0_53);
			_opcodeTable[0, 0, 0, 0x54] = new OpcodeHandler(MVN_E0M0X0_54);
			_opcodeTable[0, 0, 0, 0x55] = new OpcodeHandler(EOR_E0M0X0_55);
			_opcodeTable[0, 0, 0, 0x56] = new OpcodeHandler(LSR_E0M0X0_56);
			_opcodeTable[0, 0, 0, 0x57] = new OpcodeHandler(EOR_E0M0X0_57);
			_opcodeTable[0, 0, 0, 0x58] = new OpcodeHandler(CLI_E0M0X0_58);
			_opcodeTable[0, 0, 0, 0x59] = new OpcodeHandler(EOR_E0M0X0_59);
			_opcodeTable[0, 0, 0, 0x5A] = new OpcodeHandler(PHY_E0M0X0_5A);
			_opcodeTable[0, 0, 0, 0x5B] = new OpcodeHandler(TCD_E0M0X0_5B);
			_opcodeTable[0, 0, 0, 0x5C] = new OpcodeHandler(JMP_E0M0X0_5C);
			_opcodeTable[0, 0, 0, 0x5D] = new OpcodeHandler(EOR_E0M0X0_5D);
			_opcodeTable[0, 0, 0, 0x5E] = new OpcodeHandler(LSR_E0M0X0_5E);
			_opcodeTable[0, 0, 0, 0x5F] = new OpcodeHandler(EOR_E0M0X0_5F);
			_opcodeTable[0, 0, 0, 0x60] = new OpcodeHandler(RTS_E0M0X0_60);
			_opcodeTable[0, 0, 0, 0x61] = new OpcodeHandler(ADC_E0M0X0_61);
			_opcodeTable[0, 0, 0, 0x62] = new OpcodeHandler(PER_E0M0X0_62);
			_opcodeTable[0, 0, 0, 0x63] = new OpcodeHandler(ADC_E0M0X0_63);
			_opcodeTable[0, 0, 0, 0x64] = new OpcodeHandler(STZ_E0M0X0_64);
			_opcodeTable[0, 0, 0, 0x65] = new OpcodeHandler(ADC_E0M0X0_65);
			_opcodeTable[0, 0, 0, 0x66] = new OpcodeHandler(ROR_E0M0X0_66);
			_opcodeTable[0, 0, 0, 0x67] = new OpcodeHandler(ADC_E0M0X0_67);
			_opcodeTable[0, 0, 0, 0x68] = new OpcodeHandler(PLA_E0M0X0_68);
			_opcodeTable[0, 0, 0, 0x69] = new OpcodeHandler(ADC_E0M0X0_69);
			_opcodeTable[0, 0, 0, 0x6A] = new OpcodeHandler(ROR_E0M0X0_6A);
			_opcodeTable[0, 0, 0, 0x6B] = new OpcodeHandler(RTL_E0M0X0_6B);
			_opcodeTable[0, 0, 0, 0x6C] = new OpcodeHandler(JMP_E0M0X0_6C);
			_opcodeTable[0, 0, 0, 0x6D] = new OpcodeHandler(ADC_E0M0X0_6D);
			_opcodeTable[0, 0, 0, 0x6E] = new OpcodeHandler(ROR_E0M0X0_6E);
			_opcodeTable[0, 0, 0, 0x6F] = new OpcodeHandler(ADC_E0M0X0_6F);
			_opcodeTable[0, 0, 0, 0x70] = new OpcodeHandler(BVS_E0M0X0_70);
			_opcodeTable[0, 0, 0, 0x71] = new OpcodeHandler(ADC_E0M0X0_71);
			_opcodeTable[0, 0, 0, 0x72] = new OpcodeHandler(ADC_E0M0X0_72);
			_opcodeTable[0, 0, 0, 0x73] = new OpcodeHandler(ADC_E0M0X0_73);
			_opcodeTable[0, 0, 0, 0x74] = new OpcodeHandler(STZ_E0M0X0_74);
			_opcodeTable[0, 0, 0, 0x75] = new OpcodeHandler(ADC_E0M0X0_75);
			_opcodeTable[0, 0, 0, 0x76] = new OpcodeHandler(ROR_E0M0X0_76);
			_opcodeTable[0, 0, 0, 0x77] = new OpcodeHandler(ADC_E0M0X0_77);
			_opcodeTable[0, 0, 0, 0x78] = new OpcodeHandler(SEI_E0M0X0_78);
			_opcodeTable[0, 0, 0, 0x79] = new OpcodeHandler(ADC_E0M0X0_79);
			_opcodeTable[0, 0, 0, 0x7A] = new OpcodeHandler(PLY_E0M0X0_7A);
			_opcodeTable[0, 0, 0, 0x7B] = new OpcodeHandler(TDC_E0M0X0_7B);
			_opcodeTable[0, 0, 0, 0x7C] = new OpcodeHandler(JMP_E0M0X0_7C);
			_opcodeTable[0, 0, 0, 0x7D] = new OpcodeHandler(ADC_E0M0X0_7D);
			_opcodeTable[0, 0, 0, 0x7E] = new OpcodeHandler(ROR_E0M0X0_7E);
			_opcodeTable[0, 0, 0, 0x7F] = new OpcodeHandler(ADC_E0M0X0_7F);
			_opcodeTable[0, 0, 0, 0x80] = new OpcodeHandler(BRA_E0M0X0_80);
			_opcodeTable[0, 0, 0, 0x81] = new OpcodeHandler(STA_E0M0X0_81);
			_opcodeTable[0, 0, 0, 0x82] = new OpcodeHandler(BRL_E0M0X0_82);
			_opcodeTable[0, 0, 0, 0x83] = new OpcodeHandler(STA_E0M0X0_83);
			_opcodeTable[0, 0, 0, 0x84] = new OpcodeHandler(STY_E0M0X0_84);
			_opcodeTable[0, 0, 0, 0x85] = new OpcodeHandler(STA_E0M0X0_85);
			_opcodeTable[0, 0, 0, 0x86] = new OpcodeHandler(STX_E0M0X0_86);
			_opcodeTable[0, 0, 0, 0x87] = new OpcodeHandler(STA_E0M0X0_87);
			_opcodeTable[0, 0, 0, 0x88] = new OpcodeHandler(DEY_E0M0X0_88);
			_opcodeTable[0, 0, 0, 0x89] = new OpcodeHandler(BIT_E0M0X0_89);
			_opcodeTable[0, 0, 0, 0x8A] = new OpcodeHandler(TXA_E0M0X0_8A);
			_opcodeTable[0, 0, 0, 0x8B] = new OpcodeHandler(PHB_E0M0X0_8B);
			_opcodeTable[0, 0, 0, 0x8C] = new OpcodeHandler(STY_E0M0X0_8C);
			_opcodeTable[0, 0, 0, 0x8D] = new OpcodeHandler(STA_E0M0X0_8D);
			_opcodeTable[0, 0, 0, 0x8E] = new OpcodeHandler(STX_E0M0X0_8E);
			_opcodeTable[0, 0, 0, 0x8F] = new OpcodeHandler(STA_E0M0X0_8F);
			_opcodeTable[0, 0, 0, 0x90] = new OpcodeHandler(BCC_E0M0X0_90);
			_opcodeTable[0, 0, 0, 0x91] = new OpcodeHandler(STA_E0M0X0_91);
			_opcodeTable[0, 0, 0, 0x92] = new OpcodeHandler(STA_E0M0X0_92);
			_opcodeTable[0, 0, 0, 0x93] = new OpcodeHandler(STA_E0M0X0_93);
			_opcodeTable[0, 0, 0, 0x94] = new OpcodeHandler(STY_E0M0X0_94);
			_opcodeTable[0, 0, 0, 0x95] = new OpcodeHandler(STA_E0M0X0_95);
			_opcodeTable[0, 0, 0, 0x96] = new OpcodeHandler(STX_E0M0X0_96);
			_opcodeTable[0, 0, 0, 0x97] = new OpcodeHandler(STA_E0M0X0_97);
			_opcodeTable[0, 0, 0, 0x98] = new OpcodeHandler(TYA_E0M0X0_98);
			_opcodeTable[0, 0, 0, 0x99] = new OpcodeHandler(STA_E0M0X0_99);
			_opcodeTable[0, 0, 0, 0x9A] = new OpcodeHandler(TXS_E0M0X0_9A);
			_opcodeTable[0, 0, 0, 0x9B] = new OpcodeHandler(TXY_E0M0X0_9B);
			_opcodeTable[0, 0, 0, 0x9C] = new OpcodeHandler(STZ_E0M0X0_9C);
			_opcodeTable[0, 0, 0, 0x9D] = new OpcodeHandler(STA_E0M0X0_9D);
			_opcodeTable[0, 0, 0, 0x9E] = new OpcodeHandler(STZ_E0M0X0_9E);
			_opcodeTable[0, 0, 0, 0x9F] = new OpcodeHandler(STA_E0M0X0_9F);
			_opcodeTable[0, 0, 0, 0xA0] = new OpcodeHandler(LDY_E0M0X0_A0);
			_opcodeTable[0, 0, 0, 0xA1] = new OpcodeHandler(LDA_E0M0X0_A1);
			_opcodeTable[0, 0, 0, 0xA2] = new OpcodeHandler(LDX_E0M0X0_A2);
			_opcodeTable[0, 0, 0, 0xA3] = new OpcodeHandler(LDA_E0M0X0_A3);
			_opcodeTable[0, 0, 0, 0xA4] = new OpcodeHandler(LDY_E0M0X0_A4);
			_opcodeTable[0, 0, 0, 0xA5] = new OpcodeHandler(LDA_E0M0X0_A5);
			_opcodeTable[0, 0, 0, 0xA6] = new OpcodeHandler(LDX_E0M0X0_A6);
			_opcodeTable[0, 0, 0, 0xA7] = new OpcodeHandler(LDA_E0M0X0_A7);
			_opcodeTable[0, 0, 0, 0xA8] = new OpcodeHandler(TAY_E0M0X0_A8);
			_opcodeTable[0, 0, 0, 0xA9] = new OpcodeHandler(LDA_E0M0X0_A9);
			_opcodeTable[0, 0, 0, 0xAA] = new OpcodeHandler(TAX_E0M0X0_AA);
			_opcodeTable[0, 0, 0, 0xAB] = new OpcodeHandler(PLB_E0M0X0_AB);
			_opcodeTable[0, 0, 0, 0xAC] = new OpcodeHandler(LDY_E0M0X0_AC);
			_opcodeTable[0, 0, 0, 0xAD] = new OpcodeHandler(LDA_E0M0X0_AD);
			_opcodeTable[0, 0, 0, 0xAE] = new OpcodeHandler(LDX_E0M0X0_AE);
			_opcodeTable[0, 0, 0, 0xAF] = new OpcodeHandler(LDA_E0M0X0_AF);
			_opcodeTable[0, 0, 0, 0xB0] = new OpcodeHandler(BCS_E0M0X0_B0);
			_opcodeTable[0, 0, 0, 0xB1] = new OpcodeHandler(LDA_E0M0X0_B1);
			_opcodeTable[0, 0, 0, 0xB2] = new OpcodeHandler(LDA_E0M0X0_B2);
			_opcodeTable[0, 0, 0, 0xB3] = new OpcodeHandler(LDA_E0M0X0_B3);
			_opcodeTable[0, 0, 0, 0xB4] = new OpcodeHandler(LDY_E0M0X0_B4);
			_opcodeTable[0, 0, 0, 0xB5] = new OpcodeHandler(LDA_E0M0X0_B5);
			_opcodeTable[0, 0, 0, 0xB6] = new OpcodeHandler(LDX_E0M0X0_B6);
			_opcodeTable[0, 0, 0, 0xB7] = new OpcodeHandler(LDA_E0M0X0_B7);
			_opcodeTable[0, 0, 0, 0xB8] = new OpcodeHandler(CLV_E0M0X0_B8);
			_opcodeTable[0, 0, 0, 0xB9] = new OpcodeHandler(LDA_E0M0X0_B9);
			_opcodeTable[0, 0, 0, 0xBA] = new OpcodeHandler(TSX_E0M0X0_BA);
			_opcodeTable[0, 0, 0, 0xBB] = new OpcodeHandler(TYX_E0M0X0_BB);
			_opcodeTable[0, 0, 0, 0xBC] = new OpcodeHandler(LDY_E0M0X0_BC);
			_opcodeTable[0, 0, 0, 0xBD] = new OpcodeHandler(LDA_E0M0X0_BD);
			_opcodeTable[0, 0, 0, 0xBE] = new OpcodeHandler(LDX_E0M0X0_BE);
			_opcodeTable[0, 0, 0, 0xBF] = new OpcodeHandler(LDA_E0M0X0_BF);
			_opcodeTable[0, 0, 0, 0xC0] = new OpcodeHandler(CPY_E0M0X0_C0);
			_opcodeTable[0, 0, 0, 0xC1] = new OpcodeHandler(CMP_E0M0X0_C1);
			_opcodeTable[0, 0, 0, 0xC2] = new OpcodeHandler(REP_E0M0X0_C2);
			_opcodeTable[0, 0, 0, 0xC3] = new OpcodeHandler(CMP_E0M0X0_C3);
			_opcodeTable[0, 0, 0, 0xC4] = new OpcodeHandler(CPY_E0M0X0_C4);
			_opcodeTable[0, 0, 0, 0xC5] = new OpcodeHandler(CMP_E0M0X0_C5);
			_opcodeTable[0, 0, 0, 0xC6] = new OpcodeHandler(DEC_E0M0X0_C6);
			_opcodeTable[0, 0, 0, 0xC7] = new OpcodeHandler(CMP_E0M0X0_C7);
			_opcodeTable[0, 0, 0, 0xC8] = new OpcodeHandler(INY_E0M0X0_C8);
			_opcodeTable[0, 0, 0, 0xC9] = new OpcodeHandler(CMP_E0M0X0_C9);
			_opcodeTable[0, 0, 0, 0xCA] = new OpcodeHandler(DEX_E0M0X0_CA);
			_opcodeTable[0, 0, 0, 0xCB] = new OpcodeHandler(WAI_E0M0X0_CB);
			_opcodeTable[0, 0, 0, 0xCC] = new OpcodeHandler(CPY_E0M0X0_CC);
			_opcodeTable[0, 0, 0, 0xCD] = new OpcodeHandler(CMP_E0M0X0_CD);
			_opcodeTable[0, 0, 0, 0xCE] = new OpcodeHandler(DEC_E0M0X0_CE);
			_opcodeTable[0, 0, 0, 0xCF] = new OpcodeHandler(CMP_E0M0X0_CF);
			_opcodeTable[0, 0, 0, 0xD0] = new OpcodeHandler(BNE_E0M0X0_D0);
			_opcodeTable[0, 0, 0, 0xD1] = new OpcodeHandler(CMP_E0M0X0_D1);
			_opcodeTable[0, 0, 0, 0xD2] = new OpcodeHandler(CMP_E0M0X0_D2);
			_opcodeTable[0, 0, 0, 0xD3] = new OpcodeHandler(CMP_E0M0X0_D3);
			_opcodeTable[0, 0, 0, 0xD4] = new OpcodeHandler(PEI_E0M0X0_D4);
			_opcodeTable[0, 0, 0, 0xD5] = new OpcodeHandler(CMP_E0M0X0_D5);
			_opcodeTable[0, 0, 0, 0xD6] = new OpcodeHandler(DEC_E0M0X0_D6);
			_opcodeTable[0, 0, 0, 0xD7] = new OpcodeHandler(CMP_E0M0X0_D7);
			_opcodeTable[0, 0, 0, 0xD8] = new OpcodeHandler(CLD_E0M0X0_D8);
			_opcodeTable[0, 0, 0, 0xD9] = new OpcodeHandler(CMP_E0M0X0_D9);
			_opcodeTable[0, 0, 0, 0xDA] = new OpcodeHandler(PHX_E0M0X0_DA);
			_opcodeTable[0, 0, 0, 0xDB] = new OpcodeHandler(STP_E0M0X0_DB);
			_opcodeTable[0, 0, 0, 0xDC] = new OpcodeHandler(JMP_E0M0X0_DC);
			_opcodeTable[0, 0, 0, 0xDD] = new OpcodeHandler(CMP_E0M0X0_DD);
			_opcodeTable[0, 0, 0, 0xDE] = new OpcodeHandler(DEC_E0M0X0_DE);
			_opcodeTable[0, 0, 0, 0xDF] = new OpcodeHandler(CMP_E0M0X0_DF);
			_opcodeTable[0, 0, 0, 0xE0] = new OpcodeHandler(CPX_E0M0X0_E0);
			_opcodeTable[0, 0, 0, 0xE1] = new OpcodeHandler(SBC_E0M0X0_E1);
			_opcodeTable[0, 0, 0, 0xE2] = new OpcodeHandler(SEP_E0M0X0_E2);
			_opcodeTable[0, 0, 0, 0xE3] = new OpcodeHandler(SBC_E0M0X0_E3);
			_opcodeTable[0, 0, 0, 0xE4] = new OpcodeHandler(CPX_E0M0X0_E4);
			_opcodeTable[0, 0, 0, 0xE5] = new OpcodeHandler(SBC_E0M0X0_E5);
			_opcodeTable[0, 0, 0, 0xE6] = new OpcodeHandler(INC_E0M0X0_E6);
			_opcodeTable[0, 0, 0, 0xE7] = new OpcodeHandler(SBC_E0M0X0_E7);
			_opcodeTable[0, 0, 0, 0xE8] = new OpcodeHandler(INX_E0M0X0_E8);
			_opcodeTable[0, 0, 0, 0xE9] = new OpcodeHandler(SBC_E0M0X0_E9);
			_opcodeTable[0, 0, 0, 0xEA] = new OpcodeHandler(NOP_E0M0X0_EA);
			_opcodeTable[0, 0, 0, 0xEB] = new OpcodeHandler(XBA_E0M0X0_EB);
			_opcodeTable[0, 0, 0, 0xEC] = new OpcodeHandler(CPX_E0M0X0_EC);
			_opcodeTable[0, 0, 0, 0xED] = new OpcodeHandler(SBC_E0M0X0_ED);
			_opcodeTable[0, 0, 0, 0xEE] = new OpcodeHandler(INC_E0M0X0_EE);
			_opcodeTable[0, 0, 0, 0xEF] = new OpcodeHandler(SBC_E0M0X0_EF);
			_opcodeTable[0, 0, 0, 0xF0] = new OpcodeHandler(BEQ_E0M0X0_F0);
			_opcodeTable[0, 0, 0, 0xF1] = new OpcodeHandler(SBC_E0M0X0_F1);
			_opcodeTable[0, 0, 0, 0xF2] = new OpcodeHandler(SBC_E0M0X0_F2);
			_opcodeTable[0, 0, 0, 0xF3] = new OpcodeHandler(SBC_E0M0X0_F3);
			_opcodeTable[0, 0, 0, 0xF4] = new OpcodeHandler(PEA_E0M0X0_F4);
			_opcodeTable[0, 0, 0, 0xF5] = new OpcodeHandler(SBC_E0M0X0_F5);
			_opcodeTable[0, 0, 0, 0xF6] = new OpcodeHandler(INC_E0M0X0_F6);
			_opcodeTable[0, 0, 0, 0xF7] = new OpcodeHandler(SBC_E0M0X0_F7);
			_opcodeTable[0, 0, 0, 0xF8] = new OpcodeHandler(SED_E0M0X0_F8);
			_opcodeTable[0, 0, 0, 0xF9] = new OpcodeHandler(SBC_E0M0X0_F9);
			_opcodeTable[0, 0, 0, 0xFA] = new OpcodeHandler(PLX_E0M0X0_FA);
			_opcodeTable[0, 0, 0, 0xFB] = new OpcodeHandler(XCE_E0M0X0_FB);
			_opcodeTable[0, 0, 0, 0xFC] = new OpcodeHandler(JSR_E0M0X0_FC);
			_opcodeTable[0, 0, 0, 0xFD] = new OpcodeHandler(SBC_E0M0X0_FD);
			_opcodeTable[0, 0, 0, 0xFE] = new OpcodeHandler(INC_E0M0X0_FE);
			_opcodeTable[0, 0, 0, 0xFF] = new OpcodeHandler(SBC_E0M0X0_FF);
			#endregion
		}

		#region Opcodes Generales

		private void BRK_E0()
		{
			PushByte(_regs.ProgramBank);

			InterruptE1(0xFFE6);

			_regs.Flags |= 4;
			_regs.Flags &= 0xF7;

			_regs.ProgramBank = 0;

            this.CurrentOpCycles = 8;
		}
		private void BRK_E1()
		{
			InterruptE1(0xFFE6);

			_regs.Flags |= 4;
			_regs.Flags &= 0xF7;

			_regs.ProgramBank = 0;

			this.CurrentOpCycles = 7;
		}
		private void COP_E0()
		{
			PushByte(_regs.ProgramBank);

			InterruptE1(0xFFE4);

			_regs.Flags |= 4;
			_regs.Flags &= 0xF7;

			_regs.ProgramBank = 0;

			this.CurrentOpCycles = 8;
		}
		private void COP_E1()
		{
			InterruptE1(0xFFF4);

			_regs.Flags |= 4;
			_regs.Flags &= 0xF7;

			_regs.ProgramBank = 0;

			this.CurrentOpCycles = 7;
		}
		private void ORA_M0(uint OperandAddress)
		{
			ushort Operand = (ushort)(_bus.ReadByte(OperandAddress + (uint)1) << 8 | _bus.ReadByte(OperandAddress));

			_regs.Accumulator.Data |= Operand;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.High);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Data);
		}
		private void ORA_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Accumulator.Low |= Operand;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Low);
		}
		private void AND_M0(uint OperandAddress)
		{
			ushort Operand = (ushort)(_bus.ReadByte(OperandAddress + (uint)1) << 8 | _bus.ReadByte(OperandAddress));

			_regs.Accumulator.Data &= Operand;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.High);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Data);
		}
		private void AND_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Accumulator.Low &= Operand;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Low);
		}
		private void EOR_M0(uint OperandAddress)
		{
			ushort Operand = (ushort)(_bus.ReadByte(OperandAddress + (uint)1) << 8 | _bus.ReadByte(OperandAddress));

			_regs.Accumulator.Data ^= Operand;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.High);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Data);
		}
		private void EOR_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Accumulator.Low ^= Operand;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Low);
		}
		private void TSB_M0(uint OperandAddress)
		{
			byte LowByte = _bus.ReadByte(OperandAddress);
			byte HighByte = _bus.ReadByte(OperandAddress + 1);

			LowByte |= _regs.Accumulator.Low;
			HighByte |= _regs.Accumulator.High;

			_bus.WriteByte(OperandAddress, LowByte);
			_bus.WriteByte(OperandAddress, HighByte);

			if (LowByte > 0 && HighByte > 0) ClearZeroFlag();
			else SetZeroFlag();
		}
		private void TSB_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			Operand |= _regs.Accumulator.Low;

			_bus.WriteByte(OperandAddress, Operand);

			if (Operand > 0) ClearZeroFlag();
			else SetZeroFlag();
		}
		private void TRB_M0(uint OperandAddress)
		{
			byte LowByte = _bus.ReadByte(OperandAddress);
			byte HighByte = _bus.ReadByte(OperandAddress + 1);

			LowByte &= _regs.Accumulator.Low;
			HighByte &= _regs.Accumulator.High;

			_bus.WriteByte(OperandAddress, LowByte);
			_bus.WriteByte(OperandAddress, HighByte);

			if (LowByte > 0 && HighByte > 0) ClearZeroFlag();
			else SetZeroFlag();
		}
		private void TRB_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			Operand &= _regs.Accumulator.Low;

			_bus.WriteByte(OperandAddress, Operand);

			if (Operand > 0) ClearZeroFlag();
			else SetZeroFlag();
		}
		private void ASL_M0(uint OperandAddress)
		{
			Word Operand = new Word();
			Operand.Low = _bus.ReadByte(OperandAddress); ;
			Operand.High = _bus.ReadByte(OperandAddress + 1); ;

			Operand.Data <<= 1;

			if ((Operand.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((Operand.High >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_bus.WriteByte(OperandAddress, Operand.Low);
			_bus.WriteByte(OperandAddress + 1, Operand.High);
		}

		private void ClearCarryFlag()
		{
			_regs.Flags &= 0xFE;
		}

		private void SetCarryFlag()
		{
			_regs.Flags |= 0x01;
		}
		private void ASL_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			Operand <<= 1;

			if ((Operand & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((Operand >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_bus.WriteByte(OperandAddress, Operand);
		}
		private void LSR_M0(uint OperandAddress)
		{
			Word Operand = new Word();
			Operand.Low = _bus.ReadByte(OperandAddress); ;
			Operand.High = _bus.ReadByte(OperandAddress + 1); ;

			Operand.Data >>= 1;

			if ((Operand.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((Operand.High >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_bus.WriteByte(OperandAddress, Operand.Low);
			_bus.WriteByte(OperandAddress + 1, Operand.High);
		}
		private void LSR_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			Operand <<= 1;

			if ((Operand & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((Operand >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_bus.WriteByte(OperandAddress, Operand);
		}
		private void BIT_M0(uint OperandAddress)
		{
			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((Operand.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if ((Operand.High & 0x40) > 0) SetOverflowFlag();
			else ClearOverflowFlag();

			if ((Operand.Data & _regs.Accumulator.Data) > 0) SetZeroFlag();
			else ClearZeroFlag();
		}
		private void BIT_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			if ((Operand & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if ((Operand & 0x40) > 0) SetOverflowFlag();
			else ClearOverflowFlag();

			if ((Operand & _regs.Accumulator.Low) > 0) ClearZeroFlag();
			else SetZeroFlag();
		}
		private void INA_M0()
		{
			_regs.Accumulator.Data++;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void INA_M1()
		{
			_regs.Accumulator.Low++;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void INY_X0()
		{
			_regs.Y.Data++;

			if ((_regs.Y.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Y.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void INY_X1()
		{
			_regs.Y.Low++;

			if ((_regs.Y.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Y.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void INX_X0()
		{
			_regs.X.Data++;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void INX_X1()
		{
			_regs.X.Low++;

			if ((_regs.X.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void DEA_M0()
		{
			_regs.Accumulator.Data--;

            _regs.Flags &= 0x7F;
            _regs.Flags |= GetNegativeFlag(_regs.Accumulator.High);

            _regs.Flags &= 0xFD;
            _regs.Flags |= GetZeroFlag(_regs.Accumulator.Data);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void DEA_M1()
		{
			_regs.Accumulator.Low--;

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Low);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void DEY_X0()
		{
			_regs.Y.Data--;

			if ((_regs.Y.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Y.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void DEY_X1()
		{
			_regs.Y.Low--;

			if ((_regs.Y.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Y.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void DEX_X0()
		{
			_regs.X.Data--;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void DEX_X1()
		{
			_regs.X.Low--;

			if ((_regs.X.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void DEC_M0(uint OperandAddress)
		{
			Word Operand = new Word();
			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress);

			Operand.Data--;

			if ((Operand.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			_bus.WriteByte(OperandAddress, Operand.Low);
			_bus.WriteByte(OperandAddress, Operand.High);
		}
		private void DEC_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			Operand--;

			if ((Operand & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand > 0) ClearZeroFlag();
			else SetZeroFlag();

			_bus.WriteByte(OperandAddress, Operand);
		}
		private void INC_M0(uint OperandAddress)
		{
			Word Operand = new Word();
			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress);

			Operand.Data++;

			if ((Operand.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			_bus.WriteByte(OperandAddress, Operand.Low);
			_bus.WriteByte(OperandAddress, Operand.High);
		}
		private void INC_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			Operand++;

			if ((Operand & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (Operand > 0) ClearZeroFlag();
			else SetZeroFlag();

			_bus.WriteByte(OperandAddress, Operand);
		}
		private void ASL_M0()
		{
			byte HighByte = _regs.Accumulator.High;

			_regs.Accumulator.Data <<= 1;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if ((_regs.Accumulator.Data) > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((HighByte >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void ASL_M1()
		{
			byte LowByte = _regs.Accumulator.Low;

			_regs.Accumulator.Low <<= 1;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if ((_regs.Accumulator.Low) > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((LowByte >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void LSR_M0()
		{
			byte LowByte = _regs.Accumulator.Low;

			_regs.Accumulator.Data >>= 1;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if ((_regs.Accumulator.Data) > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((LowByte & 0x01) > 0) SetCarryFlag();
			else ClearCarryFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void LSR_M1()
		{
			byte LowByte = _regs.Accumulator.Low;

			_regs.Accumulator.Low >>= 1;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if ((_regs.Accumulator.Low) > 0) ClearZeroFlag();
			else SetZeroFlag();

			if ((LowByte & 0x01) > 0) SetCarryFlag();
			else ClearCarryFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void PHP()
		{
			PushByte(_regs.Flags);

			_regs.ProgramCounter.Data++;

			this.CurrentOpCycles = 3;
		}
		private void PLP()
		{
			_regs.Flags = PullByte();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void PHD()
		{
			PushByte(_regs.DirectPage.High);
			PushByte(_regs.DirectPage.Low);

			_regs.ProgramCounter.Data++;

			this.CurrentOpCycles = 4;
		}
		private void PLD()
		{
			_regs.DirectPage.Low = PullByte();
			_regs.DirectPage.High = PullByte();

			if ((_regs.DirectPage.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.DirectPage.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data++;
		}
		private void PHK()
		{
			PushByte(_regs.ProgramBank);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		}
		private void PLK()
		{
			_regs.ProgramBank = PullByte();

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		}
		private void PHA_M0()
		{
			PushByte(_regs.Accumulator.High);
			PushByte(_regs.Accumulator.Low);

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void PHA_M1()
		{
			PushByte(_regs.Accumulator.Low);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		}
		private void PLA_M0()
		{
			_regs.Accumulator.Low = PullByte();
			_regs.Accumulator.High = PullByte();

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data++;
		}
		private void PLA_M1()
		{
			_regs.Accumulator.Low = PullByte();

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void Branch(bool Condition)
		{
			uint OperandAddress = Immediate();

			sbyte Operand = (sbyte)_bus.ReadByte(OperandAddress);
			_regs.ProgramCounter.Data += 2;

			if (Condition)
			{
				_regs.ProgramCounter.Data += (ushort)Operand;
				this.CurrentOpCycles = 3;
			}
			else
			{
				this.CurrentOpCycles = 2;
			}
		}
		private void CLC()
		{
			_regs.Flags &= 0xFE;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void SEC()
		{
			_regs.Flags |= 0x01;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TCS_M0()
		{
			_regs.StackPointer.Data = _regs.Accumulator.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void TCS_M1()
		{
			_regs.StackPointer.Data = _regs.Accumulator.Data;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void TXS_X0()
		{
			_regs.StackPointer.Data = _regs.X.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void TXS_X1()
		{
			_regs.StackPointer.Data = _regs.X.Data;

			if ((_regs.X.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void TCD_M0()
		{
			_regs.DirectPage.Data = _regs.Accumulator.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void TCD_M1()
		{
			_regs.DirectPage.Data = _regs.Accumulator.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		}
		private void TDC_M0()
		{
			_regs.Accumulator.Data = _regs.DirectPage.Data;

			_regs.Flags |= (byte)((_regs.DirectPage.High & 0x80)
				| (_regs.DirectPage.Data > 0 ? 0x00 : 0x02));

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TDC_M1()
		{
			_regs.Accumulator.Data = _regs.DirectPage.Data;

			_regs.Flags |= (byte)((_regs.DirectPage.High & 0x80)
				| (_regs.DirectPage.Data > 0 ? 0x00 : 0x02));

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TSC_M0()
		{
			_regs.Accumulator.Data = _regs.StackPointer.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TSC_M1()
		{
			_regs.Accumulator.Data = _regs.StackPointer.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TSX_X0()
		{
			_regs.X.Data = _regs.StackPointer.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TSX_X1()
		{
			_regs.X.Data = _regs.StackPointer.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TYX_X0()
		{
			_regs.X.Data = _regs.Y.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TYX_X1()
		{
			_regs.X.Data = _regs.Y.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TXY_X0()
		{
			_regs.Y.Data = _regs.X.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TXY_X1()
		{
			_regs.Y.Data = _regs.X.Data;

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TXA_M0X0()
		{
			_regs.Accumulator.Data = _regs.X.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TXA_M0X1()
		{
			_regs.Accumulator.Low = _regs.X.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TXA_M1X0()
		{
			_regs.Accumulator.Low = _regs.X.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TXA_M1X1()
		{
			_regs.Accumulator.Low = _regs.X.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TYA_M0X0()
		{
			_regs.Accumulator.Data = _regs.Y.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TYA_M0X1()
		{
			_regs.Accumulator.Low = _regs.Y.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TYA_M1X0()
		{
			_regs.Accumulator.Low = _regs.Y.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TYA_M1X1()
		{
			_regs.Accumulator.Low = _regs.Y.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAX_M0X0()
		{
			_regs.X.Data = _regs.Accumulator.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAX_M0X1()
		{
			_regs.X.Low = _regs.Accumulator.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAX_M1X0()
		{
			_regs.X.Low = _regs.Accumulator.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAX_M1X1()
		{
			_regs.X.Low = _regs.Accumulator.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAY_M0X0()
		{
			_regs.Y.Data = _regs.Accumulator.Data;

			if ((_regs.Accumulator.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAY_M0X1()
		{
			_regs.Y.Low = _regs.Accumulator.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAY_M1X0()
		{
			_regs.Y.Low = _regs.Accumulator.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void TAY_M1X1()
		{
			_regs.Y.Low = _regs.Accumulator.Low;

			if ((_regs.Accumulator.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Accumulator.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void ROL_M0(uint OperandAddress)
		{
			Word Operand = new Word();
			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			int HighByte = _regs.Flags & 0x01;

			if ((Operand.High >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			Operand.Data <<= 1;
			Operand.Low |= (byte)HighByte;
		}
		private void ROL_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			int HighByte = _regs.Flags & 0x01;

			if ((Operand >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			Operand <<= 1;
			Operand |= (byte)HighByte;
		}
		private void ROR_M0(uint OperandAddress)
		{
			Word Operand = new Word();
			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			int lowByte = _regs.Flags << 7;

			if ((Operand.Low & 0x01) > 0) SetCarryFlag();
			else ClearCarryFlag();

			Operand.Data >>= 1;
			Operand.High |= (byte)lowByte;
		}
		private void ROR_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			int lowByte = _regs.Flags << 7;

			if ((Operand & 0x01) > 0) SetCarryFlag();
			else ClearCarryFlag();

			Operand >>= 1;
			Operand |= (byte)lowByte;
		}
		private void ROR_M0()
		{
			int lowByte = _regs.Flags << 7;

			if ((_regs.Accumulator.Low & 0x01) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_regs.Accumulator.Data >>= 1;
			_regs.Accumulator.High |= (byte)lowByte;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void ROR_M1()
		{
			int lowByte = _regs.Flags << 7;

			if ((_regs.Accumulator.Low & 0x01) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_regs.Accumulator.Low >>= 1;
			_regs.Accumulator.Low |= (byte)lowByte;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void ROL_M0()
		{
			int HighByte = _regs.Flags & 0x01;

			if ((_regs.Accumulator.High >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_regs.Accumulator.Data <<= 1;
			_regs.Accumulator.Low |= (byte)HighByte;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void ROL_M1()
		{
			int HighByte = _regs.Flags & 0x01;

			if ((_regs.Accumulator.Low >> 7) > 0) SetCarryFlag();
			else ClearCarryFlag();

			_regs.Accumulator.Low <<= 1;
			_regs.Accumulator.Low |= (byte)HighByte;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		}
		private void RTI()
		{
			_regs.Flags = PullByte();
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();
			_regs.ProgramBank = PullByte();

			if (_inNMI) _inNMI = false;
		}
		private void PHY_X0()
		{
			PushByte(_regs.Y.High);
			PushByte(_regs.Y.Low);

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void PHY_X1()
		{
			PushByte(_regs.Y.Low);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		}
		private void PLY_X0()
		{
			_regs.Y.Low = PullByte();
			_regs.Y.High = PullByte();

			if ((_regs.Y.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Y.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data++;
		}
		private void PLY_X1()
		{
			_regs.Y.Low = PullByte();

			if ((_regs.Y.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.Y.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void PHX_X0()
		{
			PushByte(_regs.X.High);
			PushByte(_regs.X.Low);

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void PHX_X1()
		{
			PushByte(_regs.X.Low);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		}
		private void PLX_X0()
		{
			_regs.X.Low = PullByte();
			_regs.X.High = PullByte();

			if ((_regs.X.High & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Data > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data++;
		}
		private void PLX_X1()
		{
			_regs.X.Low = PullByte();

			if ((_regs.X.Low & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.X.Low > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data++;
		}
		private void ADC_M0(uint OperandAddress)
		{
			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data + Operand.Data + (_regs.Flags & 0x01));

				if ((~(_regs.Accumulator.Data ^ Operand.Data) & (Operand.Data ^ Sum) & 0x8000) > 0) SetOverflowFlag();
				else ClearOverflowFlag();

				_regs.Accumulator.Data = (ushort)Sum;

				if ((Sum & 0x10000) > 0) SetCarryFlag();
				else ClearCarryFlag();

				if ((Sum & 0x8000) > 0) SetNegativeFlag();
				else ClearNegativeFlag();

				if (_regs.Accumulator.Data > 0) ClearZeroFlag();
				else SetZeroFlag();
			}
			else
			{
			}
		}
		private void ADC_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			if ((_regs.Flags & 0x04) == 0)
			{
				ushort Sum = (ushort)(_regs.Accumulator.Low + Operand + (_regs.Flags & 0x01));

				if ((~(_regs.Accumulator.Low ^ Operand) & (Operand ^ Sum) & 0x80) > 0) SetOverflowFlag();
				else ClearOverflowFlag();

				_regs.Accumulator.Data = (ushort)Sum;

				if ((Sum & 0x100) > 0) SetCarryFlag();
				else ClearCarryFlag();

				if ((Sum & 0x80) > 0) SetNegativeFlag();
				else ClearNegativeFlag();

				if (_regs.Accumulator.Data > 0) ClearZeroFlag();
				else SetZeroFlag();
			}
			else
			{
			}
		}
		private void SBC_M0(uint OperandAddress)
		{
			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data - Operand.Data - (~_regs.Flags & 0x01));

				if ((~(_regs.Accumulator.Data ^ Operand.Data) & (Operand.Data ^ Sum) & 0x8000) > 0) SetOverflowFlag();
				else ClearOverflowFlag();

				_regs.Accumulator.Data = (ushort)Sum;

				if ((Sum & 0x10000) > 0) SetCarryFlag();
				else ClearCarryFlag();

				if ((Sum & 0x8000) > 0) SetNegativeFlag();
				else ClearNegativeFlag();

				if (_regs.Accumulator.Data > 0) ClearZeroFlag();
				else SetZeroFlag();
			}
			else
			{
			}
		}
		private void SBC_M1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			if ((_regs.Flags & 0x04) == 0)
			{
				ushort Sum = (ushort)(_regs.Accumulator.Low - Operand - (~_regs.Flags & 0x01));

				if ((~(_regs.Accumulator.Low ^ Operand) & (Operand ^ Sum) & 0x80) > 0) SetOverflowFlag();
				else ClearOverflowFlag();

				_regs.Accumulator.Data = (ushort)Sum;

				if ((Sum & 0x100) > 0) SetCarryFlag();
				else ClearCarryFlag();

				if ((Sum & 0x80) > 0) SetNegativeFlag();
				else ClearNegativeFlag();

				if (_regs.Accumulator.Data > 0) ClearZeroFlag();
				else SetZeroFlag();
			}
			else
			{
			}
		}
		private void STZ_M0(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, 0);
			_bus.WriteByte(OperandAddress + 1, 0);
		}
		private void STZ_M1(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, 0);
		}
		private void STA_M0(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, _regs.Accumulator.Low);
			_bus.WriteByte(OperandAddress + 1, _regs.Accumulator.High);
		}
		private void STA_M1(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, _regs.Accumulator.Low);
		}
		private void STY_X0(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, _regs.Y.Low);
			_bus.WriteByte(OperandAddress + 1, _regs.Y.High);
		}
		private void STY_X1(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, _regs.Y.Low);
		}
		private void STX_X0(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, _regs.X.Low);
			_bus.WriteByte(OperandAddress + 1, _regs.X.High);
		}
		private void STX_X1(uint OperandAddress)
		{
			_bus.WriteByte(OperandAddress, _regs.X.Low);
		}
		private void LDY_X0(uint OperandAddress)
		{
			_regs.Y.Low = _bus.ReadByte(OperandAddress);
			_regs.Y.High = _bus.ReadByte(OperandAddress + 1);

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Y.High);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Y.Data);
		}
		private void LDY_X1(uint OperandAddress)
		{
			_regs.Y.Low = _bus.ReadByte(OperandAddress);

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Y.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Y.Low);
		}
		private void LDX_X0(uint OperandAddress)
		{
			_regs.X.Low = _bus.ReadByte(OperandAddress);
			_regs.X.High = _bus.ReadByte(OperandAddress + 1);

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.X.High);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.X.Data);
		}
		private void LDX_X1(uint OperandAddress)
		{
			_regs.X.Low = _bus.ReadByte(OperandAddress);

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.X.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.X.Low);
		}
		private void LDA_M0(uint OperandAddress)
		{
			_regs.Accumulator.Low = _bus.ReadByte(OperandAddress);
			_regs.Accumulator.High = _bus.ReadByte(OperandAddress + 1);

			_regs._Flags &= 0x7D;
			_regs._Flags |= (byte)((_regs.Accumulator.High & 0x80) | ((_regs.Accumulator.Data > 0) ? 0x00 : 0x02));
		}
		private void LDA_M1(uint OperandAddress)
		{
			_regs.Accumulator.Low = _bus.ReadByte(OperandAddress);

			_regs.Flags &= 0x7F;
			_regs.Flags |= GetNegativeFlag(_regs.Accumulator.Low);

			_regs.Flags &= 0xFD;
			_regs.Flags |= GetZeroFlag(_regs.Accumulator.Low);
		}
		private void CPX_X0(uint OperandAddress)
		{
			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if (Operand.Data > _regs.X.Data)
			{
				SetNegativeFlag();
				ClearCarryFlag();
				ClearZeroFlag();
			}
			else if (Operand.Data < _regs.X.Data)
			{
				ClearNegativeFlag();
				SetCarryFlag();
				ClearZeroFlag();
			}
			else
			{
				ClearNegativeFlag();
				SetZeroFlag();
				SetCarryFlag();
			}
		}
		private void CPX_X1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			if (Operand > _regs.X.Low)
			{
				SetNegativeFlag();
				ClearCarryFlag();
				ClearZeroFlag();
			}
			else if (Operand < _regs.X.Low)
			{
				ClearNegativeFlag();
				SetCarryFlag();
				ClearZeroFlag();
			}
			else
			{
				ClearNegativeFlag();
				SetZeroFlag();
				SetCarryFlag();
			}
		}
		private void CPY_X0(uint OperandAddress)
		{
			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if (Operand.Data > _regs.Y.Data)
			{
				SetNegativeFlag();
				ClearCarryFlag();
				ClearZeroFlag();
			}
			else if (Operand.Data < _regs.Y.Data)
			{
				ClearNegativeFlag();
				SetCarryFlag();
				ClearZeroFlag();
			}
			else
			{
				ClearNegativeFlag();
				SetZeroFlag();
				SetCarryFlag();
			}
		}
		private void CPY_X1(uint OperandAddress)
		{
			byte Operand = _bus.ReadByte(OperandAddress);

			if (Operand > _regs.Y.Low)
			{
				SetNegativeFlag();
				ClearCarryFlag();
				ClearZeroFlag();
			}
			else if (Operand < _regs.Y.Low)
			{
				ClearNegativeFlag();
				SetCarryFlag();
				ClearZeroFlag();
			}
			else
			{
				ClearNegativeFlag();
				SetZeroFlag();
				SetCarryFlag();
			}
		}
		private void CMP_M0(uint OperandAddress)
		{
			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

            if ((short)Operand.Data > (short)_regs.Accumulator.Data)
			{
				SetNegativeFlag();
				ClearCarryFlag();
				ClearZeroFlag();
			}
            else if ((short)Operand.Data < (short)_regs.Accumulator.Data)
			{
				ClearNegativeFlag();
				SetCarryFlag();
				ClearZeroFlag();
			}
			else
			{
				ClearNegativeFlag();
				SetZeroFlag();
				SetCarryFlag();
			}
		}
		private void CMP_M1(uint OperandAddress)
		{
			sbyte Operand = (sbyte)_bus.ReadByte(OperandAddress);

            if (Operand > (sbyte)_regs.Accumulator.Low)
			{
				SetNegativeFlag();
                ClearCarryFlag();
                ClearZeroFlag();
			}
            else if (Operand < (sbyte)_regs.Accumulator.Low)
			{
                ClearNegativeFlag();
				SetCarryFlag();
                ClearZeroFlag();
			}
			else
			{
                ClearNegativeFlag();
				SetZeroFlag();
				SetCarryFlag();
			}
		}

		#endregion

		#region Opcodes E1M1X1

		/// <Summary> 
		/// Número: 00
		/// Nombre: Force Break
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void BRK_E1M1X1_00()
		{
			BRK_E1();
		} // Listo

		/// <Summary> 
		/// Número: 01
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E1M1X1_01()
		{
			ORA_M1(DirectIndexedIndirect_X1());

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 02
		/// Nombre: Coprocessor
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void COP_E1M1X1_02()
		{
			COP_E1();
		} // Listo

		/// <Summary> 
		/// Número: 03
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E1M1X1_03()
		{
			uint OperandAddress = StackRelative();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 04
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E1M1X1_04()
		{
			TSB_M1(Direct());

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 05
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E1M1X1_05()
		{
			uint OperandAddress = Direct();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (4 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <summary> 
		/// Número: 06
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E1M1X1_06()
		{
			uint OperandAddress = Direct();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 07
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E1M1X1_07()
		{
			uint OperandAddress = DirectIndirectLong();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 08
		/// Nombre: Push Processor Status on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHP_E1M1X1_08()
		{
			PHP();
		} // Listo

		/// <Summary> 
		/// Número: 09
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E1M1X1_09()
		{
			uint OperandAddress = Immediate();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 0A
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ASL_E1M1X1_0A()
		{
			ASL_M1();
		} // Listo

		/// <Summary> 
		/// Número: 0B
		/// Nombre: Push Direct Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PHD_E1M1X1_0B()
		{
			PHD();
		} // Listo

		/// <Summary> 
		/// Número: 0C
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E1M1X1_0C()
		{
			uint OperandAddress = Absolute();

			TSB_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E1M1X1_0D()
		{
			uint OperandAddress = Absolute();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E1M1X1_0E()
		{
			uint OperandAddress = Absolute();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E1M1X1_0F()
		{
			uint OperandAddress = AbsoluteLong();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 10
		/// Nombre: Branch if Result Plus (PN = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BPL_E1M1X1_10()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 11
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E1M1X1_11()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 12
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E1M1X1_12()
		{
			uint OperandAddress = DirectIndirect();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 13
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E1M1X1_13()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 14
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E1M1X1_14()
		{
			uint OperandAddress = Direct();

			TRB_M1(OperandAddress);

			this.CurrentOpCycles = 7 + (_regs.DirectPage.Low > 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 15
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E1M1X1_15()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(5 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 16
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E1M1X1_16()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 17
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E1M1X1_17()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(7 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 18
		/// Nombre: Clear Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLC_E1M1X1_18()
		{
			CLC();
		} // Listo

		/// <Summary> 
		/// Número: 19
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E1M1X1_19()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1A
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Accumulator (INA)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INC_E1M1X1_1A()
		{
			INA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 1B
		/// Nombre: Transfer Accumulator to Stack Pointer Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCS_E1M1X1_1B()
		{
			TCS_M1();
		} // Listo

		/// <Summary> 
		/// Número: 1C
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E1M1X1_1C()
		{
			uint OperandAddress = Absolute();

			TRB_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E1M1X1_1D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ASL_E1M1X1_1E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E1M1X1_1F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 20
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E1M1X1_20()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		}  // Listo

		/// <Summary> 
		/// Número: 21
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E1M1X1_21()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 22
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E1M1X1_22()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data += 4;

			PushByte(_regs.ProgramBank);
			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: 23
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_23()
		{
			uint OperandAddress = StackRelative();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 24
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E1M1X1_24()
		{
			uint OperandAddress = Direct();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 4 + (_regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 25
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E1M1X1_25()
		{
			uint OperandAddress = Direct();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 26
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E1M1X1_26()
		{
			uint OperandAddress = Direct();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 27
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E1M1X1_27()
		{
			uint OperandAddress = DirectIndirectLong();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 28
		/// Nombre: Pull Processor Status from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLP_E1M1X1_28()
		{
			PLP();
		} // Listo

		/// <Summary> 
		/// Número: 29
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_29()
		{
			uint OperandAddress = Immediate();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 2A
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROL_E1M1X1_2A()
		{
			ROL_M1();
		} // Listo

		/// <Summary> 
		/// Número: 2B
		/// Nombre: Pull Direct Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PLD_E1M1X1_2B()
		{
			PLD();
		} // Listo

		/// <Summary> 
		/// Número: 2C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E1M1X1_2C()
		{
			uint OperandAddress = Direct();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_2D()
		{
			uint OperandAddress = Absolute();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E1M1X1_2E()
		{
			uint OperandAddress = Absolute();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_2F()
		{
			uint OperandAddress = AbsoluteLong();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 30
		/// Nombre: Branch if Result Minus (PN = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BMI_E1M1X1_30()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 31
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E1M1X1_31()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 32
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_32()
		{
			uint OperandAddress = DirectIndirect();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 33
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_33()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 34
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E1M1X1_34()
		{
			uint OperandAddress = DirectIndexedX_X1();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 35
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E1M1X1_35()
		{
			uint OperandAddress = DirectIndexedX_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 36
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E1M1X1_36()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 37
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E1M1X1_37()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 38
		/// Nombre: Set Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEC_E1M1X1_38()
		{
			SEC();
		} // Listo

		/// <Summary> 
		/// Número: 39
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E1M1X1_39()
		{
			uint OperandAddress = Direct();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3A
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEC_E1M1X1_3A()
		{
			DEA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 3B
		/// Nombre: Transfer Stack Pointer Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSC_E1M1X1_3B()
		{
			TSC_M1();
		} // Listo

		/// <Summary> 
		/// Número: 3C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void BIT_E1M1X1_3C()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0 + ((OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E1M1X1_3D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROL_E1M1X1_3E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E1M1X1_3F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 40
		/// Nombre: Return from Interrupt
		/// Direccionamiento: Stack/RTI
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void RTI_E1M1X1_40()
		{
			RTI();

			this.CurrentOpCycles = 7;
		} // Listo

		/// <Summary> 
		/// Número: 41
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E1M1X1_41()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 42
		/// Nombre: Unknown/Reserved Opcode
		/// Direccionamiento: 2|16
		/// Tamaño en bytes: |
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// </summary> 
		private void WDM_E1M1X1_42()
		{
			NOP_E1M1X1_EA();
		} // Listo

		/// <Summary> 
		/// Número: 43
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E1M1X1_43()
		{
			uint OperandAddress = StackRelative();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 44
		/// Nombre: Block Move Positive
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVP_E1M1X1_44()
		{
		}

		/// <Summary> 
		/// Número: 45
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E1M1X1_45()
		{
			uint OperandAddress = Direct();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 46
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E1M1X1_46()
		{
			uint OperandAddress = Direct();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low > 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 47
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E1M1X1_47()
		{
			uint OperandAddress = DirectIndirectLong();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 48
		/// Nombre: Push Accumulator on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PHA_E1M1X1_48()
		{
			PHA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 49
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E1M1X1_49()
		{
			uint OperandAddress = Immediate();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 4A
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void LSR_E1M1X1_4A()
		{
			LSR_M1();
		}  // Listo

		/// <Summary> 
		/// Número: 4B
		/// Nombre: Push Program Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHK_E1M1X1_4B()
		{
			PHK();
		} // Listo

		/// <Summary> 
		/// Número: 4C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E1M1X1_4C()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 4D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E1M1X1_4D()
		{
			uint OperandAddress = Absolute();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E1M1X1_4E()
		{
			uint OperandAddress = Absolute();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E1M1X1_4F()
		{
			uint OperandAddress = AbsoluteLong();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		}  // Listo

		/// <Summary> 
		/// Número: 50
		/// Nombre: Branch on Overflow Clear (Pv = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVC_E1M1X1_50()
		{
			Branch((_regs.Flags & 0x40) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 51
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E1M1X1_51()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 52
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E1M1X1_52()
		{
			uint OperandAddress = DirectIndirect();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 53
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E1M1X1_53()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 54
		/// Nombre: Block Move Negative
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVN_E1M1X1_54()
		{
		}

		/// <Summary> 
		/// Número: 55
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E1M1X1_55()
		{
			uint OperandAddress = DirectIndexedX_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 56
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E1M1X1_56()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 8 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 57
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E1M1X1_57()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 58
		/// Nombre: Clear Interrupt Disable Bit
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLI_E1M1X1_58()
		{
			_regs.Flags &= 0xFB;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 59
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E1M1X1_59()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5A
		/// Nombre: Push index Y on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHY_E1M1X1_5A()
		{
			PHY_X1();
		}  // Listo

		/// <Summary> 
		/// Número: 5B
		/// Nombre: Transfer Accumulator to Direct Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCD_E1M1X1_5B()
		{
			TCD_M1();
		}  // Listo

		/// <Summary> 
		/// Número: 5C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E1M1X1_5C()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 4;
		}  // Listo

		/// <Summary> 
		/// Número: 5D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E1M1X1_5D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: 5E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void LSR_E1M1X1_5E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E1M1X1_5F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 60
		/// Nombre: Return from Subroutine
		/// Direccionamiento: Stack (RTS)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTS_E1M1X1_60()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 61
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_61()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 62
		/// Nombre: Push Effective Program Counter Relative Address on Stack
		/// Direccionamiento: Stack (PC Relative Long)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void PER_E1M1X1_62()
		{
		}

		/// <Summary> 
		/// Número: 63
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_63()
		{
			uint OperandAddress = StackRelative();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 64
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E1M1X1_64()
		{
			uint OperandAddress = Direct();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 65
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_65()
		{
			uint OperandAddress = Direct();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 66
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E1M1X1_66()
		{
			uint OperandAddress = Direct();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 67
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_67()
		{
			uint OperandAddress = DirectIndirectLong();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 68
		/// Nombre: Pull Accumulator from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PLA_E1M1X1_68()
		{
			PLA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 69
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_69()
		{
			uint OperandAddress = Immediate();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6A
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROR_E1M1X1_6A()
		{
			ROR_M1();
		} // Listo

		/// <Summary> 
		/// Número: 6B
		/// Nombre: Return from Subroutine Long
		/// Direccionamiento: Stack (RTL)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTL_E1M1X1_6B()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();
			_regs.ProgramBank = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 6C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if CPU is 65C02.
		/// - 6502: if low byte of operand is $FF (ie. operand is $xxFF): yields incorrect result.
		/// </summary> 
		private void JMP_E1M1X1_6C()
		{
			uint OperandAddress = AbsoluteIndirect();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 5;
		} // Listo

		/// <Summary> 
		/// Número: 6D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_6D()
		{
			uint OperandAddress = Absolute();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E1M1X1_6E()
		{
			uint OperandAddress = Absolute();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 6F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_6F()
		{
			uint OperandAddress = AbsoluteLong();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 70
		/// Nombre: Branch on Overflow Set (Pv = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVS_E1M1X1_70()
		{
			Branch((_regs.Flags & 0x40) > 0);
		} // Listo

		/// <Summary> 
		/// Número: 71
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_71()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 72
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_72()
		{
			uint OperandAddress = DirectIndirect();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 73
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_73()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 74
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E1M1X1_74()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 75
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_75()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 76
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E1M1X1_76()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 77
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_77()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 78
		/// Nombre: Set Interrupt Disable Status
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEI_E1M1X1_78()
		{
			_regs.Flags |= 0x04;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 79
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_79()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data + Operand.Data + (_regs.Flags & 0x01));

				_regs.Accumulator.Data = (ushort)Sum;
				_regs.Flags |= (byte)(Sum >> 16);

				this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
				_regs.ProgramCounter.Data += 3;
			}
			else
			{
			}
		} // Semi Listo

		/// <Summary> 
		/// Número: 7A
		/// Nombre: Pull Index Y form Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLY_E1M1X1_7A()
		{
			PLY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 7B
		/// Nombre: Transfer Direct Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TDC_E1M1X1_7B()
		{
			TDC_M1();
		} // Listo

		/// <Summary> 
		/// Número: 7C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E1M1X1_7C()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X1();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 7D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_7D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 7E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROR_E1M1X1_7E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 7F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E1M1X1_7F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 80
		/// Nombre: Branch Always
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BRA_E1M1X1_80()
		{
			Branch(true);
		} // Listo

		/// <Summary> 
		/// Número: 81
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_81()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 82
		/// Nombre: Branch Always Long
		/// Direccionamiento: Program Counter Relative Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void BRL_E1M1X1_82()
		{
			uint OperandAddress = Immediate();

			sbyte LowByte = (sbyte)_bus.ReadByte(OperandAddress);
			sbyte HiByte = (sbyte)_bus.ReadByte(OperandAddress + 1);

			_regs.ProgramCounter.Data += 3;
			_regs.ProgramCounter.Data += (byte)((byte)LowByte + (byte)HiByte);
			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 83
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_83()
		{
			uint OperandAddress = StackRelative();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 84
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E1M1X1_84()
		{
			uint OperandAddress = Direct();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 85
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_85()
		{
			uint OperandAddress = Direct();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 86
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E1M1X1_86()
		{
			uint OperandAddress = Direct();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 87
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_87()
		{
			uint OperandAddress = DirectIndirectLong();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 88
		/// Nombre: Decrement Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEY_E1M1X1_88()
		{
			DEY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 89
		/// Nombre: Bit Test
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E1M1X1_89()
		{
			uint OperandAddress = Immediate();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 8A
		/// Nombre: Transfer Index X to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXA_E1M1X1_8A()
		{
			TXA_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: 8B
		/// Nombre: Push Data Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHB_E1M1X1_8B()
		{
			PushByte(_regs.DataBank);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: 8C
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E1M1X1_8C()
		{
			uint OperandAddress = Absolute();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_8D()
		{
			uint OperandAddress = Absolute();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8E
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E1M1X1_8E()
		{
			uint OperandAddress = Absolute();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_8F()
		{
			uint OperandAddress = AbsoluteLong();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 90
		/// Nombre: Branch on Carry Clear (Pe = O)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCC_E1M1X1_90()
		{
			Branch((_regs.Flags & 0x01) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 91
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_91()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 92
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_92()
		{
			uint OperandAddress = DirectIndirect();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 93
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_93()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 94
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E1M1X1_94()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 95
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_95()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 96
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E1M1X1_96()
		{
			uint OperandAddress = DirectIndexedY_X1();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 97
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E1M1X1_97()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 98
		/// Nombre: Transfer Index Y to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYA_E1M1X1_98()
		{
			TYA_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: 99
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_99()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9A
		/// Nombre: Transfer Index X to Stack Polnter Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXS_E1M1X1_9A()
		{
			TXS_X1();
		} // Listo

		/// <Summary> 
		/// Número: 9B
		/// Nombre: Transfer Index X to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXY_E1M1X1_9B()
		{
			TXY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 9C
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E1M1X1_9C()
		{
			uint OperandAddress = Absolute();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_9D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9E
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E1M1X1_9E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E1M1X1_9F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: A0
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E1M1X1_A0()
		{
			uint OperandAddress = Immediate();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E1M1X1_A1()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A2
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E1M1X1_A2()
		{
			uint OperandAddress = Immediate();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E1M1X1_A3()
		{
			uint OperandAddress = StackRelative();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E1M1X1_A4()
		{
			uint OperandAddress = Direct();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E1M1X1_A5()
		{
			uint OperandAddress = Direct();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E1M1X1_A6()
		{
			uint OperandAddress = Direct();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E1M1X1_A7()
		{
			uint OperandAddress = DirectIndirectLong();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A8
		/// Nombre: Transfer Accumulator to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAY_E1M1X1_A8()
		{
			TAY_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: A9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E1M1X1_A9()
		{
			uint OperandAddress = Immediate();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: AA
		/// Nombre: Transfer Accumulator to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAX_E1M1X1_AA()
		{
			TAX_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: AB
		/// Nombre: Pull Data Bank Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLB_E1M1X1_AB()
		{
			_regs.DataBank = PullByte();

			_regs.Flags |= (byte)(_regs.DataBank & 0x80 | (_regs.DataBank > 0 ? 0x00 : 0x02));

			if ((_regs.DataBank & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.DataBank > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: AC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E1M1X1_AC()
		{
			uint OperandAddress = Absolute();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E1M1X1_AD()
		{
			uint OperandAddress = Absolute();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E1M1X1_AE()
		{
			uint OperandAddress = Absolute();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E1M1X1_AF()
		{
			uint OperandAddress = AbsoluteLong();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: B0
		/// Nombre: Branch on Carry Set (Pe = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCS_E1M1X1_B0()
		{
			Branch((_regs.Flags & 0x01) > 0);
		} // Listo

		/// <Summary> 
		/// Número: B1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E1M1X1_B1()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B2
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E1M1X1_B2()
		{
			uint OperandAddress = DirectIndirect();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E1M1X1_B3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E1M1X1_B4()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E1M1X1_B5()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: DP Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E1M1X1_B6()
		{
			uint OperandAddress = DirectIndexedY_X1();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E1M1X1_B7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B8
		/// Nombre: Clear Overflow Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLV_E1M1X1_B8()
		{
			_regs.Flags &= 0xBF;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: B9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E1M1X1_B9()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BA
		/// Nombre: Transfer Stack Pointer Register to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSX_E1M1X1_BA()
		{
			TSX_X1();
		} // Listo

		/// <Summary> 
		/// Número: BB
		/// Nombre: Transfer Index Y to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYX_E1M1X1_BB()
		{
			TYX_X1();
		} // Listo

		/// <Summary> 
		/// Número: BC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E1M1X1_BC()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E1M1X1_BD()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E1M1X1_BE()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E1M1X1_BF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: C0
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E1M1X1_C0()
		{
			uint OperandAddress = Immediate();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E1M1X1_C1()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C2
		/// Nombre: Reset Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void REP_E1M1X1_C2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags &= (byte)(~Operand);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E1M1X1_C3()
		{
			uint OperandAddress = StackRelative();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: C4
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E1M1X1_C4()
		{
			uint OperandAddress = Direct();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E1M1X1_C5()
		{
			uint OperandAddress = Direct();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E1M1X1_C6()
		{
			uint OperandAddress = Direct();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E1M1X1_C7()
		{
			uint OperandAddress = DirectIndirectLong();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C8
		/// Nombre: Increment Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INY_E1M1X1_C8()
		{
			INY_X1();
		} // Listo

		/// <Summary> 
		/// Número: C9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E1M1X1_C9()
		{
			uint OperandAddress = Immediate();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: CA
		/// Nombre: Decrement Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEX_E1M1X1_CA()
		{
			DEX_X1();
		} // Listo

		/// <Summary> 
		/// Número: CB
		/// Nombre: Wait for Interrupt
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by interrupt to restart it.
		/// </summary> 
		private void WAI_E1M1X1_CB()
		{
            _waitInterrupt = true;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: CC
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E1M1X1_CC()
		{
			uint OperandAddress = Absolute();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E1M1X1_CD()
		{
			uint OperandAddress = Absolute();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E1M1X1_CE()
		{
			uint OperandAddress = Absolute();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E1M1X1_CF()
		{
			uint OperandAddress = AbsoluteLong();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: D0
		/// Nombre: Branch if Not Equal (Pz = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BNE_E1M1X1_D0()
		{
			Branch((_regs.Flags & 0x02) == 0);
		} // Listo

		/// <Summary> 
		/// Número: D1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E1M1X1_D1()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D2
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E1M1X1_D2()
		{
			uint OperandAddress = DirectIndirect();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E1M1X1_D3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D4
		/// Nombre: Push Effective Indirect Address on Stack (add one cycle if DL f 0)
		/// Direccionamiento: Stack (Direct Page Indirect)
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void PEI_E1M1X1_D4()
		{
		}

		/// <Summary> 
		/// Número: D5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E1M1X1_D5()
		{
			uint OperandAddress = DirectIndexedX_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E1M1X1_D6()
		{
			uint OperandAddress = DirectIndexedX_X1();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E1M1X1_D7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D8
		/// Nombre: Clear Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLD_E1M1X1_D8()
		{
			_regs.Flags &= 0xF7;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: D9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E1M1X1_D9()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DA
		/// Nombre: Push Index X on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHX_E1M1X1_DA()
		{
			PHX_X1();
		} // Listo

		/// <Summary> 
		/// Número: DB
		/// Nombre: Stop the Clock
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by reset to restart 
		/// </summary> 
		private void STP_E1M1X1_DB()
		{
		}

		/// <Summary> 
		/// Número: DC
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E1M1X1_DC()
		{
			uint OperandAddress = AbsoluteIndirectLong();

			_regs.ProgramCounter.Low = _bus.ReadByte(OperandAddress);
			_regs.ProgramCounter.High = _bus.ReadByte(OperandAddress + 1);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: DD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E1M1X1_DD()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void DEC_E1M1X1_DE()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E1M1X1_DF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: E0
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E1M1X1_E0()
		{
			uint OperandAddress = Immediate();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: E1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_E1()
		{
		}

		/// <Summary> 
		/// Número: E2
		/// Nombre: Set Processor Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void SEP_E1M1X1_E2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags |= Operand;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_E3()
		{
		}

		/// <Summary> 
		/// Número: E4
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E1M1X1_E4()
		{
			uint OperandAddress = Direct();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_E5()
		{
		}

		/// <Summary> 
		/// Número: E6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void INC_E1M1X1_E6()
		{
			uint OperandAddress = Direct();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_E7()
		{
		}

		/// <Summary> 
		/// Número: E8
		/// Nombre: Increment Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INX_E1M1X1_E8()
		{
			INX_X1();
		} // Listo

		/// <Summary> 
		/// Número: E9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// </summary> 
		private void SBC_E1M1X1_E9()
		{
		}

		/// <Summary> 
		/// Número: EA
		/// Nombre: No Operation
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void NOP_E1M1X1_EA()
		{
			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: EB
		/// Nombre: Exchange AH and AL
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void XBA_E1M1X1_EB()
		{
			byte temp = _regs.Accumulator.High;
			_regs.Accumulator.High = _regs.Accumulator.Low;
			_regs.Accumulator.Low = temp;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: EC
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E1M1X1_EC()
		{
			uint OperandAddress = Absolute();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: ED
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_ED()
		{
		}

		/// <Summary> 
		/// Número: EE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E1M1X1_EE()
		{
			uint OperandAddress = Absolute();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: EF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_EF()
		{
		}

		/// <Summary> 
		/// Número: F0
		/// Nombre: Branch if Equal (Pz = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BEQ_E1M1X1_F0()
		{
			Branch((_regs.Flags & 0x02) > 0);
		} // Listo

		/// <Summary> 
		/// Número: F1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_F1()
		{
		}

		/// <Summary> 
		/// Número: F2
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_F2()
		{
		}

		/// <Summary> 
		/// Número: F3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_F3()
		{
		}

		/// <Summary> 
		/// Número: F4
		/// Nombre: Push Effective Absolute Address on Stack (or Push Immediate Data on Stack)
		/// Direccionamiento: Stack (Absolute)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PEA_E1M1X1_F4()
		{
		}

		/// <Summary> 
		/// Número: F5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_F5()
		{
		}

		/// <Summary> 
		/// Número: F6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E1M1X1_F6()
		{
			uint OperandAddress = DirectIndexedX_X1();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: F7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_F7()
		{
		}

		/// <Summary> 
		/// Número: F8
		/// Nombre: Set Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SED_E1M1X1_F8()
		{
			_regs.Flags |= 0x08;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: F9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_F9()
		{
		}

		/// <Summary> 
		/// Número: FA
		/// Nombre: Pull Index X from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLX_E1M1X1_FA()
		{
			PLX_X1();
		} // Listo

		/// <Summary> 
		/// Número: FB
		/// Nombre: Exchange Carry and Emulation Bits
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void XCE_E1M1X1_FB()
		{
			uint EMode = _regs.EmulatorMode;

			_regs.EmulatorMode = (uint)(_regs.Flags & 0x00000001);
			_regs.Flags |= (byte)(EMode);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: FC
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E1M1X1_FC()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X1();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: FD
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_FD()
		{
		}

		/// <Summary> 
		/// Número: FE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void INC_E1M1X1_FE()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: FF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E1M1X1_FF()
		{
		}

		#endregion

		#region Opcodes E0M1X1

		/// <Summary> 
		/// Número: 00
		/// Nombre: Force Break
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void BRK_E0M1X1_00()
		{
			BRK_E0();
		} // Listo

		/// <Summary> 
		/// Número: 01
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X1_01()
		{
			ORA_M1(DirectIndexedIndirect_X1());

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 02
		/// Nombre: Coprocessor
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void COP_E0M1X1_02()
		{
			COP_E0();
		} // Listo

		/// <Summary> 
		/// Número: 03
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X1_03()
		{
			uint OperandAddress = StackRelative();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 04
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M1X1_04()
		{
			TSB_M1(Direct());

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 05
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X1_05()
		{
			uint OperandAddress = Direct();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (4 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <summary> 
		/// Número: 06
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M1X1_06()
		{
			uint OperandAddress = Direct();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 07
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X1_07()
		{
			uint OperandAddress = DirectIndirectLong();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 08
		/// Nombre: Push Processor Status on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHP_E0M1X1_08()
		{
			PHP();
		} // Listo

		/// <Summary> 
		/// Número: 09
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X1_09()
		{
			uint OperandAddress = Immediate();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 0A
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ASL_E0M1X1_0A()
		{
			ASL_M1();
		} // Listo

		/// <Summary> 
		/// Número: 0B
		/// Nombre: Push Direct Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PHD_E0M1X1_0B()
		{
			PHD();
		} // Listo

		/// <Summary> 
		/// Número: 0C
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M1X1_0C()
		{
			uint OperandAddress = Absolute();

			TSB_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X1_0D()
		{
			uint OperandAddress = Absolute();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M1X1_0E()
		{
			uint OperandAddress = Absolute();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X1_0F()
		{
			uint OperandAddress = AbsoluteLong();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 10
		/// Nombre: Branch if Result Plus (PN = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BPL_E0M1X1_10()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 11
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M1X1_11()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 12
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X1_12()
		{
			uint OperandAddress = DirectIndirect();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 13
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X1_13()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 14
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M1X1_14()
		{
			uint OperandAddress = Direct();

			TRB_M1(OperandAddress);

			this.CurrentOpCycles = 7 + (_regs.DirectPage.Low > 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 15
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X1_15()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(5 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 16
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M1X1_16()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 17
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X1_17()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(7 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 18
		/// Nombre: Clear Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLC_E0M1X1_18()
		{
			CLC();
		} // Listo

		/// <Summary> 
		/// Número: 19
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M1X1_19()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1A
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Accumulator (INA)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M1X1_1A()
		{
			INA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 1B
		/// Nombre: Transfer Accumulator to Stack Pointer Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCS_E0M1X1_1B()
		{
			TCS_M1();
		} // Listo

		/// <Summary> 
		/// Número: 1C
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M1X1_1C()
		{
			uint OperandAddress = Absolute();

			TRB_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M1X1_1D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ASL_E0M1X1_1E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X1_1F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 20
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M1X1_20()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		}  // Listo

		/// <Summary> 
		/// Número: 21
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X1_21()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 22
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M1X1_22()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data += 4;

			PushByte(_regs.ProgramBank);
			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: 23
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_23()
		{
			uint OperandAddress = StackRelative();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 24
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M1X1_24()
		{
			uint OperandAddress = Direct();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 4 + (_regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 25
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X1_25()
		{
			uint OperandAddress = Direct();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 26
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M1X1_26()
		{
			uint OperandAddress = Direct();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 27
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X1_27()
		{
			uint OperandAddress = DirectIndirectLong();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 28
		/// Nombre: Pull Processor Status from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLP_E0M1X1_28()
		{
			PLP();
		} // Listo

		/// <Summary> 
		/// Número: 29
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_29()
		{
			uint OperandAddress = Immediate();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 2A
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROL_E0M1X1_2A()
		{
			ROL_M1();
		} // Listo

		/// <Summary> 
		/// Número: 2B
		/// Nombre: Pull Direct Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PLD_E0M1X1_2B()
		{
			PLD();
		} // Listo

		/// <Summary> 
		/// Número: 2C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M1X1_2C()
		{
			uint OperandAddress = Direct();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_2D()
		{
			uint OperandAddress = Absolute();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M1X1_2E()
		{
			uint OperandAddress = Absolute();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_2F()
		{
			uint OperandAddress = AbsoluteLong();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 30
		/// Nombre: Branch if Result Minus (PN = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BMI_E0M1X1_30()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 31
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M1X1_31()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 32
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_32()
		{
			uint OperandAddress = DirectIndirect();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 33
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_33()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 34
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M1X1_34()
		{
			uint OperandAddress = DirectIndexedX_X1();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 35
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X1_35()
		{
			uint OperandAddress = DirectIndexedX_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 36
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M1X1_36()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 37
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X1_37()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 38
		/// Nombre: Set Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEC_E0M1X1_38()
		{
			SEC();
		} // Listo

		/// <Summary> 
		/// Número: 39
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M1X1_39()
		{
			uint OperandAddress = Direct();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3A
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEC_E0M1X1_3A()
		{
			DEA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 3B
		/// Nombre: Transfer Stack Pointer Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSC_E0M1X1_3B()
		{
			TSC_M1();
		} // Listo

		/// <Summary> 
		/// Número: 3C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void BIT_E0M1X1_3C()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0 + ((OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M1X1_3D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROL_E0M1X1_3E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X1_3F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 40
		/// Nombre: Return from Interrupt
		/// Direccionamiento: Stack/RTI
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void RTI_E0M1X1_40()
		{
			RTI();

			this.CurrentOpCycles = 7;
		} // Listo

		/// <Summary> 
		/// Número: 41
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X1_41()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 42
		/// Nombre: Unknown/Reserved Opcode
		/// Direccionamiento: 2|16
		/// Tamaño en bytes: |
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// </summary> 
		private void WDM_E0M1X1_42()
		{
			NOP_E0M1X1_EA();
		} // Listo

		/// <Summary> 
		/// Número: 43
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X1_43()
		{
			uint OperandAddress = StackRelative();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 44
		/// Nombre: Block Move Positive
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVP_E0M1X1_44()
		{
		}

		/// <Summary> 
		/// Número: 45
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X1_45()
		{
			uint OperandAddress = Direct();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 46
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M1X1_46()
		{
			uint OperandAddress = Direct();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low > 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 47
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X1_47()
		{
			uint OperandAddress = DirectIndirectLong();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 48
		/// Nombre: Push Accumulator on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PHA_E0M1X1_48()
		{
			PHA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 49
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X1_49()
		{
			uint OperandAddress = Immediate();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 4A
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void LSR_E0M1X1_4A()
		{
			LSR_M1();
		}  // Listo

		/// <Summary> 
		/// Número: 4B
		/// Nombre: Push Program Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHK_E0M1X1_4B()
		{
			PHK();
		} // Listo

		/// <Summary> 
		/// Número: 4C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X1_4C()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 4D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X1_4D()
		{
			uint OperandAddress = Absolute();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M1X1_4E()
		{
			uint OperandAddress = Absolute();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X1_4F()
		{
			uint OperandAddress = AbsoluteLong();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		}  // Listo

		/// <Summary> 
		/// Número: 50
		/// Nombre: Branch on Overflow Clear (Pv = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVC_E0M1X1_50()
		{
			Branch((_regs.Flags & 0x40) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 51
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M1X1_51()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 52
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X1_52()
		{
			uint OperandAddress = DirectIndirect();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 53
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X1_53()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 54
		/// Nombre: Block Move Negative
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVN_E0M1X1_54()
		{
		}

		/// <Summary> 
		/// Número: 55
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X1_55()
		{
			uint OperandAddress = DirectIndexedX_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 56
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M1X1_56()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 8 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 57
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X1_57()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 58
		/// Nombre: Clear Interrupt Disable Bit
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLI_E0M1X1_58()
		{
			_regs.Flags &= 0xFB;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 59
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M1X1_59()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5A
		/// Nombre: Push index Y on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHY_E0M1X1_5A()
		{
			PHY_X1();
		}  // Listo

		/// <Summary> 
		/// Número: 5B
		/// Nombre: Transfer Accumulator to Direct Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCD_E0M1X1_5B()
		{
			TCD_M1();
		}  // Listo

		/// <Summary> 
		/// Número: 5C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X1_5C()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 4;
		}  // Listo

		/// <Summary> 
		/// Número: 5D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M1X1_5D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: 5E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void LSR_E0M1X1_5E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X1_5F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 60
		/// Nombre: Return from Subroutine
		/// Direccionamiento: Stack (RTS)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTS_E0M1X1_60()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 61
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_61()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 62
		/// Nombre: Push Effective Program Counter Relative Address on Stack
		/// Direccionamiento: Stack (PC Relative Long)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void PER_E0M1X1_62()
		{
		}

		/// <Summary> 
		/// Número: 63
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_63()
		{
			uint OperandAddress = StackRelative();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 64
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M1X1_64()
		{
			uint OperandAddress = Direct();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 65
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_65()
		{
			uint OperandAddress = Direct();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 66
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M1X1_66()
		{
			uint OperandAddress = Direct();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 67
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_67()
		{
			uint OperandAddress = DirectIndirectLong();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 68
		/// Nombre: Pull Accumulator from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PLA_E0M1X1_68()
		{
			PLA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 69
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_69()
		{
			uint OperandAddress = Immediate();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6A
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROR_E0M1X1_6A()
		{
			ROR_M1();
		} // Listo

		/// <Summary> 
		/// Número: 6B
		/// Nombre: Return from Subroutine Long
		/// Direccionamiento: Stack (RTL)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTL_E0M1X1_6B()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();
			_regs.ProgramBank = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 6C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if CPU is 65C02.
		/// - 6502: if low byte of operand is $FF (ie. operand is $xxFF): yields incorrect result.
		/// </summary> 
		private void JMP_E0M1X1_6C()
		{
			uint OperandAddress = AbsoluteIndirect();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 5;
		} // Listo

		/// <Summary> 
		/// Número: 6D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_6D()
		{
			uint OperandAddress = Absolute();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M1X1_6E()
		{
			uint OperandAddress = Absolute();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 6F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_6F()
		{
			uint OperandAddress = AbsoluteLong();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 70
		/// Nombre: Branch on Overflow Set (Pv = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVS_E0M1X1_70()
		{
			Branch((_regs.Flags & 0x40) > 0);
		} // Listo

		/// <Summary> 
		/// Número: 71
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_71()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 72
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_72()
		{
			uint OperandAddress = DirectIndirect();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 73
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_73()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 74
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M1X1_74()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 75
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_75()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 76
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M1X1_76()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 77
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_77()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 78
		/// Nombre: Set Interrupt Disable Status
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEI_E0M1X1_78()
		{
			_regs.Flags |= 0x04;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 79
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_79()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data + Operand.Data + (_regs.Flags & 0x01));

				_regs.Accumulator.Data = (ushort)Sum;
				_regs.Flags |= (byte)(Sum >> 16);

				this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
				_regs.ProgramCounter.Data += 3;
			}
			else
			{
			}
		} // Semi Listo

		/// <Summary> 
		/// Número: 7A
		/// Nombre: Pull Index Y form Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLY_E0M1X1_7A()
		{
			PLY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 7B
		/// Nombre: Transfer Direct Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TDC_E0M1X1_7B()
		{
			TDC_M1();
		} // Listo

		/// <Summary> 
		/// Número: 7C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X1_7C()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X1();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 7D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_7D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 7E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROR_E0M1X1_7E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 7F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X1_7F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 80
		/// Nombre: Branch Always
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BRA_E0M1X1_80()
		{
			Branch(true);
		} // Listo

		/// <Summary> 
		/// Número: 81
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_81()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 82
		/// Nombre: Branch Always Long
		/// Direccionamiento: Program Counter Relative Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void BRL_E0M1X1_82()
		{
			uint OperandAddress = Immediate();

			sbyte LowByte = (sbyte)_bus.ReadByte(OperandAddress);
			sbyte HiByte = (sbyte)_bus.ReadByte(OperandAddress + 1);

			_regs.ProgramCounter.Data += 3;
			_regs.ProgramCounter.Data += (byte)((byte)LowByte + (byte)HiByte);
			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 83
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_83()
		{
			uint OperandAddress = StackRelative();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 84
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M1X1_84()
		{
			uint OperandAddress = Direct();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 85
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_85()
		{
			uint OperandAddress = Direct();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 86
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M1X1_86()
		{
			uint OperandAddress = Direct();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 87
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_87()
		{
			uint OperandAddress = DirectIndirectLong();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 88
		/// Nombre: Decrement Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEY_E0M1X1_88()
		{
			DEY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 89
		/// Nombre: Bit Test
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M1X1_89()
		{
			uint OperandAddress = Immediate();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 8A
		/// Nombre: Transfer Index X to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXA_E0M1X1_8A()
		{
			TXA_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: 8B
		/// Nombre: Push Data Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHB_E0M1X1_8B()
		{
			PushByte(_regs.DataBank);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: 8C
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M1X1_8C()
		{
			uint OperandAddress = Absolute();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_8D()
		{
			uint OperandAddress = Absolute();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8E
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M1X1_8E()
		{
			uint OperandAddress = Absolute();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_8F()
		{
			uint OperandAddress = AbsoluteLong();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 90
		/// Nombre: Branch on Carry Clear (Pe = O)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCC_E0M1X1_90()
		{
			Branch((_regs.Flags & 0x01) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 91
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_91()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 92
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_92()
		{
			uint OperandAddress = DirectIndirect();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 93
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_93()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 94
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M1X1_94()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 95
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_95()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 96
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M1X1_96()
		{
			uint OperandAddress = DirectIndexedY_X1();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 97
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X1_97()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 98
		/// Nombre: Transfer Index Y to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYA_E0M1X1_98()
		{
			TYA_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: 99
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_99()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9A
		/// Nombre: Transfer Index X to Stack Polnter Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXS_E0M1X1_9A()
		{
			TXS_X1();
		} // Listo

		/// <Summary> 
		/// Número: 9B
		/// Nombre: Transfer Index X to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXY_E0M1X1_9B()
		{
			TXY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 9C
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M1X1_9C()
		{
			uint OperandAddress = Absolute();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_9D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9E
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M1X1_9E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X1_9F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: A0
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X1_A0()
		{
			uint OperandAddress = Immediate();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X1_A1()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A2
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X1_A2()
		{
			uint OperandAddress = Immediate();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X1_A3()
		{
			uint OperandAddress = StackRelative();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X1_A4()
		{
			uint OperandAddress = Direct();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X1_A5()
		{
			uint OperandAddress = Direct();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X1_A6()
		{
			uint OperandAddress = Direct();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X1_A7()
		{
			uint OperandAddress = DirectIndirectLong();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A8
		/// Nombre: Transfer Accumulator to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAY_E0M1X1_A8()
		{
			TAY_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: A9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X1_A9()
		{
			uint OperandAddress = Immediate();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: AA
		/// Nombre: Transfer Accumulator to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAX_E0M1X1_AA()
		{
			TAX_M1X1();
		} // Listo

		/// <Summary> 
		/// Número: AB
		/// Nombre: Pull Data Bank Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLB_E0M1X1_AB()
		{
			_regs.DataBank = PullByte();

			_regs.Flags |= (byte)(_regs.DataBank & 0x80 | (_regs.DataBank > 0 ? 0x00 : 0x02));

			if ((_regs.DataBank & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.DataBank > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: AC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X1_AC()
		{
			uint OperandAddress = Absolute();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X1_AD()
		{
			uint OperandAddress = Absolute();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X1_AE()
		{
			uint OperandAddress = Absolute();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X1_AF()
		{
			uint OperandAddress = AbsoluteLong();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: B0
		/// Nombre: Branch on Carry Set (Pe = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCS_E0M1X1_B0()
		{
			Branch((_regs.Flags & 0x01) > 0);
		} // Listo

		/// <Summary> 
		/// Número: B1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M1X1_B1()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B2
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X1_B2()
		{
			uint OperandAddress = DirectIndirect();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X1_B3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X1_B4()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X1_B5()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: DP Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X1_B6()
		{
			uint OperandAddress = DirectIndexedY_X1();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X1_B7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B8
		/// Nombre: Clear Overflow Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLV_E0M1X1_B8()
		{
			_regs.Flags &= 0xBF;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: B9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M1X1_B9()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BA
		/// Nombre: Transfer Stack Pointer Register to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSX_E0M1X1_BA()
		{
			TSX_X1();
		} // Listo

		/// <Summary> 
		/// Número: BB
		/// Nombre: Transfer Index Y to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYX_E0M1X1_BB()
		{
			TYX_X1();
		} // Listo

		/// <Summary> 
		/// Número: BC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X1_BC()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M1X1_BD()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X1_BE()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X1_BF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: C0
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M1X1_C0()
		{
			uint OperandAddress = Immediate();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X1_C1()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C2
		/// Nombre: Reset Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void REP_E0M1X1_C2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags &= (byte)(~Operand);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X1_C3()
		{
			uint OperandAddress = StackRelative();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: C4
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M1X1_C4()
		{
			uint OperandAddress = Direct();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X1_C5()
		{
			uint OperandAddress = Direct();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M1X1_C6()
		{
			uint OperandAddress = Direct();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X1_C7()
		{
			uint OperandAddress = DirectIndirectLong();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C8
		/// Nombre: Increment Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INY_E0M1X1_C8()
		{
			INY_X1();
		} // Listo

		/// <Summary> 
		/// Número: C9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X1_C9()
		{
			uint OperandAddress = Immediate();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: CA
		/// Nombre: Decrement Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEX_E0M1X1_CA()
		{
			DEX_X1();
		} // Listo

		/// <Summary> 
		/// Número: CB
		/// Nombre: Wait for Interrupt
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by interrupt to restart it.
		/// </summary> 
		private void WAI_E0M1X1_CB()
		{
            _waitInterrupt = true;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: CC
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M1X1_CC()
		{
			uint OperandAddress = Absolute();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X1_CD()
		{
			uint OperandAddress = Absolute();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M1X1_CE()
		{
			uint OperandAddress = Absolute();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X1_CF()
		{
			uint OperandAddress = AbsoluteLong();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: D0
		/// Nombre: Branch if Not Equal (Pz = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BNE_E0M1X1_D0()
		{
			Branch((_regs.Flags & 0x02) == 0);
		} // Listo

		/// <Summary> 
		/// Número: D1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M1X1_D1()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D2
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X1_D2()
		{
			uint OperandAddress = DirectIndirect();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X1_D3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D4
		/// Nombre: Push Effective Indirect Address on Stack (add one cycle if DL f 0)
		/// Direccionamiento: Stack (Direct Page Indirect)
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void PEI_E0M1X1_D4()
		{
		}

		/// <Summary> 
		/// Número: D5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X1_D5()
		{
			uint OperandAddress = DirectIndexedX_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M1X1_D6()
		{
			uint OperandAddress = DirectIndexedX_X1();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X1_D7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D8
		/// Nombre: Clear Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLD_E0M1X1_D8()
		{
			_regs.Flags &= 0xF7;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: D9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M1X1_D9()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DA
		/// Nombre: Push Index X on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHX_E0M1X1_DA()
		{
			PHX_X1();
		} // Listo

		/// <Summary> 
		/// Número: DB
		/// Nombre: Stop the Clock
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by reset to restart 
		/// </summary> 
		private void STP_E0M1X1_DB()
		{
		}

		/// <Summary> 
		/// Número: DC
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X1_DC()
		{
			uint OperandAddress = AbsoluteIndirectLong();

			_regs.ProgramCounter.Low = _bus.ReadByte(OperandAddress);
			_regs.ProgramCounter.High = _bus.ReadByte(OperandAddress + 1);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: DD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M1X1_DD()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void DEC_E0M1X1_DE()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X1_DF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: E0
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M1X1_E0()
		{
			uint OperandAddress = Immediate();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: E1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_E1()
		{
		}

		/// <Summary> 
		/// Número: E2
		/// Nombre: Set Processor Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void SEP_E0M1X1_E2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags |= Operand;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_E3()
		{
		}

		/// <Summary> 
		/// Número: E4
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M1X1_E4()
		{
			uint OperandAddress = Direct();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_E5()
		{
		}

		/// <Summary> 
		/// Número: E6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M1X1_E6()
		{
			uint OperandAddress = Direct();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_E7()
		{
		}

		/// <Summary> 
		/// Número: E8
		/// Nombre: Increment Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INX_E0M1X1_E8()
		{
			INX_X1();
		} // Listo

		/// <Summary> 
		/// Número: E9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// </summary> 
		private void SBC_E0M1X1_E9()
		{
		}

		/// <Summary> 
		/// Número: EA
		/// Nombre: No Operation
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void NOP_E0M1X1_EA()
		{
			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: EB
		/// Nombre: Exchange AH and AL
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void XBA_E0M1X1_EB()
		{
			byte temp = _regs.Accumulator.High;
			_regs.Accumulator.High = _regs.Accumulator.Low;
			_regs.Accumulator.Low = temp;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: EC
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M1X1_EC()
		{
			uint OperandAddress = Absolute();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: ED
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_ED()
		{
		}

		/// <Summary> 
		/// Número: EE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M1X1_EE()
		{
			uint OperandAddress = Absolute();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: EF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_EF()
		{
		}

		/// <Summary> 
		/// Número: F0
		/// Nombre: Branch if Equal (Pz = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BEQ_E0M1X1_F0()
		{
			Branch((_regs.Flags & 0x02) > 0);
		} // Listo

		/// <Summary> 
		/// Número: F1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_F1()
		{
		}

		/// <Summary> 
		/// Número: F2
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_F2()
		{
		}

		/// <Summary> 
		/// Número: F3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_F3()
		{
		}

		/// <Summary> 
		/// Número: F4
		/// Nombre: Push Effective Absolute Address on Stack (or Push Immediate Data on Stack)
		/// Direccionamiento: Stack (Absolute)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PEA_E0M1X1_F4()
		{
		}

		/// <Summary> 
		/// Número: F5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_F5()
		{
		}

		/// <Summary> 
		/// Número: F6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M1X1_F6()
		{
			uint OperandAddress = DirectIndexedX_X1();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: F7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_F7()
		{
		}

		/// <Summary> 
		/// Número: F8
		/// Nombre: Set Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SED_E0M1X1_F8()
		{
			_regs.Flags |= 0x08;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: F9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_F9()
		{
		}

		/// <Summary> 
		/// Número: FA
		/// Nombre: Pull Index X from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLX_E0M1X1_FA()
		{
			PLX_X1();
		} // Listo

		/// <Summary> 
		/// Número: FB
		/// Nombre: Exchange Carry and Emulation Bits
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void XCE_E0M1X1_FB()
		{
			uint EMode = _regs.EmulatorMode;

			_regs.EmulatorMode = (uint)(_regs.Flags & 0x00000001);
			_regs.Flags |= (byte)(EMode);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: FC
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M1X1_FC()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X1();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: FD
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_FD()
		{
		}

		/// <Summary> 
		/// Número: FE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void INC_E0M1X1_FE()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: FF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X1_FF()
		{
		}

		#endregion

		#region Opcodes E0M0X1

		/// <Summary> 
		/// Número: 00
		/// Nombre: Force Break
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void BRK_E0M0X1_00()
		{
			BRK_E0();
		} // Listo

		/// <Summary> 
		/// Número: 01
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X1_01()
		{
			ORA_M0(DirectIndexedIndirect_X1());

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 02
		/// Nombre: Coprocessor
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void COP_E0M0X1_02()
		{
			COP_E0();
		} // Listo

		/// <Summary> 
		/// Número: 03
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X1_03()
		{
			uint OperandAddress = StackRelative();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 04
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M0X1_04()
		{
			TSB_M0(Direct());

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 05
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X1_05()
		{
			uint OperandAddress = Direct();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (4 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <summary> 
		/// Número: 06
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M0X1_06()
		{
			uint OperandAddress = Direct();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 07
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X1_07()
		{
			uint OperandAddress = DirectIndirectLong();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 08
		/// Nombre: Push Processor Status on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHP_E0M0X1_08()
		{
			PHP();
		} // Listo

		/// <Summary> 
		/// Número: 09
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X1_09()
		{
			uint OperandAddress = Immediate();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 0A
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ASL_E0M0X1_0A()
		{
			ASL_M0();
		} // Listo

		/// <Summary> 
		/// Número: 0B
		/// Nombre: Push Direct Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PHD_E0M0X1_0B()
		{
			PHD();
		} // Listo

		/// <Summary> 
		/// Número: 0C
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M0X1_0C()
		{
			uint OperandAddress = Absolute();

			TSB_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X1_0D()
		{
			uint OperandAddress = Absolute();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M0X1_0E()
		{
			uint OperandAddress = Absolute();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X1_0F()
		{
			uint OperandAddress = AbsoluteLong();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 10
		/// Nombre: Branch if Result Plus (PN = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BPL_E0M0X1_10()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 11
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M0X1_11()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 12
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X1_12()
		{
			uint OperandAddress = DirectIndirect();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 13
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X1_13()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 14
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M0X1_14()
		{
			uint OperandAddress = Direct();

			TRB_M0(OperandAddress);

			this.CurrentOpCycles = 7 + (_regs.DirectPage.Low > 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 15
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X1_15()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(5 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 16
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M0X1_16()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 17
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X1_17()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(7 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 18
		/// Nombre: Clear Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLC_E0M0X1_18()
		{
			CLC();
		} // Listo

		/// <Summary> 
		/// Número: 19
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M0X1_19()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1A
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Accumulator (INA)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M0X1_1A()
		{
			INA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 1B
		/// Nombre: Transfer Accumulator to Stack Pointer Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCS_E0M0X1_1B()
		{
			TCS_M0();
		} // Listo

		/// <Summary> 
		/// Número: 1C
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M0X1_1C()
		{
			uint OperandAddress = Absolute();

			TRB_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M0X1_1D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ASL_E0M0X1_1E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X1_1F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 20
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M0X1_20()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		}  // Listo

		/// <Summary> 
		/// Número: 21
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X1_21()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 22
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M0X1_22()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data += 4;

			PushByte(_regs.ProgramBank);
			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: 23
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_23()
		{
			uint OperandAddress = StackRelative();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 24
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M0X1_24()
		{
			uint OperandAddress = Direct();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 4 + (_regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 25
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X1_25()
		{
			uint OperandAddress = Direct();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 26
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M0X1_26()
		{
			uint OperandAddress = Direct();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 27
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X1_27()
		{
			uint OperandAddress = DirectIndirectLong();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 28
		/// Nombre: Pull Processor Status from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLP_E0M0X1_28()
		{
			PLP();
		} // Listo

		/// <Summary> 
		/// Número: 29
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_29()
		{
			uint OperandAddress = Immediate();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 2A
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROL_E0M0X1_2A()
		{
			ROL_M0();
		} // Listo

		/// <Summary> 
		/// Número: 2B
		/// Nombre: Pull Direct Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PLD_E0M0X1_2B()
		{
			PLD();
		} // Listo

		/// <Summary> 
		/// Número: 2C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M0X1_2C()
		{
			uint OperandAddress = Direct();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_2D()
		{
			uint OperandAddress = Absolute();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M0X1_2E()
		{
			uint OperandAddress = Absolute();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_2F()
		{
			uint OperandAddress = AbsoluteLong();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 30
		/// Nombre: Branch if Result Minus (PN = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BMI_E0M0X1_30()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 31
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M0X1_31()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 32
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_32()
		{
			uint OperandAddress = DirectIndirect();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 33
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_33()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 34
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M0X1_34()
		{
			uint OperandAddress = DirectIndexedX_X1();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 35
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X1_35()
		{
			uint OperandAddress = DirectIndexedX_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 36
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M0X1_36()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 37
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X1_37()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 38
		/// Nombre: Set Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEC_E0M0X1_38()
		{
			SEC();
		} // Listo

		/// <Summary> 
		/// Número: 39
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M0X1_39()
		{
			uint OperandAddress = Direct();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3A
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEC_E0M0X1_3A()
		{
			DEA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 3B
		/// Nombre: Transfer Stack Pointer Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSC_E0M0X1_3B()
		{
			TSC_M0();
		} // Listo

		/// <Summary> 
		/// Número: 3C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void BIT_E0M0X1_3C()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0 + ((OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M0X1_3D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROL_E0M0X1_3E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X1_3F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 40
		/// Nombre: Return from Interrupt
		/// Direccionamiento: Stack/RTI
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void RTI_E0M0X1_40()
		{
			RTI();

			this.CurrentOpCycles = 7;
		} // Listo

		/// <Summary> 
		/// Número: 41
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X1_41()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 42
		/// Nombre: Unknown/Reserved Opcode
		/// Direccionamiento: 2|16
		/// Tamaño en bytes: |
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// </summary> 
		private void WDM_E0M0X1_42()
		{
			NOP_E0M0X1_EA();
		} // Listo

		/// <Summary> 
		/// Número: 43
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X1_43()
		{
			uint OperandAddress = StackRelative();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 44
		/// Nombre: Block Move Positive
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVP_E0M0X1_44()
		{
		}

		/// <Summary> 
		/// Número: 45
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X1_45()
		{
			uint OperandAddress = Direct();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 46
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M0X1_46()
		{
			uint OperandAddress = Direct();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low > 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 47
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X1_47()
		{
			uint OperandAddress = DirectIndirectLong();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 48
		/// Nombre: Push Accumulator on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PHA_E0M0X1_48()
		{
			PHA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 49
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X1_49()
		{
			uint OperandAddress = Immediate();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 4A
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void LSR_E0M0X1_4A()
		{
			LSR_M0();
		}  // Listo

		/// <Summary> 
		/// Número: 4B
		/// Nombre: Push Program Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHK_E0M0X1_4B()
		{
			PHK();
		} // Listo

		/// <Summary> 
		/// Número: 4C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X1_4C()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 4D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X1_4D()
		{
			uint OperandAddress = Absolute();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M0X1_4E()
		{
			uint OperandAddress = Absolute();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X1_4F()
		{
			uint OperandAddress = AbsoluteLong();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		}  // Listo

		/// <Summary> 
		/// Número: 50
		/// Nombre: Branch on Overflow Clear (Pv = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVC_E0M0X1_50()
		{
			Branch((_regs.Flags & 0x40) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 51
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M0X1_51()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 52
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X1_52()
		{
			uint OperandAddress = DirectIndirect();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 53
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X1_53()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 54
		/// Nombre: Block Move Negative
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVN_E0M0X1_54()
		{
		}

		/// <Summary> 
		/// Número: 55
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X1_55()
		{
			uint OperandAddress = DirectIndexedX_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 56
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M0X1_56()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = 8 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 57
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X1_57()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 58
		/// Nombre: Clear Interrupt Disable Bit
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLI_E0M0X1_58()
		{
			_regs.Flags &= 0xFB;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 59
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M0X1_59()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5A
		/// Nombre: Push index Y on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHY_E0M0X1_5A()
		{
			PHY_X1();
		}  // Listo

		/// <Summary> 
		/// Número: 5B
		/// Nombre: Transfer Accumulator to Direct Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCD_E0M0X1_5B()
		{
			TCD_M0();
		}  // Listo

		/// <Summary> 
		/// Número: 5C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X1_5C()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 4;
		}  // Listo

		/// <Summary> 
		/// Número: 5D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M0X1_5D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: 5E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void LSR_E0M0X1_5E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X1_5F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 60
		/// Nombre: Return from Subroutine
		/// Direccionamiento: Stack (RTS)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTS_E0M0X1_60()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 61
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_61()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 62
		/// Nombre: Push Effective Program Counter Relative Address on Stack
		/// Direccionamiento: Stack (PC Relative Long)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void PER_E0M0X1_62()
		{
		}

		/// <Summary> 
		/// Número: 63
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_63()
		{
			uint OperandAddress = StackRelative();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 64
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M0X1_64()
		{
			uint OperandAddress = Direct();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 65
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_65()
		{
			uint OperandAddress = Direct();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 66
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M0X1_66()
		{
			uint OperandAddress = Direct();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 67
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_67()
		{
			uint OperandAddress = DirectIndirectLong();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 68
		/// Nombre: Pull Accumulator from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PLA_E0M0X1_68()
		{
			PLA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 69
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_69()
		{
			uint OperandAddress = Immediate();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6A
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROR_E0M0X1_6A()
		{
			ROR_M0();
		} // Listo

		/// <Summary> 
		/// Número: 6B
		/// Nombre: Return from Subroutine Long
		/// Direccionamiento: Stack (RTL)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTL_E0M0X1_6B()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();
			_regs.ProgramBank = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 6C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if CPU is 65C02.
		/// - 6502: if low byte of operand is $FF (ie. operand is $xxFF): yields incorrect result.
		/// </summary> 
		private void JMP_E0M0X1_6C()
		{
			uint OperandAddress = AbsoluteIndirect();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 5;
		} // Listo

		/// <Summary> 
		/// Número: 6D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_6D()
		{
			uint OperandAddress = Absolute();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M0X1_6E()
		{
			uint OperandAddress = Absolute();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 6F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_6F()
		{
			uint OperandAddress = AbsoluteLong();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 70
		/// Nombre: Branch on Overflow Set (Pv = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVS_E0M0X1_70()
		{
			Branch((_regs.Flags & 0x40) > 0);
		} // Listo

		/// <Summary> 
		/// Número: 71
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_71()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 72
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_72()
		{
			uint OperandAddress = DirectIndirect();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 73
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_73()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 74
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M0X1_74()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 75
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_75()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 76
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M0X1_76()
		{
			uint OperandAddress = DirectIndexedX_X1();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 77
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_77()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 78
		/// Nombre: Set Interrupt Disable Status
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEI_E0M0X1_78()
		{
			_regs.Flags |= 0x04;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 79
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_79()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data + Operand.Data + (_regs.Flags & 0x01));

				_regs.Accumulator.Data = (ushort)Sum;
				_regs.Flags |= (byte)(Sum >> 16);

				this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
				_regs.ProgramCounter.Data += 3;
			}
			else
			{
			}
		} // Semi Listo

		/// <Summary> 
		/// Número: 7A
		/// Nombre: Pull Index Y form Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLY_E0M0X1_7A()
		{
			PLY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 7B
		/// Nombre: Transfer Direct Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TDC_E0M0X1_7B()
		{
			TDC_M0();
		} // Listo

		/// <Summary> 
		/// Número: 7C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X1_7C()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X1();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 7D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_7D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 7E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROR_E0M0X1_7E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 7F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X1_7F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 80
		/// Nombre: Branch Always
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BRA_E0M0X1_80()
		{
			Branch(true);
		} // Listo

		/// <Summary> 
		/// Número: 81
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_81()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 82
		/// Nombre: Branch Always Long
		/// Direccionamiento: Program Counter Relative Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void BRL_E0M0X1_82()
		{
			uint OperandAddress = Immediate();

			sbyte LowByte = (sbyte)_bus.ReadByte(OperandAddress);
			sbyte HiByte = (sbyte)_bus.ReadByte(OperandAddress + 1);

			_regs.ProgramCounter.Data += 3;
			_regs.ProgramCounter.Data += (byte)((byte)LowByte + (byte)HiByte);
			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 83
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_83()
		{
			uint OperandAddress = StackRelative();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 84
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M0X1_84()
		{
			uint OperandAddress = Direct();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 85
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_85()
		{
			uint OperandAddress = Direct();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 86
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M0X1_86()
		{
			uint OperandAddress = Direct();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 87
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_87()
		{
			uint OperandAddress = DirectIndirectLong();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 88
		/// Nombre: Decrement Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEY_E0M0X1_88()
		{
			DEY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 89
		/// Nombre: Bit Test
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M0X1_89()
		{
			uint OperandAddress = Immediate();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 8A
		/// Nombre: Transfer Index X to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXA_E0M0X1_8A()
		{
			TXA_M0X1();
		} // Listo

		/// <Summary> 
		/// Número: 8B
		/// Nombre: Push Data Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHB_E0M0X1_8B()
		{
			PushByte(_regs.DataBank);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: 8C
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M0X1_8C()
		{
			uint OperandAddress = Absolute();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_8D()
		{
			uint OperandAddress = Absolute();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8E
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M0X1_8E()
		{
			uint OperandAddress = Absolute();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_8F()
		{
			uint OperandAddress = AbsoluteLong();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 90
		/// Nombre: Branch on Carry Clear (Pe = O)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCC_E0M0X1_90()
		{
			Branch((_regs.Flags & 0x01) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 91
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_91()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 92
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_92()
		{
			uint OperandAddress = DirectIndirect();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 93
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_93()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 94
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M0X1_94()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 95
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_95()
		{
			uint OperandAddress = DirectIndexedX_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 96
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M0X1_96()
		{
			uint OperandAddress = DirectIndexedY_X1();

			STX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 97
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X1_97()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 98
		/// Nombre: Transfer Index Y to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYA_E0M0X1_98()
		{
			TYA_M0X1();
		} // Listo

		/// <Summary> 
		/// Número: 99
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_99()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9A
		/// Nombre: Transfer Index X to Stack Polnter Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXS_E0M0X1_9A()
		{
			TXS_X1();
		} // Listo

		/// <Summary> 
		/// Número: 9B
		/// Nombre: Transfer Index X to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXY_E0M0X1_9B()
		{
			TXY_X1();
		} // Listo

		/// <Summary> 
		/// Número: 9C
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M0X1_9C()
		{
			uint OperandAddress = Absolute();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_9D()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9E
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M0X1_9E()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X1_9F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: A0
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X1_A0()
		{
			uint OperandAddress = Immediate();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X1_A1()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A2
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X1_A2()
		{
			uint OperandAddress = Immediate();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X1_A3()
		{
			uint OperandAddress = StackRelative();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X1_A4()
		{
			uint OperandAddress = Direct();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X1_A5()
		{
			uint OperandAddress = Direct();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X1_A6()
		{
			uint OperandAddress = Direct();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X1_A7()
		{
			uint OperandAddress = DirectIndirectLong();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A8
		/// Nombre: Transfer Accumulator to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAY_E0M0X1_A8()
		{
			TAY_M0X1();
		} // Listo

		/// <Summary> 
		/// Número: A9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X1_A9()
		{
			uint OperandAddress = Immediate();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AA
		/// Nombre: Transfer Accumulator to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAX_E0M0X1_AA()
		{
			TAX_M0X1();
		} // Listo

		/// <Summary> 
		/// Número: AB
		/// Nombre: Pull Data Bank Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLB_E0M0X1_AB()
		{
			_regs.DataBank = PullByte();

			_regs.Flags |= (byte)(_regs.DataBank & 0x80 | (_regs.DataBank > 0 ? 0x00 : 0x02));

			if ((_regs.DataBank & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.DataBank > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: AC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X1_AC()
		{
			uint OperandAddress = Absolute();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X1_AD()
		{
			uint OperandAddress = Absolute();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X1_AE()
		{
			uint OperandAddress = Absolute();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X1_AF()
		{
			uint OperandAddress = AbsoluteLong();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: B0
		/// Nombre: Branch on Carry Set (Pe = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCS_E0M0X1_B0()
		{
			Branch((_regs.Flags & 0x01) > 0);
		} // Listo

		/// <Summary> 
		/// Número: B1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M0X1_B1()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B2
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X1_B2()
		{
			uint OperandAddress = DirectIndirect();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X1_B3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X1_B4()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X1_B5()
		{
			uint OperandAddress = DirectIndexedX_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: DP Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X1_B6()
		{
			uint OperandAddress = DirectIndexedY_X1();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X1_B7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B8
		/// Nombre: Clear Overflow Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLV_E0M0X1_B8()
		{
			_regs.Flags &= 0xBF;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: B9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M0X1_B9()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BA
		/// Nombre: Transfer Stack Pointer Register to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSX_E0M0X1_BA()
		{
			TSX_X1();
		} // Listo

		/// <Summary> 
		/// Número: BB
		/// Nombre: Transfer Index Y to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYX_E0M0X1_BB()
		{
			TYX_X1();
		} // Listo

		/// <Summary> 
		/// Número: BC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X1_BC()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LDY_X1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M0X1_BD()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X1_BE()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			LDX_X1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X1_BF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: C0
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M0X1_C0()
		{
			uint OperandAddress = Immediate();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X1_C1()
		{
			uint OperandAddress = DirectIndexedIndirect_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C2
		/// Nombre: Reset Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void REP_E0M0X1_C2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags &= (byte)(~Operand);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X1_C3()
		{
			uint OperandAddress = StackRelative();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: C4
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M0X1_C4()
		{
			uint OperandAddress = Direct();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X1_C5()
		{
			uint OperandAddress = Direct();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M0X1_C6()
		{
			uint OperandAddress = Direct();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X1_C7()
		{
			uint OperandAddress = DirectIndirectLong();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C8
		/// Nombre: Increment Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INY_E0M0X1_C8()
		{
			INY_X1();
		} // Listo

		/// <Summary> 
		/// Número: C9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X1_C9()
		{
			uint OperandAddress = Immediate();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: CA
		/// Nombre: Decrement Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEX_E0M0X1_CA()
		{
			DEX_X1();
		} // Listo

		/// <Summary> 
		/// Número: CB
		/// Nombre: Wait for Interrupt
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by interrupt to restart it.
		/// </summary> 
		private void WAI_E0M0X1_CB()
		{
            _waitInterrupt = true;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: CC
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M0X1_CC()
		{
			uint OperandAddress = Absolute();

			CPY_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X1_CD()
		{
			uint OperandAddress = Absolute();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M0X1_CE()
		{
			uint OperandAddress = Absolute();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X1_CF()
		{
			uint OperandAddress = AbsoluteLong();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: D0
		/// Nombre: Branch if Not Equal (Pz = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BNE_E0M0X1_D0()
		{
			Branch((_regs.Flags & 0x02) == 0);
		} // Listo

		/// <Summary> 
		/// Número: D1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M0X1_D1()
		{
			uint OperandAddress = DirectIndirectIndexed_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D2
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X1_D2()
		{
			uint OperandAddress = DirectIndirect();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X1_D3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D4
		/// Nombre: Push Effective Indirect Address on Stack (add one cycle if DL f 0)
		/// Direccionamiento: Stack (Direct Page Indirect)
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void PEI_E0M0X1_D4()
		{
		}

		/// <Summary> 
		/// Número: D5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X1_D5()
		{
			uint OperandAddress = DirectIndexedX_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M0X1_D6()
		{
			uint OperandAddress = DirectIndexedX_X1();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X1_D7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D8
		/// Nombre: Clear Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLD_E0M0X1_D8()
		{
			_regs.Flags &= 0xF7;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: D9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M0X1_D9()
		{
			uint OperandAddress = AbsoluteIndexedY_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DA
		/// Nombre: Push Index X on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHX_E0M0X1_DA()
		{
			PHX_X1();
		} // Listo

		/// <Summary> 
		/// Número: DB
		/// Nombre: Stop the Clock
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by reset to restart 
		/// </summary> 
		private void STP_E0M0X1_DB()
		{
		}

		/// <Summary> 
		/// Número: DC
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X1_DC()
		{
			uint OperandAddress = AbsoluteIndirectLong();

			_regs.ProgramCounter.Low = _bus.ReadByte(OperandAddress);
			_regs.ProgramCounter.High = _bus.ReadByte(OperandAddress + 1);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: DD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M0X1_DD()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void DEC_E0M0X1_DE()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X1_DF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X1();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: E0
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M0X1_E0()
		{
			uint OperandAddress = Immediate();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: E1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_E1()
		{
		}

		/// <Summary> 
		/// Número: E2
		/// Nombre: Set Processor Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void SEP_E0M0X1_E2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags |= Operand;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_E3()
		{
		}

		/// <Summary> 
		/// Número: E4
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M0X1_E4()
		{
			uint OperandAddress = Direct();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_E5()
		{
		}

		/// <Summary> 
		/// Número: E6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M0X1_E6()
		{
			uint OperandAddress = Direct();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_E7()
		{
		}

		/// <Summary> 
		/// Número: E8
		/// Nombre: Increment Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INX_E0M0X1_E8()
		{
			INX_X1();
		} // Listo

		/// <Summary> 
		/// Número: E9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// </summary> 
		private void SBC_E0M0X1_E9()
		{
		}

		/// <Summary> 
		/// Número: EA
		/// Nombre: No Operation
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void NOP_E0M0X1_EA()
		{
			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: EB
		/// Nombre: Exchange AH and AL
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void XBA_E0M0X1_EB()
		{
			byte temp = _regs.Accumulator.High;
			_regs.Accumulator.High = _regs.Accumulator.Low;
			_regs.Accumulator.Low = temp;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: EC
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M0X1_EC()
		{
			uint OperandAddress = Absolute();

			CPX_X1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: ED
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_ED()
		{
		}

		/// <Summary> 
		/// Número: EE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M0X1_EE()
		{
			uint OperandAddress = Absolute();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: EF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_EF()
		{
		}

		/// <Summary> 
		/// Número: F0
		/// Nombre: Branch if Equal (Pz = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BEQ_E0M0X1_F0()
		{
			Branch((_regs.Flags & 0x02) > 0);
		} // Listo

		/// <Summary> 
		/// Número: F1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_F1()
		{
		}

		/// <Summary> 
		/// Número: F2
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_F2()
		{
		}

		/// <Summary> 
		/// Número: F3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_F3()
		{
		}

		/// <Summary> 
		/// Número: F4
		/// Nombre: Push Effective Absolute Address on Stack (or Push Immediate Data on Stack)
		/// Direccionamiento: Stack (Absolute)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PEA_E0M0X1_F4()
		{
		}

		/// <Summary> 
		/// Número: F5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_F5()
		{
		}

		/// <Summary> 
		/// Número: F6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M0X1_F6()
		{
			uint OperandAddress = DirectIndexedX_X1();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: F7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_F7()
		{
		}

		/// <Summary> 
		/// Número: F8
		/// Nombre: Set Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SED_E0M0X1_F8()
		{
			_regs.Flags |= 0x08;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: F9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_F9()
		{
		}

		/// <Summary> 
		/// Número: FA
		/// Nombre: Pull Index X from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLX_E0M0X1_FA()
		{
			PLX_X1();
		} // Listo

		/// <Summary> 
		/// Número: FB
		/// Nombre: Exchange Carry and Emulation Bits
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void XCE_E0M0X1_FB()
		{
			uint EMode = _regs.EmulatorMode;

			_regs.EmulatorMode = (uint)(_regs.Flags & 0x00000001);
			_regs.Flags |= (byte)(EMode);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: FC
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M0X1_FC()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X1();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: FD
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_FD()
		{
		}

		/// <Summary> 
		/// Número: FE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void INC_E0M0X1_FE()
		{
			uint OperandAddress = AbsoluteIndexedX_X1();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: FF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X1_FF()
		{
		}

		#endregion

		#region Opcodes E0M1X0

		/// <Summary> 
		/// Número: 00
		/// Nombre: Force Break
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void BRK_E0M1X0_00()
		{
			BRK_E0();
		} // Listo

		/// <Summary> 
		/// Número: 01
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X0_01()
		{
			ORA_M1(DirectIndexedIndirect_X0());

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 02
		/// Nombre: Coprocessor
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void COP_E0M1X0_02()
		{
			COP_E0();
		} // Listo

		/// <Summary> 
		/// Número: 03
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X0_03()
		{
			uint OperandAddress = StackRelative();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 04
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M1X0_04()
		{
			TSB_M1(Direct());

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 05
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X0_05()
		{
			uint OperandAddress = Direct();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (4 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <summary> 
		/// Número: 06
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M1X0_06()
		{
			uint OperandAddress = Direct();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 07
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X0_07()
		{
			uint OperandAddress = DirectIndirectLong();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 08
		/// Nombre: Push Processor Status on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHP_E0M1X0_08()
		{
			PHP();
		} // Listo

		/// <Summary> 
		/// Número: 09
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X0_09()
		{
			uint OperandAddress = Immediate();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 0A
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ASL_E0M1X0_0A()
		{
			ASL_M1();
		} // Listo

		/// <Summary> 
		/// Número: 0B
		/// Nombre: Push Direct Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PHD_E0M1X0_0B()
		{
			PHD();
		} // Listo

		/// <Summary> 
		/// Número: 0C
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M1X0_0C()
		{
			uint OperandAddress = Absolute();

			TSB_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X0_0D()
		{
			uint OperandAddress = Absolute();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M1X0_0E()
		{
			uint OperandAddress = Absolute();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X0_0F()
		{
			uint OperandAddress = AbsoluteLong();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 10
		/// Nombre: Branch if Result Plus (PN = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BPL_E0M1X0_10()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 11
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M1X0_11()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 12
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X0_12()
		{
			uint OperandAddress = DirectIndirect();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 13
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X0_13()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 14
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M1X0_14()
		{
			uint OperandAddress = Direct();

			TRB_M1(OperandAddress);

			this.CurrentOpCycles = 7 + (_regs.DirectPage.Low > 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 15
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X0_15()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(5 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 16
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M1X0_16()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 17
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M1X0_17()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (byte)(7 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 18
		/// Nombre: Clear Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLC_E0M1X0_18()
		{
			CLC();
		} // Listo

		/// <Summary> 
		/// Número: 19
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M1X0_19()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1A
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Accumulator (INA)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M1X0_1A()
		{
			INA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 1B
		/// Nombre: Transfer Accumulator to Stack Pointer Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCS_E0M1X0_1B()
		{
			TCS_M1();
		} // Listo

		/// <Summary> 
		/// Número: 1C
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M1X0_1C()
		{
			uint OperandAddress = Absolute();

			TRB_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M1X0_1D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ASL_E0M1X0_1E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ASL_M1(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M1X0_1F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			ORA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 20
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M1X0_20()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		}  // Listo

		/// <Summary> 
		/// Número: 21
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X0_21()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 22
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M1X0_22()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data += 4;

			PushByte(_regs.ProgramBank);
			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: 23
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_23()
		{
			uint OperandAddress = StackRelative();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 24
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M1X0_24()
		{
			uint OperandAddress = Direct();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 4 + (_regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 25
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X0_25()
		{
			uint OperandAddress = Direct();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 26
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M1X0_26()
		{
			uint OperandAddress = Direct();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 27
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X0_27()
		{
			uint OperandAddress = DirectIndirectLong();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 28
		/// Nombre: Pull Processor Status from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLP_E0M1X0_28()
		{
			PLP();
		} // Listo

		/// <Summary> 
		/// Número: 29
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_29()
		{
			uint OperandAddress = Immediate();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 2A
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROL_E0M1X0_2A()
		{
			ROL_M1();
		} // Listo

		/// <Summary> 
		/// Número: 2B
		/// Nombre: Pull Direct Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PLD_E0M1X0_2B()
		{
			PLD();
		} // Listo

		/// <Summary> 
		/// Número: 2C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M1X0_2C()
		{
			uint OperandAddress = Direct();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_2D()
		{
			uint OperandAddress = Absolute();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M1X0_2E()
		{
			uint OperandAddress = Absolute();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_2F()
		{
			uint OperandAddress = AbsoluteLong();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 30
		/// Nombre: Branch if Result Minus (PN = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BMI_E0M1X0_30()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 31
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M1X0_31()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 32
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_32()
		{
			uint OperandAddress = DirectIndirect();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 33
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_33()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 34
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M1X0_34()
		{
			uint OperandAddress = DirectIndexedX_X0();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 35
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X0_35()
		{
			uint OperandAddress = DirectIndexedX_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 36
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M1X0_36()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 37
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M1X0_37()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 38
		/// Nombre: Set Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEC_E0M1X0_38()
		{
			SEC();
		} // Listo

		/// <Summary> 
		/// Número: 39
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M1X0_39()
		{
			uint OperandAddress = Direct();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3A
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEC_E0M1X0_3A()
		{
			DEA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 3B
		/// Nombre: Transfer Stack Pointer Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSC_E0M1X0_3B()
		{
			TSC_M1();
		} // Listo

		/// <Summary> 
		/// Número: 3C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void BIT_E0M1X0_3C()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0 + ((OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M1X0_3D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROL_E0M1X0_3E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ROL_M1(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M1X0_3F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			AND_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 40
		/// Nombre: Return from Interrupt
		/// Direccionamiento: Stack/RTI
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void RTI_E0M1X0_40()
		{
			RTI();

			this.CurrentOpCycles = 7;
		} // Listo

		/// <Summary> 
		/// Número: 41
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X0_41()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 42
		/// Nombre: Unknown/Reserved Opcode
		/// Direccionamiento: 2|16
		/// Tamaño en bytes: |
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// </summary> 
		private void WDM_E0M1X0_42()
		{
			NOP_E0M1X0_EA();
		} // Listo

		/// <Summary> 
		/// Número: 43
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X0_43()
		{
			uint OperandAddress = StackRelative();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 44
		/// Nombre: Block Move Positive
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVP_E0M1X0_44()
		{
		}

		/// <Summary> 
		/// Número: 45
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X0_45()
		{
			uint OperandAddress = Direct();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 46
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M1X0_46()
		{
			uint OperandAddress = Direct();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low > 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 47
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X0_47()
		{
			uint OperandAddress = DirectIndirectLong();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 48
		/// Nombre: Push Accumulator on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PHA_E0M1X0_48()
		{
			PHA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 49
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X0_49()
		{
			uint OperandAddress = Immediate();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 4A
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void LSR_E0M1X0_4A()
		{
			LSR_M1();
		}  // Listo

		/// <Summary> 
		/// Número: 4B
		/// Nombre: Push Program Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHK_E0M1X0_4B()
		{
			PHK();
		} // Listo

		/// <Summary> 
		/// Número: 4C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X0_4C()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 4D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X0_4D()
		{
			uint OperandAddress = Absolute();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M1X0_4E()
		{
			uint OperandAddress = Absolute();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X0_4F()
		{
			uint OperandAddress = AbsoluteLong();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		}  // Listo

		/// <Summary> 
		/// Número: 50
		/// Nombre: Branch on Overflow Clear (Pv = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVC_E0M1X0_50()
		{
			Branch((_regs.Flags & 0x40) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 51
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M1X0_51()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 52
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X0_52()
		{
			uint OperandAddress = DirectIndirect();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 53
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X0_53()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 54
		/// Nombre: Block Move Negative
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVN_E0M1X0_54()
		{
		}

		/// <Summary> 
		/// Número: 55
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X0_55()
		{
			uint OperandAddress = DirectIndexedX_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 56
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M1X0_56()
		{
			uint OperandAddress = DirectIndexedX_X0();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 8 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 57
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M1X0_57()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 58
		/// Nombre: Clear Interrupt Disable Bit
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLI_E0M1X0_58()
		{
			_regs.Flags &= 0xFB;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 59
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M1X0_59()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5A
		/// Nombre: Push index Y on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHY_E0M1X0_5A()
		{
			PHY_X0();
		}  // Listo

		/// <Summary> 
		/// Número: 5B
		/// Nombre: Transfer Accumulator to Direct Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCD_E0M1X0_5B()
		{
			TCD_M1();
		}  // Listo

		/// <Summary> 
		/// Número: 5C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X0_5C()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 4;
		}  // Listo

		/// <Summary> 
		/// Número: 5D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M1X0_5D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: 5E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void LSR_E0M1X0_5E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			LSR_M1(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M1X0_5F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			EOR_M1(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 60
		/// Nombre: Return from Subroutine
		/// Direccionamiento: Stack (RTS)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTS_E0M1X0_60()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 61
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_61()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 62
		/// Nombre: Push Effective Program Counter Relative Address on Stack
		/// Direccionamiento: Stack (PC Relative Long)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void PER_E0M1X0_62()
		{
		}

		/// <Summary> 
		/// Número: 63
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_63()
		{
			uint OperandAddress = StackRelative();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 64
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M1X0_64()
		{
			uint OperandAddress = Direct();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 65
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_65()
		{
			uint OperandAddress = Direct();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 66
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M1X0_66()
		{
			uint OperandAddress = Direct();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 67
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_67()
		{
			uint OperandAddress = DirectIndirectLong();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 68
		/// Nombre: Pull Accumulator from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PLA_E0M1X0_68()
		{
			PLA_M1();
		} // Listo

		/// <Summary> 
		/// Número: 69
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_69()
		{
			uint OperandAddress = Immediate();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6A
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROR_E0M1X0_6A()
		{
			ROR_M1();
		} // Listo

		/// <Summary> 
		/// Número: 6B
		/// Nombre: Return from Subroutine Long
		/// Direccionamiento: Stack (RTL)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTL_E0M1X0_6B()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();
			_regs.ProgramBank = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 6C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if CPU is 65C02.
		/// - 6502: if low byte of operand is $FF (ie. operand is $xxFF): yields incorrect result.
		/// </summary> 
		private void JMP_E0M1X0_6C()
		{
			uint OperandAddress = AbsoluteIndirect();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 5;
		} // Listo

		/// <Summary> 
		/// Número: 6D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_6D()
		{
			uint OperandAddress = Absolute();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M1X0_6E()
		{
			uint OperandAddress = Absolute();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 6F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_6F()
		{
			uint OperandAddress = AbsoluteLong();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 70
		/// Nombre: Branch on Overflow Set (Pv = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVS_E0M1X0_70()
		{
			Branch((_regs.Flags & 0x40) > 0);
		} // Listo

		/// <Summary> 
		/// Número: 71
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_71()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 72
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_72()
		{
			uint OperandAddress = DirectIndirect();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 73
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_73()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 74
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M1X0_74()
		{
			uint OperandAddress = DirectIndexedX_X0();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 75
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_75()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 76
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M1X0_76()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 77
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_77()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 78
		/// Nombre: Set Interrupt Disable Status
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEI_E0M1X0_78()
		{
			_regs.Flags |= 0x04;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 79
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_79()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data + Operand.Data + (_regs.Flags & 0x01));

				_regs.Accumulator.Data = (ushort)Sum;
				_regs.Flags |= (byte)(Sum >> 16);

				this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
				_regs.ProgramCounter.Data += 3;
			}
			else
			{
			}
		} // Semi Listo

		/// <Summary> 
		/// Número: 7A
		/// Nombre: Pull Index Y form Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLY_E0M1X0_7A()
		{
			PLY_X0();
		} // Listo

		/// <Summary> 
		/// Número: 7B
		/// Nombre: Transfer Direct Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TDC_E0M1X0_7B()
		{
			TDC_M1();
		} // Listo

		/// <Summary> 
		/// Número: 7C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X0_7C()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X0();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 7D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_7D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 7E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROR_E0M1X0_7E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ROR_M1(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 7F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M1X0_7F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			ADC_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 80
		/// Nombre: Branch Always
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BRA_E0M1X0_80()
		{
			Branch(true);
		} // Listo

		/// <Summary> 
		/// Número: 81
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_81()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 82
		/// Nombre: Branch Always Long
		/// Direccionamiento: Program Counter Relative Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void BRL_E0M1X0_82()
		{
			uint OperandAddress = Immediate();

			sbyte LowByte = (sbyte)_bus.ReadByte(OperandAddress);
			sbyte HiByte = (sbyte)_bus.ReadByte(OperandAddress + 1);

			_regs.ProgramCounter.Data += 3;
			_regs.ProgramCounter.Data += (byte)((byte)LowByte + (byte)HiByte);
			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 83
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_83()
		{
			uint OperandAddress = StackRelative();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 84
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M1X0_84()
		{
			uint OperandAddress = Direct();

			STY_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 85
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_85()
		{
			uint OperandAddress = Direct();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 86
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M1X0_86()
		{
			uint OperandAddress = Direct();

			STX_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 87
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_87()
		{
			uint OperandAddress = DirectIndirectLong();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 88
		/// Nombre: Decrement Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEY_E0M1X0_88()
		{
			DEY_X0();
		} // Listo

		/// <Summary> 
		/// Número: 89
		/// Nombre: Bit Test
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M1X0_89()
		{
			uint OperandAddress = Immediate();

			BIT_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 8A
		/// Nombre: Transfer Index X to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXA_E0M1X0_8A()
		{
			TXA_M1X0();
		} // Listo

		/// <Summary> 
		/// Número: 8B
		/// Nombre: Push Data Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHB_E0M1X0_8B()
		{
			PushByte(_regs.DataBank);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: 8C
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M1X0_8C()
		{
			uint OperandAddress = Absolute();

			STY_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_8D()
		{
			uint OperandAddress = Absolute();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8E
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M1X0_8E()
		{
			uint OperandAddress = Absolute();

			STX_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_8F()
		{
			uint OperandAddress = AbsoluteLong();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 90
		/// Nombre: Branch on Carry Clear (Pe = O)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCC_E0M1X0_90()
		{
			Branch((_regs.Flags & 0x01) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 91
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_91()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 92
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_92()
		{
			uint OperandAddress = DirectIndirect();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 93
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_93()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 94
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M1X0_94()
		{
			uint OperandAddress = DirectIndexedX_X0();

			STY_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 95
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_95()
		{
			uint OperandAddress = DirectIndexedX_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 96
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M1X0_96()
		{
			uint OperandAddress = DirectIndexedY_X0();

			STX_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 97
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M1X0_97()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 98
		/// Nombre: Transfer Index Y to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYA_E0M1X0_98()
		{
			TYA_M1X0();
		} // Listo

		/// <Summary> 
		/// Número: 99
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_99()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9A
		/// Nombre: Transfer Index X to Stack Polnter Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXS_E0M1X0_9A()
		{
			TXS_X0();
		} // Listo

		/// <Summary> 
		/// Número: 9B
		/// Nombre: Transfer Index X to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXY_E0M1X0_9B()
		{
			TXY_X0();
		} // Listo

		/// <Summary> 
		/// Número: 9C
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M1X0_9C()
		{
			uint OperandAddress = Absolute();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_9D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9E
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M1X0_9E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			STZ_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M1X0_9F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			STA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: A0
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X0_A0()
		{
			uint OperandAddress = Immediate();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: A1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X0_A1()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A2
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X0_A2()
		{
			uint OperandAddress = Immediate();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: A3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X0_A3()
		{
			uint OperandAddress = StackRelative();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X0_A4()
		{
			uint OperandAddress = Direct();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X0_A5()
		{
			uint OperandAddress = Direct();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X0_A6()
		{
			uint OperandAddress = Direct();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X0_A7()
		{
			uint OperandAddress = DirectIndirectLong();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A8
		/// Nombre: Transfer Accumulator to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAY_E0M1X0_A8()
		{
			TAY_M1X0();
		} // Listo

		/// <Summary> 
		/// Número: A9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X0_A9()
		{
			uint OperandAddress = Immediate();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: AA
		/// Nombre: Transfer Accumulator to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAX_E0M1X0_AA()
		{
			TAX_M1X0();
		} // Listo

		/// <Summary> 
		/// Número: AB
		/// Nombre: Pull Data Bank Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLB_E0M1X0_AB()
		{
			_regs.DataBank = PullByte();

			_regs.Flags |= (byte)(_regs.DataBank & 0x80 | (_regs.DataBank > 0 ? 0x00 : 0x02));

			if ((_regs.DataBank & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.DataBank > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: AC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X0_AC()
		{
			uint OperandAddress = Absolute();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X0_AD()
		{
			uint OperandAddress = Absolute();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X0_AE()
		{
			uint OperandAddress = Absolute();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X0_AF()
		{
			uint OperandAddress = AbsoluteLong();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: B0
		/// Nombre: Branch on Carry Set (Pe = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCS_E0M1X0_B0()
		{
			Branch((_regs.Flags & 0x01) > 0);
		} // Listo

		/// <Summary> 
		/// Número: B1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M1X0_B1()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B2
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X0_B2()
		{
			uint OperandAddress = DirectIndirect();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X0_B3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X0_B4()
		{
			uint OperandAddress = DirectIndexedX_X0();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X0_B5()
		{
			uint OperandAddress = DirectIndexedX_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: DP Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X0_B6()
		{
			uint OperandAddress = DirectIndexedY_X0();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M1X0_B7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B8
		/// Nombre: Clear Overflow Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLV_E0M1X0_B8()
		{
			_regs.Flags &= 0xBF;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: B9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M1X0_B9()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BA
		/// Nombre: Transfer Stack Pointer Register to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSX_E0M1X0_BA()
		{
			TSX_X0();
		} // Listo

		/// <Summary> 
		/// Número: BB
		/// Nombre: Transfer Index Y to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYX_E0M1X0_BB()
		{
			TYX_X0();
		} // Listo

		/// <Summary> 
		/// Número: BC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M1X0_BC()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M1X0_BD()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M1X0_BE()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M1X0_BF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			LDA_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: C0
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M1X0_C0()
		{
			uint OperandAddress = Immediate();

			CPY_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: C1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X0_C1()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C2
		/// Nombre: Reset Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void REP_E0M1X0_C2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags &= (byte)(~Operand);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X0_C3()
		{
			uint OperandAddress = StackRelative();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: C4
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M1X0_C4()
		{
			uint OperandAddress = Direct();

			CPY_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X0_C5()
		{
			uint OperandAddress = Direct();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M1X0_C6()
		{
			uint OperandAddress = Direct();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X0_C7()
		{
			uint OperandAddress = DirectIndirectLong();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C8
		/// Nombre: Increment Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INY_E0M1X0_C8()
		{
			INY_X0();
		} // Listo

		/// <Summary> 
		/// Número: C9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X0_C9()
		{
			uint OperandAddress = Immediate();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: CA
		/// Nombre: Decrement Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEX_E0M1X0_CA()
		{
			DEX_X0();
		} // Listo

		/// <Summary> 
		/// Número: CB
		/// Nombre: Wait for Interrupt
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by interrupt to restart it.
		/// </summary> 
		private void WAI_E0M1X0_CB()
		{
            _waitInterrupt = true;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: CC
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M1X0_CC()
		{
			uint OperandAddress = Absolute();

			CPY_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X0_CD()
		{
			uint OperandAddress = Absolute();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M1X0_CE()
		{
			uint OperandAddress = Absolute();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X0_CF()
		{
			uint OperandAddress = AbsoluteLong();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: D0
		/// Nombre: Branch if Not Equal (Pz = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BNE_E0M1X0_D0()
		{
			Branch((_regs.Flags & 0x02) == 0);
		} // Listo

		/// <Summary> 
		/// Número: D1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M1X0_D1()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D2
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X0_D2()
		{
			uint OperandAddress = DirectIndirect();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X0_D3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D4
		/// Nombre: Push Effective Indirect Address on Stack (add one cycle if DL f 0)
		/// Direccionamiento: Stack (Direct Page Indirect)
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void PEI_E0M1X0_D4()
		{
		}

		/// <Summary> 
		/// Número: D5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X0_D5()
		{
			uint OperandAddress = DirectIndexedX_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M1X0_D6()
		{
			uint OperandAddress = DirectIndexedX_X0();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M1X0_D7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D8
		/// Nombre: Clear Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLD_E0M1X0_D8()
		{
			_regs.Flags &= 0xF7;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: D9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M1X0_D9()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DA
		/// Nombre: Push Index X on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHX_E0M1X0_DA()
		{
			PHX_X0();
		} // Listo

		/// <Summary> 
		/// Número: DB
		/// Nombre: Stop the Clock
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by reset to restart 
		/// </summary> 
		private void STP_E0M1X0_DB()
		{
		}

		/// <Summary> 
		/// Número: DC
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M1X0_DC()
		{
			uint OperandAddress = AbsoluteIndirectLong();

			_regs.ProgramCounter.Low = _bus.ReadByte(OperandAddress);
			_regs.ProgramCounter.High = _bus.ReadByte(OperandAddress + 1);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: DD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M1X0_DD()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void DEC_E0M1X0_DE()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			DEC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M1X0_DF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			CMP_M1(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: E0
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M1X0_E0()
		{
			uint OperandAddress = Immediate();

			CPX_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo 

		/// <Summary> 
		/// Número: E1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_E1()
		{
		}

		/// <Summary> 
		/// Número: E2
		/// Nombre: Set Processor Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void SEP_E0M1X0_E2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags |= Operand;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_E3()
		{
		}

		/// <Summary> 
		/// Número: E4
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M1X0_E4()
		{
			uint OperandAddress = Direct();

			CPX_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_E5()
		{
		}

		/// <Summary> 
		/// Número: E6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M1X0_E6()
		{
			uint OperandAddress = Direct();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_E7()
		{
		}

		/// <Summary> 
		/// Número: E8
		/// Nombre: Increment Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INX_E0M1X0_E8()
		{
			INX_X0();
		} // Listo

		/// <Summary> 
		/// Número: E9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// </summary> 
		private void SBC_E0M1X0_E9()
		{
            uint OperandAddress = DirectIndexedIndirect_X0();

            SBC_M1(OperandAddress);

            this.CurrentOpCycles = 2;
            _regs.ProgramCounter.Data += 2;
		}

		/// <Summary> 
		/// Número: EA
		/// Nombre: No Operation
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void NOP_E0M1X0_EA()
		{
			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: EB
		/// Nombre: Exchange AH and AL
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void XBA_E0M1X0_EB()
		{
			byte temp = _regs.Accumulator.High;
			_regs.Accumulator.High = _regs.Accumulator.Low;
			_regs.Accumulator.Low = temp;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: EC
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M1X0_EC()
		{
			uint OperandAddress = Absolute();

			CPX_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: ED
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_ED()
		{
		}

		/// <Summary> 
		/// Número: EE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M1X0_EE()
		{
			uint OperandAddress = Absolute();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: EF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_EF()
		{
		}

		/// <Summary> 
		/// Número: F0
		/// Nombre: Branch if Equal (Pz = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BEQ_E0M1X0_F0()
		{
			Branch((_regs.Flags & 0x02) > 0);
		} // Listo

		/// <Summary> 
		/// Número: F1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_F1()
		{
		}

		/// <Summary> 
		/// Número: F2
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_F2()
		{
		}

		/// <Summary> 
		/// Número: F3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_F3()
		{
		}

		/// <Summary> 
		/// Número: F4
		/// Nombre: Push Effective Absolute Address on Stack (or Push Immediate Data on Stack)
		/// Direccionamiento: Stack (Absolute)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PEA_E0M1X0_F4()
		{
		}

		/// <Summary> 
		/// Número: F5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_F5()
		{
		}

		/// <Summary> 
		/// Número: F6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M1X0_F6()
		{
			uint OperandAddress = DirectIndexedX_X0();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: F7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_F7()
		{
		}

		/// <Summary> 
		/// Número: F8
		/// Nombre: Set Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SED_E0M1X0_F8()
		{
			_regs.Flags |= 0x08;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: F9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_F9()
		{
		}

		/// <Summary> 
		/// Número: FA
		/// Nombre: Pull Index X from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLX_E0M1X0_FA()
		{
			PLX_X0();
		} // Listo

		/// <Summary> 
		/// Número: FB
		/// Nombre: Exchange Carry and Emulation Bits
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void XCE_E0M1X0_FB()
		{
			uint EMode = _regs.EmulatorMode;

			_regs.EmulatorMode = (uint)(_regs.Flags & 0x00000001);
			_regs.Flags |= (byte)(EMode);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: FC
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M1X0_FC()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X0();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: FD
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_FD()
		{
		}

		/// <Summary> 
		/// Número: FE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void INC_E0M1X0_FE()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			INC_M1(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: FF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M1X0_FF()
		{
		}

		#endregion

		#region Opcodes E0M0X0

		/// <Summary> 
		/// Número: 00
		/// Nombre: Force Break
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void BRK_E0M0X0_00()
		{
			BRK_E0();
		} // Listo

		/// <Summary> 
		/// Número: 01
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X0_01()
		{
			ORA_M0(DirectIndexedIndirect_X0());

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 02
		/// Nombre: Coprocessor
		/// Direccionamiento: Stack/Interrupt
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Opcode is 1 byte, but program counter value pushed onto stack is incremented by 2 allowing for optional signature byte.
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void COP_E0M0X0_02()
		{
			COP_E0();
		} // Listo

		/// <Summary> 
		/// Número: 03
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X0_03()
		{
			uint OperandAddress = StackRelative();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 04
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M0X0_04()
		{
			TSB_M0(Direct());

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 05
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X0_05()
		{
			uint OperandAddress = Direct();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (4 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <summary> 
		/// Número: 06
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M0X0_06()
		{
			uint OperandAddress = Direct();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low != 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 07
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X0_07()
		{
			uint OperandAddress = DirectIndirectLong();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 08
		/// Nombre: Push Processor Status on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHP_E0M0X0_08()
		{
			PHP();
		} // Listo

		/// <Summary> 
		/// Número: 09
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X0_09()
		{
			uint OperandAddress = Immediate();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 0A
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ASL_E0M0X0_0A()
		{
			ASL_M0();
		} // Listo

		/// <Summary> 
		/// Número: 0B
		/// Nombre: Push Direct Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PHD_E0M0X0_0B()
		{
			PHD();
		} // Listo

		/// <Summary> 
		/// Número: 0C
		/// Nombre: Test and Set Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TSB_E0M0X0_0C()
		{
			uint OperandAddress = Absolute();

			TSB_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X0_0D()
		{
			uint OperandAddress = Absolute();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M0X0_0E()
		{
			uint OperandAddress = Absolute();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 0F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X0_0F()
		{
			uint OperandAddress = AbsoluteLong();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 10
		/// Nombre: Branch if Result Plus (PN = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BPL_E0M0X0_10()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 11
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M0X0_11()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 12
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X0_12()
		{
			uint OperandAddress = DirectIndirect();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(6 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 13
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X0_13()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 14
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M0X0_14()
		{
			uint OperandAddress = Direct();

			TRB_M0(OperandAddress);

			this.CurrentOpCycles = 7 + (_regs.DirectPage.Low > 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 15
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X0_15()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(5 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 16
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ASL_E0M0X0_16()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 17
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void ORA_E0M0X0_17()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (byte)(7 + _regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 18
		/// Nombre: Clear Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLC_E0M0X0_18()
		{
			CLC();
		} // Listo

		/// <Summary> 
		/// Número: 19
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M0X0_19()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1A
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Accumulator (INA)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M0X0_1A()
		{
			INA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 1B
		/// Nombre: Transfer Accumulator to Stack Pointer Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCS_E0M0X0_1B()
		{
			TCS_M0();
		} // Listo

		/// <Summary> 
		/// Número: 1C
		/// Nombre: Test and Reset Bit
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void TRB_E0M0X0_1C()
		{
			uint OperandAddress = Absolute();

			TRB_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1D
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void ORA_E0M0X0_1D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1E
		/// Nombre: Shift One Bit Left, Memory or Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ASL_E0M0X0_1E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ASL_M0(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 1F
		/// Nombre: "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ORA_E0M0X0_1F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			ORA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 20
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M0X0_20()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		}  // Listo

		/// <Summary> 
		/// Número: 21
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X0_21()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 22
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M0X0_22()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data += 4;

			PushByte(_regs.ProgramBank);
			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: 23
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_23()
		{
			uint OperandAddress = StackRelative();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: 24
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M0X0_24()
		{
			uint OperandAddress = Direct();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 4 + (_regs.DirectPage.Low != 0 ? 1 : 0);
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 25
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X0_25()
		{
			uint OperandAddress = Direct();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 26
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M0X0_26()
		{
			uint OperandAddress = Direct();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 27
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X0_27()
		{
			uint OperandAddress = DirectIndirectLong();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 28
		/// Nombre: Pull Processor Status from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLP_E0M0X0_28()
		{
			PLP();
		} // Listo

		/// <Summary> 
		/// Número: 29
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_29()
		{
			uint OperandAddress = Immediate();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 2A
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROL_E0M0X0_2A()
		{
			ROL_M0();
		} // Listo

		/// <Summary> 
		/// Número: 2B
		/// Nombre: Pull Direct Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PLD_E0M0X0_2B()
		{
			PLD();
		} // Listo

		/// <Summary> 
		/// Número: 2C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M0X0_2C()
		{
			uint OperandAddress = Direct();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_2D()
		{
			uint OperandAddress = Absolute();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M0X0_2E()
		{
			uint OperandAddress = Absolute();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 2F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_2F()
		{
			uint OperandAddress = AbsoluteLong();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 30
		/// Nombre: Branch if Result Minus (PN = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BMI_E0M0X0_30()
		{
			Branch((_regs.Flags & 0x80) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 31
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M0X0_31()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 32
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_32()
		{
			uint OperandAddress = DirectIndirect();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 33
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_33()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 34
		/// Nombre: Bit Test
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void BIT_E0M0X0_34()
		{
			uint OperandAddress = DirectIndexedX_X0();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 35
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X0_35()
		{
			uint OperandAddress = DirectIndexedX_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 36
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROL_E0M0X0_36()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 37
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void AND_E0M0X0_37()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 38
		/// Nombre: Set Carry Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEC_E0M0X0_38()
		{
			SEC();
		} // Listo

		/// <Summary> 
		/// Número: 39
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M0X0_39()
		{
			uint OperandAddress = Direct();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3A
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEC_E0M0X0_3A()
		{
			DEA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 3B
		/// Nombre: Transfer Stack Pointer Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSC_E0M0X0_3B()
		{
			TSC_M0();
		} // Listo

		/// <Summary> 
		/// Número: 3C
		/// Nombre: Bit Test
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void BIT_E0M0X0_3C()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0 + ((OperandAddress >> 16) > _regs.DataBank ? 1 : 0);
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3D
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void AND_E0M0X0_3D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = (5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 3E
		/// Nombre: Rotate One Bit Left (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROL_E0M0X0_3E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ROL_M0(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 3F
		/// Nombre: "AND" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void AND_E0M0X0_3F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			AND_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 40
		/// Nombre: Return from Interrupt
		/// Direccionamiento: Stack/RTI
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle for 65802/65816 native mode (e=0).
		/// </summary> 
		private void RTI_E0M0X0_40()
		{
			RTI();

			this.CurrentOpCycles = 7;
		} // Listo

		/// <Summary> 
		/// Número: 41
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X0_41()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 42
		/// Nombre: Unknown/Reserved Opcode
		/// Direccionamiento: 2|16
		/// Tamaño en bytes: |
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// </summary> 
		private void WDM_E0M0X0_42()
		{
			NOP_E0M0X0_EA();
		} // Listo

		/// <Summary> 
		/// Número: 43
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X0_43()
		{
			uint OperandAddress = StackRelative();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 44
		/// Nombre: Block Move Positive
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVP_E0M0X0_44()
		{
		}

		/// <Summary> 
		/// Número: 45
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X0_45()
		{
			uint OperandAddress = Direct();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 46
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M0X0_46()
		{
			uint OperandAddress = Direct();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = (7 + _regs.DirectPage.Low > 0 ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 47
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X0_47()
		{
			uint OperandAddress = DirectIndirectLong();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 48
		/// Nombre: Push Accumulator on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PHA_E0M0X0_48()
		{
			PHA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 49
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X0_49()
		{
			uint OperandAddress = Immediate();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 2;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 4A
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void LSR_E0M0X0_4A()
		{
			LSR_M0();
		}  // Listo

		/// <Summary> 
		/// Número: 4B
		/// Nombre: Push Program Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHK_E0M0X0_4B()
		{
			PHK();
		} // Listo

		/// <Summary> 
		/// Número: 4C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X0_4C()
		{
			uint OperandAddress = Absolute();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 4D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X0_4D()
		{
			uint OperandAddress = Absolute();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M0X0_4E()
		{
			uint OperandAddress = Absolute();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 4F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X0_4F()
		{
			uint OperandAddress = AbsoluteLong();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		}  // Listo

		/// <Summary> 
		/// Número: 50
		/// Nombre: Branch on Overflow Clear (Pv = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVC_E0M0X0_50()
		{
			Branch((_regs.Flags & 0x40) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 51
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M0X0_51()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 52
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X0_52()
		{
			uint OperandAddress = DirectIndirect();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 53
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X0_53()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 8;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 54
		/// Nombre: Block Move Negative
		/// Direccionamiento: Block Move
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 
		///
		/// Notas: 
		/// - 7 cycles per byte moved.
		/// </summary> 
		private void MVN_E0M0X0_54()
		{
		}

		/// <Summary> 
		/// Número: 55
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X0_55()
		{
			uint OperandAddress = DirectIndexedX_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 56
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LSR_E0M0X0_56()
		{
			uint OperandAddress = DirectIndexedX_X0();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = 8 + ((_regs.DirectPage.Low > 0) ? 1 : 0);

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 57
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void EOR_E0M0X0_57()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 58
		/// Nombre: Clear Interrupt Disable Bit
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLI_E0M0X0_58()
		{
			_regs.Flags &= 0xFB;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 59
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M0X0_59()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5A
		/// Nombre: Push index Y on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHY_E0M0X0_5A()
		{
			PHY_X0();
		}  // Listo

		/// <Summary> 
		/// Número: 5B
		/// Nombre: Transfer Accumulator to Direct Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TCD_E0M0X0_5B()
		{
			TCD_M0();
		}  // Listo

		/// <Summary> 
		/// Número: 5C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X0_5C()
		{
			uint OperandAddress = AbsoluteLong();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 4;
		}  // Listo

		/// <Summary> 
		/// Número: 5D
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void EOR_E0M0X0_5D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: 5E
		/// Nombre: Shift One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void LSR_E0M0X0_5E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			LSR_M0(OperandAddress);

			this.CurrentOpCycles = 9;

			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 5F
		/// Nombre: Exclusive "OR" Memory with Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void EOR_E0M0X0_5F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			EOR_M0(OperandAddress);

			this.CurrentOpCycles = 6;

			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 60
		/// Nombre: Return from Subroutine
		/// Direccionamiento: Stack (RTS)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTS_E0M0X0_60()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 61
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_61()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 62
		/// Nombre: Push Effective Program Counter Relative Address on Stack
		/// Direccionamiento: Stack (PC Relative Long)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void PER_E0M0X0_62()
		{
		}

		/// <Summary> 
		/// Número: 63
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_63()
		{
			uint OperandAddress = StackRelative();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 64
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M0X0_64()
		{
			uint OperandAddress = Direct();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 65
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_65()
		{
			uint OperandAddress = Direct();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 66
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M0X0_66()
		{
			uint OperandAddress = Direct();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 67
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_67()
		{
			uint OperandAddress = DirectIndirectLong();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 68
		/// Nombre: Pull Accumulator from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void PLA_E0M0X0_68()
		{
			PLA_M0();
		} // Listo

		/// <Summary> 
		/// Número: 69
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_69()
		{
			uint OperandAddress = Immediate();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6A
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Accumulator
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void ROR_E0M0X0_6A()
		{
			ROR_M0();
		} // Listo

		/// <Summary> 
		/// Número: 6B
		/// Nombre: Return from Subroutine Long
		/// Direccionamiento: Stack (RTL)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void RTL_E0M0X0_6B()
		{
			_regs.ProgramCounter.Low = PullByte();
			_regs.ProgramCounter.High = PullByte();
			_regs.ProgramBank = PullByte();

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 6C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if CPU is 65C02.
		/// - 6502: if low byte of operand is $FF (ie. operand is $xxFF): yields incorrect result.
		/// </summary> 
		private void JMP_E0M0X0_6C()
		{
			uint OperandAddress = AbsoluteIndirect();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 5;
		} // Listo

		/// <Summary> 
		/// Número: 6D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_6D()
		{
			uint OperandAddress = Absolute();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 6E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M0X0_6E()
		{
			uint OperandAddress = Absolute();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 6F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_6F()
		{
			uint OperandAddress = AbsoluteLong();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 70
		/// Nombre: Branch on Overflow Set (Pv = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BVS_E0M0X0_70()
		{
			Branch((_regs.Flags & 0x40) > 0);
		} // Listo

		/// <Summary> 
		/// Número: 71
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_71()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 72
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_72()
		{
			uint OperandAddress = DirectIndirect();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low != 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 73
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_73()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 74
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STZ_E0M0X0_74()
		{
			uint OperandAddress = DirectIndexedX_X0();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 75
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_75()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 76
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void ROR_E0M0X0_76()
		{
			uint OperandAddress = DirectIndexedX_X0();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 77
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_77()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low != 0 ? 1 : 0;

			_regs.ProgramCounter.Data += 2;
		} // Semi Listo

		/// <Summary> 
		/// Número: 78
		/// Nombre: Set Interrupt Disable Status
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SEI_E0M0X0_78()
		{
			_regs.Flags |= 0x04;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: 79
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_79()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			Word Operand = new Word();

			Operand.Low = _bus.ReadByte(OperandAddress);
			Operand.High = _bus.ReadByte(OperandAddress + 1);

			if ((_regs.Flags & 0x04) == 0)
			{
				uint Sum = (uint)(_regs.Accumulator.Data + Operand.Data + (_regs.Flags & 0x01));

				_regs.Accumulator.Data = (ushort)Sum;
				_regs.Flags |= (byte)(Sum >> 16);

				this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
				_regs.ProgramCounter.Data += 3;
			}
			else
			{
			}
		} // Semi Listo

		/// <Summary> 
		/// Número: 7A
		/// Nombre: Pull Index Y form Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLY_E0M0X0_7A()
		{
			PLY_X0();
		} // Listo

		/// <Summary> 
		/// Número: 7B
		/// Nombre: Transfer Direct Register to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TDC_E0M0X0_7B()
		{
			TDC_M0();
		} // Listo

		/// <Summary> 
		/// Número: 7C
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X0_7C()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X0();

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: 7D
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_7D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Semi Listo

		/// <Summary> 
		/// Número: 7E
		/// Nombre: Rotate One Bit Right (Memory or Accumulator)
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void ROR_E0M0X0_7E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			ROR_M0(OperandAddress);

			this.CurrentOpCycles = 9;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 7F
		/// Nombre: Add Memory to Accumulator with Carry
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void ADC_E0M0X0_7F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			ADC_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Semi Listo

		/// <Summary> 
		/// Número: 80
		/// Nombre: Branch Always
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BRA_E0M0X0_80()
		{
			Branch(true);
		} // Listo

		/// <Summary> 
		/// Número: 81
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_81()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 82
		/// Nombre: Branch Always Long
		/// Direccionamiento: Program Counter Relative Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void BRL_E0M0X0_82()
		{
			uint OperandAddress = Immediate();

			sbyte LowByte = (sbyte)_bus.ReadByte(OperandAddress);
			sbyte HiByte = (sbyte)_bus.ReadByte(OperandAddress + 1);

			_regs.ProgramCounter.Data += 3;
			_regs.ProgramCounter.Data += (byte)((byte)LowByte + (byte)HiByte);
			this.CurrentOpCycles = 3;
		} // Listo

		/// <Summary> 
		/// Número: 83
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_83()
		{
			uint OperandAddress = StackRelative();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 84
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M0X0_84()
		{
			uint OperandAddress = Direct();

			STY_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 85
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_85()
		{
			uint OperandAddress = Direct();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 86
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M0X0_86()
		{
			uint OperandAddress = Direct();

			STX_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 87
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_87()
		{
			uint OperandAddress = DirectIndirectLong();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 88
		/// Nombre: Decrement Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEY_E0M0X0_88()
		{
			DEY_X0();
		} // Listo

		/// <Summary> 
		/// Número: 89
		/// Nombre: Bit Test
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void BIT_E0M0X0_89()
		{
			uint OperandAddress = Immediate();

			BIT_M0(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 8A
		/// Nombre: Transfer Index X to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXA_E0M0X0_8A()
		{
			TXA_M0X0();
		} // Listo

		/// <Summary> 
		/// Número: 8B
		/// Nombre: Push Data Bank Register on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void PHB_E0M0X0_8B()
		{
			PushByte(_regs.DataBank);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: 8C
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M0X0_8C()
		{
			uint OperandAddress = Absolute();

			STY_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_8D()
		{
			uint OperandAddress = Absolute();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8E
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M0X0_8E()
		{
			uint OperandAddress = Absolute();

			STX_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 8F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_8F()
		{
			uint OperandAddress = AbsoluteLong();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: 90
		/// Nombre: Branch on Carry Clear (Pe = O)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCC_E0M0X0_90()
		{
			Branch((_regs.Flags & 0x01) == 0);
		} // Listo

		/// <Summary> 
		/// Número: 91
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_91()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 92
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_92()
		{
			uint OperandAddress = DirectIndirect();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 93
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_93()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 94
		/// Nombre: Store Index Y in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STY_E0M0X0_94()
		{
			uint OperandAddress = DirectIndexedX_X0();

			STY_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 95
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_95()
		{
			uint OperandAddress = DirectIndexedX_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 96
		/// Nombre: Store Index X in Memory
		/// Direccionamiento: Direct Page Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void STX_E0M0X0_96()
		{
			uint OperandAddress = DirectIndexedY_X0();

			STX_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 97
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void STA_E0M0X0_97()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: 98
		/// Nombre: Transfer Index Y to Accumulator
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYA_E0M0X0_98()
		{
			TYA_M0X0();
		} // Listo

		/// <Summary> 
		/// Número: 99
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_99()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9A
		/// Nombre: Transfer Index X to Stack Polnter Register
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXS_E0M0X0_9A()
		{
			TXS_X0();
		} // Listo

		/// <Summary> 
		/// Número: 9B
		/// Nombre: Transfer Index X to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TXY_E0M0X0_9B()
		{
			TXY_X0();
		} // Listo

		/// <Summary> 
		/// Número: 9C
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M0X0_9C()
		{
			uint OperandAddress = Absolute();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9D
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_9D()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9E
		/// Nombre: Store Zero in Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STZ_E0M0X0_9E()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			STZ_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: 9F
		/// Nombre: Store Accumulator in Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void STA_E0M0X0_9F()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			STA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: A0
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X0_A0()
		{
			uint OperandAddress = Immediate();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: A1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X0_A1()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A2
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X0_A2()
		{
			uint OperandAddress = Immediate();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: A3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X0_A3()
		{
			uint OperandAddress = StackRelative();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X0_A4()
		{
			uint OperandAddress = Direct();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X0_A5()
		{
			uint OperandAddress = Direct();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X0_A6()
		{
			uint OperandAddress = Direct();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X0_A7()
		{
			uint OperandAddress = DirectIndirectLong();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: A8
		/// Nombre: Transfer Accumulator to Index Y
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAY_E0M0X0_A8()
		{
			TAY_M0X0();
		} // Listo

		/// <Summary> 
		/// Número: A9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X0_A9()
		{
			uint OperandAddress = Immediate();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AA
		/// Nombre: Transfer Accumulator to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TAX_E0M0X0_AA()
		{
			TAX_M0X0();
		} // Listo

		/// <Summary> 
		/// Número: AB
		/// Nombre: Pull Data Bank Register from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// </summary> 
		private void PLB_E0M0X0_AB()
		{
			_regs.DataBank = PullByte();

			_regs.Flags |= (byte)(_regs.DataBank & 0x80 | (_regs.DataBank > 0 ? 0x00 : 0x02));

			if ((_regs.DataBank & 0x80) > 0) SetNegativeFlag();
			else ClearNegativeFlag();

			if (_regs.DataBank > 0) ClearZeroFlag();
			else SetZeroFlag();

			this.CurrentOpCycles = 4;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: AC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X0_AC()
		{
			uint OperandAddress = Absolute();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X0_AD()
		{
			uint OperandAddress = Absolute();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X0_AE()
		{
			uint OperandAddress = Absolute();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: AF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X0_AF()
		{
			uint OperandAddress = AbsoluteLong();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: B0
		/// Nombre: Branch on Carry Set (Pe = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BCS_E0M0X0_B0()
		{
			Branch((_regs.Flags & 0x01) > 0);
		} // Listo

		/// <Summary> 
		/// Número: B1
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M0X0_B1()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B2
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X0_B2()
		{
			uint OperandAddress = DirectIndirect();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B3
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X0_B3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B4
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X0_B4()
		{
			uint OperandAddress = DirectIndexedX_X0();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B5
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X0_B5()
		{
			uint OperandAddress = DirectIndexedX_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B6
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: DP Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X0_B6()
		{
			uint OperandAddress = DirectIndexedY_X0();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B7
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void LDA_E0M0X0_B7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: B8
		/// Nombre: Clear Overflow Flag
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLV_E0M0X0_B8()
		{
			_regs.Flags &= 0xBF;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: B9
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M0X0_B9()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BA
		/// Nombre: Transfer Stack Pointer Register to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TSX_E0M0X0_BA()
		{
			TSX_X0();
		} // Listo

		/// <Summary> 
		/// Número: BB
		/// Nombre: Transfer Index Y to Index X
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void TYX_E0M0X0_BB()
		{
			TYX_X0();
		} // Listo

		/// <Summary> 
		/// Número: BC
		/// Nombre: Load Index Y with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDY_E0M0X0_BC()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			LDY_X0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BD
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void LDA_E0M0X0_BD()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BE
		/// Nombre: Load Index X with Memory
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void LDX_E0M0X0_BE()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			LDX_X0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: BF
		/// Nombre: Load Accumulator with Memory
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void LDA_E0M0X0_BF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			LDA_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: C0
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M0X0_C0()
		{
			uint OperandAddress = Immediate();

			CPY_X0(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X0_C1()
		{
			uint OperandAddress = DirectIndexedIndirect_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C2
		/// Nombre: Reset Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void REP_E0M0X0_C2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags &= (byte)(~Operand);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X0_C3()
		{
			uint OperandAddress = StackRelative();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 2;
		} // Listo 

		/// <Summary> 
		/// Número: C4
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M0X0_C4()
		{
			uint OperandAddress = Direct();

			CPY_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X0_C5()
		{
			uint OperandAddress = Direct();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M0X0_C6()
		{
			uint OperandAddress = Direct();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X0_C7()
		{
			uint OperandAddress = DirectIndirectLong();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: C8
		/// Nombre: Increment Index Y by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INY_E0M0X0_C8()
		{
			INY_X0();
		} // Listo

		/// <Summary> 
		/// Número: C9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X0_C9()
		{
			uint OperandAddress = Immediate();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: CA
		/// Nombre: Decrement Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void DEX_E0M0X0_CA()
		{
			DEX_X0();
		} // Listo

		/// <Summary> 
		/// Número: CB
		/// Nombre: Wait for Interrupt
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by interrupt to restart it.
		/// </summary> 
		private void WAI_E0M0X0_CB()
		{
            _waitInterrupt = true;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: CC
		/// Nombre: Compare Memory and Index Y
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPY_E0M0X0_CC()
		{
			uint OperandAddress = Absolute();

			CPY_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X0_CD()
		{
			uint OperandAddress = Absolute();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M0X0_CE()
		{
			uint OperandAddress = Absolute();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: CF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X0_CF()
		{
			uint OperandAddress = AbsoluteLong();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: D0
		/// Nombre: Branch if Not Equal (Pz = 0)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BNE_E0M0X0_D0()
		{
			Branch((_regs.Flags & 0x02) == 0);
		} // Listo

		/// <Summary> 
		/// Número: D1
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M0X0_D1()
		{
			uint OperandAddress = DirectIndirectIndexed_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D2
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X0_D2()
		{
			uint OperandAddress = DirectIndirect();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D3
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X0_D3()
		{
			uint OperandAddress = StackRelativeIndirectIndexed_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D4
		/// Nombre: Push Effective Indirect Address on Stack (add one cycle if DL f 0)
		/// Direccionamiento: Stack (Direct Page Indirect)
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void PEI_E0M0X0_D4()
		{
		}

		/// <Summary> 
		/// Número: D5
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X0_D5()
		{
			uint OperandAddress = DirectIndexedX_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D6
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void DEC_E0M0X0_D6()
		{
			uint OperandAddress = DirectIndexedX_X0();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D7
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// </summary> 
		private void CMP_E0M0X0_D7()
		{
			uint OperandAddress = DirectIndirectIndexedLong_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: D8
		/// Nombre: Clear Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void CLD_E0M0X0_D8()
		{
			_regs.Flags &= 0xF7;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: D9
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M0X0_D9()
		{
			uint OperandAddress = AbsoluteIndexedY_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DA
		/// Nombre: Push Index X on Stack
		/// Direccionamiento: Stack (Push)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PHX_E0M0X0_DA()
		{
			PHX_X0();
		} // Listo

		/// <Summary> 
		/// Número: DB
		/// Nombre: Stop the Clock
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Uses 3 cycles to shut the processor down; additional cycles are required by reset to restart 
		/// </summary> 
		private void STP_E0M0X0_DB()
		{
		}

		/// <Summary> 
		/// Número: DC
		/// Nombre: Jump to New Location
		/// Direccionamiento: Absolute Indirect Long
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// </summary> 
		private void JMP_E0M0X0_DC()
		{
			uint OperandAddress = AbsoluteIndirectLong();

			_regs.ProgramCounter.Low = _bus.ReadByte(OperandAddress);
			_regs.ProgramCounter.High = _bus.ReadByte(OperandAddress + 1);

			this.CurrentOpCycles = 6;
		} // Listo

		/// <Summary> 
		/// Número: DD
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// </summary> 
		private void CMP_E0M0X0_DD()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 5 + (OperandAddress >> 16) > _regs.DataBank ? 1 : 0;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DE
		/// Nombre: Decrement Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void DEC_E0M0X0_DE()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			DEC_M0(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: DF
		/// Nombre: Compare Memory and Accumulator
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void CMP_E0M0X0_DF()
		{
			uint OperandAddress = AbsoluteLongIndexedX_X0();

			CMP_M0(OperandAddress);

			this.CurrentOpCycles = 6;
			_regs.ProgramCounter.Data += 4;
		} // Listo

		/// <Summary> 
		/// Número: E0
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 byte if x=0 (16-bit index registers).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M0X0_E0()
		{
			uint OperandAddress = Immediate();

			CPX_X0(OperandAddress);

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 3;
		} // Listo 

		/// <Summary> 
		/// Número: E1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indexed Indirect,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_E1()
		{
		}

		/// <Summary> 
		/// Número: E2
		/// Nombre: Set Processor Status Bits
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void SEP_E0M0X0_E2()
		{
			uint OperandAddress = Immediate();
			byte Operand = _bus.ReadByte(OperandAddress);

			_regs.Flags |= Operand;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Stack Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_E3()
		{
		}

		/// <Summary> 
		/// Número: E4
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M0X0_E4()
		{
			uint OperandAddress = Direct();

			CPX_X0(OperandAddress);

			this.CurrentOpCycles = 4 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_E5()
		{
		}

		/// <Summary> 
		/// Número: E6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void INC_E0M0X0_E6()
		{
			uint OperandAddress = Direct();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 7 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		} // Listo

		/// <Summary> 
		/// Número: E7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect Long
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_E7()
		{
		}

		/// <Summary> 
		/// Número: E8
		/// Nombre: Increment Index X by One
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void INX_E0M0X0_E8()
		{
			INX_X0();
		} // Listo

		/// <Summary> 
		/// Número: E9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Immediate
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 if m=0 (16 bit memory/accumulator).
		/// </summary> 
		private void SBC_E0M0X0_E9()
		{
		}

		/// <Summary> 
		/// Número: EA
		/// Nombre: No Operation
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void NOP_E0M0X0_EA()
		{
			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: EB
		/// Nombre: Exchange AH and AL
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 3
		///
		/// Notas: 
		/// </summary> 
		private void XBA_E0M0X0_EB()
		{
			byte temp = _regs.Accumulator.High;
			_regs.Accumulator.High = _regs.Accumulator.Low;
			_regs.Accumulator.Low = temp;

			this.CurrentOpCycles = 3;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: EC
		/// Nombre: Compare Memory and Index X
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void CPX_E0M0X0_EC()
		{
			uint OperandAddress = Absolute();

			CPX_X0(OperandAddress);

			this.CurrentOpCycles = 5;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: ED
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_ED()
		{
		}

		/// <Summary> 
		/// Número: EE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M0X0_EE()
		{
			uint OperandAddress = Absolute();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 8;
			_regs.ProgramCounter.Data += 3;
		} // Listo

		/// <Summary> 
		/// Número: EF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_EF()
		{
		}

		/// <Summary> 
		/// Número: F0
		/// Nombre: Branch if Equal (Pz = 1)
		/// Direccionamiento: Program Counter Relative
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// - Add 1 cycle if branch is taken.
		/// - Add 1 more cycle if branch taken crosses page boundary on 6502, 65C02, or 65816/65082's emulation mode (e=1).
		/// </summary> 
		private void BEQ_E0M0X0_F0()
		{
			Branch((_regs.Flags & 0x02) > 0);
		} // Listo

		/// <Summary> 
		/// Número: F1
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_F1()
		{
		}

		/// <Summary> 
		/// Número: F2
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indirect
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_F2()
		{
		}

		/// <Summary> 
		/// Número: F3
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: SR Indirect Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_F3()
		{
		}

		/// <Summary> 
		/// Número: F4
		/// Nombre: Push Effective Absolute Address on Stack (or Push Immediate Data on Stack)
		/// Direccionamiento: Stack (Absolute)
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// </summary> 
		private void PEA_E0M0X0_F4()
		{
		}

		/// <Summary> 
		/// Número: F5
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_F5()
		{
		}

		/// <Summary> 
		/// Número: F6
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Direct Page Indexed,X
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// </summary> 
		private void INC_E0M0X0_F6()
		{
			uint OperandAddress = DirectIndexedX_X0();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 8 + _regs.DirectPage.Low > 0 ? 1 : 0;
			_regs.ProgramCounter.Data += 2;
		}  // Listo

		/// <Summary> 
		/// Número: F7
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: DP Indirect Long Indexed,Y
		/// Tamaño en bytes: 2
		/// Duración en ciclos: 6
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if low bye of Direct Page (zero page) register is other than zero (DL&lt;&gt;0).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_F7()
		{
		}

		/// <Summary> 
		/// Número: F8
		/// Nombre: Set Decimal Mode
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void SED_E0M0X0_F8()
		{
			_regs.Flags |= 0x08;

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data += 1;
		} // Listo

		/// <Summary> 
		/// Número: F9
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,Y
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_F9()
		{
		}

		/// <Summary> 
		/// Número: FA
		/// Nombre: Pull Index X from Stack
		/// Direccionamiento: Stack (Pull)
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if x=0 (16-bit index registers).
		/// </summary> 
		private void PLX_E0M0X0_FA()
		{
			PLX_X0();
		} // Listo

		/// <Summary> 
		/// Número: FB
		/// Nombre: Exchange Carry and Emulation Bits
		/// Direccionamiento: Implied
		/// Tamaño en bytes: 1
		/// Duración en ciclos: 2
		///
		/// Notas: 
		/// </summary> 
		private void XCE_E0M0X0_FB()
		{
			uint EMode = _regs.EmulatorMode;

			_regs.EmulatorMode = (uint)(_regs.Flags & 0x00000001);
			_regs.Flags |= (byte)(EMode);

			this.CurrentOpCycles = 2;
			_regs.ProgramCounter.Data++;
		} // Listo

		/// <Summary> 
		/// Número: FC
		/// Nombre: Jump to New Location Saving Return Address
		/// Direccionamiento: Absolute Indexed Indirect
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 8
		///
		/// Notas: 
		/// </summary> 
		private void JSR_E0M0X0_FC()
		{
			uint OperandAddress = AbsoluteIndexedIndirect_X0();

			_regs.ProgramCounter.Data += 3;

			PushByte(_regs.ProgramCounter.High);
			PushByte(_regs.ProgramCounter.Low);

			_regs.ProgramCounter.Data = (ushort)(OperandAddress);
			_regs.ProgramBank = (byte)(OperandAddress >> 16);

			this.CurrentOpCycles = 8;
		} // Listo

		/// <Summary> 
		/// Número: FD
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 4
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if adding index crosses a page boundary.
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_FD()
		{
		}

		/// <Summary> 
		/// Número: FE
		/// Nombre: Increment Memory or Accumulator by One
		/// Direccionamiento: Absolute Indexed,X
		/// Tamaño en bytes: 3
		/// Duración en ciclos: 7
		///
		/// Notas: 
		/// - Add 2 cycles if m=0 (16-bit memory/accumulator).
		/// - Subtract 1 cycle if CPU is 65C02 and no page boundary crossed.
		/// </summary> 
		private void INC_E0M0X0_FE()
		{
			uint OperandAddress = AbsoluteIndexedX_X0();

			INC_M0(OperandAddress);

			this.CurrentOpCycles = 7;
			_regs.ProgramCounter.Data += 3;
		}  // Listo

		/// <Summary> 
		/// Número: FF
		/// Nombre: Subtract Memory from Accumulator with Borrow
		/// Direccionamiento: Absolute Long Indexed,X
		/// Tamaño en bytes: 4
		/// Duración en ciclos: 5
		///
		/// Notas: 
		/// - Add 1 cycle if m=0 (16-bit memory/accumulator).
		/// - Add 1 cycle if CPU is 65C02 and d=1 (decimal mode. 65C02 only).
		/// </summary> 
		private void SBC_E0M0X0_FF()
		{
		}

		#endregion
	}
}
