using System;
using System.Collections.Generic;

namespace NetExtentions
{
    /// <summary>
    /// List with extend methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListEx<T>:List<T>
    {
        public ListEx(){}

        public ListEx(IEnumerable<T> collection):base(collection){}

        /// <summary>
        /// Swap two elements
        /// </summary>
        /// <param name="indexA"></param>
        /// <param name="indexB"></param>
        public void Swap(int indexA, int indexB)
        {
            T tmp = this[indexA];
            this[indexA] = this[indexB];
            this[indexB] = tmp;
        }

        /// <summary>
        /// Swap two elements 
        /// </summary>
        /// <param name="elementA"></param>
        /// <param name="elementB"></param>
        public void Swap(T elementA, T elementB)
        {
            Swap(this.IndexOf(elementA), this.IndexOf(elementA));
        }
    }
}
