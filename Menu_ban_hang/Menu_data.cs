using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_ban_hang
{
    class Menu_data
    {
        //public int[] Gia = { 50000, 20000, 35000, 30000, 6000, 12000 };
        int[] Gia;
        public int[] soLuong;
        //public int[] Soluong = new int[6];
        bool Freeze1, Freeze2;
        bool Fresh1, Fresh2;

        public int[] gia
        {
            get { return Gia; }
            set { Gia = value; }
        }

       public int this[int i]
        {
            get { return soLuong[i];}
            set { soLuong[i] = value; }
        }
        
        //public void setSoluong(int value1, int value2, int value3, int value4, int value5, int value6)
        //{
        //    Soluong[0] = value1;
        //    Soluong[1] = value2;
        //    Soluong[2] = value3;
        //    Soluong[3] = value4;
        //    Soluong[4] = value5;
        //    Soluong[5] = value6;
        //}
        //public void getSoluong { get; set }
        public Menu_data()
        {
            Gia = new int[] { 50000, 20000, 35000, 30000, 6000, 12000 };
        }
    }
}
