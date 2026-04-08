using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OOP___Project__1
{
    public class Generic<T>
    {
        public List<T> MyList { get; set; }
        public Generic()
        {
            MyList = new List<T>();
        }
        public void Add(T item)
        {
            MyList.Add(item);
        }
        public void Show()
        {
            foreach (T item in MyList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
