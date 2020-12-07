using System;

namespace Documenti.Interop
{
    internal interface IField : IDisposable
    {
        string Name { get; }
        byte NumericScale { get; set; }
        object OriginalValue { get; }
        byte Precision { get; set; }
        long Status { get; }
        DataTypeEnum Type { get; set; }
        object UnderlyingValue { get; }
        object Value { get; set; }
    }

    internal enum DataTypeEnum
    {
        adArray = 0x2000,
        adBigInt = 0x14,
        adBinary = 0x80,
        adBoolean = 11,
        adBSTR = 8,
        adChapter = 0x88,
        adChar = 0x81,
        adCurrency = 6,
        adDate = 7,
        adDBDate = 0x85,
        adDBTime = 0x86,
        adDBTimeStamp = 0x87,
        adDecimal = 14,
        adDouble = 5,
        adEmpty = 0,
        adError = 10,
        adFileTime = 0x40,
        adGUID = 0x48,
        adIDispatch = 9,
        adInteger = 3,
        adIUnknown = 13,
        adLongVarBinary = 0xCD,
        adLongVarChar = 0xC9,
        adLongVarWChar = 0xCB,
        adNumeric = 0x83,
        adPropVariant = 0x8A,
        adSingle = 4,
        adSmallInt = 2,
        adTinyInt = 0x10,
        adUnsignedBigInt = 0x15,
        adUnsignedInt = 0x13,
        adUnsignedSmallInt = 0x12,
        adUnsignedTinyInt = 0x11,
        adUserDefined = 0x84,
        adVarBinary = 0xCC,
        adVarChar = 0xC8,
        adVariant = 12,
        adVarNumeric = 0x8B,
        adVarWChar = 0xCA,
        adWChar = 0x82
    }
}