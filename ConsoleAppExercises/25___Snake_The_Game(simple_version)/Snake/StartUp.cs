namespace Snake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Windows;

    class StartUp
    {
        static void Main(string[] args)
        {
            // 1. Keep the directions in one Array with positions from 0 to 3 
            Position[] directions = new Position[]
            {
                new Position(0,1), // right
                new Position(0,-1), // left
                new Position(1,0), // down
                new Position(-1,0), // up   

            };
            int sleepTime = 100;
            int direction = 0;
            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;
            //2.Fix the console size 
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            //3. Place the postion of the food on random coordinates on the console window
            Random randomNumber = new Random();
            Position foodPosition = new Position
                (randomNumber.Next(0, Console.WindowHeight),
                 randomNumber.Next(0, Console.WindowWidth));
            Console.SetCursorPosition(foodPosition.column, foodPosition.row);
            Console.Write("@");
            //4. Starting the snake with 6 elements long and print it 
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.column, position.row);
                Console.Write("*");
            }
            //5. Into the loop I just read the key from the keyboard
            //if no key is pressed the snake just keep moving 
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left) direction = right;
                    }
                    else if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (direction != right) direction = left;
                    }
                    else if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up) direction = down;
                    }
                    else if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down) direction = up;
                    }
                }

                Position snakeHeadPosition = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHeadPosition = new Position(snakeHeadPosition.row + nextDirection.row,
                                                             snakeHeadPosition.column + nextDirection.column);
                if (snakeNewHeadPosition.row < 0 ||
                    snakeNewHeadPosition.column < 0 ||
                    snakeNewHeadPosition.row >= Console.WindowHeight ||
                    snakeNewHeadPosition.column >= Console.LargestWindowWidth)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Clear();
                    Console.WriteLine("Looooooser, Try Again Later!");
                    return;
                }
                foreach (var item in snakeElements)
                {
                    if (snakeNewHeadPosition.row == item.row &&
                        snakeNewHeadPosition.column == item.column)
                    {

                        Console.SetCursorPosition(0, 0);
                        Console.Clear();
                        Console.WriteLine("Game over");
                        return;
                    }
                }
                snakeElements.Enqueue(snakeNewHeadPosition);

                if (snakeNewHeadPosition.row == foodPosition.row &&
                    snakeNewHeadPosition.column == foodPosition.column)
                {
                    foodPosition = new Position(randomNumber.Next(0, Console.WindowHeight),
                                                randomNumber.Next(0, Console.WindowWidth));

                    sleepTime--;
                }
                else
                {
                    snakeElements.Dequeue();

                }

                Console.Clear();
                foreach (Position position in snakeElements)
                {
                    Console.SetCursorPosition(position.column, position.row);
                    Console.Write("*");
                }
                Console.SetCursorPosition(foodPosition.column, foodPosition.row);
                Console.Write("@");
                Console.SetCursorPosition(foodPosition.column, foodPosition.row);
                Thread.Sleep(sleepTime);
            }

        }

    }
}

