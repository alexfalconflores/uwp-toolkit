using System.Collections.ObjectModel;

namespace ConsoleAppNet7;

public static class List
{
    public static IEnumerable<object> Flat(this IEnumerable<object> source)
    {
        List<object> result = new();
        Stack<object> stack = new(source);
        while (stack.Count > 0)
        {
            object item = stack.Pop();
            if (item is IEnumerable<object> nestedSubList)
                foreach (var subItem in nestedSubList)
                    stack.Push(subItem);
            else
                result.Insert(0, item);
        }
        return result;
    }
    public static List<object> RecursiveFlat(this List<object> inputList)
    {
        List<object> result = new();
        foreach (var item in inputList)
        {
            if (item is List<object> nestedSubList)
                result.AddRange(RecursiveFlat(nestedSubList));
            else
                result.Add(item);
        }
        return result;
    }

    public static List<T> ToListX<T>(this IEnumerable<T> source)
    {
        return new List<T>(source);
    }
    public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
    {
        if (source is null) throw new ArgumentNullException(nameof(source));
        return new ObservableCollection<T>(source);
    }
}
