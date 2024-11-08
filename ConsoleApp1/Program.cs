using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                do{
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("======================================");
                Console.WriteLine("Selamat Datang Di Kalkulator Sederhana");
                Console.WriteLine("======================================");

                Console.WriteLine("Masukkan Angka 1:");
                num1 = Convert.ToDouble(Console.ReadLine()); // Inputan Angka Pertama

                Console.WriteLine("Masukkan Angka 2:");
                num2 = Convert.ToDouble(Console.ReadLine()); //Inputan Angka Kedua

                Console.WriteLine("\t+ : Tambah");
                Console.WriteLine("\t- : Kurang");
                Console.WriteLine("\t* : Kali");
                Console.WriteLine("\t/ : Bagi");
                Console.Write("Masukkan Opsi: ");

                switch (Console.ReadLine()){
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid");
                        break;
                    }
                    Console.WriteLine("Would you like to continue? [Y/N]: ");
                } while(Console.ReadLine()?.ToUpper() == "Y");

            Console.WriteLine("Bye!");    
            Console.ReadKey();
        }
    }
}