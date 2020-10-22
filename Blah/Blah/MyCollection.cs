using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Blah
{

    public class blah
    {
        // static void Main(string[] args)
        // {
        //     MyCollection<int> IntCollection = new MyCollection<int>();
        //     IntCollection.Add(1);
        //     IntCollection.Add(2);
        //     IntCollection.Add(3);
        //     IntCollection.Add(4, 1);
        //     Console.WriteLine("Display integer list:");
        //     IntCollection.DisplayItems();
        //
        //     MyCollection<string> StringCollection = new MyCollection<string>();
        //     StringCollection.Add("aa");
        //     StringCollection.Add("bb");
        //     StringCollection.Add("cc");
        //     StringCollection.Add("dd", 1);
        //     Console.WriteLine("Display string list:");
        //     StringCollection.DisplayItems();
        //     Console.ReadLine();
        // }
    }

    public class MyCollection<T>
    {
        private readonly List<T> _data;

        public MyCollection()
        {
            _data = new List<T>();
        }

        public void Add(T obj)
        {
            _data.Add(obj);
        }

        public void Add(T obj, int k)
        {
            _data.Insert(k,obj);
        }

        public void DisplayItems()
        {
            foreach (var x in _data)
            {
                Console.WriteLine(x);
            }
        }

    }
}