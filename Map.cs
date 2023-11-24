using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    /// <summary>
    /// Represents a generic map interface.
    /// </summary>
    /// <typeparam name="K">The type of keys in the map.</typeparam>
    /// <typeparam name="V">The type of values in the map.</typeparam>
    internal interface Map<K, V>
    {
        /// <summary>
        /// Gets the number of key-value pairs in the map.
        /// </summary>
        int Size
        {
            get;
        }
        /// <summary>
        /// Checks if the map is empty.
        /// </summary>
        /// <returns>True if the map is empty; otherwise , false.</returns>
        bool IsEmpty();

        /// <summary>
        /// Clears all key-value pairs from the map.
        /// </summary>
        void Clear();

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The specified key.</param>
        /// <returns>The value associated with the key.</returns>
        V Get(K key);

        /// <summary>
        /// Adds a specified key-value pair in the map.
        /// </summary>
        /// <param name="key">The specified key.</param>
        /// <param name="value">The specified value.</param>
        /// <returns>The previous value associated with the key.</returns>
        V Put(K key, V value);

        /// <summary>
        /// Removes the key-value pair associated with the specified key.
        /// </summary>
        /// <param name="key">The specified key.</param>
        /// <returns>The value associated with the removed key.</returns>
        V Remove(K key);

        /// <summary>
        /// Gets an enumerator for the keys in the map.
        /// </summary>
        /// <returns>An enumerator for the keys.</returns>
        IEnumerator<K> Keys();

        /// <summary>
        /// Gets an enumerator for the values in the map.
        /// </summary>
        /// <returns>An enumerator for the values.</returns>
        IEnumerator<V> Values();
    }
}
