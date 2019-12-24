using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorLatidos
{
    public partial class frmGerenciadorDeLatidos : Form
    {
        private GerenciadorLatidos gerenciadorLatidos;
        public frmGerenciadorDeLatidos()
        {
            gerenciadorLatidos = new GerenciadorLatidos();
            gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeis;
            InitializeComponent();
        }

        private void frmGerenciadorDeLatidos_Load(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = gerenciadorLatidos.Latir();
        }

        public void QuandoExcederDecibeis(object obj, EventArgs e)
        {
            MessageBox.Show("O cachorro passou dos limites", "Excesso Decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
