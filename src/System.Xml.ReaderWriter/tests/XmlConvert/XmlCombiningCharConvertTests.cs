// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using OLEDB.Test.ModuleCore;

namespace System.Xml.Tests
{
    internal abstract class XmlCombiningCharConvertTests : CTestCase
    {
        #region Static Fields

        public static string[] _Expbyte_CombiningChar = { "_x02FF_", "_x0346_", "_x035F_", "_x0362_", "_x0482_", "_x0487_", "_x0590_", "_x05A2_", "_x05BA_", "_x05BE_", "_x05C0_", "_x05C3_", "_x05C5_", "_x0653_", "_x066F_", "_x06E9_", "_x06EE_", "_x0900_", "_x0904_", "_x093B_", "_x094E_", "_x0950_", "_x0955_", "_x0964_", "_x0980_", "_x0984_", "_x09BB_", "_x09BD_", "_x09C5_", "_x09C6_", "_x09C9_", "_x09CA_", "_x09CE_", "_x09D6_", "_x09D8_", "_x09E4_", "_x0A01_", "_x0A03_", "_x0A3B_", "_x0A3D_", "_x0A43_", "_x0A46_", "_x0A49_", "_x0A4A_", "_x0A4E_", "_x0A6F_", "_x0A80_", "_x0A84_", "_x0ABB_", "_x0AC6_", "_x0ACA_", "_x0ACE_", "_x0B00_", "_x0B04_", "_x0B3B_", "_x0B44_", "_x0B46_", "_x0B49_", "_x0B4A_", "_x0B4E_", "_x0B55_", "_x0B58_", "_x0B81_", "_x0B84_", "_x0BBD_", "_x0BC3_", "_x0BC5_", "_x0BC9_", "_x0BCE_", "_x0BD6_", "_x0BD8_", "_x0C00_", "_x0C04_", "_x0C3D_", "_x0C45_", "_x0C49_", "_x0C4E_", "_x0C54_", "_x0C57_", "_x0C81_", "_x0C84_", "_x0CBD_", "_x0CC5_", "_x0CC9_", "_x0CCE_", "_x0CD4_", "_x0CD7_", "_x0D01_", "_x0D04_", "_x0D3D_", "_x0D44_", "_x0D45_", "_x0D49_", "_x0D4E_", "_x0D56_", "_x0D58_", "_x0E3B_", "_x0E46_", "_x0E4F_", "_x0EBA_", "_x0EC7_", "_x0ECE_", "_x0F17_", "_x0F1A_", "_x0F34_", "_x0F36_", "_x0F38_", "_x0F3A_", "_x0F3D_", "_x0F70_", "_x0F85_", "_x0F8C_", "_x0F8F_", "_x0F96_", "_x0F98_", "_x0FAE_", "_x0FB0_", "_x0FB8_", "_x0FBA_", "_x20CF_", "_x20DD_", "_x20E0_", "_x20E2_", "_x3030_", "_x3098_", "_x309B_" };

        public static byte[] _byte_CombiningChar = { 0xFF, 0x02, 0x46, 0x03, 0x5F, 0x03, 0x62, 0x03, 0x82, 0x04, 0x87, 0x04, 0x90, 0x05, 0xA2, 0x05, 0xBA, 0x05, 0xBE, 0x05, 0xC0, 0x05, 0xC3, 0x05, 0xC5, 0x05, 0x53, 0x06, 0x6F, 0x06, 0xE9, 0x06, 0xEE, 0x06, 0x00, 0x09, 0x04, 0x09, 0x3B, 0x09, 0x4E, 0x09, 0x50, 0x09, 0x55, 0x09, 0x64, 0x09, 0x80, 0x09, 0x84, 0x09, 0xBB, 0x09, 0xBD, 0x09, 0xC5, 0x09, 0xC6, 0x09, 0xC9, 0x09, 0xCA, 0x09, 0xCE, 0x09, 0xD6, 0x09, 0xD8, 0x09, 0xE4, 0x09, 0x01, 0x0A, 0x03, 0x0A, 0x3B, 0x0A, 0x3D, 0x0A, 0x43, 0x0A, 0x46, 0x0A, 0x49, 0x0A, 0x4A, 0x0A, 0x4E, 0x0A, 0x6F, 0x0A, 0x80, 0x0A, 0x84, 0x0A, 0xBB, 0x0A, 0xC6, 0x0A, 0xCA, 0x0A, 0xCE, 0x0A, 0x00, 0x0B, 0x04, 0x0B, 0x3B, 0x0B, 0x44, 0x0B, 0x46, 0x0B, 0x49, 0x0B, 0x4A, 0x0B, 0x4E, 0x0B, 0x55, 0x0B, 0x58, 0x0B, 0x81, 0x0B, 0x84, 0x0B, 0xBD, 0x0B, 0xC3, 0x0B, 0xC5, 0x0B, 0xC9, 0x0B, 0xCE, 0x0B, 0xD6, 0x0B, 0xD8, 0x0B, 0x00, 0x0C, 0x04, 0x0C, 0x3D, 0x0C, 0x45, 0x0C, 0x49, 0x0C, 0x4E, 0x0C, 0x54, 0x0C, 0x57, 0x0C, 0x81, 0x0C, 0x84, 0x0C, 0xBD, 0x0C, 0xC5, 0x0C, 0xC9, 0x0C, 0xCE, 0x0C, 0xD4, 0x0C, 0xD7, 0x0C, 0x01, 0x0D, 0x04, 0x0D, 0x3D, 0x0D, 0x44, 0x0D, 0x45, 0x0D, 0x49, 0x0D, 0x4E, 0x0D, 0x56, 0x0D, 0x58, 0x0D, 0x3B, 0x0E, 0x46, 0x0E, 0x4F, 0x0E, 0xBA, 0x0E, 0xC7, 0x0E, 0xCE, 0x0E, 0x17, 0x0F, 0x1A, 0x0F, 0x34, 0x0F, 0x36, 0x0F, 0x38, 0x0F, 0x3A, 0x0F, 0x3D, 0x0F, 0x70, 0x0F, 0x85, 0x0F, 0x8C, 0x0F, 0x8F, 0x0F, 0x96, 0x0F, 0x98, 0x0F, 0xAE, 0x0F, 0xB0, 0x0F, 0xB8, 0x0F, 0xBA, 0x0F, 0xCF, 0x20, 0xDD, 0x20, 0xE0, 0x20, 0xE2, 0x20, 0x30, 0x30, 0x98, 0x30, 0x9B, 0x30 };

        #endregion

        #region Public Methods and Operators

        public override int Init(object objParam)
        {
            return TEST_PASS;
        }
        #endregion
    }
}