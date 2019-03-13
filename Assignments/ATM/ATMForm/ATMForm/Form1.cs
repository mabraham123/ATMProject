using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATMForm
{
    public partial class Form1 : Form
    {
        private Account[] ac = new Account[3];
        private ATM atm;

        Button[] btn = new Button[10];
        int rows, columns = 3;

        public Form1()
        {
            InitializeComponent();
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            atm = new ATM(ac);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fLPNumbers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int rows = 0;  rows < 10; rows++)
            {
                btn[rows] = new Button();
                btn[rows].Text = rows.ToString();
                fLPNumbers.Controls.Add(btn[rows]);
            }
        }
    }
}
