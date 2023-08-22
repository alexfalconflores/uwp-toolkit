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
    /// Flattens a collection of nested objects, returning a flat sequence of objects.
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
}
