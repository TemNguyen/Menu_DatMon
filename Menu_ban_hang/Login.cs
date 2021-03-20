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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void LoginButt_Click(object sender, EventArgs e)
        {
            Login_Data Lg = new Login_Data();
            if (userName.Text == Lg.userName && passWord.Text == Lg.passWord)
            {
                Menu Menu_Show = new Menu();

                Menu_Show.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ten tai khoan hoac mat khau khong dung, vui long kiem tra lai!", "Loi dang nhap", MessageBoxButtons.OK);
                userName.Text = "";
                passWord.Text = "";
            }    
        }

   

        private void Exitbutt_Click(object sender, EventArgs e)
        {
            this.Close();
            //DialogResult Quit = new DialogResult();
            //MessageBox.Show("Ban co chac chan muon thoat?", "Thoat", MessageBoxButtons.YesNo);
            //switch (Quit)
            //{
            //    case DialogResult.Yes:
            //        this.Close();
            //        break;
            //    case DialogResult.No:
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
