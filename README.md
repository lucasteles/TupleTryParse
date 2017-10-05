# TupleTryParse
Extensions for use TryParse of types with a tuple result

```cs
var value = "123";
var (success, parsedValue) = Parser.TryParseInt(value);
```

suports
```
int, double, long, float, decimal, bool, byte, DateTim, short, sbyte, char, uint, ulong, ushort
```

## Installing
Install from Nuget

```powershell
Install-Package TupleTryParse 
```

Install from dotnet core CLI

```powershell
dotnet add package TupleTryParse 
```

[]`s
