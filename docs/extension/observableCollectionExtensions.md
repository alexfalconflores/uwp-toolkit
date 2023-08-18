# Extensions
## ObservableCollectionExtensions
### RemoveAll(match)
> RemoveAll<T>(Predicate<T> match)

Removes all the elements that match the conditions defined by the specified `predicate`. 
- Returns the `number` of elements removed from the `ObservableCollection<T>`.
- Exception match is `null`.

```csharp
var collection = new ObservableCollection<int> { 1, 2, 3, 4, 5 };
var removed = collection.RemoveAll(x => x % 2 == 0); // 2 // { 1, 3, 5 }
```

### RemoveAll(match,action)
> RemoveAll<T>()

Removes all the elements that match the conditions defined by the specified `predicate`, and execute the specified `action` on each element removed. 
- Returns the `number` of elements removed from the `ObservableCollection<T>`. 
- Exception match is `null` or action is `null`.

```csharp
var collection = new ObservableCollection<int> { 1, 2, 3, 4, 5 };
var removed = collection.RemoveAll(x => x % 2 == 0, x => Console.WriteLine("Delete: " + x));
// Delete: 2
// Delete: 4
```


