namespace p_Antivirus01
{
    partial class UC_AgregarVirus
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            nombreVirusCampo = new TextBox();
            tituloNombreVirus = new Label();
            num1 = new NumericUpDown();
            num2 = new NumericUpDown();
            num3 = new NumericUpDown();
            num4 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textSecuenciasRegistradas = new ListBox();
            button2 = new Button();
            tituloNombreSecuenciasRegistradas = new Label();
            statusStrip1 = new StatusStrip();
            label_estadoSecuencia = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num4).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nombreVirusCampo
            // 
            nombreVirusCampo.BackColor = SystemColors.GradientInactiveCaption;
            nombreVirusCampo.Location = new Point(91, 103);
            nombreVirusCampo.Name = "nombreVirusCampo";
            nombreVirusCampo.Size = new Size(238, 31);
            nombreVirusCampo.TabIndex = 0;
            nombreVirusCampo.TextChanged += nombreVirus;
            // 
            // tituloNombreVirus
            // 
            tituloNombreVirus.AutoSize = true;
            tituloNombreVirus.BackColor = Color.Silver;
            tituloNombreVirus.FlatStyle = FlatStyle.Popup;
            tituloNombreVirus.ForeColor = Color.FromArgb(0, 25, 40);
            tituloNombreVirus.Location = new Point(91, 55);
            tituloNombreVirus.Name = "tituloNombreVirus";
            tituloNombreVirus.Size = new Size(151, 25);
            tituloNombreVirus.TabIndex = 1;
            tituloNombreVirus.Text = "Nombre del Virus";
            tituloNombreVirus.Click += titulo_nombreVirus;
            // 
            // num1
            // 
            num1.BackColor = SystemColors.GradientInactiveCaption;
            num1.Location = new Point(256, 168);
            num1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            num1.Name = "num1";
            num1.Size = new Size(73, 31);
            num1.TabIndex = 2;
            num1.ValueChanged += num_1;
            // 
            // num2
            // 
            num2.BackColor = SystemColors.GradientInactiveCaption;
            num2.Location = new Point(256, 219);
            num2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            num2.Name = "num2";
            num2.Size = new Size(73, 31);
            num2.TabIndex = 4;
            num2.ValueChanged += num_2;
            // 
            // num3
            // 
            num3.BackColor = SystemColors.GradientInactiveCaption;
            num3.Location = new Point(256, 266);
            num3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            num3.Name = "num3";
            num3.Size = new Size(73, 31);
            num3.TabIndex = 5;
            num3.ValueChanged += num_3;
            // 
            // num4
            // 
            num4.BackColor = SystemColors.GradientInactiveCaption;
            num4.Location = new Point(256, 318);
            num4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            num4.Name = "num4";
            num4.Size = new Size(73, 31);
            num4.TabIndex = 6;
            num4.ValueChanged += num_4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(31, 49, 61);
            label2.Location = new Point(91, 174);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 7;
            label2.Text = "Secuencia 1 ------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(31, 49, 61);
            label3.Location = new Point(91, 225);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 8;
            label3.Text = "Secuencia 2 ------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(31, 49, 61);
            label4.Location = new Point(91, 272);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 9;
            label4.Text = "Secuencia 3 ------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(31, 49, 61);
            label5.Location = new Point(91, 324);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 10;
            label5.Text = "Secuencia 4 ------";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(152, 23, 54);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(557, 374);
            button1.Name = "button1";
            button1.Size = new Size(151, 69);
            button1.TabIndex = 11;
            button1.Text = "Eliminar Secuencia";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textSecuenciasRegistradas
            // 
            textSecuenciasRegistradas.BackColor = SystemColors.GradientInactiveCaption;
            textSecuenciasRegistradas.FormattingEnabled = true;
            textSecuenciasRegistradas.ItemHeight = 25;
            textSecuenciasRegistradas.Location = new Point(380, 103);
            textSecuenciasRegistradas.Name = "textSecuenciasRegistradas";
            textSecuenciasRegistradas.Size = new Size(328, 254);
            textSecuenciasRegistradas.TabIndex = 12;
            textSecuenciasRegistradas.SelectedIndexChanged += lista_secuenciasRegistradas;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(115, 185, 229);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(380, 374);
            button2.Name = "button2";
            button2.Size = new Size(151, 69);
            button2.TabIndex = 13;
            button2.Text = "Agregar Secuencia";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tituloNombreSecuenciasRegistradas
            // 
            tituloNombreSecuenciasRegistradas.AutoSize = true;
            tituloNombreSecuenciasRegistradas.ForeColor = Color.FromArgb(0, 25, 40);
            tituloNombreSecuenciasRegistradas.Location = new Point(380, 55);
            tituloNombreSecuenciasRegistradas.Name = "tituloNombreSecuenciasRegistradas";
            tituloNombreSecuenciasRegistradas.Size = new Size(193, 25);
            tituloNombreSecuenciasRegistradas.TabIndex = 14;
            tituloNombreSecuenciasRegistradas.Text = "Secuencias Registradas";
            tituloNombreSecuenciasRegistradas.Click += titulo_NombreSecuenciasRegistradas;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { label_estadoSecuencia });
            statusStrip1.Location = new Point(0, 517);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(773, 32);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // label_estadoSecuencia
            // 
            label_estadoSecuencia.Name = "label_estadoSecuencia";
            label_estadoSecuencia.Size = new Size(210, 25);
            label_estadoSecuencia.Text = "Seleccione una Secuencia";
            label_estadoSecuencia.Click += labelEstadosSecuencia;
            // 
            // UC_AgregarVirus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(156, 172, 175);
            Controls.Add(statusStrip1);
            Controls.Add(tituloNombreSecuenciasRegistradas);
            Controls.Add(button2);
            Controls.Add(textSecuenciasRegistradas);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(tituloNombreVirus);
            Controls.Add(nombreVirusCampo);
            Name = "UC_AgregarVirus";
            Size = new Size(773, 549);
            Load += UC_AgregarVirus_Load;
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)num3).EndInit();
            ((System.ComponentModel.ISupportInitialize)num4).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreVirusCampo;
        private Label tituloNombreVirus;
        private NumericUpDown num1;
        private NumericUpDown num2;
        private NumericUpDown num3;
        private NumericUpDown num4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ListBox textSecuenciasRegistradas;
        private Button button2;
        private Label tituloNombreSecuenciasRegistradas;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label_estadoSecuencia;
    }
}
