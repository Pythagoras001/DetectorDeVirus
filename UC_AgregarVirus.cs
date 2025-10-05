using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using p_Antivirus01.Modelos;

namespace p_Antivirus01
{
    public partial class UC_AgregarVirus : UserControl
    {
        // Declaramos la instancia virus
        private Virus virusRegistrados;

        public UC_AgregarVirus(Virus virusCompartido)
        {
            InitializeComponent();
            virusRegistrados = virusCompartido; // Asignamos la misma instancia 
        }

        // Cargamos los virus registrados en la lista de virus
        private void UC_AgregarVirus_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, byte[]> claveValorVirus in virusRegistrados.DiccVirus)
            {
                textSecuenciasRegistradas.Items.Add(claveValorVirus.Key);
            }
        }

        // Configuramos el boton de agregar secuencia
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las varibles
                string nombreVirus = nombreVirusCampo.Text;

                // Revisamos un minimo de longitud en el nombre
                if (nombreVirus.Length > 3)
                {
                    // Si lo accepta lo agregamos en la instancia de virus y lo agregamos en la lista
                    virusRegistrados.AgregarSecuencia(concatenarArrayByte(), nombreVirus);
                    textSecuenciasRegistradas.Items.Add(nombreVirus);

                    // Reseteamos los valores
                    nombreVirusCampo.Clear();
                    num1.Value = 0;
                    num3.Value = 0;
                    num2.Value = 0;
                    num4.Value = 0;

                }
                else throw new Exception("El nombre tiene que ser mayor a 3 caracteres");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Configuramos el boton de eliminar una secuencia 
        private void button1_Click(object sender, EventArgs e)
        {
            // si se tiene seleccionado un elemento entonces que lo elimine
            if (textSecuenciasRegistradas.SelectedItem != null)
            {
                // Declaramos las variables
                string seleccionado = textSecuenciasRegistradas.SelectedItem.ToString()!;

                // Eliminamos de la instancia de virus y de la lista
                virusRegistrados.eliminarSecuencia(seleccionado);
                textSecuenciasRegistradas.Items.Remove(textSecuenciasRegistradas.SelectedItem);
            }
        }

        // Creamos una funcion para concatenar en un array los campos numericos 
        public byte[] concatenarArrayByte()
        {
            return
                new byte[] { (byte)num1.Value, (byte)num2.Value, (byte)num3.Value, (byte)num4.Value };
        }

        // Configuramos la lista para que al seleccionar un elemento nos de la informacion de la secuencia
        private void lista_secuenciasRegistradas(object sender, EventArgs e) 
        {
            if (textSecuenciasRegistradas.SelectedItem != null)
            {
                string seleccionado = textSecuenciasRegistradas.SelectedItem.ToString()!;
                label_estadoSecuencia.Text = $"Virus: {seleccionado}" +
                    $"\nSecuencia: {String.Join(", ", virusRegistrados.DiccVirus[seleccionado!])}";
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }


        private void nombreVirus(object sender, EventArgs e) { }

        private void titulo_nombreVirus(object sender, EventArgs e) { }


        private void titulo_NombreSecuenciasRegistradas(object sender, EventArgs e) { }


        private void labelEstadosSecuencia(object sender, EventArgs e) { }


        private void num_1(object sender, EventArgs e) { }


        private void num_2(object sender, EventArgs e) { }

        private void num_3(object sender, EventArgs e) { }

        private void num_4(object sender, EventArgs e) { }
 
    }
}
