﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_02
{
    // / Структуры.

    // Если в структуре имеются члены, которые обращаются к полю и нет пользовательского конструктора,
    //  то требуется при создании экземпляра вызывать конструктор по умолчанию. (Иначе будет ошибка.)
    struct MyStruct
    {
        private int field;

        public int Field
        {
            get { return field; }
            set { field = value; }
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа с вызовом конструктора по умолчанию.
            MyStruct instance = new MyStruct();

            instance.Field = 1;

            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}
