using System;

namespace Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");

            //Ex1
            int num1 = 3;
            int num2 = 4;
            Console.WriteLine("Ex 1");
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} i {num2} są równe");
            }
            else
            {
                Console.WriteLine($"{num1} i {num2} nie są równe");
            }

            //Ex2
            Console.WriteLine("Ex 2");
            Console.WriteLine("Podaj liczbę:");
            var numRead = Console.ReadKey();
            int num = Int32.Parse(numRead.KeyChar.ToString());

            if (num % 2 == 0)
            {
                Console.WriteLine($"Liczba {num} jest parzysta.");
            }
            else
            {
                Console.WriteLine($"Liczba {num} jest nieparzysta.");
            }

            //Ex3
            int numNeg = 14;

            if (numNeg > 0)
            {
                Console.WriteLine("Ex 3");
                Console.WriteLine($"Liczba {numNeg} jest dodatnia.");
            }
            else if (numNeg < 0)
            {
                Console.WriteLine($"Liczba {num} jest ujemna.");
            }
            else
            {
                Console.WriteLine($"Liczba {num}, poza zbiorem ujemnych/dodatnich.");
            }

            //Ex4
            Console.WriteLine("Ex 4");
            Console.WriteLine("Podaj rok i naciśnij enter:");
            var yearRead = Console.ReadLine();
            int year = Int32.Parse(yearRead);

            if (year % 4 == 0)
            {
                Console.WriteLine($"Rok {year} jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine($"Rok {year} nie jest rokiem przestępnym.");
            }

            //Ex5
            Console.WriteLine("Ex 5");
            Console.WriteLine("Podaj wiek i naciśnij enter:");
            var ageRead = Console.ReadLine();
            int age = Int32.Parse(ageRead);

            if (age >= 21 && age < 35)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (age >= 35 && age < 90)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Za młody albo za stary jesteś!");
            }

            //Ex6
            Console.WriteLine("Ex 6");
            Console.WriteLine("Podaj wzrost i naciśnij enter:");
            var heightRead = Console.ReadLine();
            int height = Int32.Parse(heightRead);

            if (height <= 170)
            {
                Console.WriteLine("Jesteś  niski, ale może jeszcze urośniesz.");
            }
            else if (height > 170 && height < 180)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else
            {
                Console.WriteLine("Możesz iść d o NBA");
            }

            //Ex7
            Console.WriteLine("Ex 7");
            Console.WriteLine("Podaj liczbę:");
            var nb1Read = Console.ReadLine();
            int nb1 = Int32.Parse(nb1Read);
            Console.WriteLine("Podaj kolejną:");
            var nb2Read = Console.ReadLine();
            int nb2 = Int32.Parse(nb2Read);
            Console.WriteLine("Podaj kolejną:");
            var nb3Read = Console.ReadLine();
            int nb3 = Int32.Parse(nb3Read);
            int biggerNum;

            if (nb1 < nb2)
            {
                biggerNum = nb2;
            }
            else
            {
                biggerNum = nb1;
            }

            if (biggerNum > nb3)
            {
                Console.WriteLine($"{biggerNum} jest największa z podanych");
            }
            else
            {
                Console.WriteLine($"{nb3} jest największa z podanych");
            }

            //Ex8
            Console.WriteLine("Ex 8");
            int mat = 80;
            int fiz = 71;
            int chem = 0;

            if (mat > 70 && fiz > 55 && chem > 45 && mat + fiz + chem > 180 || mat + fiz > 150 || mat + chem > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");

            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji.");
            }

            //Ex9
            Console.WriteLine("Ex 9");
            Console.WriteLine("Podaj temperature i naciśnij enter:");
            var tempRead = Console.ReadLine();
            int temp = Int32.Parse(tempRead);

            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }

            //Ex 10
            Console.WriteLine("Podaj długość 1:");
            var l1Read = Console.ReadLine();
            int l1 = Int32.Parse(l1Read);
            Console.WriteLine("Podaj kolejną:");
            var l2Read = Console.ReadLine();
            int l2 = Int32.Parse(l2Read);
            Console.WriteLine("Podaj kolejną:");
            var l3Read = Console.ReadLine();
            int l3 = Int32.Parse(l3Read);

            int longestL = Math.Max(Math.Max(l1, l2), l3);

            if (longestL == l1 && l1 < l2 + l3)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (longestL == l2 && l2 < l1 + l3)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (longestL == l3 && l3 < l1 + l2)
            {
                Console.WriteLine("Można zbudować trójkąt!");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta.");
            }

            //Ex 11
            Console.WriteLine("Ex 11");
            Console.WriteLine("Podaj ocenę od 1 do 6:");
            var grade = Console.ReadLine();


            switch (grade)
            {
                case "6":
                    Console.WriteLine("Celujący");
                    break;
                case "5":
                    Console.WriteLine("Bordzo dobry");
                    break;
                case "4":
                    Console.WriteLine("Dobry");
                    break;
                case "3":
                    Console.WriteLine("Dostateczny");
                    break;
                case "2":
                    Console.WriteLine("Dopuszczający");
                    break;
                case "1":
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Niepoprawnie wpisana ocena");
                    break;
            }

            //Ex 12
            Console.WriteLine("Ex 12");
            Console.WriteLine("Podaj numer dnia tygodnia");
            var numberDay = Console.ReadLine();


            switch (numberDay)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Niepoprawny numer dnia tygodnia");
                    break;
            }

            //Ex 13
            Console.WriteLine("Podaj pierwszą liczbę:");
            var n1Read = Console.ReadLine();
            int n1 = Int32.Parse(n1Read);
            Console.WriteLine("Podaj drugą liczbę:");
            var n2Read = Console.ReadLine();
            int n2 = Int32.Parse(n2Read);

            Console.WriteLine("Podaj numer operacji do wykonania");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            var operationRead = Console.ReadKey();
            char operation = char.Parse(operationRead.KeyChar.ToString());
            int result;
            double divisionResult;

            switch (operation)
            {
                case '1':
                    result = n1 + n2;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case '2':
                    result = n1 * n2;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case '3':
                    result = n1 * n2;
                    Console.WriteLine($"Twój wynik to {result}");
                    break;
                case '4':
                    divisionResult = n1 / n2;
                    Console.WriteLine($"Twój wynik to {divisionResult}");
                    break;
                default:
                    Console.WriteLine("Błędny wybór operacji");
                    break;
            }

        }
    }
}