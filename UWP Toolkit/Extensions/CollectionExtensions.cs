using System;
using System.Collections.Generic;

namespace UWP_Toolkit.Extensions;

public static class CollectionExtensions
{
    /// <summary>
    /// Fill the collection with the value entered for the given quantity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="quantity"></param>
    /// <param name="value"></param>
    /// <param name="canOverwrite"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static void Fill<T>(this ICollection<T> collection, int quantity, T value, bool canOverwrite = true)
    {
        if (collection is null) throw new ArgumentNullException(nameof(collection));
        if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
        if (canOverwrite) collection.Clear();
        for (int i = 0; i < quantity; i++)
            collection.Add(value);
    }
    #region Fill Examples
    /*
     * List<string> values = new();
values.Fill(10, "A");
foreach (var item in values)
{
    Console.WriteLine(item);
}

ObservableCollection<string> strings = new();
strings.Fill(10, "b");
foreach (var item in strings)
{
    Console.WriteLine(item);
}

List<int> numbers = new();
numbers.Fill(10, 4);
numbers.Fill(10, 6, false);
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
     */
    #endregion Fill Examples


}
