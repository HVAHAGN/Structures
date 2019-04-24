using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St_Inheritance_02
{
    // Структуры. Наследование.

    // Все структуры неявно наследуются от абстрактного класса - ValueType
    struct MyStruct // : ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

    class Program
    {
        static void Main()
        {
            MyStruct instance = new MyStruct();

            ValueType valueType = instance as ValueType;

            Console.WriteLine("instance  = {0}", instance.GetHashCode());
            Console.WriteLine("valueType = {0}", valueType.GetHashCode());

            // Delay.
            Console.ReadKey();
        }
    }
}
