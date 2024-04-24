namespace JuanApp.Formularios.Salida
{
    partial class FormularioSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSalida));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            lblCodigoDeCliente = new Label();
            txtCodigoDeCliente = new TextBox();
            txtNombreDeCliente = new TextBox();
            lblNombreDeCliente = new Label();
            txtCodigoDeProducto = new TextBox();
            lblCodigoDeProducto = new Label();
            txtNombreProducto = new TextBox();
            lblNombreProducto = new Label();
            lblKilosTotales = new Label();
            numericUpDownKilosTotales = new NumericUpDown();
            lblPrecio = new Label();
            numericUpDownPrecio = new NumericUpDown();
            lblSubtotal = new Label();
            numericUpDownSubtotal = new NumericUpDown();
            lblInfo = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNroDePesada = new TextBox();
            lblNroDePesada = new Label();
            label3 = new Label();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubtotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de salidas";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 520);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(479, 26);
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
            toolStrip1.Size = new Size(479, 27);
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
            btnGuardar.Location = new Point(341, 467);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 43);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCodigoDeCliente
            // 
            lblCodigoDeCliente.AutoSize = true;
            lblCodigoDeCliente.Location = new Point(12, 159);
            lblCodigoDeCliente.Name = "lblCodigoDeCliente";
            lblCodigoDeCliente.Size = new Size(147, 20);
            lblCodigoDeCliente.TabIndex = 6;
            lblCodigoDeCliente.Text = "Código de cliente (*)";
            // 
            // txtCodigoDeCliente
            // 
            txtCodigoDeCliente.Location = new Point(12, 182);
            txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            txtCodigoDeCliente.Size = new Size(232, 27);
            txtCodigoDeCliente.TabIndex = 1;
            txtCodigoDeCliente.KeyPress += txtCodigoDeCliente_KeyPress;
            // 
            // txtNombreDeCliente
            // 
            txtNombreDeCliente.Location = new Point(12, 271);
            txtNombreDeCliente.Name = "txtNombreDeCliente";
            txtNombreDeCliente.Size = new Size(232, 27);
            txtNombreDeCliente.TabIndex = 2;
            // 
            // lblNombreDeCliente
            // 
            lblNombreDeCliente.AutoSize = true;
            lblNombreDeCliente.Location = new Point(12, 248);
            lblNombreDeCliente.Name = "lblNombreDeCliente";
            lblNombreDeCliente.Size = new Size(153, 20);
            lblNombreDeCliente.TabIndex = 13;
            lblNombreDeCliente.Text = "Nombre de cliente (*)";
            // 
            // txtCodigoDeProducto
            // 
            txtCodigoDeProducto.Location = new Point(12, 341);
            txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            txtCodigoDeProducto.Size = new Size(232, 27);
            txtCodigoDeProducto.TabIndex = 4;
            txtCodigoDeProducto.KeyPress += txtCodigoDeProducto_KeyPress;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Location = new Point(12, 318);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(164, 20);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Código de producto (*)";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(12, 433);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(232, 27);
            txtNombreProducto.TabIndex = 5;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(12, 410);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(170, 20);
            lblNombreProducto.TabIndex = 17;
            lblNombreProducto.Text = "Nombre de producto (*)";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Location = new Point(284, 70);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(110, 20);
            lblKilosTotales.TabIndex = 19;
            lblKilosTotales.Text = "Kilos totales (*)";
            // 
            // numericUpDownKilosTotales
            // 
            numericUpDownKilosTotales.DecimalPlaces = 2;
            numericUpDownKilosTotales.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownKilosTotales.Location = new Point(284, 94);
            numericUpDownKilosTotales.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownKilosTotales.Name = "numericUpDownKilosTotales";
            numericUpDownKilosTotales.Size = new Size(150, 27);
            numericUpDownKilosTotales.TabIndex = 6;
            numericUpDownKilosTotales.KeyPress += numericUpDownKilosTotales_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(284, 159);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 23;
            lblPrecio.Text = "Precio";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPrecio.Location = new Point(284, 183);
            numericUpDownPrecio.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(150, 27);
            numericUpDownPrecio.TabIndex = 7;
            numericUpDownPrecio.KeyPress += numericUpDownPrecio_KeyPress;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(284, 225);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 25;
            lblSubtotal.Text = "Subtotal";
            // 
            // numericUpDownSubtotal
            // 
            numericUpDownSubtotal.DecimalPlaces = 2;
            numericUpDownSubtotal.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownSubtotal.Location = new Point(284, 249);
            numericUpDownSubtotal.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownSubtotal.Name = "numericUpDownSubtotal";
            numericUpDownSubtotal.Size = new Size(150, 27);
            numericUpDownSubtotal.TabIndex = 8;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 371);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(349, 20);
            lblInfo.TabIndex = 26;
            lblInfo.Text = "Presione Enter para rellenar el nombre de producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 212);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 27;
            label1.Text = "Presione Enter para rellenar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 490);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 28;
            label2.Text = "(*) Requerido y mayor a 0";
            // 
            // txtNroDePesada
            // 
            txtNroDePesada.Location = new Point(12, 93);
            txtNroDePesada.Name = "txtNroDePesada";
            txtNroDePesada.Size = new Size(232, 27);
            txtNroDePesada.TabIndex = 30;
            txtNroDePesada.KeyPress += txtNroDePesada_KeyPress;
            // 
            // lblNroDePesada
            // 
            lblNroDePesada.AutoSize = true;
            lblNroDePesada.Location = new Point(12, 70);
            lblNroDePesada.Name = "lblNroDePesada";
            lblNroDePesada.Size = new Size(119, 20);
            lblNroDePesada.TabIndex = 29;
            lblNroDePesada.Text = "Nº de pesada (*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 31;
            label3.Text = "Presione Enter para rellenar";
            // 
            // FormularioSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 546);
            Controls.Add(label3);
            Controls.Add(txtNroDePesada);
            Controls.Add(lblNroDePesada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblInfo);
            Controls.Add(numericUpDownSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(numericUpDownKilosTotales);
            Controls.Add(lblKilosTotales);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtCodigoDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(txtNombreDeCliente);
            Controls.Add(lblNombreDeCliente);
            Controls.Add(txtCodigoDeCliente);
            Controls.Add(btnGuardar);
            Controls.Add(lblCodigoDeCliente);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioSalida";
            Text = "Formulario de salidas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSubtotal).EndInit();
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
        private Label lblCodigoDeCliente;
        private TextBox txtCodigoDeCliente;
        private TextBox txtNombreDeCliente;
        private Label lblNombreDeCliente;
        private TextBox txtCodigoDeProducto;
        private Label lblCodigoDeProducto;
        private TextBox txtNombreProducto;
        private Label lblNombreProducto;
        private Label lblKilosTotales;
        private NumericUpDown numericUpDownKilosTotales;
        private Label lblPrecio;
        private NumericUpDown numericUpDownPrecio;
        private Label lblSubtotal;
        private NumericUpDown numericUpDownSubtotal;
        private Label lblInfo;
        private Label label1;
        private Label label2;
        private TextBox txtNroDePesada;
        private Label lblNroDePesada;
        private Label label3;
    }
}
