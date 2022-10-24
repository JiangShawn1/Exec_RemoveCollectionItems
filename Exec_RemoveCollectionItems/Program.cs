using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
    internal class Program
    {
        static void Main(string[] args)
        //在集合中移除多個項目
        {
            List<int> ints = new List<int> { 1,2,3,4,5,6,7,8,9,};
            ints.Remove(1);
            ints.Remove(2);
            ints.Remove(3);
            ints.Remove(4);
            ints.Remove(5);

        }
    }
}
