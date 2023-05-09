using System;

namespace CsharpString
{
    class Test
    {
        public static void Main(string[] args)
        {

            //create string 
            string str1 = "C#";
            Console.WriteLine("String str1: " + str1);

            //create string
            string str2 = "Programming";
            Console.WriteLine("String str2: " + str2);

            //join two strings

            string joinedString = string.Concat(str1, str2);

            Console.WriteLine("JoinedString: " + joinedString);
            Console.ReadLine();
           
            /*get length of str
            int length = str.Length;

            Console.WriteLine("Length: " + length);*/
        }
    }
}
