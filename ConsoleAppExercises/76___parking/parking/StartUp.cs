namespace _01___parking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public class Cell
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }
        static void Main()
        {
            int[] parkingSize = InitializeParking();
            HashSet<Cell> usedCells = new HashSet<Cell>();

            string[] input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "stop")
            {
                int carEntryRow = int.Parse(input[0]);
                Cell carTargetParkingSpot = new Cell();
                carTargetParkingSpot.Row = int.Parse(input[1]);
                carTargetParkingSpot.Column = int.Parse(input[2]);

                if (IsCarAvailableToPark(carTargetParkingSpot, usedCells, parkingSize))
                {
                    // Print distance travelled to the parking spot, we add 1 to each row and column because by default we start
                    // counting from 0 and in this case we need to count from 1 
                    Console.WriteLine(Math.Abs((carEntryRow  - carTargetParkingSpot.Row)) + carTargetParkingSpot.Column + 1);
                    usedCells.Add(carTargetParkingSpot);
                }
                else
                {
                    Console.WriteLine($"Row {carTargetParkingSpot.Row} full");
                }

                input = Console.ReadLine().Split();
            }
        }
        private static bool IsCarAvailableToPark(Cell carTargetSpot, HashSet<Cell> usedCells, int[] parkingDimensions)
        {
            // if this condition is true - it means there is no car on that spot , so we can park 
            // our car there and this is why we return true !!!
            if (usedCells
                .Where(c => c.Row == carTargetSpot.Row && 
                         c.Column == carTargetSpot.Column)
                .FirstOrDefault() == null)
            {
                return true; 
            }
            // this could be also for loop but i keep it consistent with the rest of the code
            int column = 1;
            while (true)
            {
                
                int leftCol = carTargetSpot.Column - column;
                int rightCol = carTargetSpot.Column + column;

                if (leftCol <= 0 && rightCol >= parkingDimensions[1])
                {
                    break;
                }

                if (leftCol > 0 &&
                    usedCells.Where(c => c.Row == carTargetSpot.Row && c.Column == leftCol)
                    .FirstOrDefault() == null)
                {
                    carTargetSpot.Column = leftCol;
                    return true;
                }

                if (rightCol < parkingDimensions[1] &&
                    usedCells.Where(c => c.Row == carTargetSpot.Row && c.Column == rightCol)
                    .FirstOrDefault() == null)
                {
                    carTargetSpot.Column = rightCol;
                    return true;
                }

                column++;
            }
            return false;
        }

        private static int[] InitializeParking()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array = new int[] { size[0], size[1] };
            return array;
        }
    }
}
