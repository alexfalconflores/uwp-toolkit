using System;
using System.Collections.Generic;
using System.Linq;

namespace UWP_Toolkit.Extensions;

/// <summary>
/// Collection Extensions.
/// </summary>
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

    /// <summary>
    /// Get a random element from the collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <returns>Element</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static T RandomChoice<T>(this ICollection<T> source)
    {
        if (source is null) throw new ArgumentNullException(nameof(source));
        if (!source.Any()) throw new ArgumentException("The source collection is empty.", nameof(source));
        var random = new Random();
        var index = random.Next(source.Count());
        return source.ElementAt(index);
    }
}
