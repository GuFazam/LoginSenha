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

namespace LoginSenha
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Admin" && textBoxSenha.Text == "123456")
            {
                MessageBox.Show("Bem vindo ao sistema!", "Acesso ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Acesso ao Sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
