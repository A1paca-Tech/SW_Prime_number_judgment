using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_number_judgment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_show.Text = "";
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            try
            {
                int my_nb = int.Parse(tb_nb.Text);

                if (my_nb == 1 || my_nb == 0) { lb_show.Text = my_nb.ToString() + " 不是質數!"; return; }
                if (my_nb == 2 || my_nb == 3 || my_nb == 5 || my_nb == 7) { lb_show.Text = my_nb.ToString() + " 是質數!"; return; }

                if ((my_nb % 2) != 0 && (my_nb % 3) != 0 && (my_nb % 5) != 0 && (my_nb % 7) != 0)
                { lb_show.Text = my_nb.ToString() + " 是質數!"; }
                else
                {
                    lb_show.Text = my_nb.ToString() + " 不是質數!";
                }

            }
            catch { MessageBox.Show("Error! 可能是您所輸入的並非數字", "Error!"); }
        }
    }
}
