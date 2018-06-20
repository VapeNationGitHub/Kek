using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp1
{
    class Program
    {
        enum Operation
        {
            Add,
            Sub,
            Mult,
            Div
        }

        static void ApplyOperation(double x, double y, Operation op)
        {
            double result = 0.0;
            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Sub:
                    result = x - y;
                    break;
                case Operation.Mult:
                    result = x * y;
                    break;
                case Operation.Div:
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            ApplyOperation(10, 15, Operation.Add);
            ApplyOperation(10, 15, Operation.Sub);
            ApplyOperation(10, 15, Operation.Mult);
            ApplyOperation(10, 15, Operation.Div);
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
