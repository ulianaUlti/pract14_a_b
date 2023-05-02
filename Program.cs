using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Practica_14
{
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();

            Console.WriteLine("Введите число элементов");
            int num = int.Parse(Console.ReadLine());


            if (num < 1)
                Console.WriteLine("Введи от 1 до нужного числа");
            else
            {

                Console.WriteLine("n: " + num);
                for (int i = 0; i < num; i++)
                {
                    intStack.Push(i);
                }

                Console.WriteLine("Размерность стека: " + intStack.Count());
                Console.WriteLine("Верхний элемент стека: " + intStack.Peek());
                Console.WriteLine("Содержимое стека: ");
                while (intStack.Count != 0)
                {
                    Console.WriteLine("{0}", intStack.Pop());
                    Console.WriteLine("Новая размерность стека " + intStack.Count());

                }

                //Console.Write("Новая рамерность стека: " +0);
            }



            //2 задание
            ///
            Console.WriteLine("Введите выражение");
            string math = Convert.ToString(Console.ReadLine());

            StreamWriter t = File.AppendText("Math.txt");
            t.WriteLine("выражение " + t);
            t.Close();

            string t2 = File.ReadAllText("Math.txt");
            Stack<int> st = new Stack<int>();
            bool inString = false;
            for(int i = 0; 1 < t2.Length; i++)
            {
                char num = t2[i];
                if (num = '"')
                {
                    inString = inString;
                }
                else if (!inString)
                {
                    if (num == ')')
                    {
                        st.Push(i);
                    }
                    else if (st.Count > 0)
                    {
                        st.Pop();
                    }
                    //if(num==){
                    //}

                    else
                    {
                        Console.WriteLine("Лишняя скобка в позиции: {0}",+ i+1);
                        return

                    }

                    if (st.Count == 0)
                    {
                        Console.WriteLine("Cбаланированы");
                    }

                    else
                    {

                        Console.WriteLine("Лишняя скобка в позиции: {0}", st.Pop()+1);
                     9
                    }

                }
                ///2задание часть б
                ///
                Console.WriteLine("Введите выражение");
                string math1 = Convert.ToString(Console.ReadLine());

                StreamWriter txt = File.AppendText("Math.txt");

                string t13 = File.ReadAllText("Math.txt");

                Stack<int> str = new Stack<int>();
                for(int i = 0; i < t13.Lenght i++)
                {
                    if (t13[i] == '(')
                    {
                        str.Push();
                    }
                    else if (t13[i] == ')')
                    {
                        if (str.Count > 0)
                        {
                            str.Pop();
                        }
                        else
                        {
                            t13 = t13.Remove(i, 1);
                            t13 = t13.Insert(i, " ");

                        }
                    }
                }
                while (str.Count > 0)
                {
                    int ii = str.Pop();
                    t13=t13.Insert(ii," ")
                    t13 = t13.Remove(i, 1);
                }
                StreamWriter sw12 = File.AppendText("Math.txt");
                sw12.WriteLine(t13);
                sw12.Close();

            }
   
        }     
}   } 

    




    

