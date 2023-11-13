using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Clinica
{
    public partial class Form1 : Form
    {
        Thread nt;
        Thread nz;
        public Form1()
        {
            InitializeComponent();
        }

        private void CADASTRAR_PACIENTES_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoform);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void novoform()
        {
            Application.Run(new Form2());
        }

        private void ListaPacientes1_Click(object sender, EventArgs e)
        {
            this.Close();
            nz = new Thread(novoform3);
            nz.SetApartmentState(ApartmentState.STA);
            nz.Start();
        }
        private void novoform3()
        {
            Application.Run(new Form3());
        }
    }
}
