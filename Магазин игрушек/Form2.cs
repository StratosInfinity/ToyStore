using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магазин_игрушек
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void yula_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ball_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void truck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bear_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void allcost_Click(object sender, EventArgs e)
        {
            double s = 0;
            if (yula.Checked)
                s = s + 268;
            if (ball.Checked)
                s = s + 377;
            if (truck.Checked)
                s = s + 678;
            if (bear.Checked)
                s = s + 899;
            MessageBox.Show(Convert.ToString(s) + "руб", "Стоимость заказа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
