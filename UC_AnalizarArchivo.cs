using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using p_Antivirus01.Controladores;
using p_Antivirus01.Modelos;

namespace p_Antivirus01
{
    public partial class UC_AnalizarArchivo : UserControl
    {
        // Declaramos la instancia de virus
        private Virus virusRegistrado;

        public UC_AnalizarArchivo(Virus virusCompartido)
        {
            InitializeComponent();
            virusRegistrado = virusCompartido; // Asignamos la misma instancia
        }

        // Creamos el boton para seleccionar el arhicvo
        private void botonBuscarArchivo_click(object sender, EventArgs e)
        {
            // Crear el cuadro de diálogo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtro opcional: solo imágenes o todos los archivos
            openFileDialog.Filter = "Todos los archivos|*.*";

            // Si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mostrar la ruta en el TextBox
                text_DireccionDeArchivo.Text = openFileDialog.FileName;
                button1.Enabled = true;
            }
        }

        // Creamos el boton para analizar el archivo
        private void botonAnalizarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_DireccionDeArchivo.Text.Length > 0)
                {
                    // Instanciamos la clase admin archivo con la ubicacion del archivo
                    AdminArchivo objAdminArchivo = new AdminArchivo(text_DireccionDeArchivo.Text);

                    //Instaciamos la clase analizar con los bytes del archivo leido
                    Analizador objAnalizar = new Analizador(objAdminArchivo.LeerArchivo(), virusRegistrado);



                    // Dejamos esta instancia para pruebas
                    //Analizador objAnalizar = new Analizador(virusRegistrado);

                    // llenamos el campo con los bytes de la informacion
                    text_SecuenciaArchivo.Text = String.Join(" - ", objAdminArchivo.LeerArchivo());

                    // Limpiamos la lista de virus detectados
                    text_VirusDetectados.Items.Clear();

                    // Mostramos la lista de virus detectados
                    foreach (var virus in objAnalizar.AnarlizarTipoVirus())
                    {
                        text_VirusDetectados.Items.Add(virus);
                    }

                    // Si no detecto ninguno 
                    if (text_VirusDetectados.Items.Count == 0) text_VirusDetectados.Items.Add("No se detectaron Virus");

                    // Deshabilitamos el boron nuevamente
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textDireccionDeArchivo(object sender, EventArgs e)
        {

        }

        private void textSecuencia(object sender, EventArgs e)
        {

        }

        private void textVirusDetectados(object sender, EventArgs e)
        {

        }

        private void tituloVirusDetectado_CLick(object sender, EventArgs e)
        {

        }

        private void tituloSecuencia_click(object sender, EventArgs e)
        {

        }

        private void tituloDireccion_click(object sender, EventArgs e)
        {

        }
    }
}
