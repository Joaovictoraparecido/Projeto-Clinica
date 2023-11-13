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
    public partial class Form3 : Form
    {
        Thread nj;
        public Form3()
        {
            InitializeComponent();
        }

        private void pACIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pACIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cLINICADataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cLINICADataSet.PACIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.pACIENTESTableAdapter.Fill(this.cLINICADataSet.PACIENTES);

        }

        private void Voltar_home_Click(object sender, EventArgs e)
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
