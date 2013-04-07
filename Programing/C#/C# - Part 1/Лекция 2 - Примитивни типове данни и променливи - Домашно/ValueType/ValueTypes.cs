using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class ValueTypes
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //int a = 0;
            //int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            //for (int i = 0; i < n; i++)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp + b;
            //    Console.WriteLine(a);
            //}

            //1.Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

            ushort a = 52130;
            sbyte b = -115;
            ulong c = 4825932;
            short d = -10000;
            double e = 34.567839023f;

            //2.Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

            double a1 = 34.567839023;
            float b1 = 12.345f;
            double c1 = 8923.1234857;
            float d1 = 3456.091f;

            //3.Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

            decimal num1 = 6.01m;
            decimal num2 = 5.3m;
            decimal num3 = 5.00000003m;
            decimal num4 = 5.0000001m;
            decimal result1 = num1 - num2;
            decimal result2 = num3 - num4;
            decimal precision = 0.000001m;
            bool compare1 = (result1 < precision);
            bool compare2 = (result2 < precision);

            Console.WriteLine("compared numbers {1} - {2} are = {0}", compare1, num1, num2);

            Console.WriteLine("compared numbers {1} - {2} are = {0}", compare2, num3, num4);

            //4.Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.
            int valueinHex = 0xFE;
            Console.WriteLine(valueinHex);

            //5.Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
            char valueinHex2 = '\x0048';
            Console.WriteLine(valueinHex2);
            char unicodechar = (char)72;
            Console.WriteLine(unicodechar);

            //6.Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
            bool isFemale = false;
            Console.WriteLine(isFemale);

            //7.Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

            string word1 = "Hello";
            string word2 = "World";

            object word = word1 + word2;
           
            string oneword = (string) word;
            Console.WriteLine(oneword);
            //8.Declare two string variables and assign them with following value:	Do the above in two different ways: with and without using quoted strings.

            string one = "The \"use\" of quotations causes difficulties.";
            string tone = @"The ""use"" of quotations causes difficulties.";

            //9.Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

            char crSymbol = '\u00A9';
            Console.WriteLine("   {0}\n  {0}{0}{0}\n {0}{0}{0}{0}{0}", crSymbol);

            //10.A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

            string firstName, familyName;
            firstName = "Kiril";
            familyName = "Daskalov";
            char gender = 'm';
            ushort employID = 1;
            int id = 752;
            sbyte age = 23;
            Console.WriteLine(" First Name: {0}\n Family Name: {1}\n Gender: {2}\n Age: {3}\n ID: {4}\n EmployID: {5}", firstName, familyName, gender, age, id, 27560000+employID);

            //11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

            int five=5;
            int ten = 10;
            ten = 5;
            five = 10;

            //12.Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.
            Console.Write("Decimal".PadRight(10));
            Console.Write("ASCII".PadRight(10));
            Console.Write("Hex".PadRight(10));
            Console.WriteLine();

            int min = 0;
            int max = 256;
            for (int i = min; i < max; i++)
            {
                // Get ascii character.
                char cchar = (char)i;

                // Get display string.
                string display = string.Empty;
                if (char.IsWhiteSpace(cchar))
                {
                    display = cchar.ToString();
                    switch (cchar)
                    {
                        case '\t':
                            display = "\\t";
                            break;
                        case ' ':
                            display = "space";
                            break;
                        case '\n':
                            display = "\\n";
                            break;
                        case '\r':
                            display = "\\r";
                            break;
                        case '\v':
                            display = "\\v";
                            break;
                        case '\f':
                            display = "\\f";
                            break;
                    }
                }
                else if (char.IsControl(cchar))
                {
                    display = "control";
                }
                else
                {
                    display = cchar.ToString();
                }
                // Write table row.
                Console.Write(i.ToString().PadRight(10));
                Console.Write(display.PadRight(10));
                Console.Write(i.ToString("X2"));
                Console.WriteLine();

            }
            //13.Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

            int? emptyInt=null;
            double? emptyDoble = null;
   
            Console.WriteLine("{0}, {1}",emptyDoble,emptyInt);
            emptyInt = 1;
            emptyDoble = 22;
            Console.WriteLine("{0}, {1}", emptyDoble, emptyInt);

            //14.A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
            string firstNames, middleNames, familyNames, bankName, IBAN, BIC;
            long card1, card2, card3;
            card1 = 4916541419229149;
            card2 = 4916541419229149;
            card3 = 4916541419229149;
            IBAN = "GB82 WEST 1234 5698 7654 32";
            BIC = "FINVBGSF";
            bankName = "First Investmant Bank";
            firstNames = "Kiril";
            familyNames = "Daskalov";
            middleNames = "Dimitrov";
            decimal amount = 156000000.51m;
            Console.WriteLine(" First Name: {0}\n Middle Name: {1}\n Family Name: {2}\n Bank Name: {3}\n IBAN: {4}\n BIC: {5}\n Cards: {6}\n\t{7}\n\t{8}\n Total amount: {9} USD", firstNames, middleNames, familyNames, bankName, IBAN, BIC, card1, card2, card3,amount);

        }
    }
}
