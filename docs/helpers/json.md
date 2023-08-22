# Helpers
## Json
###  ToObjectAsync
Converts the specified JSON `string` to an `object` of type T.
- Returns an `object` of type T.
 
```csharp
var json = @"{""Name"":""Alex Falcon"",""Occupation"": ""Software Developer""}";
var obj = await Json.ToObjectAsync<Dictionary<string, string>>(json);
Output: obj["Name"] = "Alex Falcon"
Output: obj["Occupation"] = "Software Developer"
```

### StringifyAsync
Converts a specified `object` to a JSON `string`.

```csharp
var obj = new { Name = "Alex Falcon", Occupation = "Software Developer" };
var json = await Json.StringifyAsync(obj);
Output: {"Name":"Alex Falcon","Occupation": "Software Developer"}
```
