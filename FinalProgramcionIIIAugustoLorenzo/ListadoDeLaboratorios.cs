using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgramcionIIIAugustoLorenzo
{
   
    public partial class ListadoDeLaboratorios : Form
    {
        private string _nombreLabo;

        public string NombreLabo
        {
            get { return _nombreLabo; }
            set { _nombreLabo = value; }
        }
   
        public void cargar()
        {
            DataTable dt = new DataTable();
            dt = Libreria.Recuperar("select * from Laboratorios");

            dgv.DataSource = dt;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Columns["IdLaboratorio"].Visible = false;
        }
        public ListadoDeLaboratorios()
        {
            InitializeComponent();
        }

        private void ListadoDeLaboratorios_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (dgv.CurrentRow ==null)
            {
                MessageBox.Show("Debe seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                /* IForm miInterfaz1 = this.Owner as IForm;
                 IForm miInterfaz2= this.Owner as IForm;
                 if (miInterfaz1 != null)
                 {
                     miInterfaz1.transferir(dgv.CurrentRow.Cells["Laboratorio"].Value.ToString());
                     miInterfaz2.transferirId(int.Parse(dgv.CurrentRow.Cells["IdLaboratorio"].Value.ToString()));

                     this.Close();
                 }*/

                NombreLabo = (dgv.CurrentRow.Cells["Laboratorio"].Value.ToString());
                this.Close();



            }
             

        }
    }
}
