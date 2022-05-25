using System;

namespace _209_Task3
{
    public delegate double ArrDelegate(ElemDelegate[] array);

    public delegate int ElemDelegate();

    static class Container
    {
        public static int GiveRandomNum()
        {
            Random rand = new Random();
            int a = rand.Next(0,10);
            Console.WriteLine(a);
            return a;      
            //return 9;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            ElemDelegate delegate1 = new ElemDelegate(Container.GiveRandomNum);
            ElemDelegate delegate2 = () => { int a = rand.Next(0, 10); Console.WriteLine(a); return a; };
            //ElemDelegate delegate2 = () => 9;
            ElemDelegate delegate3 = () => { int a = rand.Next(0, 10); Console.WriteLine(a); return a; };
            //ElemDelegate delegate3 = () => 3;

            ElemDelegate[] array = {delegate1, delegate2, delegate3};

            ArrDelegate delegateArray = delegate (ElemDelegate[] array1) { return (double)(array1[0].Invoke() + array1[1].Invoke() + array1[2].Invoke()) / (double)array1.Length; };

            Console.WriteLine("The mean of 3 random numbers = {0:F2}", delegateArray(array));

            Console.ReadKey();
        } 
    }
}
