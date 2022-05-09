using System;

namespace ShiftCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ARG";
            int shift = 3; //DetermineShift();
            string output = ShiftCypher(input, shift);
            Console.WriteLine(output);
        }
        
        static string ShiftCypher(string s, int shift)
        {
            string encodedS = " ";
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    int ascii = (int)c;
                    ascii += shift;
                    if (ascii >= (int)'a' && ascii <= (int)'z')
                    {
                        char shiftedC = (char)ascii;
                        encodedS += shiftedC;
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    encodedS += c;
                }
                
            }
            return encodedS;
        }

        static int DetermineShift()
        {
            int shift = 0;
            Random gen = new Random();
            int distance = gen.Next(0, 11);
            int negative = gen.Next(0, 1);
            if (negative == 1)
                distance = distance * -1;
            else;
            shift = distance;
            return shift;
        }

        
        
    }


}
