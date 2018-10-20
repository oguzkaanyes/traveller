using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic
{
    class Robot
    {
        int xCoordinate;
        int yCoordinate;
        string direction;

        public Robot(string input)
        {
            xCoordinate = int.Parse(input[0].ToString());
            yCoordinate = int.Parse(input[1].ToString());
            direction = input[2].ToString().ToUpper();
        }

        public void Move(string steps)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                Directions compassJustDirection = CreateCompass().Directions.Where(p => p.Direction == direction).ToList()[0];

                direction = steps[i].ToString().ToUpper() == "L" ? compassJustDirection.LeftDirection :
                            steps[i].ToString().ToUpper() == "R" ? compassJustDirection.RightDirection : direction;

                if (steps[i].ToString().ToUpper() == "M")
                {
                    Directions moveToDirection = CreateCompass().Directions.Where(p => p.Direction == direction).ToList()[0];
                    if (direction == "N" || direction == "S")
                    {
                        yCoordinate += moveToDirection.AddNumber;
                    }
                    else if (direction == "W" || direction == "E")
                    {
                        xCoordinate += moveToDirection.AddNumber;
                    }
                }
            }
            xCoordinate = Plane.maxX < xCoordinate ? Plane.maxX : xCoordinate;
            yCoordinate = Plane.maxY < yCoordinate ? Plane.maxY : yCoordinate;
            Console.WriteLine(string.Concat(xCoordinate, " ", yCoordinate, " ", direction));
            Console.ReadKey();
        }

        public Compass CreateCompass()
        {
            Compass compass = new Compass();
            List<Directions> directions = new List<Directions>();

            directions.Add(
                new Directions
                {
                    Direction = "N",
                    LeftDirection = "W",
                    RightDirection = "E",
                    AddNumber = 1
                });
            directions.Add(
                new Directions
                {
                    Direction = "E",
                    LeftDirection = "N",
                    RightDirection = "S",
                    AddNumber = 1
                });
            directions.Add(
                new Directions
                {
                    Direction = "S",
                    LeftDirection = "E",
                    RightDirection = "W",
                    AddNumber = -1
                });
            directions.Add(
                new Directions
                {
                    Direction = "W",
                    LeftDirection = "S",
                    RightDirection = "N",
                    AddNumber = -1
                });
            compass.Directions = directions;
            return compass;
        }
    }
}