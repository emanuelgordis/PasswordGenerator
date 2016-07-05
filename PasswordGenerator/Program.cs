using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] validCharacters = new string[] { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K", "l", "L", "m", "M", "n", "N", "o", "O",
            "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y", "z", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^",
                "&", "*", "(", ")", "?", };
            int passwordLength = 16;
            int length = 0;
            Random random = new Random();
            string[] password = new string[100];
            int arrayLength = validCharacters.Length;

            while (length < passwordLength)
            {
                int randomInt = random.Next(arrayLength);
                password[length] = validCharacters[randomInt];
                length++;
            }
           string passwordAsString = string.Join("", password);
            Console.WriteLine(passwordAsString);
            Console.WriteLine(length);
        }
       
    }
}
