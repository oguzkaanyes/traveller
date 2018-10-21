
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic
{
    class Program
    {
        static Dictionary<string, string> input = new Dictionary<string, string>();
        
        static void Main(string[] args)
        {
            DisplayMessage();
            GetInputs();
            //try
            //{
                Plane plane = new Plane(input["Plane"]);
                Robot robot = new Robot(input["RobotPosition"]);
                robot.Move(input["RobotStrings"]);
                Robot robot1 = new Robot(input["Robot1Position"]);
                robot1.Move(input["Robot1Strings"]);
            //}
            //catch
            //{
            //    Console.WriteLine("İnput hatalı girildi. Tekrar denemek ister misiniz?(y/n)");
            //    string selectedOption = Console.ReadLine();
            //    if (selectedOption.ToLower() == "y")
            //    {
            //        Main(args);
            //    }
            //}
        }

        public static void GetInputs()
        {
            input.Add("Plane", Console.ReadLine().Replace(" ", string.Empty));
            input.Add("RobotPosition", Console.ReadLine().Replace(" ", string.Empty));
            input.Add("RobotStrings", Console.ReadLine().Replace(" ", string.Empty));
            input.Add("Robot1Position", Console.ReadLine().Replace(" ", string.Empty));
            input.Add("Robot1Strings", Console.ReadLine().Replace(" ", string.Empty));
        }

        public static void DisplayMessage()
        {
            Console.WriteLine(
                "5 5 ---->// düzlem koordinatları.\n1 2 N ---->// 1.robot koordinat ve yön.\nLMLMLMLMM ---->// hareket katarları.\n3 3 E ---->// 2.robot koordinat ve yön.\nMMRMMRMRRM ---->// hareket katarları\nLütfen yukarıda gösterilen formatta input giriniz."
                );
        }
    }
}