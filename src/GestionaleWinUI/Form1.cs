using System;
using System.Windows.Forms;

namespace GestionaleWinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += $" Ver.{Application.ProductVersion}";
        }

        private void cmdArticoli_Click(object sender, EventArgs e)
        {
        }

        private void cmdOrdini_Click(object sender, EventArgs e)
        {
        }

        private void tsmUtenti_Click(object sender, EventArgs e)
        {

        }

        private void tsmClienti_Click(object sender, EventArgs e)
        {

        }

        private void tsmFornitori_Click(object sender, EventArgs e)
        {

        }

        private void tsmEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
