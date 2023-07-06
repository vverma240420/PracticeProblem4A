using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLoggerDemo
{
    internal class DataManipulation
    {
        private ArrayList list;

        public DataManipulation()
        {
            list = new ArrayList();
        }

        public void Create(string item)
        {
            list.Add(item);
        }

        public void Read()
        {
            Console.WriteLine("Items in the list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void Update(int index, string newItem)
        {
            if (index >= 0 && index < list.Count)
            {
                list[index] = newItem;
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
    }
}
