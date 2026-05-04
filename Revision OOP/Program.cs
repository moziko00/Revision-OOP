using Common;

namespace Revision_OOP
{
    class Program
    {
        static void Main()
        {
            Point P1;
            // Declare for object of type "Point".
            // CLR Will Allocate 8 UnInitialized Bytes in Stack.

            P1 = new Point(1, 2);

            //new => is just for the constructor selection that will initialize the struct object


            Console.WriteLine(P1);



        }


    }
}
