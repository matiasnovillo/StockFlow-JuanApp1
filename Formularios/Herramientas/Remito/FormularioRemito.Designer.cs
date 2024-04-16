namespace JuanApp.Formularios.Herramientas.Remito
{
    partial class FormularioRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRemito));
            lblTitulo = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            dropDownButton = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            btnGuardar = new Button();
            lblCodigoDeProducto = new Label();
            lblNombreDeProducto = new Label();
            DateTimePickerFechaDeEmision = new DateTimePicker();
            NumericUpDownKilosTotales = new NumericUpDown();
            NumericUpDownPrecioTotal = new NumericUpDown();
            label1 = new Label();
            NumericUpDownSubtotalTotal = new NumericUpDown();
            label2 = new Label();
            txtCodigoCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNombreCliente = new TextBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownKilosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrecioTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownSubtotalTotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de remito";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 411);
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
            btnGuardar.Location = new Point(408, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 43);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblCodigoDeProducto
            // 
            lblCodigoDeProducto.AutoSize = true;
            lblCodigoDeProducto.Location = new Point(12, 70);
            lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            lblCodigoDeProducto.Size = new Size(124, 20);
            lblCodigoDeProducto.TabIndex = 15;
            lblCodigoDeProducto.Text = "Fecha de emisión";
            // 
            // lblNombreDeProducto
            // 
            lblNombreDeProducto.AutoSize = true;
            lblNombreDeProducto.Location = new Point(279, 70);
            lblNombreDeProducto.Name = "lblNombreDeProducto";
            lblNombreDeProducto.Size = new Size(90, 20);
            lblNombreDeProducto.TabIndex = 17;
            lblNombreDeProducto.Text = "Kilos totales";
            // 
            // DateTimePickerFechaDeEmision
            // 
            DateTimePickerFechaDeEmision.Location = new Point(12, 93);
            DateTimePickerFechaDeEmision.Name = "DateTimePickerFechaDeEmision";
            DateTimePickerFechaDeEmision.Size = new Size(250, 27);
            DateTimePickerFechaDeEmision.TabIndex = 19;
            // 
            // NumericUpDownKilosTotales
            // 
            NumericUpDownKilosTotales.Location = new Point(279, 93);
            NumericUpDownKilosTotales.Name = "NumericUpDownKilosTotales";
            NumericUpDownKilosTotales.Size = new Size(250, 27);
            NumericUpDownKilosTotales.TabIndex = 20;
            // 
            // NumericUpDownPrecioTotal
            // 
            NumericUpDownPrecioTotal.Location = new Point(279, 173);
            NumericUpDownPrecioTotal.Name = "NumericUpDownPrecioTotal";
            NumericUpDownPrecioTotal.Size = new Size(250, 27);
            NumericUpDownPrecioTotal.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 150);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 21;
            label1.Text = "Precio total";
            // 
            // NumericUpDownSubtotalTotal
            // 
            NumericUpDownSubtotalTotal.Location = new Point(279, 256);
            NumericUpDownSubtotalTotal.Name = "NumericUpDownSubtotalTotal";
            NumericUpDownSubtotalTotal.Size = new Size(250, 27);
            NumericUpDownSubtotalTotal.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 233);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 23;
            label2.Text = "Subtotal total";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(12, 172);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(250, 27);
            txtCodigoCliente.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 26;
            label3.Text = "Codigo de cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 233);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 28;
            label4.Text = "Nombre de cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(12, 255);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(250, 27);
            txtNombreCliente.TabIndex = 27;
            // 
            // FormularioRemito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 437);
            Controls.Add(label4);
            Controls.Add(txtNombreCliente);
            Controls.Add(label3);
            Controls.Add(txtCodigoCliente);
            Controls.Add(NumericUpDownSubtotalTotal);
            Controls.Add(label2);
            Controls.Add(NumericUpDownPrecioTotal);
            Controls.Add(label1);
            Controls.Add(NumericUpDownKilosTotales);
            Controls.Add(DateTimePickerFechaDeEmision);
            Controls.Add(lblNombreDeProducto);
            Controls.Add(lblCodigoDeProducto);
            Controls.Add(btnGuardar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(lblTitulo);
            Name = "FormularioRemito";
            Text = "Formulario de remitos";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownKilosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrecioTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownSubtotalTotal).EndInit();
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
        private Label lblCodigoDeProducto;
        private Label lblNombreDeProducto;
        private DateTimePicker DateTimePickerFechaDeEmision;
        private NumericUpDown NumericUpDownKilosTotales;
        private NumericUpDown NumericUpDownPrecioTotal;
        private Label label1;
        private NumericUpDown NumericUpDownSubtotalTotal;
        private Label label2;
        private TextBox txtCodigoCliente;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCliente;
    }
}
