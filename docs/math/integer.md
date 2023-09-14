# Math
## Integer (Before IntegerExtensions)
### Fibonacci
Get a `list` of Fibonacci numbers. Return Exception if `n` is less than `0`.
> **Note**: It brings a sequence of numbers, starting with `�0` and ending with `�20`, it does not bring the `first` 20 numbers.
- Exception if `n` is less than `0`.

```csharp
const List<ulong> result = 20.Fibonacci();
// Output: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1,597, 2,584, 4,181, 6,765
```

### IsEven
Check if a `number` is even.

```csharp
var numbers = [0,1, 2, 3, 4, 5, 6, 7, 8, 9,10];
for (int i = 0; i < numbers.Count; i++)
    Console.WriteLine($"{numbers[i]} : {numbers[i].IsOdd()}");
// Output: { 0 : True, 1 : False, 2 : True, 3 : False, 4 : True, 5 : False, 6 : True, 7 : False, 8 : True, 9 : False, 10 : True }
```

### Evens
Generate a sequence of odd `numbers` up to the given number.

```csharp
List<int> evens = 10.Evens().ToList();
for (int i = 0; i < evens.Count; i++)
    Console.WriteLine(odds[i]);
// Output: { 0, 2, 4, 6, 8, 10}
```

### IsOdd
Check if a `number` is odd.

```csharp
var numbers = [0,1, 2, 3, 4, 5, 6, 7, 8, 9,10];
for (int i = 0; i < numbers.Count; i++)
    Console.WriteLine($"{numbers[i]} : {numbers[i].IsEven()}");
// Output: { 0 : False, 1 : True, 2 : False, 3 : True, 4 : False, 5 : True, 6 : False, 7 : True, 8 : False, 9 : True, 10 : False }
```

### Odds
Generate a sequence of even `numbers` up to the given `number`.

```csharp
List<int> odds = 10.Odds().ToList();
for (int i = 0; i < odds.Count; i++)
    Console.WriteLine(odds[i]);
// Output: {1 ,3 ,5 ,7 ,9}

```

### IsDivisibleBy
Check if a `number` is divisible by another `number`.
- Exception: if `n` is less than `0`.

```csharp
14.IsDivisibleBy(6) // false
14.IsDivisibleBy(2) // true
14.IsDivisibleBy(14) // true
14.IsDivisibleBy(1) // true
14.IsDivisibleBy(3) // false
15.IsDivisibleBy(7) // false
0.IsDivisibleBy(7) // true
14.IsDivisibleBy(0) // throw DivideByZeroException
```

### IsMultipleOf
Check if a `number` is a multiple of another `number`.
- Exception: if `n` is less than `0`.

```csharp
 12.IsMultipleOf(3) // true
7.IsMultipleOf(3) // false
7.IsMultipleOf(2) // false
7.IsMultipleOf(7) // true
14.IsMultipleOf(7) // true
19.IsMultipleOf(7) // false
0.IsMultipleOf(2) // true
2.IsMultipleOf(0); // throw MultipleOfZeroException
```

### IsPrime
Check if the `number` is prime.

```csharp
0.IsPrime() // false
1.IsPrime() // false
2.IsPrime() // true
3.IsPrime() // true
4.IsPrime() // false
5.IsPrime() // true
6.IsPrime() // false
7.IsPrime() // true
8.IsPrime() // false
9.IsPrime() // false
10.IsPrime() // false
11.IsPrime() // true
```

### Primes
Get the prime numbers until the quantity.

```csharp
 List<int> primes = 19.Primes().ToList();
 // Output: 2, 3, 5, 7, 11, 13, 17, 19
```