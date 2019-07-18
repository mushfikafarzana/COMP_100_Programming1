using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int row = 0; row <= 21; row++)
            {
                for ( int col =0; col <= 76; col++)
                {
                    if ((col- 1) % 8 == 0 || (row-1) % 8 == 0 || col % 8==0|| row%8 ==0)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                        
                }
                Console.WriteLine();
            }
        }
    }
}
