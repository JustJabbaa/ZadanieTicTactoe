using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        private Form1 board;
        public Form3(Form1 b)
        {
            board = b;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.clearBoard();
            this.Close();
        }
    }
}
