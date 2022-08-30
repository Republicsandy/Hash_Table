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
            //storing the sentence in paragraph variable
            String sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            //using split function , split is mainly used to split string based on the delimiters passed to the string
            string[] paragraphSentence = sentence.Split(' ');
            //gets the length of array string
            int StringLength = paragraphSentence.Length;
            // Itreating along each word and adding it to hash set
            for (int i = 0; i < StringLength; i++)
            {
                hashtable.Add(Convert.ToString(i), paragraphSentence[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Removing the word 'avoidable' from the hash table ");
            Console.WriteLine("Frequency of 'avoidable' before removal is :" + hashtable.GetFrequency("avoidable"));
            hashtable.RemoveValue("avoidable");
            Console.WriteLine("Frequency of 'avoidable' after removal is :" + hashtable.GetFrequency("avoidable"));
            Console.ReadLine();
        }
    }
}
