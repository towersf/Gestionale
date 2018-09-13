using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaleWinUI.Forms
{
    public partial class FormOrdini : Form
    {
        public FormOrdini()
        {
            InitializeComponent();
        }

        private void FormOrdini_Load(object sender, EventArgs e)
        {
            var applicazione = Gestionale.Core.App.GetInstance();

        }
    }
}
