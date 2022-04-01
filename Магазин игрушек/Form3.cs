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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void reference_Click(object sender, EventArgs e)
        {

            MessageBox.Show(null, "Данная форма находится в разработке", "Корзина",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
