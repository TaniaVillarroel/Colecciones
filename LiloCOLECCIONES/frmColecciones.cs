using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiloCOLECCIONES
{
    public partial class frmColecciones : Form
    {
        public frmColecciones()
        {
            InitializeComponent();
        }

        private void frmColecciones_Load(object sender, EventArgs e) // el evento load es cuando se carga el form escribimos la programacion de modo tal que cuando ejecutemos el formulario y lo cargue ya aparexca el combo o lista cargados
        {
            this.lstCurso.Sorted = true; // ordenar segun string
            this.cboCurso.Sorted = true;

            this.cboCurso.Items.Clear();
            this.cboCurso.Items.Add("1w1");
            this.cboCurso.Items.Add("1w2");
            this.cboCurso.Items.Add("1w3");
            this.cboCurso.SelectedIndex = 0;

            this.lstCurso.Items.Clear();
            this.lstCurso.Items.Add("1w1");
            this.lstCurso.Items.Add("1w2");
            this.lstCurso.Items.Add("1w3");
            this.cboCurso.SelectedIndex = 0;

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.Add(this.txtDato.Text);
            this.lstCurso.Items.Add(txtDato.Text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.Insert(Convert.ToInt32(txtPosicion.Text), txtDato.Text);
            this.lstCurso.Items.Insert(Convert.ToInt32(txtPosicion.Text), txtDato.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.Insert(this.cboCurso.Items.Count, txtDato.Text);
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.Insert(cboCurso.SelectedIndex, txtDato.Text);
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.Remove(txtDato.Text); // si es fuera de rango NO TIRA error
            this.lstCurso.Items.Remove(txtDato.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.RemoveAt(Convert.ToInt32(txtPosicion.Text));  // si es fuera de rango TIRA error
            //this.lstCurso.Items.RemoveAt(Convert.ToInt32(txtPosicion.Text));
            this.lstCurso.Items.RemoveAt(cboCurso.Items.IndexOf(txtDato.Text)); // el indez me devuelve la posicion
        }

        private void btnCU_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.RemoveAt(Convert.ToInt32(cboCurso.Items.Count) - 1);
            this.lstCurso.Items.RemoveAt(Convert.ToInt32(cboCurso.Items.Count) - 1);
        } 

        private void BorararSelecc_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.RemoveAt(cboCurso.SelectedIndex);
            this.lstCurso.Items.Remove(cboCurso.SelectedItem);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cboCurso.Items.Clear();
            this.lstCurso.Items.Clear();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            lblPosi.Text=cboCurso.SelectedIndex.ToString();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            lblCant.Text = Convert.ToString(Convert.ToInt32(cboCurso.Items.Count) - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMostrarDato.Text = cboCurso.SelectedItem.ToString();
        }

    }
}
