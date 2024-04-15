namespace JuanApp.Formularios.Salida
{
    partial class ConsultaSalida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSalida));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewSalida = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            btnGenerarPDF = new Button();
            txtBuscar = new TextBox();
            lblBarraDeBusqueda = new Label();
            dateTimePickerFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            dateTimePickerFechaInicio = new DateTimePicker();
            lblFechaInicio = new Label();
            btnGenerarExcel = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            lblKilosTotales = new Label();
            txtKilosRealesTotal = new TextBox();
            txtPrecioTotal = new TextBox();
            lblPrecioUnidadTotal = new Label();
            txtSubtotalTotal = new TextBox();
            lblSubtotalTotal = new Label();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSalida).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { menuItemMain });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuItemMain
            // 
            menuItemMain.Name = "menuItemMain";
            menuItemMain.Size = new Size(189, 26);
            menuItemMain.Text = "Volver al inicio";
            menuItemMain.Click += menuItemMain_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 620);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewSalida
            // 
            DataGridViewSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSalida.Location = new Point(12, 239);
            DataGridViewSalida.Name = "DataGridViewSalida";
            DataGridViewSalida.RowHeadersWidth = 51;
            DataGridViewSalida.Size = new Size(776, 319);
            DataGridViewSalida.TabIndex = 2;
            DataGridViewSalida.CellContentClick += DataGridViewSalida_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(211, 31);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de salidas";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(691, 183);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 50);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Location = new Point(670, 38);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(118, 50);
            btnGenerarPDF.TabIndex = 5;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 206);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 27);
            txtBuscar.TabIndex = 16;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Location = new Point(12, 163);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(447, 20);
            lblBarraDeBusqueda.TabIndex = 15;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por cód. de cliente, cód. de producto, ";
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Location = new Point(294, 108);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(250, 27);
            dateTimePickerFechaFin.TabIndex = 14;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(294, 85);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(89, 20);
            lblFechaFin.TabIndex = 13;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Location = new Point(12, 108);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(250, 27);
            dateTimePickerFechaInicio.TabIndex = 12;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(12, 85);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(108, 20);
            lblFechaInicio.TabIndex = 11;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.Location = new Point(670, 94);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(118, 50);
            btnGenerarExcel.TabIndex = 17;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = true;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(588, 183);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 50);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 183);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 19;
            label1.Text = "nombre de cliente o nombre de producto)";
            // 
            // lblKilosTotales
            // 
            lblKilosTotales.AutoSize = true;
            lblKilosTotales.Location = new Point(154, 561);
            lblKilosTotales.Name = "lblKilosTotales";
            lblKilosTotales.Size = new Size(148, 20);
            lblKilosTotales.TabIndex = 20;
            lblKilosTotales.Text = "Kilos reales TOTALES:";
            // 
            // txtKilosRealesTotal
            // 
            txtKilosRealesTotal.Location = new Point(154, 584);
            txtKilosRealesTotal.Name = "txtKilosRealesTotal";
            txtKilosRealesTotal.ReadOnly = true;
            txtKilosRealesTotal.Size = new Size(202, 27);
            txtKilosRealesTotal.TabIndex = 21;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(367, 584);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.ReadOnly = true;
            txtPrecioTotal.Size = new Size(202, 27);
            txtPrecioTotal.TabIndex = 23;
            // 
            // lblPrecioUnidadTotal
            // 
            lblPrecioUnidadTotal.AutoSize = true;
            lblPrecioUnidadTotal.Location = new Point(367, 561);
            lblPrecioUnidadTotal.Name = "lblPrecioUnidadTotal";
            lblPrecioUnidadTotal.Size = new Size(98, 20);
            lblPrecioUnidadTotal.TabIndex = 22;
            lblPrecioUnidadTotal.Text = "Precio TOTAL:";
            // 
            // txtSubtotalTotal
            // 
            txtSubtotalTotal.Location = new Point(577, 584);
            txtSubtotalTotal.Name = "txtSubtotalTotal";
            txtSubtotalTotal.ReadOnly = true;
            txtSubtotalTotal.Size = new Size(202, 27);
            txtSubtotalTotal.TabIndex = 25;
            // 
            // lblSubtotalTotal
            // 
            lblSubtotalTotal.AutoSize = true;
            lblSubtotalTotal.Location = new Point(577, 561);
            lblSubtotalTotal.Name = "lblSubtotalTotal";
            lblSubtotalTotal.Size = new Size(113, 20);
            lblSubtotalTotal.TabIndex = 24;
            lblSubtotalTotal.Text = "Subtotal TOTAL:";
            // 
            // ConsultaSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 646);
            Controls.Add(txtSubtotalTotal);
            Controls.Add(lblSubtotalTotal);
            Controls.Add(txtPrecioTotal);
            Controls.Add(lblPrecioUnidadTotal);
            Controls.Add(txtKilosRealesTotal);
            Controls.Add(lblKilosTotales);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnGenerarExcel);
            Controls.Add(txtBuscar);
            Controls.Add(lblBarraDeBusqueda);
            Controls.Add(dateTimePickerFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dateTimePickerFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(DataGridViewSalida);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaSalida";
            Text = "Consulta de salidas - Clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSalida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewSalida;
        private Label lblTitulo;
        private Button btnBuscar;
        private Button btnGenerarPDF;
        private TextBox txtBuscar;
        private Label lblBarraDeBusqueda;
        private DateTimePicker dateTimePickerFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dateTimePickerFechaInicio;
        private Label lblFechaInicio;
        private Button btnGenerarExcel;
        private Button btnAgregar;
        private Label label1;
        private Label lblKilosTotales;
        private TextBox txtKilosRealesTotal;
        private TextBox txtPrecioTotal;
        private Label lblPrecioUnidadTotal;
        private TextBox txtSubtotalTotal;
        private Label lblSubtotalTotal;
    }
}