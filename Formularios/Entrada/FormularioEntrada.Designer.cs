namespace JuanApp.Formularios.Entrada
{
    partial class FormularioEntrada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEntrada));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            lblNroDeCodigoDeBarra = new Label();
            txtNroDeCodigoDeBarra = new TextBox();
            txtNroDePesada = new TextBox();
            lblNroDePesada = new Label();
            txtCodigoDeProducto = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreDeProducto = new TextBox();
            lblNombreDeProducto = new Label();
            txtTexContenido = new TextBox();
            lblTexContenido = new Label();
            lblNeto = new Label();
            numericUpDownNeto = new NumericUpDown();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeto).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de entradas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 421);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(546, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { dropDownButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(546, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // dropDownButton
            // 
            dropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dropDownButton.DropDownItems.AddRange(new ToolStripItem[] { menuItemMain });
            dropDownButton.Image = (Image)resources.GetObject("dropDownButton.Image");
            dropDownButton.ImageTransparentColor = Color.Magenta;
            dropDownButton.Name = "dropDownButton";
            dropDownButton.Size = new Size(34, 24);
            dropDownButton.Text = "toolStripDropDownButton1";
            // 
            // menuItemMain
            // 
            menuItemMain.Name = "menuItemMain";
            menuItemMain.Size = new Size(189, 26);
            menuItemMain.Text = "Volver al inicio";
            menuItemMain.Click += menuItemMain_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(408, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 43);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblNroDeCodigoDeBarra
            // 
            lblNroDeCodigoDeBarra.AutoSize = true;
            lblNroDeCodigoDeBarra.Location = new Point(12, 70);
            lblNroDeCodigoDeBarra.Name = "lblNroDeCodigoDeBarra";
            lblNroDeCodigoDeBarra.Size = new Size(158, 20);
            lblNroDeCodigoDeBarra.TabIndex = 6;
            lblNroDeCodigoDeBarra.Text = "Nº de código de barra";
            // 
            // txtNroDeCodigoDeBarra
            // 
            txtNroDeCodigoDeBarra.Location = new Point(12, 93);
            txtNroDeCodigoDeBarra.Name = "txtNroDeCodigoDeBarra";
            txtNroDeCodigoDeBarra.Size = new Size(232, 27);
            txtNroDeCodigoDeBarra.TabIndex = 12;
            // 
            // txtNroDePesada
            // 
            txtNroDePesada.Location = new Point(12, 156);
            txtNroDePesada.Name = "txtNroDePesada";
            txtNroDePesada.Size = new Size(232, 27);
            txtNroDePesada.TabIndex = 14;
            // 
            // lblNroDePesada
            // 
            lblNroDePesada.AutoSize = true;
            lblNroDePesada.Location = new Point(12, 133);
            lblNroDePesada.Name = "lblNroDePesada";
            lblNroDePesada.Size = new Size(99, 20);
            lblNroDePesada.TabIndex = 13;
            lblNroDePesada.Text = "Nº de pesada";
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.Location = new Point(12, 222);
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.Size = new Size(232, 27);
            txtCodigoDeProducto.TabIndex = 16;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Location = new Point(12, 199);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(144, 20);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de producto";
            // 
            // txtNombreDeProducto
            // 
            txtNombreDeProducto.Location = new Point(12, 293);
            txtNombreDeProducto.Name = "txtNombreDeProducto";
            txtNombreDeProducto.Size = new Size(232, 27);
            txtNombreDeProducto.TabIndex = 18;
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.Location = new Point(12, 270);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(150, 20);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Nombre de producto";
            // 
            // txtTexContenido
            // 
            txtTexContenido.Location = new Point(286, 93);
            txtTexContenido.Name = "txtTexContenido";
            txtTexContenido.Size = new Size(232, 27);
            txtTexContenido.TabIndex = 20;
            // 
            // lblTexContenido
            // 
            lblTexContenido.AutoSize = true;
            lblTexContenido.Location = new Point(286, 70);
            lblTexContenido.Name = "lblTexContenido";
            lblTexContenido.Size = new Size(236, 20);
            lblTexContenido.TabIndex = 19;
            lblTexContenido.Text = "Tex Contenido (Cant. de unidades)";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(286, 133);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(42, 20);
            lblNeto.TabIndex = 21;
            lblNeto.Text = "Neto";
            // 
            // numericUpDownNeto
            // 
            numericUpDownNeto.Location = new Point(286, 157);
            numericUpDownNeto.Name = "numericUpDownNeto";
            numericUpDownNeto.Size = new Size(232, 27);
            numericUpDownNeto.TabIndex = 22;
            // 
            // FormularioEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 447);
            Controls.Add(numericUpDownNeto);
            Controls.Add(lblNeto);
            Controls.Add(txtTexContenido);
            Controls.Add(lblTexContenido);
            Controls.Add(txtNombreDeProducto);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(txtCodigoDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(txtNroDePesada);
            Controls.Add(lblNroDePesada);
            Controls.Add(txtNroDeCodigoDeBarra);
            Controls.Add(btnGuardar);
            Controls.Add(lblNroDeCodigoDeBarra);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioEntrada";
            Text = "Formulario de entradas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNeto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton dropDownButton;
        private Button btnGuardar;
        private ToolStripMenuItem menuItemMain;
        private Label lblNroDeCodigoDeBarra;
        private TextBox txtNroDeCodigoDeBarra;
        private TextBox txtNroDePesada;
        private Label lblNroDePesada;
        private TextBox txtCodigoDeProducto;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreDeProducto;
        private Label lblNombreDeProducto;
        private TextBox txtTexContenido;
        private Label lblTexContenido;
        private Label lblNeto;
        private NumericUpDown numericUpDownNeto;
    }
}
