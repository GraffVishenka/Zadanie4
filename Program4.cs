using System;
using static System.Convert;
using static System.Console;
using System.Collections;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add('Y');
            list.Add(5);
            list.Add('j');
            list.Add(1);
            list.Add(0);
            list.Add('P');
            list.Add(98);
            list.Add(-1);
            list.Add('N');
            list.Add(4);
            list.Add(34);
            list.Add('i');
            list.Add(666);
            list.Add('l');

            ArrayList list2 = new ArrayList();
            WriteLine("Числа: ");
            for (int i = 0; i < list.Count; i++)
            {
                int g = 0;
                string s = list[i] + "";
                bool rez = int.TryParse(s, out g); ;

                if (rez == false)
                {
                    if (s == s.ToUpper())
                    {
                        list2.Add(list[i]);
                        list.RemoveAt(i);
                    }
                    else list.RemoveAt(i);
                }
            }
            foreach (object o in list)
            {
                WriteLine(o);
            }
            WriteLine("Заглавные буквы: ");
            foreach (object o in list2)
            {
                WriteLine(o);
            }
            ReadLine();
        }
    }
}