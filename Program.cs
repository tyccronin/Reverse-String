using System;

namespace REVERSESTRING{
class Program{
    static void Main(string[] args){
            Console.WriteLine("This program will take in a word you type and output it in reverse." + "\n");
            Console.WriteLine("Please enter a string of characters! (A name, a jumble of numbers, anything!)" + "\n");
            Console.WriteLine(Program.reverseString(Console.ReadLine()));
    }

    public static String reverseString(string str){
            char[] chars = str.ToCharArray();
 
                for (int i = 0, j = str.Length - 1; i < j; i++, j--){
                    char c = chars[i];
                    chars[i] = chars[j];
                    chars[j] = c;
                }

            return "The reversed string is: " + new string(chars);
    }
}
}
