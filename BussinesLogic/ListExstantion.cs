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

        public static List<T> MyStructReverse<T>(this List<T> list) where T :struct
        {
            if (list == null)
                throw new ArgumentNullException("List is empty.");
            else if (list.Count <= 1)
                return list;
            List<T> _list = new List<T>();
            foreach (var item in list)
            {
                _list.Add(item);
            }
            _list.Reverse();
            return _list;
        }
    }

    public static class ListStructReverse<T> where T : struct
    {
        public static List<T> MyReverse(List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("List is empty.");
            else if (list.Count <= 1)
                return list;
            List<T> _list = new List<T>();
            foreach (var item in list)
            {
                _list.Add(item);
            }
            _list.Reverse();
            return _list;
        }
    }
}