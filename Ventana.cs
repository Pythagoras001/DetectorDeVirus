using System.Windows.Forms;
using p_Antivirus01.Modelos;

namespace p_Antivirus01
{
    public partial class Ventana : Form
    {
        // Declaramos la instancia de virus 
        private Virus virusCompartido = new Virus();

        public Ventana()
        {
            InitializeComponent();
        }

        // Boton para Ingresar a la vista Analizador
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpia el contenido de Panel2
            splitContainer1.Panel2.Controls.Clear();

            // Crear una instancia de tu UserControl
            UC_AnalizarArchivo uc = new UC_AnalizarArchivo(virusCompartido);
            uc.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregar el UserControl al Panel2
            splitContainer1.Panel2.Controls.Add(uc);

        }

        // Boton para ingresar a la vista de agregar secuencia
        private void button2_Click(object sender, EventArgs e)
        {
            // Limpia el contenido de Panel2
            splitContainer1.Panel2.Controls.Clear();

            // Crear una instancia de tu UserControl
            UC_AgregarVirus uc = new UC_AgregarVirus(virusCompartido);
            uc.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregar el UserControl al Panel2
            splitContainer1.Panel2.Controls.Add(uc);
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logoFinal;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }   
}
