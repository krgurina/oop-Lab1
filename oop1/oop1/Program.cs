using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------ТИПЫ-----------------
            //1a
            bool a1 = true;
            Console.WriteLine("bool = " + a1);

            Console.Write("byte = ");
            byte a2 = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine(a2);

            Console.Write("sbyte = ");
            sbyte a3 = Convert.ToSByte(Console.ReadLine());
           // Console.WriteLine(a3);

            Console.Write("char = ");
            char a4 = Convert.ToChar(Console.ReadLine()); ;

            Console.Write("decimal = ");
            decimal a5 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("double = ");
            double a6 = Convert.ToDouble(Console.ReadLine());

            Console.Write("float = ");
            float a7 = Convert.ToByte(Console.ReadLine());

            Console.Write("int = ");
            int a8 = Convert.ToInt32(Console.ReadLine());

            Console.Write("uint = ");
            uint a9 = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("long = ");
            long a10 = Convert.ToInt64(Console.ReadLine());

            Console.Write("ulong = ");
            ulong a11 = Convert.ToUInt64(Console.ReadLine());

            Console.Write("short = ");
            short a12 = Convert.ToInt16(Console.ReadLine());

            Console.Write("ushort = ");
            ushort a13 = Convert.ToUInt16(Console.ReadLine());
            


            //1b
            // явные
            float b1 = 7.592f;
            float b2 = 1.616f;
            byte b3 = (byte)(b1 + b2);
            sbyte b4 = (sbyte)(b1 + b2);
            short b5 = (short)(b1 + b2);
            int b6 = (int)(b1 + b2);
            long b7 = (long)(b1 + b2);
            Console.WriteLine("float-->byte: " + b3);
            Console.WriteLine("float-->sbyte: " + b4);
            Console.WriteLine("float-->short: " + b5);
            Console.WriteLine("float-->int: " + b6);
            Console.WriteLine("float-->long: " + b7);

            // неявные
            byte bnum = 8;
            short snum = bnum;
            int inum = snum;
            long lnum = inum;
            float fnum = lnum;
            Console.WriteLine("byte->short->int->long->float: " + fnum);

            Console.Write("Введите число: ");
            int b8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число: " + b8);

            //1c
            int c1 = 5;
            object c2 = c1;
            int c3 = (int)c2;

            double c4 = 7.7777777;
            object c5 = c4;
            double c6 = (double)c5;

            //1d
            var d1 = "Неявно типизированная переменная";
            Console.WriteLine(d1);
            var d2 = 5;
            var d3 = 7.74;
            var d4 = d2 + d3;

            //1e
            int? e1 = null;

            if (e1 == null) Console.WriteLine("null");
            else Console.WriteLine("Число");

            //1f
            var f1 = 5;
            //f1 = 0.4444;

            //--------------Строки-----------------
            //2a

            string str1 = "nnn";
            string str2 = "nnn";
            string str3 = "ppp";
            Console.WriteLine($"Сравнение 1 и 2 строки: {str1 == str2}");
            Console.WriteLine($"Сравнение 2 и 3 строки: {str3 == str2}");

            //2b

            string str11 = "Это первая строка";
            string str22 = "Это вторая строка";
            string str33 = "Это третья строка";

            Console.WriteLine($"Сцепление строк: {String.Concat(str11, str22)}");
            Console.WriteLine($"Копирование строки: {String.Copy(str22)}");
            Console.WriteLine($"Выделение подстроки: {str33.Substring(11)}");
            Console.WriteLine($"Разделение строки на слова: ");
            string[] strArr = str11.Split();
            for (int ind = 0; ind < strArr.Length; ind++)
            {
                Console.WriteLine(strArr[ind]);
            }
            Console.WriteLine($"Вставка подстроки в заданную позицию: {str22.Insert(4, str11)}");
            Console.WriteLine($"Удаление заданной подстроки: {str33.Remove(4)}");

            //2c
            string emtstr = "";
            string nullstr = null;
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(emtstr)}");
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(nullstr)}");
           
            Console.WriteLine($"Вывод пустой строки: {emtstr}");
            Console.WriteLine($"Вывод нулевой строки: {nullstr}");
            Console.WriteLine($"Сравнение 1 и 2 строки: {emtstr == nullstr}");
            Console.WriteLine($"Сцепление: {String.Concat(emtstr, nullstr)}");

            //2d
            StringBuilder ww = new StringBuilder("rrkkkkrrrr", 7);
            ww.Remove(2, 4);
            ww.Insert(0, str33.Substring(11));
            ww.Append("end");
            Console.WriteLine($"StringBuilder: {ww}");

            //--------------МАССИВЫ-----------------
            //3a
            int[,] arr2d = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr2d[i, j]} \t");
                }
                Console.WriteLine();
            }

            //3b
            string[] srtArr = { "aaa", "bbbbb", "ccccccc" };
            Console.WriteLine($"Длина массива: {srtArr.Length}");

            foreach (string str in srtArr)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Введите позицию: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите строку: ");
            string strpos = Convert.ToString(Console.ReadLine());

            srtArr[pos] = strpos;
            Console.WriteLine("--------");

            foreach (string str in srtArr)
            {
                Console.WriteLine(str);
            }

            //3c
            double [][] arr = new double[3][];
            arr[0] = new double[2];
            arr[1] = new double[3];
            arr[2] = new double[4];

            Console.WriteLine("Заполните ступенчатый массив: ");
            for (int i = 0; i < 2; i++)
            {
                arr[0][i] = Convert.ToDouble(Console.ReadLine());
                //Console.Write("{0}\t", arr[0][i]);
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                arr[1][i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i  = 0; i < 4; i++)
            {
                arr[2][i] = Convert.ToDouble(Console.ReadLine());
            }



            foreach (double[] row in arr)
            {
                foreach (double number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
            //3d

            var vArr = new object[0];
            var vstr = "";

   
            
        }
    }
}





