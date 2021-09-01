using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (quit == false)
            {
                Console.WriteLine("Type '1' for 'Case Switch'");
                Console.WriteLine("Type '2' for 'Reverse String'");
                Console.WriteLine("Type '3' for 'One Adds'");
                Console.WriteLine("Type 'Quit' to quit after finshing a process or now to exit program");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    cases();
                }

                if (input == "2")
                {
                    reverse();
                }

                if (input == "3")
                {
                    addOne();
                }

                if (input == "Quit" || input == "quit")
                {
                    quit = true;
                }
            }
        }

        public static void cases()
        {
            bool end = false;
            bool quit = false;

            while (quit == false)
            {
                Console.WriteLine("Enter in a string between 5 and 10 inclusive, or type 'Quit' to go back to the menu");
                
                string input = Console.ReadLine();

                if (input == "Quit" || input == "quit")
                {
                    quit = true;
                    end = true;
                }

                while (end == false)
                { 
                    char[] charArr = input.ToCharArray();

                    if (charArr.Length >= 5 && charArr.Length <= 10)
                    {
                        for (int i = 0; i < charArr.Length; i++)
                        {
                            if (Char.IsUpper(charArr[i]) == true)
                            {
                                charArr[i] = Char.ToLower(charArr[i]);

                            }

                            else
                            {
                                charArr[i] = Char.ToUpper(charArr[i]);
                            }
                        }


                        input = new string(charArr);
                        Console.WriteLine(input);

                        end = true;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a string between 5 and 10 inclusive!");
                    }
                }
            }
        }

        public static void reverse()
        {
            bool quit = false;
            bool end = false;

            while (quit == false) {

                Console.WriteLine("Enter a String between 8 and 20, inclusive, or type 'Quit' to go back to the menu");

                string input = Console.ReadLine();

                if (input == "Quit" || input == "quit")
                {
                    quit = true;
                    end = true;
                }

                while (end == false)
                {
                    char[] charArr = input.ToCharArray();

                    input = "";

                    if (charArr.Length >= 8 && charArr.Length <= 20)
                    {
                        for (int i = charArr.Length - 1; i >= 0; i--)
                        {
                            input += charArr[i];
                        }

                        Console.WriteLine(input);

                        end = true;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a string between 8 and 20 inclusive!");
                    }
                }
            }
        }

        public static void addOne()
        {
            bool end = false;
            bool quit = false;

            while (quit == false)
            {
                Console.WriteLine("Write a three digit number please, or type 'Quit' to go back to the menu");

                string input = Console.ReadLine();

                if (input == "Quit" || input == "quit")
                {
                    quit = true;
                    end = true;
                }

                end = false;

                while (end == false)
                {
                    string temps = "";

                    char[] charArr = input.ToCharArray();


                    int temp = 0;

                    if (charArr.Length == 3)
                    {

                        for (int i = 0; i < charArr.Length; i++)
                        {

                            if (Char.IsNumber(charArr[i]))
                            {
                                temps = charArr[i].ToString();
                                temp = int.Parse(temps);
                                temp += 1;

                                if (temp == 10)
                                {
                                    temp = 0;
                                }

                                temps = temp.ToString();

                                charArr[i] = temps[0];
                            }

                            else
                            {
                                Console.WriteLine("Write numbers bozo...");
                                break;
                            }
                        }
                        end = true;

                        input = new string(charArr);
                        Console.WriteLine(input);
                    }

                    else
                    {
                        Console.WriteLine("Write 3 numbers bozo...");
                    }
                }
            }
        }
    }
}
