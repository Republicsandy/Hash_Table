using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Programs
{
    internal class My_Map_Node<K,V>
    {
        //defining variables
        public readonly int size;
        public readonly LinkedList<keyValue<K, V>>[] items;
        public My_Map_Node(int size)
        {
            this.size = size;
            this.items = new LinkedList<keyValue<K, V>>[size];
        }
        public struct keyValue<k, v>
        {
            public k key { get; set; }
            public v value { get; set; }
            public int Frequency { get; set; }
        }
        protected LinkedList<keyValue<K, V>> GetLinkedlist(int position)
        {
            LinkedList<keyValue<K, V>> linkedlist = items[position];

            if (linkedlist == null)
            {
                linkedlist = new LinkedList<keyValue<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        protected int GetArrayPosition(K key)
        {
            //gethashcode gives position value using inbuilt function
            int position = key.GetHashCode() % size;
            //returning absolute position
            return Math.Abs(position);
        }
        // Gets the value at the specified key.
        // Generic Method to find the key value pair at the particular position
        public V Get(K key)
        {
            int position = GetArrayPosition(key);

            LinkedList<keyValue<K, V>> linkedlist = GetLinkedlist(position);

            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default;
        }
        public void Add(K key, V value)
        {
            //gets the psotion of key
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedlist(position);
            keyValue<K, V> item = new keyValue<K, V>() { key = key, value = value };
            //adds the key to the list 
            linkedlist.AddLast(item);
           // Console.WriteLine(item.value + " :- is Added at Index : " + item.key);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedlist(position);
            bool itemFound = false;
            keyValue<K, V> foundItem = default(keyValue<K, V>);
            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(foundItem);
            }
        }

        // UC 1 : Prints the frequency of the specified value in the hashtable.        
        public int GetFrequency(V value)
        {
            int frequency = 0;
            // Iterating using the foreach loop to get the key value of each item
            foreach (LinkedList<keyValue<K, V>> list in items)
            {
                // checking if key is not null 
                if (list == null)
                {
                    continue;
                }
                // iterating using the foreach loop to get the value of the item in linked list
                foreach (keyValue<K, V> obj in list)
                {
                    if (obj.Equals(null))
                    {
                        continue;
                    }
                    if (obj.value.Equals(value))
                    {
                        frequency++;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Word '{0}' appears {1} times", value, frequency);
            return frequency;
        }
        public void RemoveValue(V value)
        {
            // Iterating through foreach loop to get the key value pair in the list
            foreach (LinkedList<keyValue<K, V>> list in items)
            {
                if (list == null)
                    continue;
                // iterating through loop to get each object in the list
                foreach (keyValue<K, V> obj in list)
                {
                    if (obj.Equals(null))
                        continue;
                    // if the object matches the value then it will be removed
                    if (obj.value.Equals(value))
                    {
                        Remove(obj.key);
                        break;
                    }
                }
            }
        }
    }
}
