using System;

namespace Hash_Table_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to HashTable!");
            //creating an object of mapnode class
            My_Map_Node<string, string> hashtable = new My_Map_Node<string, string>(5);
            hashtable.Add("0", "To");
            hashtable.Add("1", "be");
            hashtable.Add("2", "or");
            hashtable.Add("3", "not");
            hashtable.Add("4", "To");
            hashtable.Add("5", "be");
            hashtable.GetFrequency("To");
            string hash5 = hashtable.Get("5");
            Console.WriteLine("5th index value: " + hash5);
        }
    }
}
