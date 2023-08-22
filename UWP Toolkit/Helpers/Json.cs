using Newtonsoft.Json;
using System.Threading.Tasks;

namespace UWP_Toolkit.Helpers;

public static class Json
{
    /// <summary>
    /// Converts the specified JSON string to an object of type T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    /// <returns>
    /// Returns an object of type T.
    /// </returns>
    public static async Task<T> ToObjectAsync<T>(string value) => await Task.Run<T>(() => JsonConvert.DeserializeObject<T>(value));

    /// <summary>
    /// Converts a specified object to a JSON string.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static async Task<string> StringifyAsync(object value) => await Task.Run<string>(() => JsonConvert.SerializeObject(value));
}
