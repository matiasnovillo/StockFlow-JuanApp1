namespace JuanApp.Formularios.Herramientas.Remito
{
    partial class ConsultaRemito
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
            DataGridViewRemito = new DataGridView();
            lblTitulo = new Label();
            btnBuscar = new Button();
            lblBarraDeBusqueda = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            panel1 = new Panel();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRemito).BeginInit();
            panel1.SuspendLayout();
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
            statusLabel.BackColor = SystemColors.Window;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = SystemColors.ControlText;
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(132, 28);
            statusLabel.Text = "Información:";
            // 
            // DataGridViewRemito
            // 
            DataGridViewRemito.AllowUserToAddRows = false;
            DataGridViewRemito.AllowUserToDeleteRows = false;
            DataGridViewRemito.AllowUserToOrderColumns = true;
            DataGridViewRemito.BackgroundColor = Color.Black;
            DataGridViewRemito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRemito.Dock = DockStyle.Bottom;
            DataGridViewRemito.Location = new Point(0, 360);
            DataGridViewRemito.Name = "DataGridViewRemito";
            DataGridViewRemito.ReadOnly = true;
            DataGridViewRemito.RowHeadersWidth = 51;
            DataGridViewRemito.Size = new Size(1924, 661);
            DataGridViewRemito.TabIndex = 2;
            DataGridViewRemito.CellClick += DataGridViewRemito_CellClick;
            DataGridViewRemito.CellContentClick += DataGridViewRemito_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(12, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(563, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Consulta de remitos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.Window;
            btnBuscar.Location = new Point(1739, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(173, 75);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBarraDeBusqueda
            // 
            lblBarraDeBusqueda.AutoSize = true;
            lblBarraDeBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarraDeBusqueda.ForeColor = SystemColors.Window;
            lblBarraDeBusqueda.Location = new Point(12, 153);
            lblBarraDeBusqueda.Name = "lblBarraDeBusqueda";
            lblBarraDeBusqueda.Size = new Size(175, 28);
            lblBarraDeBusqueda.TabIndex = 9;
            lblBarraDeBusqueda.Text = "Barra de búsqueda";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(12, 184);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(532, 34);
            txtBuscar.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.Enabled = false;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(1547, 143);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(173, 75);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Visible = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblBarraDeBusqueda);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 335);
            panel1.TabIndex = 12;
            // 
            // ConsultaRemito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(DataGridViewRemito);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConsultaRemito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Remitos";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRemito).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private DataGridView DataGridViewRemito;
        private Label lblTitulo;
        private Button btnBuscar;
        private Label lblBarraDeBusqueda;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Panel panel1;
    }
}