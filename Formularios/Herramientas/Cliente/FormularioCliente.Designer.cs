namespace JuanApp.Formularios.Entrada
{
    partial class FormularioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCliente));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            txtCodigoDeCliente = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreDeCliente = new TextBox();
            lblNombreDeProducto = new Label();
            txtDomicilio = new TextBox();
            label1 = new Label();
            txtLocalidad = new TextBox();
            label2 = new Label();
            txtCUIT = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCodigoPostal = new TextBox();
            label5 = new Label();
            txtProvincia = new TextBox();
            label6 = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de cliente";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 430);
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
            btnGuardar.Location = new Point(408, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 43);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCodigoDeCliente
            // 
            txtCodigoDeCliente.Location = new Point(12, 93);
            txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            txtCodigoDeCliente.Size = new Size(232, 27);
            txtCodigoDeCliente.TabIndex = 16;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Location = new Point(12, 70);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(127, 20);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de cliente";
            // 
            // txtNombreDeCliente
            // 
            txtNombreDeCliente.Location = new Point(12, 164);
            txtNombreDeCliente.Name = "txtNombreDeCliente";
            txtNombreDeCliente.Size = new Size(232, 27);
            txtNombreDeCliente.TabIndex = 18;
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.Location = new Point(12, 141);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(133, 20);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Nombre de cliente";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(12, 242);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(232, 27);
            txtDomicilio.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 219);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 19;
            label1.Text = "Domicilio";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(12, 316);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(232, 27);
            txtLocalidad.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 293);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 21;
            label2.Text = "Localidad";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(12, 393);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(232, 27);
            txtCUIT.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 23;
            label3.Text = "CUIT";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(282, 93);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 27);
            txtTelefono.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 70);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 25;
            label4.Text = "Teléfono";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(282, 164);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(232, 27);
            txtCodigoPostal.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 141);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 27;
            label5.Text = "Código postal";
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(282, 242);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(232, 27);
            txtProvincia.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 219);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 29;
            label6.Text = "Provincia";
            // 
            // FormularioCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 456);
            Controls.Add(txtProvincia);
            Controls.Add(label6);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCUIT);
            Controls.Add(label3);
            Controls.Add(txtLocalidad);
            Controls.Add(label2);
            Controls.Add(txtDomicilio);
            Controls.Add(label1);
            Controls.Add(txtNombreDeCliente);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(txtCodigoDeCliente);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioCliente";
            Text = "Formulario de entradas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private TextBox txtCodigoDeCliente;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreDeCliente;
        private Label lblNombreDeProducto;
        private TextBox txtDomicilio;
        private Label label1;
        private TextBox txtLocalidad;
        private Label label2;
        private TextBox txtCUIT;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCodigoPostal;
        private Label label5;
        private TextBox txtProvincia;
        private Label label6;
    }
}
