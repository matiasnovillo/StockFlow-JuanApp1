namespace JuanApp.Formularios.Entrada
{
    partial class ConsultaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEntrada));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewEntrada = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblFechaInicio = new Label();
            dateTimePickerFechaInicio = new DateTimePicker();
            dateTimePickerFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEntrada).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(826, 27);
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
            statusStrip1.Location = new Point(0, 528);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(826, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(92, 20);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewEntrada
            // 
            DataGridViewEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEntrada.Location = new Point(12, 203);
            DataGridViewEntrada.Name = "DataGridViewEntrada";
            DataGridViewEntrada.RowHeadersWidth = 51;
            DataGridViewEntrada.Size = new Size(802, 322);
            DataGridViewEntrada.TabIndex = 2;
            DataGridViewEntrada.CellContentClick += DataGridViewEntrada_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 31);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de entradas";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(720, 147);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 50);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(12, 83);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(108, 20);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Location = new Point(12, 106);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(250, 27);
            dateTimePickerFechaInicio.TabIndex = 6;
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Location = new Point(294, 106);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(250, 27);
            dateTimePickerFechaFin.TabIndex = 8;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(294, 83);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(89, 20);
            lblFechaFin.TabIndex = 7;
            lblFechaFin.Text = "Fecha de fin";
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Location = new Point(12, 147);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(588, 20);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por Nº de pesaje, nombre de producto o cód. de producto)";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 170);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 27);
            txtBuscar.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(620, 147);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 50);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ConsultaEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 554);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBarraDeBusqueda);
            Controls.Add(dateTimePickerFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dateTimePickerFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(btnBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(DataGridViewEntrada);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaEntrada";
            Text = "Consulta de entradas - Pesajes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEntrada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewEntrada;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblFechaInicio;
        private DateTimePicker dateTimePickerFechaInicio;
        private DateTimePicker dateTimePickerFechaFin;
        private Label lblFechaFin;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private Button btnAgregar;
    }
}