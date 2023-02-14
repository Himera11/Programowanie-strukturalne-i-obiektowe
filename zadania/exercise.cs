using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace zadania
{
    class Exercise
    {
        public void Exercise1(int number, int number2)
        {
            Console.WriteLine($"wyink = {(number + number2) / 2}");
        }
        public void Exercise2(int bok, int bok2)
        {
            Console.WriteLine($"pole = {bok * bok2}");
        }
        public void Exercise3(int wysokosc, int r)
        {
            Console.WriteLine($"objetosc stozka wynosi {(Math.PI * 1 / 3) * r * r * wysokosc}");
        }
        public void Exercise4(int r)
        {
            Console.WriteLine($"pole koła = {Math.PI * r * r}");
        }
        public void Exercise5(int a, int b)
        {
            Console.WriteLine($"wyraxenie wynosi {Math.Pow(a, 2) + Math.Pow(b, 2)}");
        }
        public void Exercise6(int b, int h)
        {
            Console.WriteLine($"pole trójkata wynosi = {b * 1 / 2 * h}");
        }
        public void Exercise7(int r)
        {
            Console.WriteLine($"objetosc kuli wynosi = {(Math.PI * 4 / 3) * Math.Pow(r, 3)}");
        }
        public void Exercise8(double a, double b, double h)
        {
            Console.WriteLine($"pole trapezu wynosi = {(a + b) / 2 * h}");
        }
        public void Exercise9(double liczba, double liczba2, double liczba3, double waga1, double waga2, double waga3)
        {
            Console.WriteLine((liczba * waga1 + liczba2 * waga2 + liczba3 * waga3) / (waga1 + waga2 + waga3));
        }
        public void Exercise1_1(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("liczba jest parzysta");
            }
            else
                Console.WriteLine("liczba jest nie parzysta");
        }
        public void Exercise1_2(int a)
        {
            if (a > 0)
                Console.WriteLine("liczba " + a + " jest dodatnia");
            else if (a == 0)
                Console.WriteLine("liczbą " + a + " jest 0");

            else if (a < 0)
                Console.WriteLine("liczba " + a + " jest ujemna");
        }
        public void Exercise1_3()
        {
            int rok;
            Console.WriteLine("podaj rok");
            rok = Convert.ToInt32(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0)
                Console.WriteLine("rok jest przestępny");
            else
                Console.WriteLine("rok nie jest przestepny");
        }
        public void Exercise1_4()
        {
            int a;
            Console.WriteLine("typical asian parents.");
            Console.WriteLine("podaj ocene");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("jeden - u are a failure, im about to disown you ");
                    break;
                case 2:
                    Console.WriteLine("dwa - your five years old cousin did better. he is already a doctor and he is working 30 hours a day.");
                    break;
                case 3:
                    Console.WriteLine("trzy - why so dumb.");
                    break;
                case 4:
                    Console.WriteLine("cztery - you are completly useless");
                    break;
                case 5:
                    Console.WriteLine("piątka - in your age all my grades were A+.");
                    break;
                case 6:
                    Console.WriteLine("szesc - u should do better i expected more from you..... you are so usless taht i cant even understand it your a failure.");
                    break;
            }
        }
        public void Exercise1_5()
        {
            string haslo = "hasło";
            string a;
            Console.WriteLine("podaj hasło");
            a = Convert.ToString(Console.ReadLine());
            if (a == haslo)
                Console.WriteLine("poprawne hasło");
            else
                Console.WriteLine("złe hasło");
        }
        public void Exercise1_6()
        {
            Console.WriteLine("Podaj dzien ");
            int dzien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj miesiac ");
            int miesiac = Convert.ToInt32(Console.ReadLine());

            if (dzien < 31 && dzien > 1)
            {
                Console.WriteLine("poprawny dzien");
            }
            else
                Console.WriteLine("nie poprawny dzien");

            if (miesiac <= 12 && miesiac >= 1)
            {
                Console.WriteLine("poprawny miesiac");
            }
            else
                Console.WriteLine("nie poprawny dzien");
        }
        public void Exercise1_7()
        {
            Console.WriteLine("Ile jest stopnii ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp > 20 && temp < 40)
            {
                Console.WriteLine("Gorąco");
            }
            else if (temp > 0 && temp < 20)
            {
                Console.WriteLine("ciepło");
            }
            else if (temp > 40)
            {
                Console.WriteLine("piekło");
            }
            else if (temp < 0 && temp > -20)
            {
                Console.WriteLine("zimno");
            }
            else if (temp < -20)
            {
                Console.WriteLine("lodowato");
            }
            else if (temp == 0)
            {
                Console.WriteLine("średniawa");
            }
        }

        public void Exercise2_1()
        {
            Console.WriteLine("podaj liczbe ");
            int num = Convert.ToInt32(Console.ReadLine());
            int licznik = 0;
            if (num < 2)
                Console.WriteLine("to nie jest liczba pierwsza");

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    licznik++;
            }
            if (licznik > 2)
            {
                Console.WriteLine("nie jest");
            }
            else
                Console.WriteLine("jest");
        }
        public void Exercise2_2()
        {
            Console.WriteLine("podaj wyraz");
            string wyraz = Convert.ToString(Console.ReadLine());
            string wyrazod = "";
            for (int i = wyraz.Length - 1; i >= 0; i--)
                wyrazod = wyrazod + wyraz[i];
            if (wyraz == wyrazod)
            {
                Console.WriteLine("jest to palindrom");
            }
            else
                Console.WriteLine("nie jest to palindrom");
        }

        public void Exercise2_3()
        {

        }

        public void Exercise2_4()
        {
            Console.WriteLine("Podaj liczbe");
            int suma = 0;
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {

                    suma = suma + i;
                }
            }
            if (suma == num)
            {
                Console.WriteLine("Liczba " + num + " jest liczbą doskonałą");
            }
            else
            {
                Console.WriteLine("Liczba " + num + " nie jest liczbą doskonałą");
            }
        }
        public void Exercise3_1()
        {
            for (int i = 1; i != 11; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Exercise3_2()
        {
            int suma = 0;
            for (int i = 1; i != 101; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
        }
        public void Exercise3_3()
        {
            for (int i = 1; i != 11; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        public void Exercise3_4()
        {
            Console.WriteLine("podaj liczbe ");
            int num = Convert.ToInt32(Console.ReadLine());
            int suma = 1;
            for (int i = 1; i <= num; i++)
            {
                suma = suma * i;
            }
            Console.WriteLine(suma);
        }
        public void Exercise3_5()
        {
            int suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j);
                }
            }
        }
        public void Exercise3_6()
        {
            for (int i = 1; i != 101; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
        public void Exercise3_7()
        {
            double suma = 0;
            for (int i = 1; i != 11; i++)
            {
                suma = suma + (Math.Pow(i, 2));
            }
            Console.WriteLine(suma);
        }
        public void Exercise3_8()
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(b);
                b = b + a;
                a = b - a;
            }
        }
        public void Exercise3_9()
        {
            double sum;
            for (int i = 0; i <= 10; i++)
            {
                sum = (Math.Pow(2, i));
                Console.WriteLine($"2^{i} = {sum}");
            }
        }
        public void Exercise3_10()
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(b);
                b = b + a;
                a = b - a;
            }
        }
        public void Exercise4_1()
        {
            string pass = "abc123";
            string haslo = "";
            do
            {
                Console.WriteLine("podaj hasło");
                haslo = Convert.ToString(Console.ReadLine());
            } while (haslo != "abc123");
            if (haslo == "abc123")
            {
                Console.WriteLine("poprawne haslo");
            }
            else Console.WriteLine("niepoprawne haslo");
        }
        public void Exercise4_2()
        {
            double number = 1;
            double suma = 0;
            do
            {
                Console.WriteLine(suma = Math.Pow(number, 2));
                number++;
            } while (suma < 1000);
            Console.WriteLine(suma);
        }

        public void harder2()
        {
            Console.WriteLine("podaj liczbe");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj 2 liczbe");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            while (liczba != liczba2)
            {
                if (liczba > liczba2)
                {
                    liczba -= liczba2;
                }
                else
                {
                    liczba2 -= liczba;
                }
            }
            Console.WriteLine("największy wspólny dzielnik to " + liczba);

        }
        public void harder3()
        {
            Console.WriteLine("podaj liczbe");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj 2 liczbe");
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            while (liczba != liczba2)
            {
                if (liczba < liczba2)
                {
                    liczba += liczba;
                }
                if (liczba > liczba2)
                {
                    liczba2 += liczba2;

                }
            }
            Console.WriteLine("największa wspólna wielokrotność to " + liczba);

        }
    }
}
