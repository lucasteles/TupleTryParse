using System;

namespace TupleTryParse
{
    public static class Parser
    {
        public static (bool success, int value) TryParseInt(string value) => (int.TryParse(value, out int result),result);
        public static (bool success, double value) TryParseDouble(string value) => (double.TryParse(value, out double result),result);
        public static (bool success, long value) TryParseLong(string value) => (long.TryParse(value, out long result),result);
        public static (bool success, float value) TryParseFloat(string value) => (float.TryParse(value, out float result),result);
        public static (bool success, decimal value) TryParseDecimal(string value) => (decimal.TryParse(value, out decimal result),result);
        public static (bool success, bool value) TryParseBool(string value) => (bool.TryParse(value, out bool result),result);
        public static (bool success, byte value) TryParseByte(string value) => (byte.TryParse(value, out byte result),result);
        public static (bool success, DateTime value) TryParseDateTime(string value) => (DateTime.TryParse(value, out DateTime result),result);
        public static (bool success, short value) TryParseShort(string value) => (short.TryParse(value, out short result),result);
        public static (bool success, sbyte value) TryParseSbyte(string value) => (sbyte.TryParse(value, out sbyte result),result);
        public static (bool success, char value) TryParseChar(string value) => (char.TryParse(value, out char result),result);
        public static (bool success, uint value) TryParseUint(string value) => (uint.TryParse(value, out uint result),result);
        public static (bool success, ulong value) TryParseUlong(string value) => (ulong.TryParse(value, out ulong result),result);
        public static (bool success, ushort value) TryParseUshort(string value) => (ushort.TryParse(value, out ushort result),result);
    }
}
