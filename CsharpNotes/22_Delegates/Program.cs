using System;

namespace _22_Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegateWithParameter(string message);
    public delegate int myDelegateWithReturn(int number1,int number2);

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAllert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAllert;
            myDelegate();

            myDelegate -= customerManager.ShowAllert;
            myDelegate();

            MyDelegateWithParameter myDelegateWithParameter = customerManager.ShowAllert2;
            myDelegateWithParameter += customerManager.SendMessage2;
            myDelegateWithParameter("Hello World");

            Math math = new Math();
            myDelegateWithReturn myDelegateWithReturn = math.Add;
            myDelegateWithReturn += math.Multiply;
            int result = myDelegateWithReturn(5, 10);
            Console.WriteLine(result); // Output: 50 (5 + 10 ? 5 * 10)
            // Note: The last result will be the result of the last method in the delegate chain, which is Multiply in this case.
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Message Sent");
        }
        public void ShowAllert()
        {
            Console.WriteLine("Be careful");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAllert2(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Math
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
