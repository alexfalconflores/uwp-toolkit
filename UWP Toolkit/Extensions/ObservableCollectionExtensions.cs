using System;
using System.Collections.ObjectModel;

namespace UWP_Toolkit.Extensions;

public static class ObservableCollectionExtensions
{
    //cost: O(n)
    /// <summary>
    /// Removes all the elements that match the conditions defined by the specified <see cref="Predicate{T}"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="match">The <see cref="Predicate{T}"/> delegate that defines the conditions of the elements to remove.</param>
    /// <returns>The number of elements removed from the <see cref="ObservableCollection{T}"/></returns>
    /// <exception cref="ArgumentNullException">match is <see langword="null"/></exception>
    public static int RemoveAll<T>(this ObservableCollection<T> collection, Predicate<T> match)
    {
        if (match is null) throw new ArgumentNullException(nameof(match), "The predicate cannot be null");

        int removedCount = 0;
        for (int i = collection.Count - 1; i >= 0; i--)
        {
            if (match(collection[i]))
            {
                collection.RemoveAt(i);
                removedCount++;
            }
        }
        return removedCount;
    }

    //cost: O(n)
    /// <summary>
    /// Removes all the elements that match the conditions defined by the specified <see cref="Predicate{T}"/>, and execute the specified <see cref="Action"/> on each removed item.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="match">The <see cref="Predicate{T}"/> delegate that defines the conditions of the elements to remove.</param>
    /// <param name="onRemoved">The <see cref="Action"/> delegate that represents the custom action to be performed for each element that is removed. </param>
    /// <returns>The number of elements removed from the <see cref="ObservableCollection{T}"/></returns>
    /// <exception cref="ArgumentNullException">match is <see langword="null"/> or onRemoved is <see langword="null"/></exception>
    public static int RemoveAll<T>(this ObservableCollection<T> collection, Predicate<T> match, Action<T> onRemoved)
    {
        if (match is null) throw new ArgumentNullException(nameof(match), "The predicate cannot be null");
        if (onRemoved is null) throw new ArgumentNullException(nameof(onRemoved), "The action cannot be null");

        int removedCount = 0;
        for (int i = collection.Count - 1; i >= 0; i--)
        {
            if (match(collection[i]))
            {
                onRemoved?.Invoke(collection[i]);
                collection.RemoveAt(i);
                removedCount++;
            }
        }
        return removedCount;
    }

    //cost: O(n^2)
    //public static int RemoveAll<T>(this ObservableCollection<T> collection, Predicate<T> match)
    //{
    //    List<T> itemsToRemove = collection.Where(item => match(item)).ToList();

    //    foreach (T itemToRemove in itemsToRemove)
    //    {
    //        collection.Remove(itemToRemove);
    //    }
    //    return itemsToRemove.Count;
    //}
}
