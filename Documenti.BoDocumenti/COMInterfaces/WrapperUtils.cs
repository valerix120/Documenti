using System;
using System.Reflection;

namespace Documenti.Interop
{
    internal static class WrapperUtils
    {
        public static IField WrapField(object fieldToWrap)
        {
            return COMWrapper.Wrap<IField>(fieldToWrap);
        }

        public static object GetMissingValue()
        {
            return System.Reflection.Missing.Value;
        }

        public static object GetEmptyValue()
        {
            return null;
        }

        public static object GetNothingValue()
        {
            return System.DBNull.Value;
        }

        public enum RecordsetType
        {
            RstDocTestata,
            RstDocCorpo,
            RstDocCorpoLot

        }
    }
}