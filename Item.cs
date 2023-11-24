﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    /// <summary>
    /// Represents an item.
    /// </summary>
    internal class Item : IComparable<Item>
    {
        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name
        {
            get;
        }

        /// <summary>
        /// Gets the goldpieces of the item.
        /// </summary>
        public int GoldPieces
        {
            get;
        }

        /// <summary>
        /// Gets the weight of the item.
        /// </summary>
        public double Weight
        {
            get;
        }

        /// <summary>
        /// Initializes an instance of the class item with the specified name, goldPieces and weight.
        /// </summary>
        /// <param name="Name">The specified name.</param>
        /// <param name="GoldPieces">The specified goldPieces.</param>
        /// <param name="Weight">The specified weight.</param>
        public Item(string Name, int GoldPieces, double Weight)
        {
            this.Name = Name;
            this.GoldPieces = GoldPieces;
            this.Weight = Weight;
        }

        /// <summary>
        /// Compares the instance item to the specified object. Returns true if the objects are the same type and have the same properties, otherwise returns false.
        /// </summary>
        /// <param name="obj">The specified object</param>
        /// <returns>Returns true if the objects are the same type and have the same properties, otherwise returns false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Item otherItem = (Item)obj;

            return Name == otherItem.Name &&
                   GoldPieces == otherItem.GoldPieces &&
                   Weight.Equals(otherItem.Weight);
        }

        /// <summary>
        /// Compares the instance item with the specified item based on the Name property. Returns 0 if the items have the same name; 
        /// Returns a positive number if the specified item with a name that comes aphabetically before the instance item.
        /// Returns a negative number if the specified item with a name that comes aphabetically after the instance item.
        /// Returns 1 if the specified item is null.
        /// </summary>
        /// <param name="other">The specified item.</param>
        /// <returns>Returns 0 if the items have the same name; 
        /// Returns a positive number if the specified item with a name that comes aphabetically before the instance item;
        /// Returns a negative number if the specified item with a name that comes aphabetically after the instance item;
        /// Returns 1 if the specified item is null.</returns>
        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }

            return Name.CompareTo(other.Name);
        }

        /// <summary>
        /// Returns a formatted string representation of an instance of Item.
        /// </summary>
        /// <returns>The formatted string representation.</returns>
        public override string ToString()
        {
            return String.Format("{0} is worth {1}gp and weighs {2}kg", Name, GoldPieces, Weight );
        }
    }
}