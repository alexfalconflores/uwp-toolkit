# Extensions
## ResourceExtensions
### GetLocalized
Get localized `string` from resource file
- Return `string`

```csharp
var appName = "AppName".GetLocalized(); // "My App Name"

var errorMessage = "/Error/empty".GetLocalized();  // "Error message is empty"
```

### Format
Replace the format item in a specified string with the `string` representation of a corresponding object in a specified `array`.
- Return `string`

```resw
/// Word.resw
gretting = {0} {1} Hello {2} {3}
```

```csharp
var name = "Alex";
var message = "/Word/greeting".GetLocalized().Format("😊", "🔥", name, "🙌"); 
// message = "😊 🔥 Hello Alex 🙌"
```

### GetStyle
Get `style` by `key` from resource file
- Return `Style`

```csharp
// without this library
var style = Application.Current.Resources["ButtonStyle"] as Style ?? throw new NullReferenceException("ButtonStyle not found");

// with this library
var style = "ButtonStyle".GetStyle();
```

### GetDouble
Get `double` by `key` from resource file
- Return `double`

```csharp
// without this library
var value = Application.Current.Resources["ButtonWidth"] as double? ?? throw new NullReferenceException("ButtonWidth not found");

// with this library
var value = "ButtonWidth".GetDouble();
```


