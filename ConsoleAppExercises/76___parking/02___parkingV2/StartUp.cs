namespace _02___parkingV2
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] parkingRowsColumns = ParseInput();

            int[,] parkingMatrix = new int[parkingRowsColumns[0], parkingRowsColumns[1]];
            string[] input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "stop")
            {
                int carBeginRow = int.Parse(input[0]);
                int parkingRow = int.Parse(input[1]);
                int parkingColumn = int.Parse(input[2]);

                Tuple<bool, int> parkingInfo = IsCarAvailableToPark(parkingMatrix, carBeginRow, parkingRow, parkingColumn);
                //if can is available to park  on particular spor on the row  then : parkingInfo.Item1 = true
                if (parkingInfo.Item1)
                {
                    // if the initial searched parking spot is available we park the car directly
                    // it means Item2 from the tupple is = 0 because ishase been changed 
                    //otherwise we find another parking spot and initialize new value to parkingColumn!
                    if (parkingInfo.Item2 == 0)
                    {
                        PrintResult(parkingMatrix, carBeginRow, parkingRow, parkingColumn);
                    }
                    else
                    {
                        parkingColumn = parkingInfo.Item2;
                        PrintResult(parkingMatrix, carBeginRow, parkingRow, parkingColumn);
                    }
                }
                else
                {
                    Console.WriteLine($"Row {parkingRow} full");
                }
                input = Console.ReadLine().Split();
            }
        }

        private static void PrintResult(int[,] parkingMatrix, int carBeginRow, int parkingRow, int parkingColumn)
        {
            Console.WriteLine(Math.Abs(carBeginRow - parkingRow) + parkingColumn + 1);
            parkingMatrix[parkingRow, parkingColumn] = 1;
        }

        private static Tuple<bool, int> IsCarAvailableToPark(int[,] parkingMatrix, int carBeginRow, int parkingRow, int parkingColumn)
        {
            if (parkingMatrix[parkingRow, parkingColumn] == 0)
            {
                return Tuple.Create(true, 0);
            }
            // we set to 1 because we can't start from zero(this is by the task condition)
            int column = 1;
            while (true)
            {
                // these are the the borders of the parking matrix
                int leftColumn = parkingColumn - column;
                int rightColumn = parkingColumn + column;
                // if we are out of the bounds we break the while loop
                if (leftColumn <= 0 && rightColumn >= parkingMatrix.GetLength(1))
                {
                    break;
                }
                if (leftColumn > 0 && parkingMatrix[parkingRow, leftColumn] == 0)
                {
                    return Tuple.Create(true, leftColumn);
                }
                if (rightColumn < parkingMatrix.GetLength(1) && parkingMatrix[parkingRow, rightColumn] == 0)
                {
                    return Tuple.Create(true, rightColumn);
                }
                column++;
            }
            return Tuple.Create(false, 0);
        }

        private static int[] ParseInput()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rowsColumns = new int[] { input[0], input[1] };
            return rowsColumns;
        }
    }
}
