using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct MyStruct : IComparable
    {
        public int Frequency { get; set; }
        public char Letter { get; set; }

        public int CompareTo(object obj)
        {
            return (int)obj > Frequency ? 1 : 0;
        }
    }

    class Node
    {
        List<MyStruct> m = new List<MyStruct>();
        public void Count(string s)
        {
            var unique = s.Distinct();
            foreach (var item in unique)
            {
                m.Add(new MyStruct()
                {
                    Letter = item,
                    Frequency = s.Where(x => x == item).Count()
                });            
            }
            m.Sort((b, a) => a.Frequency - b.Frequency);
            foreach (var item in m)
            {
                 Console.WriteLine($"{item.Letter}----{item.Frequency}");
            }
        }

    }
}
