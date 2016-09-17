using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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

        /// <summary>
        /// Clone list
        /// </summary>
        /// <returns></returns>
        public ListEx<T> Clone()
        {
            return this.MemberwiseClone() as ListEx<T>;
        }

        /// <summary>
        /// Compare list
        /// </summary>
        /// <param name="listToCompare"></param>
        /// <returns></returns>
        public int Compare(ListEx<T> listToCompare)
        {
            if (listToCompare==null)
                return -1;

            if (this.Count != listToCompare.Count)
                return -1;

            for(int i=0; i< this.Count; i++)
            {
                var currentProperties = this[i].GetType().GetProperties();
                var compareProperties = listToCompare[0].GetType().GetProperties();
                for(int j =0;j<currentProperties.Length;j++)
                {
                    var type = currentProperties[j].GetType();
                    if (type == typeof (string))
                    {
                        //TODO
                    }
                }
            }
            return 0;
        }

        private static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
