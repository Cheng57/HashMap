using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    /// <summary>
    /// Represents a stringKey.
    /// </summary>
    internal class StringKey : IComparable<StringKey>
    {
        /// <summary>
        /// Gets the KeyName of the stringKey.
        /// </summary>
        public string KeyName
        {
            get;
        }

        /// <summary>
        /// Initilizes an instance of StringKey class with a specified KeyName.
        /// </summary>
        /// <param name="KeyName">The specified keyName.</param>
        public StringKey(string KeyName)
        {
            this.KeyName = KeyName;
        }

        /// <summary>
        /// Compares a StringKey object to another StringKey object based on the KeyName property. 
        /// Returns true if the objects have the same KeyName, otherwise returns false.
        /// </summary>
        /// <param name="obj">The specified StringKey object.</param>
        /// <returns>True if the objects have the same KeyName, otherwise false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            StringKey otherStringKey = (StringKey)obj;

            return KeyName == otherStringKey.KeyName;
        }

        /// <summary>
        /// Compares a StringKey object to another StringKey object based on the KeyName property.
        /// Returns 1 when the specified StringKey object is null.
        /// Returns 0 when the two objects have the same KeyName.
        /// Returns a positive number when the specified StringKey object with a KeyName comes alphabetically before the instance object.
        /// Returns a negative number when the specified StringKey object with a KeyName comes alphabetically after the instance object.
        /// </summary>
        /// <param name="other">The specified StringKey object.</param>
        /// <returns>Returns 1 when the specified StringKey object is null.
        /// Returns 0 when the two objects have the same KeyName.
        /// Returns a positive number when the specified StringKey object with a KeyName comes alphabetically before the instance object.
        /// Returns a negative number when the specified StringKey object with a KeyName comes alphabetically after the instance object.</returns>
        public int CompareTo(StringKey? other)
        {
            if (other == null)
            {
                return 1;
            }

            return KeyName.CompareTo(other.KeyName);
        }

        /// <summary>
        /// Generates a hashcode based on the KeyName using a polynomial equation with a coefficient of 31.
        /// </summary>
        /// <returns>The hashcode.</returns>
        public override int GetHashCode()
        {
            const int coefficient = 31;
            int hashcode = 0;
            int x = 1;

            for (int i = 0; i < KeyName.Length; i++)
            {
                hashcode += x * (int)KeyName[i];

                x *= coefficient;
            }

            return hashcode;
        }

        /// <summary>
        /// Returns a formatted string representation of an instance of StringKey.
        /// </summary>
        /// <returns>The formatted string representation.</returns>
        public override string ToString()
        {
            return String.Format("KeyName: {0} HashCode: {1}", KeyName, GetHashCode());
        }
    }
}
