namespace ConsoleAppNet7;

public static partial class List
{
    //public static IEnumerable<object> Flat(this IEnumerable<object> source)
    //{
    //    List<object> result = new();
    //    Stack<object> stack = new(source);
    //    while (stack.Count > 0)
    //    {
    //        object item = stack.Pop();
    //        if (item is IEnumerable<object> nestedSubList)
    //            foreach (var subItem in nestedSubList)
    //                stack.Push(subItem);
    //        else
    //            result.Insert(0, item);
    //    }
    //    return result;
    //}
    //public static List<object> RecursiveFlat(this List<object> inputList)
    //{
    //    List<object> result = new();
    //    foreach (var item in inputList)
    //    {
    //        if (item is List<object> nestedSubList)
    //            result.AddRange(nestedSubList.RecursiveFlat());
    //        else
    //            result.Add(item);
    //    }
    //    return result;
    //}
    //public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
    //{
    //    if (source is null) throw new ArgumentNullException(nameof(source));
    //    return new ObservableCollection<T>(source);
    //}

    //public static void Fill<T>(this ICollection<T> collection, int quantity, T value, bool canOverwrite = true)
    //{
    //    if (collection is null) throw new ArgumentNullException(nameof(collection));
    //    if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
    //    if (canOverwrite) collection.Clear();
    //    for (int i = 0; i < quantity; i++)
    //        collection.Add(value);
    //}

}
