using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Tools.Model
{
    static class ListExtension
    {
        public static T[] ToArray<T>(this IList<T> list)
        {
            T[] arr = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }

        public static string JoinToString<T>(this IList<T> list, char sep = ',')
        {
            string res = string.Empty;
            string spliter = new string(new char[] { sep });
            foreach (var item in list)
            {
                res += item + spliter;
            }
            return res.TrimEnd(sep);
        }
    }
}
