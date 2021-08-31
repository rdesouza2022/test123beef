using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            Console.WriteLine("Enter a String between 5 and 10, inclusive. For case switches!");

            while (end == false)
            {

                string input = Console.ReadLine();

                char[] charArr = input.ToCharArray();

                if (charArr.Length >= 5 && charArr.Length <= 10)
                {
                    for (int i = 0; i <= charArr.Length; i++)
                    {
                        if (Char.IsUpper(charArr[i]) == true)
                        {
                            Char.ToLower(charArr[i]);

                        }

                        else
                        {
                            Char.ToUpper(charArr[i]);
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

            end = false;

            Console.WriteLine("Enter a String between 8 and 20, inclusive. For reverse strings!");

            while (end == false)
            {

                string input = Console.ReadLine();

                char[] charArr = input.ToCharArray();

                if (charArr.Length >= 8 && charArr.Length <= 20)
                {
                    for (int i = charArr.Length; i >= 0; i--)
                    {

                    }




                    end = true;
                }

                else
                {
                    Console.WriteLine("Please enter a string between 8 and 20 inclusive!");
                }
            }

        }
    }
}
