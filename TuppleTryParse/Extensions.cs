using System;

namespace TuppleTryParse
{
    public static class Parser
    {
        public static (bool, int) TryParseInt(string value) => (int.TryParse(value, out int result),result);
        public static (bool, double) TryParseDouble(string value) => (double.TryParse(value, out double result),result);
        public static (bool, long) TryParseLong(string value) => (long.TryParse(value, out long result),result);
        public static (bool, float) TryParseFloat(string value) => (float.TryParse(value, out float result),result);
        public static (bool, decimal) TryParseDecimal(string value) => (decimal.TryParse(value, out decimal result),result);
        public static (bool, bool) TryParseBool(string value) => (bool.TryParse(value, out bool result),result);
        public static (bool, byte) TryParseByte(string value) => (byte.TryParse(value, out byte result),result);
        public static (bool, DateTime) TryParseDateTime(string value) => (DateTime.TryParse(value, out DateTime result),result);
        public static (bool, short) TryParseShort(string value) => (short.TryParse(value, out short result),result);
        public static (bool, sbyte) TryParseSbyte(string value) => (sbyte.TryParse(value, out sbyte result),result);
        public static (bool, char) TryParseChar(string value) => (char.TryParse(value, out char result),result);
        public static (bool, uint) TryParseUint(string value) => (uint.TryParse(value, out uint result),result);
        public static (bool, ulong) TryParseUlong(string value) => (ulong.TryParse(value, out ulong result),result);
        public static (bool, ushort) TryParseUshort(string value) => (ushort.TryParse(value, out ushort result),result);
    }
}
