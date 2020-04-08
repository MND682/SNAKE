using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake

{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b = 0;
            do
            {
                Console.WriteLine("Введите уровень сложности (легко, нормально, сложно)");
                a = Console.ReadLine();
                if ("ЛЕГКО" == a.ToUpper() || "нормально" == a.ToLower() || "сложно" == a.ToLower())
                {
                    b = 1;
                }
            } while (b != 1);
            Console.Clear();
            switch (a.ToLower())
            {
                case "легко":
                    //задаю размер 
                    Console.SetBufferSize(200, 50);
                    // граници поля ( стены )
                    Walls walls = new Walls(20, 10);
                    walls.Drow();
                    //  сама змейка первые ее координаты 
                    Point p = new Point(4, 5, '*');
                    Snake snake = new Snake(p, 2, Direction.RIGHT);
                    snake.Drow();

                    FoodCreator foodCreator = new FoodCreator(20, 10, 'O');
                    Point food = foodCreator.CreateFood();
                    food.Draw();

                    while (true)
                    {
                        if (walls.IsHit(snake) || snake.IsHitTail())
                        {
                            break;
                        }

                        if (snake.Eat(food))
                        {
                            food = foodCreator.CreateFood();
                            food.Draw();
                        }
                        else
                        {
                            snake.Move();
                        }
                        System.Threading.Thread.Sleep(200);

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey();
                            snake.dvig(key.Key);

                        }
                    }
                    break;
                case "нормально":

                    //задаю размер 
                    Console.SetBufferSize(200, 50);
                    // граници поля ( стены )
                    Walls walls1 = new Walls(30, 15);
                    walls1.Drow();
                    //  сама змейка первые ее координаты 
                    Point p1 = new Point(4, 5, '*');
                    Snake snake1 = new Snake(p1, 2, Direction.RIGHT);
                    snake1.Drow();

                    FoodCreator foodCreator1 = new FoodCreator(30, 15, 'O');
                    Point food1 = foodCreator1.CreateFood();
                    food1.Draw();

                    while (true)
                    {
                        if (walls1.IsHit(snake1) || snake1.IsHitTail())
                        {
                            break;
                        }

                        if (snake1.Eat(food1))
                        {
                            food = foodCreator1.CreateFood();
                            food.Draw();
                        }
                        else
                        {
                            snake1.Move();
                        }
                        System.Threading.Thread.Sleep(160);

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey();
                            snake1.dvig(key.Key);

                        }
                    }

                    break;

                case "сложно":

                    //задаю размер 
                    Console.SetBufferSize(200, 50);
                    // граници поля ( стены )
                    Walls walls2 = new Walls(30, 15);
                    walls2.Drow();
                    //  сама змейка первые ее координаты 
                    Point p2 = new Point(4, 5, '*');
                    Snake snake2 = new Snake(p2, 2, Direction.RIGHT);
                    snake2.Drow();

                    FoodCreator foodCreator2 = new FoodCreator(40, 20, 'O');
                    Point food2 = foodCreator2.CreateFood();
                    food2.Draw();

                    while (true)
                    {
                        if (walls2.IsHit(snake2) || snake2.IsHitTail())
                        {
                            break;
                        }

                        if (snake2.Eat(food2))
                        {
                            food = foodCreator2.CreateFood();
                            food.Draw();
                        }
                        else
                        {
                            snake2.Move();
                        }
                        System.Threading.Thread.Sleep(100);

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey();
                            snake2.dvig(key.Key);

                        }
                    }

                    break;

                default:
                    break;
            }
            


            Console.WriteLine(" ");
            Console.WriteLine("       ／> _  >");
            Console.WriteLine("      |  _  _|");
            Console.WriteLine("     ／`Z _x Z  ");
            Console.WriteLine("     /       |");
            Console.WriteLine("   /  \\     )                ");
            Console.WriteLine(" ／ |    | | |   _      _     ");
            Console.WriteLine(" | ( \\__\\_)_)    \\____/    ");
            Console.WriteLine(" ＼_)");
            Console.WriteLine(" ");
            Console.WriteLine("                                 Game Over");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }
}