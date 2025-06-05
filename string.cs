using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema4
{
    public static class @string
    {
        public static List<int> ToIntegerList(this string input)
        {
            return input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => {
                    bool success = int.TryParse(s.Trim(), out int num);
                    return (success, num);
                })
                .Where(t => t.success)
                .Select(t => t.num)
                .ToList();
        }
    }
}