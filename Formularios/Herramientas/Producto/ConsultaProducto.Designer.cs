namespace JuanApp.Formularios.Herramientas.Producto
{
    partial class ConsultaProducto
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
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            DataGridViewProducto = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            pnlSearchBar = new Panel();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducto).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1924, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1021);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1924, 34);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(132, 28);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewProducto
            // 
            DataGridViewProducto.AllowUserToAddRows = false;
            DataGridViewProducto.AllowUserToDeleteRows = false;
            DataGridViewProducto.AllowUserToOrderColumns = true;
            DataGridViewProducto.BackgroundColor = Color.Black;
            DataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProducto.Dock = DockStyle.Bottom;
            DataGridViewProducto.Location = new Point(0, 294);
            DataGridViewProducto.Name = "DataGridViewProducto";
            DataGridViewProducto.ReadOnly = true;
            DataGridViewProducto.RowHeadersWidth = 51;
            DataGridViewProducto.Size = new Size(1924, 727);
            DataGridViewProducto.TabIndex = 2;
            DataGridViewProducto.CellClick += DataGridViewProducto_CellClick;
            DataGridViewProducto.CellContentClick += DataGridViewProducto_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(632, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de productos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1717, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(195, 80);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 124);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(175, 28);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 155);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 34);
            txtBuscar.TabIndex = 10;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(1498, 109);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(195, 80);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.BackColor = Color.Black;
            pnlSearchBar.Controls.Add(lblTitulo);
            pnlSearchBar.Controls.Add(btnAgregar);
            pnlSearchBar.Controls.Add(btnBuscar);
            pnlSearchBar.Controls.Add(txtBuscar);
            pnlSearchBar.Controls.Add(lblBarraDeBusqueda);
            pnlSearchBar.Dock = DockStyle.Fill;
            pnlSearchBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlSearchBar.Location = new Point(0, 25);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(1924, 269);
            pnlSearchBar.TabIndex = 12;
            // 
            // ConsultaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlSearchBar);
            Controls.Add(DataGridViewProducto);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaProducto";
            Text = "Consulta de Productos";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducto).EndInit();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewProducto;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Panel pnlSearchBar;
    }
}