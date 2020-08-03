using System;

namespace Permutation
{
    class Program
    {
        const int CHARSLIMIT = 128;
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two strings");
            var sentence1 = Console.ReadLine();
            var sentence2 = Console.ReadLine();
            System.Console.WriteLine(IsPermutation(sentence1, sentence2) ? "Is Permutation": "Is Not Permutation");
        }

        static bool IsPermutation(string sentence1, string sentence2){
            int[] values = new int[CHARSLIMIT];
            char[] char1 = sentence1.ToCharArray();
            char[] char2 = sentence2.ToCharArray();

            if(sentence1.Length != sentence2.Length){
                return false;
            }

            for (int i = 0; i < char1.Length; i++)
            {
               ++values[(int)char1[i]];
            }

            for (int i = 0; i < char2.Length; i++)
            {
                --values[(int)char2[i]];
                if(values[(int)char2[i]] < 0)
                    return false;
            }

            return true;
        }
    }
}
