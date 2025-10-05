namespace p_Antivirus01
{
    partial class UC_AnalizarArchivo
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
            text_DireccionDeArchivo = new TextBox();
            buttonAnalizar = new Button();
            openFileDialog1 = new OpenFileDialog();
            text_VirusDetectados = new ListBox();
            button1 = new Button();
            tituloDireccionArchivo = new Label();
            tituloVirusDetectados = new Label();
            text_SecuenciaArchivo = new TextBox();
            tituloSecuencia = new Label();
            SuspendLayout();
            // 
            // text_DireccionDeArchivo
            // 
            text_DireccionDeArchivo.Location = new Point(52, 130);
            text_DireccionDeArchivo.Name = "text_DireccionDeArchivo";
            text_DireccionDeArchivo.ReadOnly = true;
            text_DireccionDeArchivo.Size = new Size(453, 31);
            text_DireccionDeArchivo.TabIndex = 0;
            text_DireccionDeArchivo.TextChanged += textDireccionDeArchivo;
            // 
            // buttonAnalizar
            // 
            buttonAnalizar.AccessibleName = "";
            buttonAnalizar.BackColor = Color.FromArgb(125, 178, 186);
            buttonAnalizar.ForeColor = SystemColors.ActiveCaptionText;
            buttonAnalizar.Location = new Point(533, 101);
            buttonAnalizar.Name = "buttonAnalizar";
            buttonAnalizar.Size = new Size(200, 60);
            buttonAnalizar.TabIndex = 1;
            buttonAnalizar.Text = "Buscar Archivo";
            buttonAnalizar.UseVisualStyleBackColor = false;
            buttonAnalizar.Click += botonBuscarArchivo_click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // text_VirusDetectados
            // 
            text_VirusDetectados.BackColor = SystemColors.GradientInactiveCaption;
            text_VirusDetectados.FormattingEnabled = true;
            text_VirusDetectados.ItemHeight = 25;
            text_VirusDetectados.Location = new Point(533, 227);
            text_VirusDetectados.Name = "text_VirusDetectados";
            text_VirusDetectados.Size = new Size(200, 204);
            text_VirusDetectados.Sorted = true;
            text_VirusDetectados.TabIndex = 2;
            text_VirusDetectados.SelectedIndexChanged += textVirusDetectados;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(178, 228, 236);
            button1.Enabled = false;
            button1.Location = new Point(533, 446);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 3;
            button1.Text = "Analizar Archivo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += botonAnalizarArchivo_Click;
            // 
            // tituloDireccionArchivo
            // 
            tituloDireccionArchivo.AutoSize = true;
            tituloDireccionArchivo.ForeColor = Color.Navy;
            tituloDireccionArchivo.Location = new Point(52, 90);
            tituloDireccionArchivo.Name = "tituloDireccionArchivo";
            tituloDireccionArchivo.Size = new Size(181, 25);
            tituloDireccionArchivo.TabIndex = 4;
            tituloDireccionArchivo.Text = "Direccion Del Archivo";
            tituloDireccionArchivo.Click += tituloDireccion_click;
            // 
            // tituloVirusDetectados
            // 
            tituloVirusDetectados.AutoSize = true;
            tituloVirusDetectados.BackColor = SystemColors.GradientInactiveCaption;
            tituloVirusDetectados.ForeColor = Color.Navy;
            tituloVirusDetectados.Location = new Point(533, 185);
            tituloVirusDetectados.Name = "tituloVirusDetectados";
            tituloVirusDetectados.Size = new Size(146, 25);
            tituloVirusDetectados.TabIndex = 5;
            tituloVirusDetectados.Text = "Virus Detectados";
            tituloVirusDetectados.Click += tituloVirusDetectado_CLick;
            // 
            // text_SecuenciaArchivo
            // 
            text_SecuenciaArchivo.Location = new Point(52, 227);
            text_SecuenciaArchivo.Multiline = true;
            text_SecuenciaArchivo.Name = "text_SecuenciaArchivo";
            text_SecuenciaArchivo.ReadOnly = true;
            text_SecuenciaArchivo.Size = new Size(453, 279);
            text_SecuenciaArchivo.TabIndex = 6;
            text_SecuenciaArchivo.TextChanged += textSecuencia;
            // 
            // tituloSecuencia
            // 
            tituloSecuencia.AutoSize = true;
            tituloSecuencia.BackColor = SystemColors.GradientInactiveCaption;
            tituloSecuencia.ForeColor = Color.Navy;
            tituloSecuencia.Location = new Point(52, 185);
            tituloSecuencia.Name = "tituloSecuencia";
            tituloSecuencia.Size = new Size(94, 25);
            tituloSecuencia.TabIndex = 7;
            tituloSecuencia.Text = "Secuencia ";
            tituloSecuencia.Click += tituloSecuencia_click;
            // 
            // UC_AnalizarArchivo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(156, 172, 175);
            Controls.Add(tituloSecuencia);
            Controls.Add(text_SecuenciaArchivo);
            Controls.Add(tituloVirusDetectados);
            Controls.Add(tituloDireccionArchivo);
            Controls.Add(button1);
            Controls.Add(text_VirusDetectados);
            Controls.Add(buttonAnalizar);
            Controls.Add(text_DireccionDeArchivo);
            Name = "UC_AnalizarArchivo";
            Size = new Size(773, 549);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_DireccionDeArchivo;
        private Button buttonAnalizar;
        private OpenFileDialog openFileDialog1;
        private ListBox text_VirusDetectados;
        private Button button1;
        private Label tituloDireccionArchivo;
        private Label tituloVirusDetectados;
        private TextBox text_SecuenciaArchivo;
        private Label tituloSecuencia;
    }
}
