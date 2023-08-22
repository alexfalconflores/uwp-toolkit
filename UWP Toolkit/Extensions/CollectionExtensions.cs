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
    /// <param name="canOverwrite">Indicates whether the collection should be deleted before filling.</param>
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
}
