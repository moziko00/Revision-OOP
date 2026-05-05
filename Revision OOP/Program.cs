using Common;
using Revision_OOP.Encapsulation;

namespace Revision_OOP
{
    class Program
    {
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


            PhoneBook note = new PhoneBook(10);

            note.AddPerosn(0, "Ahmed", 11111);
            note.AddPerosn(1, "Nadia", 22222);
            note.AddPerosn(2, "Osama", 33333);
            note.AddPerosn(3, "Amany", 44444);


            //note.SetNumber("Ahmed", 99999);
            //Console.WriteLine(note.GetNumber("Ahmed")); 


            //Console.WriteLine(note["Ahemd"]);
            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }


        }


    }
}
