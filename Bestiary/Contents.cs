using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestiary
{
    public partial class Contents : Form
    {
        public int ID = 0;
        public Contents()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Monsters win = new Monsters(ID);
            win.Owner = this;
            this.Hide();
            win.Show();
        }
    }
}
