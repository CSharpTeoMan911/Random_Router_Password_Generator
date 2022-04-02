using System;

namespace Random_Router_Password_Generator
{
    class Program
    {
        static Random Random_Character_Type_Selector = new System.Random();
        static char[] letters = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static char[] symbols = new char[36] { '¬', '`', '¦', '!', '"', '£', '$', '€', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', ':', ';', '@', '\'', '~', '#', '|', '\\', '<', ',', '>', '.', '?', '/' };

        static void Main()
        {
            Console.Write("\n\n\nEnter [ R ] to generate a random 20 charaters high security password or [ E ] to exit:  ");
            var user_input = Console.ReadLine();

            if (user_input == "R")
            {
                Console.Clear();
                Random_Number_Generator();
            }

            else if(user_input == "E")
            {
                Console.Clear();
                Environment.Exit(0);
            }

            else
            {
                Console.Clear();
                Main();
            }
        }


        private static void Random_Number_Generator()
        {             
            Span<char> password_buffer = stackalloc char[20];

            for(int Index = 0; Index < 20; Index++)
            { 
                switch (Random_Character_Type_Selector.Next(0, 3))
                {
                    case 0:
                        switch(Random_Character_Type_Selector.Next(0, 2))
                        {
                            case 0:
                                password_buffer[Index] = letters[Random_Character_Type_Selector.Next(0, 25)];
                                break;

                            case 1:
                                password_buffer[Index] = Char.ToUpper(letters[Random_Character_Type_Selector.Next(0, 25)]);
                                break;
                        }
                       
                        break;

                    case 1:
                        password_buffer[Index] = symbols[Random_Character_Type_Selector.Next(0, 35)];
                        break;

                    case 2:
                        switch (Random_Character_Type_Selector.Next(0, 10))
                        {
                            case 0:
                                password_buffer[Index] = '0';
                                break;

                            case 1:
                                password_buffer[Index] = '1';
                                break;

                            case 2:
                                password_buffer[Index] = '2';
                                break;

                            case 3:
                                password_buffer[Index] = '3';
                                break;

                            case 4:
                                password_buffer[Index] = '4';
                                break;

                            case 5:
                                password_buffer[Index] = '5';
                                break;

                            case 6:
                                password_buffer[Index] = '6';
                                break;

                            case 7:
                                password_buffer[Index] = '7';
                                break;

                            case 8:
                                password_buffer[Index] = '8';
                                break;

                            case 9:
                                password_buffer[Index] = '9';
                                break;
                        }
                        break;

                       

                }
            }

            Console.WriteLine("\n\n\n[ GENERATED PASSWORD ] --> " + password_buffer.ToString() + "\n\n\n\n");


            Console.Write("Enter [ R ] to repeat the password generation procedure or [ E ] to exit:  ");
            var User_Input = Console.ReadLine();


            if(User_Input == "R")
            {
                Console.Clear();
                Random_Number_Generator();
            }

            else if(User_Input == "E")
            {
                Console.Clear();
                Environment.Exit(0);
            }

            else
            {
                Console.Clear();
                Random_Number_Generator();
            }
        }
    }
}
