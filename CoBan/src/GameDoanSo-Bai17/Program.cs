using System;

namespace GameDoanSo_Bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GameDoanSo();
                Console.Write("Co muon choi tiep khong (c/k): ");
                var ch = Console.ReadLine();
                if (ch == "k")
                    break;

                Console.WriteLine("TRO CHOI MOI!");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("TRO CHOI KET THUC!");
        }

        private static void GameDoanSo()
        {
            const int TOIDA = 7;
            int soLuotDoan = 0;

            int soNgauNhien = new Random().Next(1, 100);
            int soDoan = 0;

            Console.WriteLine("CHAO MUNG BAN DEN VOI GAME DOAN SO");
            Console.WriteLine("So ngau nhien da duoc tao! Bat dau tro choi");
            Console.WriteLine($"Ban co toi da {TOIDA} luot doan.");
            Console.WriteLine("");

            while (soLuotDoan < TOIDA)
            {
                Console.WriteLine($"Ban co {TOIDA - soLuotDoan} luot doan!");
                Console.Write("Hay doan 1 so: ");

                try
                {
                    soDoan = int.Parse(Console.ReadLine());
                    if (soDoan == soNgauNhien)
                    {
                        Console.WriteLine("Xin chuc mung!");
                        Console.WriteLine($"So bi mat la: {soNgauNhien}.");
                        Console.WriteLine($"Ban mat {soLuotDoan + 1} luot doan de doan ra so bi mat.");
                        break;
                    }

                    else if (soDoan < soNgauNhien)
                    {
                        Console.WriteLine("So bi mat lon hon");
                    }
                    else
                    {
                        Console.WriteLine("So bi mat nho hon");
                    }
                }
                catch
                {
                    Console.WriteLine("So nhap vao khong hop le!");
                }
                finally
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine("");
                    soLuotDoan++;
                }
            }

            if (soLuotDoan == TOIDA)
            {
                System.Console.WriteLine("BAN DA HET LUOT DOAN");
                Console.WriteLine($"So bi mat la: {soNgauNhien}.");
            }
        }
    }
}
