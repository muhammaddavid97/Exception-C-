using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{

    /*
        - Multiple Catch merupakan metode untuk menangkap beberapa jenis exception dalam satu program.
     */
    public class MultipleCatch
    {
        public static void main() 
        {
            catchs();
        }

        public static void catchs() 
        {
            int[] numbers = new int[2];

            try
            {
                numbers[0] = 3;
                numbers[1] = 'a';
                numbers[2] = 2;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);    
            }
        }
    }
}
