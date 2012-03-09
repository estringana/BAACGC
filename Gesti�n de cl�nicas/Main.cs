using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestión_de_clínicas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tab_medicos_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_TabIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point inicio= new Point(0,0);
            
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            switch (Menu.SelectedIndex)
            {
                case 0:
                    Agenda formMedicos = new Agenda();
                    formMedicos.MdiParent = this;
                    formMedicos.Location = inicio;
                    formMedicos.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    formMedicos.Show();
                    break;
                case 1:
                    Auxiliares formAuxiliares = new Auxiliares();
                    formAuxiliares.MdiParent = this;
                    formAuxiliares.Location = inicio;
                    formAuxiliares.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    formAuxiliares.Show();
                    break;
                case 2:
                    Pacientes formPacientes = new Pacientes();
                    formPacientes.MdiParent = this;
                    formPacientes.Location = inicio;
                    formPacientes.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    formPacientes.Show();
                    break;
                case 3:
                    Administracion formAdministracion = new Administracion();
                    formAdministracion.MdiParent = this;
                    formAdministracion.Location = inicio;
                    formAdministracion.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    formAdministracion.Show();
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Menu.SelectedIndex = -1;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
                 this.ActiveMdiChild.Close();
            Medicos form = new Medicos();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Agenda form = new Agenda();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Auxiliares form = new Auxiliares();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Pacientes form = new Pacientes();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Administracion form = new Administracion();
            form.MdiParent = this;
            form.Show(); form.Location = new Point(0, 0);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Stock form = new Stock();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton5_ButtonClick(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Facturas form = new Facturas();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Mensajes form = new Mensajes();
            form.MdiParent = this; 
            form.Show();form.Location = new Point(0, 0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Servicios form = new Servicios();
            form.MdiParent = this;
            form.Show(); form.Location = new Point(0, 0);  
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }
    }
}
