using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_ban_hang
{
    public partial class Hoa_Don : Form
    {
        public Hoa_Don()
        {
            InitializeComponent();
        }

        int soMon;
        int tongTien = 0;
        int[] index;
        int[] soLuong = new int[6];
        private void Hoa_Don_Load(object sender, EventArgs e)
        {
            Menu_data menu_Data = new Menu_data();
        }
        public Hoa_Don(int value) : this()
        {
            soMon = value;
        }
        public void getSoLuong(int i, int value)
        {
            soLuong[i] = value;
        }
        public void getIndex()
        {
            for (int i = 0; i < soLuong.Length; i++)
            {
                if (soLuong[i] != 0);
            }
        }
    }
}
