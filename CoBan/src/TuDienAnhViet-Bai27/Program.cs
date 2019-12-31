using System;
using System.Collections.Generic;

namespace TuDienAnhViet_Bai27
{
    class Program
    {
        static Dictionary<string, string> dics = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            const int SoMenu = 4;
            while (true)
            {
                try
                {
                    Console.Clear();
                    int action = ChonChucNang(SoMenu);
                    XuLyChucNang(action);

                    Console.Write("Ban co muon tiep tuc khong (c/k): ");
                    string chosen = Console.ReadLine();
                    if (chosen == "k" || chosen == "K")
                        break;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"Da xay ra loi: {ex.Message}");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Cam on da su dung chuong trinh");
        }

        private static void XuLyChucNang(int action)
        {
            switch (action)
            {
                case 1:
                    TaoTuMoi();
                    break;
                case 2:
                    SuaTu();
                    break;
                case 3:
                    TraCuu();
                    break;
                case 4:
                    XoaTu();
                    break;
            }
        }

        private static void Save(string key, string value, bool overWrite = false)
        {
            string lowerKey = key.ToLower();
            string lowerValue = value.ToLower();

            if (!overWrite)
            {
                if (dics.ContainsKey(lowerKey))
                    throw new ArgumentException($"Tu {key} da ton tai trong tu dien.");
                else
                {
                    dics.Add(lowerKey, lowerValue);
                }
            }
            else
            {
                dics[key] = value;
            }
        }

        private static string Retrieve(string key)
        {
            string lowerKey = key.ToLower();

            if (!dics.ContainsKey(lowerKey))
                throw new KeyNotFoundException($"Khong tim thay tu {ToiUuTu(lowerKey)} trong tu dien");
            else
            {
                return dics[lowerKey];
            }
        }

        private static string ToiUuTu(string str)
        {
            var strArr = str.ToCharArray();
            strArr[0] = char.ToUpper(strArr[0]);
            return new string(strArr);
        }

        private static void XoaTu()
        {
            string key;

            Console.Write("Nhap tu tieng Anh can xoa khoi tu dien: ");
            key = Console.ReadLine();

            Retrieve(key);

            dics.Remove(key.ToLower());
            Console.WriteLine($"Da xoa tu {ToiUuTu(key)} ra khoi tu dien.");
        }

        private static void TraCuu()
        {
            string key;

            Console.Write("Nhap tu tieng Anh can tra cuu: ");
            key = Console.ReadLine();

            string value = Retrieve(key);
            Console.WriteLine($"Nghia cua tu {ToiUuTu(key)} la {ToiUuTu(value)}");
        }

        private static void SuaTu()
        {
            string key;
            string value;

            Console.Write("Nhap tu tieng Anh can sua nghia: ");
            key = Console.ReadLine();

            Retrieve(key);

            Console.Write($"Nhap nghia tieng Viet moi cua tu {ToiUuTu(key)}: ");
            value = Console.ReadLine();

            Save(key, value, true);
            Console.WriteLine("Da thay doi nghia thanh cong!");
        }

        private static void TaoTuMoi()
        {
            string key;
            string value;

            Console.Write("Nhap tu moi (tieng Anh): ");
            key = Console.ReadLine();

            Console.Write("Nhap nghia cua tu (tieng Viet): ");
            value = Console.ReadLine();

            Save(key, value);
            Console.WriteLine("Da luu tu moi thanh cong");
        }

        private static int ChonChucNang(int SoMenu)
        {
            int menu;
            while (true)
            {
                try
                {
                    XuatMenu();
                    Console.Write("Vui long chon chuc nang: ");
                    menu = int.Parse(Console.ReadLine());
                    if (0 < menu && menu <= SoMenu)
                        break;
                }
                catch
                {
                    Console.WriteLine("Ki tu nhap vao khong hop le!");
                }
            }
            return menu;
        }

        private static void XuatMenu()
        {
            Console.WriteLine("1. Tao tu moi");
            Console.WriteLine("2. Sua tu");
            Console.WriteLine("3. Tra cuu Anh - Viet");
            Console.WriteLine("4. Xoa tu");
        }
    }
}
