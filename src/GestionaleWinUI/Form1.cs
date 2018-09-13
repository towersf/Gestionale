using System;
using System.Windows.Forms;
using GestionaleWinUI.Forms;

namespace GestionaleWinUI
{
    public partial class MainForm : Form
    {
        private Form _formArticoli;
        private Form _formOrdini;

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
            if(_formArticoli == null)
            {
                _formArticoli = new FormArticoli();
                _formArticoli.Show();
            }
            else
            {
                _formArticoli.Activate();
            }
        }

        private void cmdOrdini_Click(object sender, EventArgs e)
        {
            if(_formOrdini == null)
            {
                _formOrdini = new FormOrdini();
                _formOrdini.Show();
            }
            else
            {
                _formOrdini.Activate();
            }
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
