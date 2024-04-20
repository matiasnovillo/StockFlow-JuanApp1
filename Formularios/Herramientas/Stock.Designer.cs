namespace JuanApp.Formularios.Herramientas
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemMain = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            lblTitulo = new Label();
            DataGridViewStock = new DataGridView();
            txtBuscar = new TextBox();
            lblBarraDeBusqueda = new Label();
            btnBuscar = new Button();
            numericUpDownRegistrosPorPagina = new NumericUpDown();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).BeginInit();
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
            statusStrip1.Location = new Point(0, 523);
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(194, 31);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Consulta de stock";
            // 
            // DataGridViewStock
            // 
            DataGridViewStock.AllowUserToAddRows = false;
            DataGridViewStock.AllowUserToDeleteRows = false;
            DataGridViewStock.AllowUserToOrderColumns = true;
            DataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewStock.Location = new Point(12, 172);
            DataGridViewStock.Name = "DataGridViewStock";
            DataGridViewStock.ReadOnly = true;
            DataGridViewStock.RowHeadersWidth = 51;
            DataGridViewStock.Size = new Size(776, 348);
            DataGridViewStock.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 139);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 27);
            txtBuscar.TabIndex = 12;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Location = new Point(12, 116);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(588, 20);
            lblBarraDeBusqueda.TabIndex = 11;
            lblBarraDeBusqueda.Text = "Barra de búsqueda (Busque por Nº de pesaje, nombre de producto o cód. de producto)";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(694, 116);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 50);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // numericUpDownRegistrosPorPagina
            // 
            numericUpDownRegistrosPorPagina.Location = new Point(260, 49);
            numericUpDownRegistrosPorPagina.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownRegistrosPorPagina.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownRegistrosPorPagina.Name = "numericUpDownRegistrosPorPagina";
            numericUpDownRegistrosPorPagina.Size = new Size(150, 27);
            numericUpDownRegistrosPorPagina.TabIndex = 14;
            numericUpDownRegistrosPorPagina.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 26);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 15;
            label1.Text = "Cant. de registros a mostrar";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(label1);
            Controls.Add(numericUpDownRegistrosPorPagina);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBarraDeBusqueda);
            Controls.Add(lblTitulo);
            Controls.Add(DataGridViewStock);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Stock";
            Text = "Stock";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegistrosPorPagina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Label lblTitulo;
        private DataGridView DataGridViewStock;
        private TextBox txtBuscar;
        private Label lblBarraDeBusqueda;
        private Button btnBuscar;
        private NumericUpDown numericUpDownRegistrosPorPagina;
        private Label label1;
    }
}