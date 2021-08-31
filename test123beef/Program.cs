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




            end = false;

            Console.WriteLine("Enter a String between 8 and 20, inclusive. For reverse strings!");

            while (end == false)
            {

                string input = Console.ReadLine();

                char[] charArr = input.ToCharArray();

                input = "";

                if (charArr.Length >= 8 && charArr.Length <= 20)
                {
                    for (int i = charArr.Length - 1 ; i >= 0; i--)
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





            end = false;

            Console.WriteLine("Write a three digit number please...");

            while (end == false)
            {
                string input = Console.ReadLine();
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
