# Extensions
## EnumerableExtensions
### Flatten
Flattens a `collection` of nested objects, returning a flat sequence of objects.
```csharp
List<object> nestedList = new()
{
    1,
    new List<object> { 2, 3, new List<object> { 4, 5 } },
    6,
    new List<object> { 7 },
    new List<object> { 8, 9, new List<object> { 10, 11, new List<object> { 12,13,14,15} } },
    16,
    new List<object> { 17, 18, new List<object> { 19, 20, new List<object> { 21,22,23,24,25,26,27,28,29,30,31,32,33,34,35 } } },
    36,
};

List<object> stringList = new()
{
    "Hello",
    new List<object> { "World", "!" },
    "How",
    new List<object> { "are", "you", new List<object> { "doing", "today", new List<object> { "my", "friend", "!" } } },
    "I",
    new List<object> { "am", "fine", new List<object> { "thank", "you", new List<object> { "for", "asking", "!" } } },
    "Goodbye",
};

List<object> newList3 = nestedList.Flatten().ToList();
foreach (var item in newList3)
    Console.WriteLine(item);
// Output: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, ... , 35, 36

List<object> newListString = stringList.Flatten().ToList();
foreach (var item in newListString)
    Console.WriteLine(item);
// Output: Hello, World, !, How, are, you, doing, today, my, friend, !, I, am, fine, thank, you, for, asking, !, Goodbye
```

### ToObservableCollection
Converts an `IEnumerable` to an `ObservableCollection`.
```csharp
List<int> list = new() { 1, 2, 3, 4, 5 };
ObservableCollection<int> observableCollection = list.ToObservableCollection();

// stringList is a List<object> from the Flatten example
ObservableCollection<object> newStringList = stringList.Flatten().ToObservableCollection();
```