using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCC_Day9_Exercise1
{
    public class Exercise
    {
        private int sLength, sWidth, sideSquare;
        private Double bottom, high;

        public int Length
        {
            get { return sLength; }
            set { sLength = value; }
        }

        public int Width
        {
            get { return sWidth; }
            set { sWidth = value; }
        }

        public int Side
        {
            get { return sideSquare; }
            set { sideSquare = value; }
        }
        
        public Double Bottom
        {
            get { return bottom; }
            set { bottom = value; }
        }
        
        public Double High
        {
            get { return high; }
            set { high = value; }
        }

        public class TwoDimensional
        {
            public virtual void Formula()
            {
                Console.WriteLine("Rumus Luas Bangun Datar");
            }
        }

        public class Square : TwoDimensional
        {
            public override void Formula()
            {
                Console.WriteLine("Luas Persegi = s x s");
            }

            public int Formula(int side)
            {
                Console.WriteLine("Luas Persegi = " + side + " x " + side);
                return side * side;
            }
        }

        public class Rectangle : TwoDimensional
        {
            public override void Formula()
            {
                Console.WriteLine("Luas Persegi Panjang = p x l");
            }

            public int Formula(int length, int width)
            {
                Console.WriteLine("Luas Persegi Panjang = " + length + " x " + width);
                return length * width;
            }
        }

        public class Triangle : TwoDimensional
        {
            public override void Formula()
            {
                Console.WriteLine("Luas Segitiga = 1/2 x alas x tinggi");
            }

            public Double Formula(Double bottom, Double high)
            {
                Console.WriteLine("Luas Segitiga = 1/2 x " + bottom + " x " + high);
                return 0.5 * bottom * high;
            }
        }

        static void Main(string[] args)
        {
            string reset;
            
            Exercise pro = new Exercise();
            TwoDimensional bd = new TwoDimensional();
            bd.Formula();
            Console.WriteLine("1. Luas Persegi");
            Console.WriteLine("2. Luas Persegi Panjang");
            Console.WriteLine("3. Luas Segitiga");
            Console.Write("Silakan pilih ingin menghitung luas bangun datar yang mana : ");
            try
            {
                do
                {
                    int choose = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (choose)
                    {
                        case 1:
                            Console.Write("Silakan masukkan sisi persegi (cm) : ");
                            pro.sideSquare = Convert.ToInt32(Console.ReadLine());
                            Square sq = new Square();
                            sq.Formula();
                            Console.WriteLine("Luas Persegi = " + sq.Formula(pro.sideSquare));
                            break;
                        case 2:
                            Console.Write("Silakan masukkan panjang persegi (cm) : ");
                            pro.sLength = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Silakan masukan lebar persegi (cm) : ");
                            pro.sWidth = Convert.ToInt32(Console.ReadLine());
                            Rectangle rt = new Rectangle();
                            rt.Formula();
                            Console.WriteLine("Luas Persegi Panjang = " + rt.Formula(pro.sLength, pro.sWidth));
                            break;
                        case 3:
                            Console.Write("Silakan masukkan alas segitiga (cm) : ");
                            pro.bottom = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Silakan masukkan tinggi segitiga (cm) : ");
                            pro.high = Convert.ToDouble(Console.ReadLine());
                            Triangle tr = new Triangle();
                            tr.Formula();
                            Console.WriteLine("Luas Segitiga = " + tr.Formula(pro.bottom, pro.high));
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak tersedia, silakan pilih kembali");
                            break;
                    }
                    Console.WriteLine("\nApakah ingin menghitung kembali? [Yes/No]");
                    reset = Console.ReadLine();
                    Console.Clear();
                } while (reset == "Yes" || reset == "yes" || reset == "Y" || reset == "y");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}