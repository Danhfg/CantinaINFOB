using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelCantina;
using Controller;

namespace GUICantina
{
    public partial class FormFuncionario : Form
    {
        private ControllerFuncionario controle;
        public FormFuncionario()
        {
            InitializeComponent();
            controle = new ControllerFuncionario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Nome = textBoxNome.Text;
            func.Matricula = textBoxMatricula.Text;
            if (controle.GravarFuncionario(func))
            {
                MessageBox.Show("Funcionário Cadastrado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Funcionário");
            }
        }
    }
}
