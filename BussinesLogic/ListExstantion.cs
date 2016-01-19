using System;
using System.Collections.Generic;

namespace Logic
{
    public static class ListExstantion
    {
        public static List<T> MyReverse<T>(this List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("List is empty.");
            else if (list.Count <= 1)
                return list;
            list.Reverse();
            return list;
        }
    }
}