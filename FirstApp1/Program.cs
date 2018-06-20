using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp1
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        // f(n) = f(n-1)+f(n-2)
        //1, 1, 2, 3, 5, 8, 13, 21,...
        // F(0) = 0; F(1) = 1

        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            int x = Fibonachi(8);
            Console.WriteLine(x);
            Console.WriteLine(Fibonachi(4));
            Console.WriteLine(Fibonachi(6));
            Console.ReadKey();
        }
          
    }
}

// public используем для того, чтобы метод был доступен извне
// void использумем, т.к. метод не будет возвращать какое-то значение, а просто выполнять некоторые действия
// тип object может хранить любое значение (число, символ и т.д.)
// float q = 166.45F;
// decimal r = 5.4M;
// a++; // операция инкремент увеличивает на 1
// a--; // декремент уменьшает на 1
// cheched проверяет значение, входит ли в нужный диапазон


// try-catch
// в try помещается та часть когда, которая может вызвать ошибку


/*

   // тернарный оператор 
           int x = 3;
           int y = 2;
           Console.WriteLine("Нажмите + или -");
           string selection2 = Console.ReadLine();
           // условие1(нажали + или -), если "+", то true и выполняется (x + y), если "-", то false и выполняется (x - y)
           int z = selection2 == "+" ? (x + y) : (x - y);
           Console.WriteLine(z);
*/
