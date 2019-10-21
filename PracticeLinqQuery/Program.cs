using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };


            var myFirstQuery = from name in words
                               where name.Contains("th")
                               select name;

            foreach (var name in myFirstQuery)
                Console.WriteLine(name + " ");
            Console.ReadLine();

            List<string> names1 = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            List<string> distinct = names1.Distinct().ToList();

            foreach (string value in distinct)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();


            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            var intClassGrades = classGrades[0].Split(',').Select(x => double.Parse(x)).ToList();
            var intClassGrades1 = classGrades[1].Split(',').Select(x => double.Parse(x)).ToList();
            var intClassGrades2 = classGrades[2].Split(',').Select(x => double.Parse(x)).ToList();
            var intClassGrades3 = classGrades[3].Split(',').Select(x => double.Parse(x)).ToList();

            intClassGrades.Remove(intClassGrades.Min());
            intClassGrades1.Remove(intClassGrades1.Min());
            intClassGrades2.Remove(intClassGrades2.Min());
            intClassGrades3.Remove(intClassGrades3.Min());

            double average = intClassGrades.Average();
            double average1 = intClassGrades1.Average();
            double average2 = intClassGrades2.Average();
            double average3 = intClassGrades3.Average();

            double totalAverage = (average + average1 + average2 + average3) / 4;

            Console.WriteLine(totalAverage);
            Console.ReadLine();


            List<string> mikeName = new List<string>();
            mikeName.Add("T");
            mikeName.Add("e");
            mikeName.Add("r");
            mikeName.Add("r");
            mikeName.Add("i");
            mikeName.Add("l");
            mikeName.Add("l");

            var a = from b in mikeName
                    group b by b into c
                    orderby c.Key
                    select c;
            foreach (var nameNum in a)
            {
                Console.WriteLine(nameNum.Key + nameNum.Count() );
                //Console.WriteLine("Letter " + nameNum.Key + " appears " + nameNum.Count() + " times");
                Console.ReadLine();
            }

        }

    }
}

