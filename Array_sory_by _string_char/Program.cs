using System;

namespace Array_sory_by__string_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] ar = { "Ajay", "Ram", "Aman", "Shyam" };
            

            for (int i = 0; i < ar.Length; i++)
            {
                if(ar[i][0]=='A')
                Console.WriteLine(ar[i]);

            }

        }
    }
}
