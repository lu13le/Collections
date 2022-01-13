using System;
using System.Collections;
using System.Collections.Generic;

namespace LukaRaicevicWeek1AkvelonInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STEK");
            Stack stek = new Stack();
            stek.Push(1);
            stek.Push(2);
            stek.Push(3);

            Console.WriteLine("Itemi u steku:\n ");
            foreach (var item in stek)
            {
                Console.WriteLine(item);
            }
            stek.Pop();
            Console.WriteLine("\nItemi posle stek.pop()");
            foreach (var item in stek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nRED");
            Queue red = new Queue();

            red.Enqueue(1);
            red.Enqueue(2);
            red.Enqueue(3);
            Console.WriteLine("Itemi u redu:\n ");
            foreach (var item in red)
            {
                Console.WriteLine(item);
            }
            red.Dequeue();
            Console.WriteLine("\nItemi posle red.Dequeue()");
            foreach (var item in red)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nARRAY LIST");

            ArrayList al = new ArrayList();
            al.Add(true);
            al.Add("Luka");
            al.Add(1);
            Console.WriteLine("Itemi u array listi:\n ");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            al[0] = false;
            al[1] = "Ivana";
            al[2] = "Akvelon";

            Console.WriteLine("\nItemi u array listi posle update:\n ");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nItemi u array listi posle delete:\n ");


            al.Remove(false);
            al.Remove("Ivana");



            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLISTA");
            Console.WriteLine("Clanovi liste: \n");
            List<string> lista = new List<string>();
            lista.Add("Ja sam ");
            lista.Add("Luka ");
            lista.Add("Raicevic\n");

            foreach (var item in lista)
            {
                Console.Write(item);
            }

            lista[1] = "Ivan ";
            lista[2] = "Stefanovic\n";
            Console.WriteLine("\nClanovi LISTE posle update: \n");
            foreach (var item in lista)
            {
                Console.Write(item);
            }
            lista.Remove("Ja sam ");
            Console.WriteLine("\nClanovi LISTE posle delete:\n");
            foreach (var item in lista)
            {
                Console.Write(item);
            }
            Console.WriteLine("\nDICTIONARY");
            Console.WriteLine("Clanovi Dikšnerija: \n");
            Dictionary<int,string> dict=new Dictionary<int,string>();

            dict.Add(13, "Luka");
            dict.Add(1, "Milan");
            dict.Add(3, "Ana");

            foreach (var item in dict) { Console.WriteLine(item); }

            dict.Remove(13);
            Console.WriteLine("\nClanovi Dikšnerija posle Delete: \n");
            foreach (var item in dict) { Console.WriteLine(item); }

            dict[1] = ("Milutin Milankovic");
            Console.WriteLine("\nClanovi Dikšnerija posle Update: \n");
            foreach (var item in dict) { Console.WriteLine(item); }
        }
    }
}
