using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _21_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math math = new Math(2, 3);
            //var result = math.Topla2();
            //var result2 = math.Topla(3, 4);
            //Console.WriteLine(result2);
            //Console.WriteLine(result);
            var type = typeof(Math);

            Math math =(Math)Activator.CreateInstance(type,6,7);
            //var result = math.Topla(4, 5);
            //Console.WriteLine(math.Topla2());
            //Console.WriteLine(result);

            var instance = Activator.CreateInstance(type, 5, 6);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Name of method: {0}",info.Name);
                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine("Parameter: {0} Type: {1}", parameter.Name, parameter.ParameterType);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: {0}", attribute.GetType().Name);
                }
            }


        }
    }


    class Math
    {
        int _num1;
        int _num2;

        [MetodName]
        public Math(int num1,int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public int Topla(int num1, int num2)
        {
            return num1 + num2;
        }

        public int carp(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Topla2()
        {
            return _num1 + _num2;
        }
        [MetodName]
        public int carp2()
        {
            return _num1 * _num2;
        }


    }


    class MetodNameAttribute : Attribute
    {
       
    }
}
