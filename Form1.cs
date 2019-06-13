using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace examen3aParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, Equipo> equipos;

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupoEquipo.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = new Equipo(txtNomEquipo.Text, Convert.ToInt32(txtNumEquipo.Text));
                listaEquipos.Items.Add(equipo.ToString());
                listaEquiposJornada.Items.Add(equipo.ToString());
                grupoJugador.Show();
                txtNombreEquipo.Text = txtNomEquipo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAgregarJug_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador jugador = new Jugador(txtNombreEquipo.Text,txtNombreJug.Text,Convert.ToInt32(txtEdadJug.Text), Convert.ToInt32(txtNumeroJug.Text));
                listaJugadores.Items.Add(jugador.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void pasarA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indice = 0;
            indice = listaJugadores.SelectedIndex;
            listaEquipos.Items.RemoveAt(indice);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupoEquipo.Hide();
            grupoJugador.Hide();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int indice = listaJugadores.SelectedIndex;
            listaJugadores.Items.RemoveAt(indice);
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grupoJugador.Show();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog generar = new SaveFileDialog();
            generar.FileName = "reporte.txt";
            generar.Filter="Text File | *.txt";
            if (generar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escritor = new StreamWriter(generar.OpenFile());
                escritor.WriteLine("Reporte: " + DateTime.Now);
                escritor.WriteLine("Equipos:");
                for (int i = 0; i < listaEquipos.Items.Count; i++)
                {
                    escritor.WriteLine(listaEquipos.Items[i].ToString());
                }
                escritor.WriteLine("Jugadores:");
                for (int i = 0; i < listaJugadores.Items.Count; i++)
                {
                    escritor.WriteLine(listaJugadores.Items[i].ToString());
                }
                escritor.WriteLine("Jornadas:");
                for (int i = 0; i < listaJornada.Items.Count; i++)
                {
                    escritor.WriteLine(listaJornada.Items[i].ToString());
                }
                escritor.Dispose();
                escritor.Close();
            }
        }

        private void equipo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEquipo1.Text = listaEquiposJornada.SelectedItem.ToString();
            listaEquiposJornada.Items.RemoveAt(listaEquiposJornada.SelectedIndex);
        }

        private void equipo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEquipo2.Text = listaEquiposJornada.SelectedItem.ToString();
            listaEquiposJornada.Items.RemoveAt(listaEquiposJornada.SelectedIndex);
        }

        private void btnGuardarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                Jornada jornada = new Jornada(Convert.ToInt32(numJornada.Value.ToString()), txtEstado.Text, txtEquipo1.Text + " vs " + txtEquipo2.Text, txtGoles.Text);
                listaJornada.Items.Add(jornada.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
