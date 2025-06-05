using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjsTema4
{
    public class Pair <T1, T2>
    {
        private T1 first;
        private T2 second;
        public Pair(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }
        public (T1, T2) GetValues()
        {
            return (first, second);
        }
    }
}