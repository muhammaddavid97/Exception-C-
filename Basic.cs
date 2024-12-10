using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    public class Basic
    {
        /*
            - Exception adalah sebuah kesalahan yang muncul pada saat program berjalan.
            - Exception menyebabkan program tidak dapat beroperasi secara normal.
            - Exception dapat direpresentasikan sebagai sebuah class.
         */

        public static void main() 
        {
            TestException("supriyono");
            TestException2();
        }

        public static void TestException(string teks) 
        {
            char[] str = new char[2];
            string temp = string.Empty;

            // try adalah statement yang berisi blok kode program yang akan memunculkan sebuah error.
            try
            {
                int idx = 0;

                for (int i = 0; i < teks.Length; i++)
                {
                    str[idx] = teks[i];
                    idx++;
                }

                temp = new string(str);
            }

            // catch adala statement yang berisi blok kode program yang akan menangkap jika terjadi exception.
            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(temp);
        }

        public static void TestException2()
        {
            int[] nums = new int[] { 4, 1, 3, 0, 2 };

            try
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int j = i + 1;

                    Console.WriteLine($"{nums[i]} % {nums[j]} = {nums[i] % nums[j]}");
                }
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
