using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1,"Hakkı");
            myDictionary.Add(2, "Karakaş");
            myDictionary.Add(3, "İzmir");

            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine("Key: "+myDictionary.Keys[i]+"  "+"Value: "+myDictionary.Values[i]);
            }
        }
    }
   
}
