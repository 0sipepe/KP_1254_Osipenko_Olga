using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace passwords
{
    internal class Program
    {

        static Random rand = new Random();
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            int length = 16, digits = 0, letters = 0;
            bool uppercase = false, special = false;
            int dig_index = 1000000000, let_index = 100000000;
            bool mistake = false;
            string Password = "";



            //Console.WriteLine(args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                if ((i == 0) && (int.TryParse(args[i], out int x) == true))
                {

                    int.TryParse(args[i], out length);
                    //Console.WriteLine(length);
                }

                else if (args[i][0] == '-')
                {
                    //Console.WriteLine("hello");
                    switch (args[i][1])
                    {
                        case '-':
                            string[] command;
                            command = args[i].Split('=');
                            if ((command.Length == 2) || (args.Length == 1) || (command[0] == "--uppercase") || (command[0] == "--special"))
                            {
                                //Console.WriteLine("hello2");
                                switch (command[0])
                                {
                                    case "--length":
                                        int.TryParse(command[1], out length);
                                        //Console.WriteLine("hellolength");
                                        break;

                                    case "--letters":
                                        int.TryParse(command[1], out letters);
                                        let_index = i;
                                        //Console.WriteLine("helloletters");
                                        break;
                                    case "--special":
                                        special = true;
                                        //Console.WriteLine("hellospecial");
                                        break;
                                    case "--digits":
                                        int.TryParse(command[1], out digits);
                                        //Console.WriteLine("hellodigits");
                                        dig_index = i;
                                        break;
                                    case "--uppercase":
                                        //Console.WriteLine("helloupper");
                                        uppercase = true;
                                        break;
                                    default:
                                        mistake = true;
                                        //Console.WriteLine("hello3");
                                        break;
                                }

                            }



                            break;

                        case 'u':

                            //Console.WriteLine(args[i].Length);
                            //Console.WriteLine(i);
                            if (args[i].Length == 2)
                            {
                                //Console.WriteLine("kkk");
                                uppercase = true;
                            }
                            else if ((args[i].Length == 3) && (args[i][2] == 's'))
                            {
                                uppercase = true;
                                special = true;
                            }
                            else { Console.WriteLine("You made a mistake"); }
                            break;

                        case 's':
                            if (args[i].Length == 2) special = true;
                            break;

                        default:
                            //Console.WriteLine(i);
                            Console.WriteLine("you made a mistake");
                            mistake = true;
                            break;
                    }

                }


            }

            //Console.WriteLine(special);
            //Console.WriteLine("" + length  + " " + uppercase + "" +  special +" " +  digits + " " + letters);
            if (dig_index > let_index) digits = 0;
            else letters = 0;
            //Console.WriteLine("" + length + " " + uppercase + "" + special + " " + digits + " " + letters);

            if ((digits > length) || (letters > length)) length = digits > letters ? digits : letters;

            int[] counts = { digits, letters };

            if (!mistake)
            {
                //Console.WriteLine(111111);
                List<char> components = new List<char>();


                for (int i = 0; i < digits; i++)
                {
                    components.Add(GetDigit());
                }
                //Console.WriteLine(uppercase + " " + letters);
                //for(int i = 65; i < 123; i++) Console.WriteLine((char)i);


                if ((uppercase) && (letters > 0))
                {
                    for (int j = 0; j < letters; j++)
                    {
                        components.Add(GetAnyLetter());
                        //Console.WriteLine("u");
                    }
                }


                //if (uppercase == true) components.Add(GetHighLetter());

                if (special == true) components.Add(GetSpecial());


                int z = uppercase ? 1 : 0;
                int y = special ? 1 : 0;


                //while (components.Count < length) { components.Add(GetRandomSymbol(length - digits - letters - z - y, digits, letters, uppercase, special)); }
                while (components.Count < length) { components.Add(GetExtra(uppercase, special)); }
                //for (int i = 0; i < components.Count; i++) { Console.WriteLine(components[i]); }


                for (int i = components.Count - 1; i >= 1; i--)
                {
                    int j = rand.Next(i + 1);
                    char tmp = components[j];
                    components[j] = components[i];
                    components[i] = tmp;
                }

                //string Password = "";
                for (int i = 0; i < components.Count; i++)
                {
                    Password += components[i];
                }

            }
            else
            {
                Console.WriteLine("You Made  a mistake");
            }
            Console.WriteLine(Password);
            Console.ReadLine();




        }
        static char GetDigit()
        {

            string digit = rand.Next(0, 10) + String.Empty;
            char chigit = Convert.ToChar(digit);
            return chigit;
        }
        static char GetSpecial()
        {
            string symbols = "%&`/,-=+_!@#^*~";

            int index = rand.Next(symbols.Length);
            char symb = symbols[index];

            return symb;
        }

        static char GetLowLetter()
        {

            int num = rand.Next((int)'a', (int)'z' + 1);
            char letter = (char)num;
            return letter;

        }


        static char GetHighLetter()
        {
            int num = rand.Next((int)'A', (int)'Z' + 1);
            char letter = (char)num;
            return letter;
        }


        static char GetAnyLetter()
        {
            switch (rand.Next(0, 2))
            {
                case 0:
                    return GetLowLetter();
                case 1:
                    return GetHighLetter();
            }
            return ',';
        }



        static char GetExtra(bool uppercase, bool special)
        {
            if ((!uppercase) && (!special))
            {

                switch (rand.Next() % 3)
                {
                    case 0:
                        return GetDigit();
                    case 1:
                        return GetAnyLetter();
                    case 2:
                        return GetSpecial();
                }
            }
            else if ((!uppercase) && (special))
            {
                switch (rand.Next() % 3)
                {
                    case 0:
                        return GetDigit();
                    case 1:
                        return GetLowLetter();
                    case 2:
                        return GetSpecial();
                }
            }
            else if ((uppercase) && (!special))
            {
                switch (rand.Next() % 2)
                {
                    case 0:
                        return GetDigit();
                    case 1:
                        return GetLowLetter();
                }
            }
            else
            {
                switch (rand.Next() % 2)
                {
                    case 0:
                        return GetDigit();
                    case 1:
                        return GetLowLetter();
                }
            }
            return '.';

        }


    }
}