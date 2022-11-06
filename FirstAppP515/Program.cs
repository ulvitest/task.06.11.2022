using System;

namespace FirstAppP515
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            //Console.WriteLine("bye World");
            //Console.WriteLine("lorem");

            //string name = "Rovshen";
            //int age = 22;
            //bool isMarried=false;

            //string name2=Console.ReadLine();
            //Console.WriteLine(name2);
            //int age2 =int.Parse(Console.ReadLine());
            //Console.WriteLine(age2);

            //string word = "Zumrud";
            // word = "";
            //word = "Lorem";
            //Console.WriteLine(word);

            //int num1 = 4;
            //int num2 = 7;
            //num1 += num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;


            //Console.WriteLine($"num1=>> {num1}");
            //Console.WriteLine($"num2=>> {num2}");


            //int age = 45;

            //if (age>18)
            //{
            //    Console.WriteLine("okaydir");
            //    return;
            //}

            //Console.WriteLine("lorem");
            //int day = 33;
            //string day = "Monday";
            //int day2 = 1;


            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("1cigundur");
            //        break;

            //    case 2:
            //        Console.WriteLine("2cigundur");
            //        break;

            //    case 3:
            //        Console.WriteLine("3cigundur");
            //        break;

            //    default:
            //        Console.WriteLine("hecbiri");
            //        break;
            //}


            //string[] names = { "lorem", "ipsum" };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //string[] names = { "lorem", "ipsum" };
            //int[] numbers = { 1, 2 };

            //foreach (string item in names)
            //{
            //    //Console.WriteLine(item[0]);
            //}

            //string name = "Lorem";
            //// Console.WriteLine(name[0]);

            //int num =int.Parse(Console.ReadLine());


            string month = "Mart";
            switch (month)
            {
                case "Yanvar":
                case "Fevral":
                case "Dekabr":
                    Console.WriteLine("Qis ayidir");
                    break;
                case "Sentyabr":
                case "Oktyabr":
                case "Noyabr":
                    Console.WriteLine("Payiz ayidir");
                    break;
                case "Mart":
                case "Aprel":
                case "May":
                    Console.WriteLine("Yaz aylari.");
                    break;
                case "Iyun":
                case "Iyul":
                case "Avqust":
                    Console.WriteLine("Yay aylari.");
                    break;
                default:
                    break;
            }
        }
    }
}
