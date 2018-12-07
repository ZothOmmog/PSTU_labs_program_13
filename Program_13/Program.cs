using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection collection = new MyCollection(100);
            collection.Contains(RandElem.Rand());
            collection.Show();
        }
    }
}
