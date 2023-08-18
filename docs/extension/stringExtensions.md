# Extensions
## StringExtensions
### TrimAround
Removes all leading and trailing white-space characters from the current `string` 
object.
- Return `string`

```csharp
var str = "  Hello World!  ";
var trimmed = str.TrimAround(); // "Hello World!"
```

### IsNullOrEmpty
Indicates whether the specified `string` is `null` or an `string.Empty`.
- Return `bool`

```csharp
var str = "Hello World!";
bool isNullOrEmpty = str.IsNullOrEmpty(); // false

bool str = null;
isNullOrEmpty = str.IsNullOrEmpty(); // true

bool str = string.Empty;
isNullOrEmpty = str.IsNullOrEmpty(); // true
```

### IsNullOrWhiteSpace
Indicates whether the specified `string` is `null`, `string.Empty`, or consists only of white-space.
- Return `bool`

```csharp
var str = "Hello World!";
bool isNullOrWhiteSpace = str.IsNullOrWhiteSpace(); // false

str = null;
bool isNullOrWhiteSpace = str.IsNullOrWhiteSpace(); // true

str = string.Empty;
bool isNullOrWhiteSpace = str.IsNullOrWhiteSpace(); // true

str = "   ";
bool isNullOrWhiteSpace = str.IsNullOrWhiteSpace(); // true
```
