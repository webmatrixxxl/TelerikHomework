using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programing_Homework
{
    public static class ListExtensions
    {
        public static async Task<string> JoinAsStringAsync<T>(this IEnumerable<T> enumerable, string separator)
        {
            string result = await Task.Run(() =>
            {
                var joinedBuilder = new StringBuilder();

                foreach (var item in enumerable)
                {
                    joinedBuilder.Append(item + separator);
                }

                return joinedBuilder.ToString();
            });

            return result;
        }

    }
}
