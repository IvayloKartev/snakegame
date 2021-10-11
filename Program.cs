using System;
using System.Runtime.InteropServices;
namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 22;
            Console.WindowWidth = 32;
            char[,] arr = new char[20, 20];
            char[] snake = new char[100];
            int h = 0;
            arr[0, 0]= '_';
            arr[0, 1] = '_';
            arr[0, 2] = '_';
            arr[0, 3] = '_';
            arr[0, 4] = '_';
            arr[0, 5] = '_';
            arr[0, 6] = '_';
            arr[0, 7] = '_';
            arr[0, 8] = '_';
            arr[0, 9] = '_';
            arr[0, 10] = '_';
            arr[0, 11] = '_';
            arr[0, 12] = '_';
            arr[0, 13] = '_';
            arr[0, 14] = '_';

            arr[1, 0] = '|';
            arr[2, 0] = '|';
            arr[3, 0] = '|';
            arr[4, 0] = '|';
            arr[5, 0] = '|';
            arr[6, 0] = '|';
            arr[7, 0] = '|';
            arr[8, 0] = '|';
            arr[9, 0] = '|';
            arr[10, 0] = '|';
            arr[11, 0] = '|';
            arr[12, 0] = '|';
            arr[13, 0] = '|';
            arr[14, 0] = '|';

            arr[1, 14] = '|';
            arr[2, 14] = '|';
            arr[3, 14] = '|';
            arr[4, 14] = '|';
            arr[5, 14] = '|';
            arr[6, 14] = '|';
            arr[7, 14] = '|';
            arr[8, 14] = '|';
            arr[9, 14] = '|';
            arr[10, 14] = '|';
            arr[11, 14] = '|';
            arr[12, 14] = '|';
            arr[13, 14] = '|';

            arr[14, 0] = '_';
            arr[14, 1] = '_';
            arr[14, 2] = '_';
            arr[14, 3] = '_';
            arr[14, 4] = '_';
            arr[14, 5] = '_';
            arr[14, 6] = '_';
            arr[14, 7] = '_';
            arr[14, 8] = '_';
            arr[14, 9] = '_';
            arr[14, 10] = '_';
            arr[14, 11] = '_';
            arr[14, 12] = '_';
            arr[14, 13] = '_';
            arr[14, 14] = '_';
             bool flag = false;
            int counter = 0;
            Random rnd = new Random();
            int apple1 = rnd.Next(1, 13);  // creates a number between 1 and 12
            int apple2= rnd.Next(1, 13);
            arr[apple1, apple2] = 'o';
            int sn1 = rnd.Next(1, 13);  // creates a number between 1 and 12
            int sn2 = rnd.Next(1, 13);
            arr[sn1,sn2] = '■';
            int heads = 0;
            while (flag==false)
            {
                Console.WriteLine("         Snake game");

                for (int i = 0; i < 15; i++)
                {

                    for (int j = 0; j < 15; j++)
                    {
                        if (arr[i, j] == '_')
                        {
                            Console.Write(arr[i, j] + "_");
                        }
                        else
                        {

                            Console.Write(arr[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Apples: " + counter);

                ConsoleKey move = Console.ReadKey().Key;
          
                if(move==ConsoleKey.W)
                {
                    arr[sn1 - 1, sn2] = '■';
                    arr[sn1, sn2] = ' ';
                    sn1 = sn1 - 1;
                    if (arr[apple1, apple2] == '■')
                    {
                        counter++;
                        Random rnd1 = new Random();
                        apple1 = rnd1.Next(1, 13);
                        apple2 = rnd1.Next(1, 13);
                        arr[apple1, apple2] = 'o';
                        snake[h] = '■';
                        arr[sn1 + 1, sn2] = snake[h];
                        heads++;
                    }
                    if (heads > 0)
                    {
                        for (int i = 1; i <= counter; i++)
                        {
                            arr[sn1 + i, sn2] = snake[h];
                            arr[sn1 + i+1, sn2] = ' ';
                            arr[sn1 + i+1, sn2 - 1] = ' ';
                            arr[sn1 + i+1, sn2 + 1] = ' ';
                        }
                    }
                }
                else if (move == ConsoleKey.S)
                {
                    arr[sn1 + 1, sn2] = '■';
                    arr[sn1, sn2] = ' ';
                    sn1 = sn1 + 1;
                    if (arr[apple1, apple2] == '■')
                    {
                        counter++;
                        Random rnd1 = new Random();
                        apple1 = rnd1.Next(1, 13);
                        apple2 = rnd1.Next(1, 13);
                        arr[apple1, apple2] = 'o';
                        snake[h] = '■';
                        arr[sn1- 1, sn2] = snake[h];
                        heads++;
                    }
                    if (heads > 0)
                    {
                        for (int i = 1; i <= counter; i++)
                        {
                            arr[sn1 - i, sn2] = snake[h];
                            arr[sn1 - i-1, sn2] = ' ';
                            arr[sn1 - i-1, sn2 - 1] = ' ';
                            arr[sn1 - i-1, sn2 + 1] = ' ';
                        }
                    }
                }
                else if (move == ConsoleKey.A)
                {
                    arr[sn1, sn2-1] = '■';
                    arr[sn1, sn2] = ' ';
                    sn2 = sn2 - 1;
                    if (arr[apple1, apple2] == '■')
                    {
                        counter++;
                        Random rnd1 = new Random();
                        apple1 = rnd1.Next(1, 13);
                        apple2 = rnd1.Next(1, 13);
                        arr[apple1, apple2] = 'o';
                        snake[h] = '■';
                        arr[sn1, sn2+1] = snake[h];
                        heads++;
                    }
                    if (heads > 0)
                    {
                        for (int i = 1; i <= counter; i++)
                        {
                            arr[sn1, sn2 + i] = snake[h];
                            arr[sn1, sn2 + i+1] = ' ';
                            arr[sn1 + 1, sn2 + i+1] = ' ';
                            arr[sn1 - 1, sn2 + i+1] = ' ';
                        }
                    }
                }
                else if (move == ConsoleKey.D)
                {
                    arr[sn1, sn2 + 1] = '■';
                    arr[sn1, sn2] = ' ';
                    sn2 = sn2 + 1;
                    if (arr[apple1, apple2] == '■')
                    {
                        counter++;
                        Random rnd1 = new Random();
                        apple1 = rnd1.Next(1, 13);
                        apple2 = rnd1.Next(1, 13);
                        arr[apple1, apple2] = 'o';
                        snake[h] = '■';
                        arr[sn1, sn2-1] = snake[h];
                        heads++;

                    }
                    if (heads > 0)
                    {
                        for (int i = 1; i <= counter; i++)
                        {
                            arr[sn1, sn2 - i] = snake[h];
                            arr[sn1, sn2 - i-1] = ' ';
                            arr[sn1 + 1, sn2 - i-1] = ' ';
                            arr[sn1 - 1, sn2 - i-1] = ' ';
                        }
                    }
                }
                
               

                //System.Threading.Thread.Sleep(600);
                Console.Clear();
            }
        }
    }
}
   //public class Win32Interop {[DllImport("crtdll.dll")] public static extern int _kbhit(); }
