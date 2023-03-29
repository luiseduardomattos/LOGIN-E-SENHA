using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LOGIN_E_SENHA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == "Admin" && txtBoxSenha.Text == "123456")
            {
                MessageBox.Show("Bem vindo ao sistema!", "Acesso ao sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Acesso Negado!", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
