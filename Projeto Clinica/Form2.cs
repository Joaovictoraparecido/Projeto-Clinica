using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Clinica
{
    public partial class Form2 : Form
    {
        Thread nj;
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cLINICADataSet.PACIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.pACIENTESTableAdapter.Fill(this.cLINICADataSet.PACIENTES);

        }

        private void Criar_Novo_Click(object sender, EventArgs e)
        {
            pACIENTESBindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            pACIENTESBindingSource.EndEdit();
            pACIENTESTableAdapter.Update(cLINICADataSet);
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            pACIENTESBindingSource.RemoveCurrent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nj = new Thread(novoform1);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform1()
        {
            Application.Run(new Form1());
        }
    }
}
