using Revision_OOP.Encapsulation;
using Revision_OOP.Inheritance;
using Revision_OOP.InterfaceExample_01;

namespace Revision_OOP
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return (x + y + z);
        }

        static void PrintTenNumbersFromSeries(TypeSeries series)
        {
            if (series is null)
                return;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(series.Current);
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main()
        {
            #region Struct
            //Point P1;
            //// Declare for object of type "Point".
            //// CLR Will Allocate 8 UnInitialized Bytes in Stack.

            //P1 = new Point(1, 2);

            ////new => is just for the constructor selection that will initialize the struct object


            //Console.WriteLine(P1); 
            #endregion

            #region Encapsulation
            //Employee employee = new Employee(1001,"Mohamed Zakaria",10_000);


            //employee.SetId(2002); // Setter

            //Console.WriteLine(employee.GetId()); // Getter 
            #endregion

            #region Indexer

            //PhoneBook note = new PhoneBook(10);

            //note.AddPerosn(0, "Ahmed", 11111);
            //note.AddPerosn(1, "Nadia", 22222);
            //note.AddPerosn(2, "Osama", 33333);
            //note.AddPerosn(3, "Amany", 44444);


            ////note.SetNumber("Ahmed", 99999);
            ////Console.WriteLine(note.GetNumber("Ahmed")); 


            ////Console.WriteLine(note["Ahemd"]);
            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //} 
            #endregion

            #region Class


            // Car C1;
            /// Declare For reference of type Car.
            /// This Reference is refering to the default value of the reference types = null
            /// This reference 'C1' Can Refer to an object of type car or another Type inherting from Car.
            /// Clr Will Allcote 4 UnInitialized Bytes in Stack for the Reference 'C1'.
            /// CLR Will Allocte 0 Bytes in Heap.

            // C1 = new Car();
            // new 
            /// 1. Allocate Required number of bytes for the allocated object in HEAB == 16 byte
            /// 2. Initialize (Cross Out) The Allocated bytes with for each and every attribute with default value
            /// 3. Call User Defined Constructor [if Exist]
            /// 4. Return address of the allocated object to the reference C1.


            //Console.WriteLine(C1.ToString());

            #endregion

            #region Inheritance



            //Parent parent = new Parent(1, 2);
            //parent.X = 11;
            //parent.Y = 22;

            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Prodcut());

            //  Child child = new Child(1, 2, 3);
            // 
            //  child.X = 11;
            //  child.Y = 22;
            //  child.Z = 33;

            #endregion

            #region PolyMorphism 1. Overloading

            //dynamic result = Sum(1, 2);

            //Console.WriteLine($"Result = {result}"); 
            #endregion

            #region Binary Operator
            //Complex C1 = new Complex() { Real = 2 , Imag =4}; 
            //Complex C2 = new Complex() { Real = 3 , Imag =5};

            //Complex C3 = default; // Default value is null



            //C3 = C1 + C2;


            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C2 = {C2}");
            //Console.WriteLine($"======================");

            //Console.WriteLine($"C3 = {C3}"); 
            #endregion

            #region Unary Operator
            //Complex C1 = new Complex() { Real = 2, Imag = 4 };
            //Complex C2 = new Complex() { Real = 3, Imag = 5 };

            //Console.WriteLine($"C1 = {C1}");



            //Complex C3 = ++C1;
            //Console.WriteLine("After ++C1");

            //Console.WriteLine($"C1 = {C1}"); 
            #endregion

            #region Comparison Operator
            //if (C1 > C2)
            //    Console.WriteLine("C1 Bigger Than C2");

            //else
            //    Console.WriteLine("C2 bigger Than C1"); 
            #endregion

            #region Overriding
            //Complex C1 = new Complex() { Real = 2, Imag = 4 };
            //Complex C2 = new Complex() { Real = 3, Imag = 5 };



            //int Y = (int)C1;

            //Console.WriteLine($"Y {Y}"); 
            #endregion

            #region Interface Example 01

            //IType reference;
            //// Declare for Reference of type "Itype", Containg Garbag Value
            //// This Reference 'type' can refer to an object of any type implementing Itype Interface
            //// CLR will allocate 4 uninitialized Bytesin stack fot this reference.
            //// CLR will allocate 0 bytes in heap.

            ////reference = /*new IType()*/; => Invalid;

            //reference = new TypeA();

            //reference.MyProperty = 1;
            //reference.MyMethod(); // Hello World
            //reference.Print(); 
            #endregion


            TypeSeries seriesByTwo = new TypeSeries();


            PrintTenNumbersFromSeries(seriesByTwo);





        }


    }
}
