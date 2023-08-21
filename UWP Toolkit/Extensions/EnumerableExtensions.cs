using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UWP_Toolkit.Extensions;

public static class EnumerableExtensions
{
    //public static List<object> RecursiveFlat(this List<object> inputList)
    //{
    //    List<object> result = new();
    //    foreach (var item in inputList)
    //    {
    //        if (item is List<object> nestedSubList)
    //            result.AddRange(RecursiveFlat(nestedSubList));
    //        else
    //            result.Add(item);
    //    }
    //    return result;
    //}
    /// <summary>
    /// Flattens a list of objects
    /// </summary>
    /// <param name="collection"></param>
    /// <returns></returns>
    public static IEnumerable<object> Flatten(this IEnumerable<object> collection)
    {
        List<object> result = new();
        Stack<object> stack = new(collection);
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
    #region Flat Example
    /*
     * List<object> nestedList = new()
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


List<object> newList3 = nestedList.Flat().ToList();
foreach (var item in newList3)
    Console.WriteLine(item);

List<object> newListString = stringList.Flat().ToList();
foreach (var item in newListString)
    Console.WriteLine(item);
     */
    #endregion Flat Example

    /// <summary>
    /// Converts an <see cref="IEnumerable{T}"/> to an <see cref="ObservableCollection{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <returns>Returns an <see cref="ObservableCollection{T}"/> from an <see cref="IEnumerable{T}"/>"/></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
    {
        if (source is null) throw new ArgumentNullException(nameof(source));
        return new ObservableCollection<T>(source);
    }

    #region ToObservableCollection Example
    /*
     * ObservableCollection<object> newListString = stringList.Flat().ToObservableCollection();
foreach (var item in newListString)
    Console.WriteLine(item);
     */
    #endregion ToObservableCollection Example
}
