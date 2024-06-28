using System;

class Program
{
    static void Main(string[] args)
    {
        int broj1, broj2;
        char operacija;
        char nastavak = 'd';
        while (nastavak.Equals('d')) {
            Console.WriteLine("Unesite operaciju: ");
            operacija = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Unesite prvi broj: ");
            broj1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            broj2 = Convert.ToInt32(Console.ReadLine());


            switch (operacija)
            {
                case ('+'):
                    Console.WriteLine(broj1 + " + " + broj2 + " = " + (broj1 + broj2));
                    break;

                case ('-'):
                    Console.WriteLine(broj1 + " - " + broj2 + " = " + (broj1 - broj2));
                    break;

                case ('/'):
                    if (broj2 == 0)
                    {
                        Console.WriteLine("Ne mozete deliti nulom.");
                    }
                    else
                    {
                        Console.WriteLine(broj1 + " / " + broj2 + " = " + (Convert.ToDouble(broj1) / broj2));
                    }
                    break;

                case ('*'):
                    Console.WriteLine(broj1 + " * " + broj2 + " = " + (broj1 * broj2));
                    break;

                case ('%'):
                    Console.WriteLine(broj1 + " % " + broj2 + " = " + (broj1 % broj2));
                    break;

                default:
                    Console.WriteLine("Izabrali ste nepostojecu oparaciju.");
                    break;
            }

            Console.WriteLine("Zelite li da nastavite (d/n)? ");
            nastavak = Convert.ToChar(Console.ReadLine());
        }
    }
    }
