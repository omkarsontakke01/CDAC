// Define the namespace for organizing related classes
namespace ConsoleApp2.Day_2
{
    // Internal class means it is accessible only within this assembly
    internal class InterfaceImpl
    {
        // Define interface IX with two methods: Add and Mul
        public interface IX
        {
            void Add(int a, int b);   // Method to add two integers
            void Mul(int a, int b);   // Method to multiply two integers
        }

        // Define interface IY with two methods: Add and Div
        public interface IY
        {
            void Add(int a, int b);   // Method to add two integers
            void Div(int a, int b);   // Method to divide two integers
        }

        // Demo class implements both IX and IY interfaces
        public class Demo : IX, IY
        {
            // Explicit implementation of IX.Add
            void IX.Add(int a, int b)
            {
                Console.WriteLine("In IX Add : {0}", a + b);
            }

            // Explicit implementation of IY.Add
            void IY.Add(int a, int b)
            {
                Console.WriteLine("In IY Add : {0}", a + b);
            }

            // Explicit implementation of IY.Div
            void IY.Div(int a, int b)
            {
                Console.WriteLine("In IY Div : {0}", a / b);
            }

            // Explicit implementation of IX.Mul
            void IX.Mul(int a, int b)
            {
                Console.WriteLine("In IX Mul : {0}", a * b);
            }
        }

        #region Main method
        // Entry point of the program (currently commented out)
        //static void Main(string[] args)
        //{
        //    // Create object of Demo class
        //    // Demo obj = new Demo(); // Not useful here because methods are explicitly implemented

        //    // Access Demo through IX interface reference
        //    IX obj = new Demo();
        //    obj.Add(1, 2);   // Calls IX.Add
        //    obj.Mul(1, 2);   // Calls IX.Mul

        //    // Access Demo through IY interface reference
        //    IY obj1 = new Demo();
        //    obj1.Add(1, 2);  // Calls IY.Add
        //    obj1.Div(4, 2);  // Calls IY.Div
        //}
        #endregion
    }
}
