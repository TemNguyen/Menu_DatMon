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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        int soMon = 0;

            

        private void Menu_Load(object sender, EventArgs e)
        {
            //addStaff("Thinh");
            Time.Text = DateTime.Now.ToString();
        }

        //private void addStaff(string Name)
        //{
        //    Staff_Infor.Controls.Add(new Label() { Text = "Hello, " + Name });
        //}

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            
            Hoa_Don hoa_Don = new Hoa_Don(soMon);
            Menu_data menu_Data = new Menu_data();
                
                #region IFS
                if (Convert.ToInt32(Hamberger_count.Value) != 0) 
                    {   soMon++;
                        hoa_Don.getSoLuong(0, Convert.ToInt32(Hamberger_count.Value));
                    }
                if (Convert.ToInt32(Noodle_count.Value) != 0) { soMon++; hoa_Don.getSoLuong(1, Convert.ToInt32(Noodle_count.Value)); }
            if (Convert.ToInt32(Meat_count.Value) != 0) { soMon++; hoa_Don.getSoLuong(2, Convert.ToInt32(Meat_count.Value)); }
            if (Convert.ToInt32(Fish_count.Value) != 0) { soMon++; hoa_Don.getSoLuong(3, Convert.ToInt32(Fish_count.Value)); }
            if (Convert.ToInt32(chillCount.Value) != 0) { soMon++; hoa_Don.getSoLuong(4, Convert.ToInt32(chillCount.Value)); }
            if (Convert.ToInt32(carrotCount.Value) != 0) { soMon++; hoa_Don.getSoLuong(5, Convert.ToInt32(carrotCount.Value)); }
                #endregion
                #region Class
                //menu_Data.setSoluong(Convert.ToInt32(Hamberger_count.Value), Convert.ToInt32(Noodle_count.Value), Convert.ToInt32(Fish_count.Value), Convert.ToInt32(Meat_count.Value), Convert.ToInt32(chillCount.Value), Convert.ToInt32(carrotCount.Value));
                #endregion
                //menu_Data.soLuong[0] = Convert.ToInt32(Hamberger_count.Value);
                hoa_Don.Show();
            this.Hide();
           

            //tongTien = Gia[0] * Convert.ToInt32(Hamberger_count.Value) + Gia[1] * Convert.ToInt32(Noodle_count.Value) + Gia[2] * Convert.ToInt32(Fish_count.Value) + Gia[3] * Convert.ToInt32(Meat_count.Value) + Gia[4] * Convert.ToInt32(chillCount.Value) + Gia[5] * Convert.ToInt32(carrotCount.Value);
        }

    }
}
