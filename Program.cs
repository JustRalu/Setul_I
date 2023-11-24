using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ex_1();
            ex_2();
            ex_3();
            ex_4();
            ex_5();
            ex_6();
            ex_7();
            ex_8();
            ex_9();
            ex_10();
            ex_11();
            ex_12();
            ex_13();
            ex_14();
            ex_15();
            ex_16();
            ex_17();
            ex_18();
            ex_19();
            ex_20();
            ex_21();
            Console.ReadKey();

        }

        private static void ex_1()
        {
            double a, b;
            Console.WriteLine("Scrieti doua numere reale a si b de la tastatura");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("si aflati solutia ecuatiei de gradul I");
            Console.WriteLine();
            if (b == 0)

                Console.WriteLine("Solutia ecuatiei de gradul I este: 0");
            else
            if (a == 0)
                Console.WriteLine("Ecuatia data nu are solutii");
            else
            {
                double x = (-1) * b / a;
                Console.WriteLine($"Solutia ecuatiei de gradul I este: {x}");
            }
            Console.WriteLine();
        }
        private static void ex_2()
        {
            double a, b, c, delta;
            Console.WriteLine("Scrieti trei numere reale a, b si c");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("si aflati solutiile/solutia ecuatiei de gradul al II-lea");
            Console.WriteLine();
            if (a == 0) /// ecuatia data este defapt de primul grad
            {
                if (b == 0)
                    Console.WriteLine($"{c} = 0 => GRESIT: Date gresite date de la tastatura");
                else
                {
                    double x = (-1) * c / b;
                    Console.WriteLine($"Solutia ecuatiei de gradul al II-lea este: {x}");
                }

            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1, x2;
                    x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    Console.WriteLine($"Solutiile ecuatiei de gradul al II-lea sunt: {x1} si {x2}");
                }
                else


                if (delta == 0)
                {
                    double x; ///solutie unica, x1 = x2
                    x = -b / (2 * a);
                    Console.WriteLine($"Solutia ecuatiei de gradul al II-lea este: {x}");
                }


                else
                {

                    double Parte_Reala = (-b / (2 * a));
                    double Parte_Complexa = ((Math.Sqrt((delta * (-1))) / (2 * a)));

                    Console.WriteLine($"Solutiile ecuatiei de gradul al II-lea sunt: {Parte_Reala}+/-{Parte_Complexa}*i");

                }
            }
            Console.WriteLine();

        }
        private static void ex_3()
        {
            Console.WriteLine("Scrieti 2 numere, n si k");
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("si aflati daca n divide la k");
            Console.WriteLine();
            if (k == 0)
                Console.WriteLine("Nu exista numere ce sa divida la 0");
            else
            {
                if (n / k * k == n)
                    Console.WriteLine("Cele 2 numere sunt divizibile intre ele");
                else
                    Console.WriteLine("Cele 2 numere NU sunt divizibile intre ele");
            }
            Console.WriteLine();
        }

        private static void ex_4()
        {
            Console.WriteLine("Scrieti un an y de la tastatura:");
            int y;
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"si aflati daca acesta este bisect");
            Console.WriteLine();
            //Console.Write(DateTime.IsLeapYear(y)); comanda rapida
            if (y <= 0)
                Console.WriteLine("Anii BC nu sunt luati in considerare");
            else
            {
                if (y % 4 == 0)
                {
                    if (y % 100 == 0)
                    {
                        if (y % 400 == 0)
                            Console.WriteLine($"Anul {y} este bisect");
                        else
                            Console.WriteLine($"Anul {y} NU este bisect");
                    }
                    else
                        Console.WriteLine($"Anul {y} este bisect");
                }
                else
                    Console.WriteLine($"Anul {y} NU este bisect");
            }
            Console.WriteLine();
        }
        private static void ex_5()
        {
            Console.WriteLine("Scrieti doua numere n si k, k un numar ce este mai mic sau egal decat numarul de cifre ale lui n, date de la tastatura");
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"si aflati a {k}-a cifra de la sfarsitul lui {n}");
            Console.WriteLine();

            if (k <= 0)
                Console.WriteLine("Date gresite date de la tastatura");

            else
            {
                int n1, cifre = 0;
                n1 = n;
                while (n1 != 0)
                {
                    n1 /= 10;
                    cifre++;
                }
                n1 = n;
                if (k > cifre)
                    Console.WriteLine("Date gresite date de la tastatura");
                else
                {
                    if ((cifre + 1) / 2 <= k)
                    {
                        for (int i = 0; i < k - 1; i++)
                            n1 /= 10;

                        Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului {n} este {n1 % 10}");
                    }

                    else
                    {
                        for (int i = 0; i < cifre - (cifre - k) - 1; i++)
                            n1 /= 10;
                        Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului {n} este {n1 % 10}");
                    }
                }
            }

            Console.WriteLine();
        }
        private static void ex_6()
        {
            int a, b, c;
            Console.WriteLine("Scrieti 3 numere a, b si c");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("si aflati daca acestea formeaza un triunghi");
            Console.WriteLine();
            if (a + b > c || a + c > b || b + c > a)
                Console.WriteLine($"Laturile {a}, {b} si {c} formeaza un triunghi");
            else
                Console.WriteLine($"Laturile {a}, {b} si {c} NU formeaza un triunghi");
            Console.WriteLine();


        }
        private static void ex_7()
        {
            Console.WriteLine("Scrieti doua numere a si b");
            int a, b, aux;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("iar apoi inversati-le");
            Console.WriteLine();
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Numerele inversate sunt {a} si {b}");
            Console.WriteLine();
        }
        private static void ex_8()
        {
            Console.WriteLine("Scrieti doua numere a si b");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("iar apoi inversati-le, dar fara a va folosi de variabile suplimentare");
            Console.WriteLine();
            if (a == 0)
            {
                a = b;
                b = 0;
            }
            else
                if (b == 0)
            {
                b = a;
                a = 0;
            }
            else
            {
                a = a * b;
                b = a / b;
                a = a / b;
            }

            Console.WriteLine();
            Console.WriteLine($"Numerele inversate sunt {a} si {b}");
            Console.WriteLine();
        }
        private static void ex_9()
        {
            Console.WriteLine("Dati un numar intreg n de la tastatura");
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("si aflati divizorii sai");
            Console.WriteLine();

            if (n < 0)
                n *= (-1);

            if (n == 0 || n == 1)
                Console.WriteLine($"divizorul lui {n} este el insusi, {n}");
            else

                if (n == 2)
                Console.WriteLine($"divizorii lui 2 sunt 1 si 2");
            else
            {
                Console.Write($"1, {n}, ");
                for (int i = 2; i * i <= n; i++)
                    if (n % i == 0)
                        Console.Write($"{i}, {n / i}, ");
            }
            Console.WriteLine();


        }
        private static void ex_10()
        {

            Console.WriteLine("Dati de la tastatura un numar natural n >= 2");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("si aflati daca acesta este prim");
            Console.WriteLine();
            bool ok = true;
            if (n < 2)
                ok = false;
            else
                if (n != 2 && n % 2 == 0)
                ok = false;
            else
                for (int i = 3; i * i <= n && ok; i += 2)
                    if (n % i == 0)
                        ok = false;

            if (ok)
                Console.Write($"{n} este prim");
            else
                Console.Write($"{n} NU este prim");

            Console.WriteLine();
        }
        private static void ex_11()
        {
            Console.WriteLine("Dati de la tastatura un numar n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("si afisati cifrele sale in ordine inversa");
            Console.WriteLine();
            if (n < 0)
                n *= (-1);

            if (n == 0)
                Console.WriteLine(0);
            else
                while (n != 0)
                {
                    Console.Write(n % 10);
                    n /= 10;
                }
            Console.WriteLine();

        }
        private static void ex_12()
        {
            int a, b, n, nr = 0;
            Console.WriteLine("Scrieti 3 numere a, b, b>= a si n, n >= a si n <= b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            Console.WriteLine($"si aflati cate numere din [{a},{b}] sunt divizibile cu {n}");
            Console.WriteLine();
            if (n == 0)
                Console.WriteLine("date gresite date de la tastatura");
            else
            {
                int aux_a = a;
                while(aux_a <= n && aux_a < b)
                {
                    if (n % aux_a == 0)
                        nr++;
                    aux_a++;
                }
                int ratie = n;
                if (ratie < 0)
                    ratie *= (-1);
                while (aux_a % n != 0 && aux_a < b)
                    aux_a++;

                if(aux_a % n == 0)
                    for (int i = aux_a; i <= b; i += ratie)
                        nr++;
                  Console.WriteLine($"Numarul de numere din [{a},{b}] divizibile cu {n} este {nr}");
                
            }

            Console.WriteLine();
        }
        private static void ex_13()
        {
            Console.WriteLine("Scrieti doua numere naturale nenule, ce reprezinta un interval de ani");
            int y1, y2;
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (y1 <= 0 || y2 <= 0)
                Console.WriteLine("Anii BC nu sunt luati in considerare");
            else
            {
                int y1_aux = y1, nr_ani_bisecti = 0;
                if (y1 > y2)
                {
                    int aux = y1;
                    y1 = y2;
                    y2 = aux;
                }
                Console.WriteLine($"si aflati numarul de ani bisecti din [{y1},{y2}]");

                while (y1_aux % 4 != 0)

                    y1_aux++;

                for (int i = y1_aux; i <= y2; i += 4)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                            nr_ani_bisecti++;

                    }
                    else
                        nr_ani_bisecti++;
                }
                Console.WriteLine($"Numarul de ani bisecti intre {y1} si {y2} este: {nr_ani_bisecti}");
            }

            Console.WriteLine();
        }
        private static void ex_14()
        {

            Console.WriteLine("Scrieti un numar natural n");
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("si aflati daca acesta este palindrom");
            Console.WriteLine();
            if (n % 10 == 0 && n != 0)
                Console.WriteLine($"Numarul {n} NU este palindrom");
            else
            {
                int n1, ogl = 0;
                n1 = n;
                while (n1 != 0)
                {
                    ogl = ogl * 10 + n1 % 10;
                    n1 /= 10;
                }

                if (n == ogl)
                    Console.WriteLine($"Numarul {n} este palindrom");
                else
                    Console.WriteLine($"Numarul {n} NU este palindrom");
            }
            Console.WriteLine();
        }

        private static void ex_15()
        {
            int a, b, c;
            Console.WriteLine("Scrieti 3 nr a, b si c");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("si afisati-le in ordine crescatoare");
            Console.WriteLine();
            if (a <= b && b <= c)
                Console.WriteLine($"Numerele afisate in ordine crescatoare sunt {a}, {b}, {c} ");
            else
            if (a <= c && c >= b && a >= b)
                Console.WriteLine($"Numerele afisate in ordine crescatoare sunt {b}, {a}, {c} ");

            else

            if (a <= b && b >= c && a >= c)
                Console.WriteLine($"Numerele afisate in ordine crescatoare sunt {c}, {a}, {b} ");

            else
                if (a <= b && b >= c && c >= a)
                Console.WriteLine($"Numerele afisate in ordine crescatoare sunt {a}, {c}, {b} ");

            else
                   if (b <= a && a >= c && c >= b)
                Console.WriteLine($"Numerele afisate in ordine crescatoare sunt {b}, {c}, {a} ");
            else

                Console.WriteLine($"Numerele afisate in ordine crescatoare sunt {c}, {b}, {a} ");

            Console.WriteLine();

        }
        public static int min(int x, int y)
        {
            if (x > y)
                return y;
            return x;
        }
        private static bool verif(int x, int y)
        {
            if (x == y)
                return true;
            return false;
        }

        private static void ex_16()
        {
            Console.WriteLine("Scrieti 5 nr intregi a, b, c, d si e");
            int a, b, c, d, e, aux, minim;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("si afisati-le in ordine crescatoare, dar fara a va folosi de tablouri");
            Console.WriteLine();

            minim = min(min(min(min(d, e), c), b), a);

            if (!verif(a, minim))
            {
                if (verif(b, minim))
                {
                    aux = a;
                    a = b;
                    b = aux;
                }
                else
                    if (verif(c, minim))
                {
                    aux = a;
                    a = c;
                    c = aux;
                }
                else
                        if (verif(d, minim))
                {
                    aux = a;
                    a = d;
                    d = aux;
                }
                else
                {
                    aux = a;
                    a = e;
                    e = aux;
                }

            }
            minim = min(min(min(d, e), c), b);
            if (!verif(b, minim))
            {
                if (verif(c, minim))
                {
                    aux = b;
                    b = c;
                    c = aux;
                }
                else
                    if (verif(d, minim))
                {
                    aux = b;
                    b = d;
                    d = aux;
                }
                else
                {
                    aux = b;
                    b = e;
                    e = aux;
                }

            }
            minim = min(min(d, e), c);
            if (!verif(c, minim))
            {
                if (verif(d, minim))
                {
                    aux = c;
                    c = d;
                    d = aux;
                }
                else
                {
                    aux = c;
                    c = e;
                    e = aux;
                }

            }

            minim = min(d, e);
            if (!verif(d, minim))
            {
                aux = d;
                d = e;
                e = aux;
            }

            Console.WriteLine($"Nr ordonate sunt: {a}, {b}, {c}, {d}, {e}");
            Console.WriteLine();

        }
        private static void ex_17()
        {

            Console.WriteLine("Scrieti doua numere a si b");
            int a, b, a1, b1, r;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("si aflati cel mai mare divizor comun, respectiv cel mai mic multiplu comun al acestora");
            Console.WriteLine();
            a1 = a;
            b1 = b;
            while (b1 != 0)
            {
                r = a1 % b1;
                a1 = b1;
                b1 = r;
            }
            Console.WriteLine($"Cel mai mare divizor comun al nr {a} si {b} este {a1} si cel mai mic multiplu comunn al acestora  este {a * b / a1} ");
            Console.WriteLine();
        }
        private static void ex_18()
        {
            Console.WriteLine("Scrieti un numar intreg n");
            int n = int.Parse(Console.ReadLine());
            int f = 2, pow;
            Console.WriteLine("si afisati descompunerea sa in factori primi");
            Console.WriteLine();
            Console.WriteLine($"{n}: ");
            while (n != 1)
            {
                pow = 0;
                while (n % f == 0)
                {
                    pow++;
                    n /= f;
                }

                if (pow != 0 && n != 1)
                    Console.Write($"{f}^{pow} + ");
                else
                    if (pow != 0 && n == 1)
                    Console.Write($"{f}^{pow}");
                f++;
            }
            Console.WriteLine();
        }
        private static void ex_19()
        {
            Console.WriteLine("Dati de la tastatura un numar n");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("si aflati daca acesta contine exact 2 cifre ce se repeta in scrierea sa");
            Console.WriteLine();
            long[] cif = new long[10];
           long n1 = n, n2 = n;

            List<long> repetitii = new List<long>();
            for (int i = 0; i < 10; i++)
                cif[i] = 0;
            int cifre_repetative = 0;
            if (n < 0)
                n = (-1) * n;


            while (n != 0)
            {

                cif[n % 10]++;
                n2 = n;
                n /= 10;

                if (cif[n2 % 10] > 1)///o anumita cifra se repeta
                {
                    if (!repetitii.Contains(n2 % 10))
                    {
                        repetitii.Add(n2 % 10);
                        cifre_repetative++;///se repeta mai mult de o cifra din n
                        if (cifre_repetative > 2)
                        {
                            Console.WriteLine($"In scrierea lui {n1} se repet MAI MULT de 2 cifre distincte");
                            break;
                        }
                    }
                }

            }

            if (cifre_repetative < 2)
                Console.WriteLine($"In scrierea lui {n1} se repet MAI PUTIN de 2 cifre distincte");
            else
                if (cifre_repetative == 2)
                Console.WriteLine($"In scrierea lui {n1} se repet EXACT 2 cifre distincte");

        }
        private static void ex_20()
        {
            int m, n, f2 = 0, f5 = 0, m1, n1;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            m1 = m;
            n1 = n;
            Console.WriteLine();
            Console.Write($"{m / n},"); ///parte intreaga

            while (m1 % 2 == 0 && n1 % 2 == 0)
            {
                m1 /= 2;
                n1 /= 2;
            }
            while (m1 % 5 == 0 && n1 % 5 == 0)
            {
                m1 /= 5;
                n1 /= 5;
            }
            while (n1 % 2 == 0)
            {
                n1 /= 2;
                f2++;
            }
            while (n1 % 5 == 0)
            {
                n1 /= 5;
                f5++;
            }
            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;

            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (n1 == 1 || m1 % n1 == 0)///fractie simpla/finita
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            if(f2 == 0 && f5 == 0) ///fractie periodica simpla
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
            else///fractie periodica mixta f2 != 0 si/sau f5 != 0
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }


        }
        private static void ex_21()
        {
            int random, random1;
            Random a = new Random();
            random = a.Next(0, 1024);
            Random b = new Random();
            do
            {
                random1 = b.Next(0, 1024);
            } while (random == random1);
            Console.WriteLine();
            Console.WriteLine($"Numerele sunt: {random} si {random1}");

            if (random > random1)
                Console.WriteLine($"{random} > {random1}");

            else
                Console.WriteLine($"{random} < {random1}");

            Console.WriteLine();
        }

    }
}

