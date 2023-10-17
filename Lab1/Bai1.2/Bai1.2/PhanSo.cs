using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._2
{
        public class PhanSo : IComparable<PhanSo>
        {
            private int tuso;
            private int mauso;

            public PhanSo(int tuso = 0, int mauso = 1)
            {
                this.tuso = tuso;
                this.mauso = mauso;
            }

            public int TuSo
            {
                get { return tuso; }
                set { tuso = value; }
            }

            public int MauSo
            {
                get { return mauso; }
                set
                {
                    if (value != 0)
                        mauso = value;
                    else
                        throw new ArgumentException("Mau so phai khac 0!.");
                }
            }

            public void RutGon()
            {
                int t = Math.Abs(tuso);
                int m = Math.Abs(mauso);

                while (m != 0)
                {
                    int temp = m;
                    m = t % m;
                    t = temp;
                }
                tuso /= t;
                mauso /= t;
            }

            public int CompareTo(PhanSo o)
            {
                int a = tuso * o.mauso;
                int b = mauso * o.tuso;
                if (a > b) return 1;
                else if (a < b) return -1;
                else return 0;
            }

            public static bool operator >(PhanSo a, PhanSo b)
            {
                return a.CompareTo(b) > 0;
            }

            public static bool operator <(PhanSo a, PhanSo b)
            {
                return a.CompareTo(b) < 0;
            }

            public override bool Equals(object o)
            {
                if (o == null || GetType() != o.GetType()) return false;
                PhanSo other = (PhanSo)o;
                return tuso * other.mauso == mauso * other.tuso;
            }

            public override int GetHashCode()
            {
                return tuso.GetHashCode() ^ mauso.GetHashCode();
            }

            public static bool operator ==(PhanSo a, PhanSo b)
            {
                return a.CompareTo(b) == 0;
            }

            public static bool operator !=(PhanSo a, PhanSo b)
            {
                return !(a == b);
            }

            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                return new PhanSo((a.tuso * b.mauso) + (a.mauso * b.tuso), a.mauso * b.mauso);
            }

            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                return new PhanSo((a.tuso * b.mauso) - (a.mauso * b.tuso), a.mauso * b.mauso);
            }

            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                return new PhanSo(a.tuso * b.tuso, a.mauso * b.mauso);
            }

            public static PhanSo operator /(PhanSo a, PhanSo b)
            {
                return new PhanSo(a.tuso * b.mauso, a.mauso * b.tuso);
            }

            public static implicit operator PhanSo(int a)
            {
                return new PhanSo(a, 1);
            }

            public static explicit operator double(PhanSo a)
            {
                return (double)a.tuso / a.mauso;
            }

            public override string ToString()
            {
                RutGon();
                return tuso + "/" + mauso;
            }

            public void Nhap()
            {
            Enhap:
                try
                {
                    string ps = Console.ReadLine();
                    string[] p = ps.Split('/');
                    if (p.Length < 2 && int.TryParse(p[0], out tuso)) return;
                    else if (p.Length == 2 && int.TryParse(p[0], out tuso) && int.TryParse(p[1], out mauso) && mauso != 0) return;
                    else throw new ArgumentException("Chuoi khong hop le");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Nhap lai");
                    goto Enhap;
                }
            }

        }
    }