using System;

namespace W2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in my homework from lesson number 7.\n");

            Console.WriteLine("\n----- Exercise nr. 1 -----\n");
            int a = 5, b = 5, d, result;
            double c;
            if (a == b)
                Console.WriteLine($"{a} i {b} są równe.");
            else
                Console.WriteLine("Nie są równe.");

            Console.WriteLine("\n----- Exercise nr. 2 -----\n");
            Console.Write("Enter the number: ");
            a = Int32.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " jest liczbą parzystą.");
            }
            else
            {
                Console.WriteLine(a + " jest liczbą nieparzystą.");
            }

            Console.WriteLine("\n----- Exercise nr. 3 -----\n");
            Console.Write("Enter the number: ");
            a = Int32.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine(a + " jest liczbą ujemną.");
            }
            else
            {
                Console.WriteLine(a + " jest liczbą dodatnią.");
            }

            Console.WriteLine("\n----- Exercise nr. 4 -----\n");
            Console.Write("Enter the year: ");
            a = Int32.Parse(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine(a + " jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine(a + " nie jest rokiem przestępnym.");
            }

            Console.WriteLine("\n----- Exercise nr. 5 -----\n");
            Console.Write("Enter age: ");
            a = Int32.Parse(Console.ReadLine());
            if (a < 35 && a >= 21)
            {
                Console.WriteLine("Możesz zostać posłem, premierem oraz senatorem.");
                Console.WriteLine("Nie możesz zostać prezydentem.");
            }
            else if (a >= 35)
            {
                Console.WriteLine("Możesz ubiegać się o wszystkie polityczne stanowiska.");

            }
            else
            {
                Console.WriteLine("Jesteś gówniarzem. Nie nadajesz sie do polityki.");
            }

            Console.WriteLine("\n----- Exercise nr. 6 -----\n");
            Console.Write("Enter height: ");
            c = Double.Parse(Console.ReadLine());
            if (c < 150)
            {
                Console.WriteLine("Jesteś krasnoludem.");
            }
            else if (c > 150 && c < 190)
            {
                Console.WriteLine("Masz fajny wzrost.");
            }
            else
            {
                Console.WriteLine("Uważaj na głowę przechodząc przez drzwi.");
            }


            Console.WriteLine("\n----- Exercise nr. 7 -----\n");

            Console.WriteLine("Enter three integer number: ");
            Console.Write("a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("c: ");
            d = Int32.Parse(Console.ReadLine());
            if (a >= b && a >= d)
            {
                Console.WriteLine(a + " jest największą liczbą.");
            }
            else if (a < b && b > d)
            {
                Console.WriteLine(b + " jest największą liczbą.");
            }
            else
            {
                Console.WriteLine(d + " jest największą liczbą.");
            }

            Console.WriteLine("\n----- Exercise nr. 8 -----\n");
            a = 80;
            b = 71;
            d = 0;
            if (a > 70 || b > 55 || d > 45)
            {

                if ((a + b + d > 180) || ((a + b > 150) || (a + d > 150)))
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
                }
                else
                {
                    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
                }
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
            }

            Console.WriteLine("\n----- Exercise nr.  9-----\n");
            Console.Write("Enter temperature: ");
            c = Double.Parse(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (c >= 0 && c < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (c >= 10 && c < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (c >= 20 && c < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (c >= 30 && c < 40)
            {
                Console.WriteLine("zaczyna byc słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }

            Console.WriteLine("\n----- Exercise nr. 10 -----\n");
            Console.WriteLine("Enter three integer number: ");
            Console.Write("a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("c: ");
            d = Int32.Parse(Console.ReadLine());
            if (a >= b && a >= d)
            {
                if (b + d > a)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else
                    Console.WriteLine("Nie można zbudować trójkąta.");
            }
            else if (a < b && b > d)
            {
                if (a + d > b)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else
                    Console.WriteLine("Nie można zbudować trójkąta.");
            }
            else
            {
                if (a + b > d)
                {
                    Console.WriteLine("Można zbudować trójkąt.");
                }
                else
                    Console.WriteLine("Nie można zbudować trójkąta.");
            }

            Console.WriteLine("\n----- Exercise nr. 11 -----\n");
            Console.Write("Enter your mark: ");
            a = Int32.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Niedostateczny.");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczalny.");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny.");
                    break;
                case 4:
                    Console.WriteLine("Dobry.");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry.");
                    break;
                case 6:
                    Console.WriteLine("Celujący.");
                    break;
                default:
                    Console.WriteLine("Podałeś złą ocene");
                    break;
            }

            Console.WriteLine("\n----- Exercise nr. 12 -----\n");
            Console.Write("Enter number of day: ");
            a = Int32.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Poniedziałek.");
                    break;
                case 2:
                    Console.WriteLine("Wtorek.");
                    break;
                case 3:
                    Console.WriteLine("Środa.");
                    break;
                case 4:
                    Console.WriteLine("Czwartek.");
                    break;
                case 5:
                    Console.WriteLine("Piątek.");
                    break;
                case 6:
                    Console.WriteLine("Sobota.");
                    break;
                case 7:
                    Console.WriteLine("Niedziela.");
                    break;
                default:
                    Console.WriteLine("Podałeś zły numer dnia");
                    break;
            }

            Console.WriteLine("\n----- Exercise nr. 12 -----\n");
            Console.Write("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation number. ");
            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Substract ");
            Console.WriteLine("3. Multiply ");
            Console.WriteLine("4. Division ");
            d = Int32.Parse(Console.ReadLine());

            switch(d)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine("Your result: " + result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine("Your result: " + result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine("Your result: " + result);
                    break;
                case 4:
                    if(b == 0)
                    {
                        Console.WriteLine("You can't division by 0.");
                        break;
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine("Your result: " + result);
                        break;
                    }
                default:
                    Console.WriteLine("You enter a  not valid operation");
                    break;
            }



        }
    }
}
