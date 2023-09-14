# Math
## Number
### IsBetween
Check if the number is between two numbers.
- Exception: if `minValue` is greater than `maxValue`.

```csharp
20.IsBetween(10, 30) // true
20.0.IsBetween(10, 20) // true
20.IsBetween(30, 40) // false
0.IsBetween(0, 40) // true
100.IsBetween(0,50) // false
0.IsBetween(0,0) // true
0.0m.IsBetween(0,0) // true
5.IsBetween(0,0) // false
5.IsBetween(1,0) // InvalidRangeOrderException
(-5).IsBetween(-10,0) // true
(-15).IsBetween(-15,15) // true
(-15).IsBetween(15,-15) // throw InvalidRangeOrderException
(-10).IsBetween(-15,15) // true
(-15.5).IsBetween(-15,15) // false
```

### IsPositive
Check if the number is positive. Zero is considered positive or negative.

```csharp
10.IsPositive() // true
5.4.IsPositive() // true
(-5.4).IsPositive() // false
(-0).IsPositive() // true
0.IsPositive() // true
0.0m.IsPositive() // true
-10.IsPositive() // false
```

### IsNegative
Check if the number is negative. Zero is considered positive or negative.

```csharp
10.IsNegative() // false
5.4.IsNegative() // false
(-5.4).IsNegative() // true
0.IsNegative() // true
(-0).IsNegative() // true
0.0m.IsNegative() // true
-10.IsNegative() // true
```

### IsZero
Check if the number is zero.

```csharp
 10.IsZero() // false
 0.IsZero() // true
 0.0m.IsZero() // true
 0.2m.IsZero() // false
 (-0.0m).IsZero() // true
 (-10).IsZero() // false
```

### IsInteger
Check if the number is integer.

```csharp
5.IsInteger() // true
5.5.IsInteger() // false
5.0.IsInteger() // false
0.IsInteger() // true
(-5).IsInteger() // true
(-5.5).IsInteger() // false
(-5.0).IsInteger() // false
```

### IsDecimal
Check if the number is decimal.(float,32bits: Single, double,64bits: Double or decimal)

```csharp
2.0.IsDecimal() // true
2.IsDecimal() // false
2.0d.IsDecimal() // true
2.0f.IsDecimal() // true
2.0m.IsDecimal() // true
(-2.0m).IsDecimal() // true
```

### IsNatural
Check if the number is natural. Zero is considered natural default, but you can change it.

```csharp
 0.IsNatural() // true
 0.IsNatural(includeZero: false) // false
 5.IsNatural() // true
 (-5).IsNatural() // false
 5u.IsNatural() // true
 0.0m.IsNatural() // false
 5.0m.IsNatural() // false
 5.5.IsNatural() // false
 5.5f.IsNatural() // false
 50L.IsNatural() // true
 2.5m.IsNatural() // false
 (-2.5m).IsNatural() // false
```