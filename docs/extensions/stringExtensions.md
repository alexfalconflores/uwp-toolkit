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

### Join
Concatenates the members of a collection, using the specified separator between each member.
- Return A `string` that consists of the members of values delimited by the separator `string`. If values has no members, the method returns `System.String.Empty`.- Exception values is `null`

```csharp
var list = new List<string> { "a", "b", "c" };
var newString = list.Join(",");
// Output: a,b,c
```

### Repeat
Repeats the given string n times.

```csharp
var newString = "aasdd".Repeat(3);
// Output: aasddaasddaasdd
```

### ToCamelCase
Converts string to [camelCase](https://en.wikipedia.org/wiki/Camel_case).

```csharp
string newString = "Foo Bar".ToCamelCase();
string newString2 = "--foo-bar--".ToCamelCase();
string newString3 = "__FOO_BAR__".ToCamelCase();
// All Output: fooBar
```

### ToPascalCase
Converts string to <see href="">PascalCase</see>.

```csharp
string newString = "Foo Bar".ToPascalCase();
string newString2 = "--foo-bar--".ToPascalCase();
string newString3 = "__FOO_BAR__".ToPascalCase();
// All Output: FooBar
```

### ToKebabCase
Converts string to [kebab-case](https://en.wikipedia.org/wiki/Letter_case#Special_case_styles).

```csharp
string newString = "Foo Bar".ToKebabCase();
string newString2 = "--foo-bar--".ToKebabCase();
string newString3 = "__FOO_BAR__".ToKebabCase();
// All Output: foo-bar
```

### ToSnakeCase
Converts string to [snake_case](https://en.wikipedia.org/wiki/Snake_case).

```csharp
string newString = "Foo Bar".ToSnakeCase();
string newString2 = "--foo-bar--".ToSnakeCase();
string newString3 = "__FOO_BAR__".ToSnakeCase();
// All Output: foo_bar
```

### HtmlEscape
Converts the characters "&", "<", ">", '"', and "'" in `string` to their corresponding HTML entities.
- Returns the escaped `string`

```csharp
var stringHTML = "< fred >, barney, & pebbles".HtmlEscape();
// Output: &lt; fred &gt;, barney, &amp; pebbles    
```

### HtmlUnEscape
The inverse of `HtmlEscape(string)`; this method converts the HTML entities &amp;, &lt;, &gt;, &quot;, and &#39; in `string` to their corresponding characters."/>
- Returns the unescaped `string`

```csharp
// stringHTML variable comes from the example in HtmlEscape()
var stringDefault = stringHTML.HtmlUnEscape();
// Output: < fred >, barney, & pebbles
```