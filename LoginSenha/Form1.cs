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
        Thread nt; //criação do thread como 'se fosse uma variável'
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
                //MessageBox.Show("Bem vindo ao sistema!", "Acesso ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //essa parte acima foi para exemplificar o acesso ao sistemas com usuário já "cadastrado"
                this.Close(); //neste caso iremos fechar o primeiro formulário e iremos já para o seguinte formulário
                nt = new Thread(Form2);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Acesso ao Sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form2(object obj)
        {
            // throw new NotImplementedException(); código criado pois apenas vamos chamar o novo formulário e instância-lo
            Application.Run(new Form2()); //está linha serve para abrir o Form2 após clicar no botão login
        }
    }
}
