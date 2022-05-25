using System;

namespace _207_Task3
{

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            MyStruct myStruct;

            myClass.change = "not changed";

            myStruct.change = "not changed";

            ClassTaker(myClass);

            StructTaker(myStruct);

            Console.WriteLine("MyClass field = " + myClass.change + "\n" + "MyStruct field = " + myStruct.change);

            Console.ReadKey();
        }
    }
}
