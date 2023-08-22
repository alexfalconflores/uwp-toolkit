# Extensions
# CollectionExtensions
### Fill
Fill the collection with the value entered for the given quantity.

```csharp
List<string> values = new();
values.Fill(10, "A");
// Output : [A, A, A, A, A, A, A, A, A, A]
    
ObservableCollection<string> strings = new();
strings.Fill(10, "b");
// Output : [b, b, b, b, b, b, b, b, b, b]
strings.Fill(10, "c");
// Output : [c, c, c, c, c, c, c, c, c, c]

List<int> numbers = new();
numbers.Fill(10, 4);
// Output : [4, 4, 4, 4, 4, 4, 4, 4, 4, 4]
numbers.Fill(10, 6, false);
// Output : [4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6]  
```