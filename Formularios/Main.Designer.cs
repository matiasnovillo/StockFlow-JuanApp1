namespace JuanApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            ToolStripButtonAcercaDe = new ToolStripButton();
            btnEntradaCargarExcel = new Button();
            btnEntradaConsulta = new Button();
            btnSalidaConsulta = new Button();
            groupBoxHerramientas = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRemito = new Button();
            btnCliente = new Button();
            btnProducto = new Button();
            btnStock = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBoxHerramientas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1924, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(89, 20);
            statusLabel.Text = "Información";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, ToolStripButtonAcercaDe });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1924, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(42, 24);
            toolStripButton2.Text = "Salir";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // ToolStripButtonAcercaDe
            // 
            ToolStripButtonAcercaDe.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripButtonAcercaDe.Image = (Image)resources.GetObject("ToolStripButtonAcercaDe.Image");
            ToolStripButtonAcercaDe.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAcercaDe.Name = "ToolStripButtonAcercaDe";
            ToolStripButtonAcercaDe.Size = new Size(79, 24);
            ToolStripButtonAcercaDe.Text = "Acerca de";
            ToolStripButtonAcercaDe.Click += ToolStripButtonAcercaDe_Click;
            // 
            // btnEntradaCargarExcel
            // 
            btnEntradaCargarExcel.BackColor = Color.Black;
            btnEntradaCargarExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnEntradaCargarExcel.ForeColor = SystemColors.Window;
            btnEntradaCargarExcel.Location = new Point(288, 248);
            btnEntradaCargarExcel.Name = "btnEntradaCargarExcel";
            btnEntradaCargarExcel.Size = new Size(167, 71);
            btnEntradaCargarExcel.TabIndex = 4;
            btnEntradaCargarExcel.Text = "CARGAR EXCEL";
            btnEntradaCargarExcel.UseVisualStyleBackColor = false;
            btnEntradaCargarExcel.Click += btnEntradaCargarExcel_Click;
            // 
            // btnEntradaConsulta
            // 
            btnEntradaConsulta.BackColor = Color.Black;
            btnEntradaConsulta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnEntradaConsulta.ForeColor = SystemColors.Window;
            btnEntradaConsulta.Location = new Point(288, 83);
            btnEntradaConsulta.Name = "btnEntradaConsulta";
            btnEntradaConsulta.Size = new Size(167, 148);
            btnEntradaConsulta.TabIndex = 3;
            btnEntradaConsulta.Text = "CONSULTAS";
            btnEntradaConsulta.UseVisualStyleBackColor = false;
            btnEntradaConsulta.Click += btnEntradaConsulta_Click;
            // 
            // btnSalidaConsulta
            // 
            btnSalidaConsulta.BackColor = Color.Black;
            btnSalidaConsulta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSalidaConsulta.ForeColor = SystemColors.Window;
            btnSalidaConsulta.Location = new Point(874, 83);
            btnSalidaConsulta.Name = "btnSalidaConsulta";
            btnSalidaConsulta.Size = new Size(167, 148);
            btnSalidaConsulta.TabIndex = 3;
            btnSalidaConsulta.Text = "CONSULTAS";
            btnSalidaConsulta.UseVisualStyleBackColor = false;
            btnSalidaConsulta.Click += btnSalidaConsulta_Click;
            // 
            // groupBoxHerramientas
            // 
            groupBoxHerramientas.BackColor = Color.Black;
            groupBoxHerramientas.Controls.Add(label4);
            groupBoxHerramientas.Controls.Add(label3);
            groupBoxHerramientas.Controls.Add(label2);
            groupBoxHerramientas.Controls.Add(btnSalidaConsulta);
            groupBoxHerramientas.Controls.Add(btnEntradaCargarExcel);
            groupBoxHerramientas.Controls.Add(btnRemito);
            groupBoxHerramientas.Controls.Add(btnEntradaConsulta);
            groupBoxHerramientas.Controls.Add(btnCliente);
            groupBoxHerramientas.Controls.Add(btnProducto);
            groupBoxHerramientas.Controls.Add(btnStock);
            groupBoxHerramientas.Dock = DockStyle.Bottom;
            groupBoxHerramientas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxHerramientas.ForeColor = Color.FromArgb(57, 210, 220);
            groupBoxHerramientas.Location = new Point(0, 468);
            groupBoxHerramientas.Name = "groupBoxHerramientas";
            groupBoxHerramientas.Size = new Size(1924, 561);
            groupBoxHerramientas.TabIndex = 5;
            groupBoxHerramientas.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(1392, 34);
            label4.Name = "label4";
            label4.Size = new Size(261, 46);
            label4.TabIndex = 11;
            label4.Text = "HERRAMIENTAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(896, 34);
            label3.Name = "label3";
            label3.Size = new Size(130, 46);
            label3.TabIndex = 10;
            label3.Text = "SALIDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(288, 34);
            label2.Name = "label2";
            label2.Size = new Size(167, 46);
            label2.TabIndex = 9;
            label2.Text = "ENTRADA";
            // 
            // btnRemito
            // 
            btnRemito.BackColor = Color.Black;
            btnRemito.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRemito.ForeColor = SystemColors.Window;
            btnRemito.Location = new Point(874, 248);
            btnRemito.Name = "btnRemito";
            btnRemito.Size = new Size(167, 71);
            btnRemito.TabIndex = 7;
            btnRemito.Text = "REMITOS";
            btnRemito.UseVisualStyleBackColor = false;
            btnRemito.Click += btnRemito_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.Black;
            btnCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCliente.ForeColor = SystemColors.Window;
            btnCliente.Location = new Point(1486, 248);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(167, 77);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "CLIENTES";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.Black;
            btnProducto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnProducto.ForeColor = SystemColors.Window;
            btnProducto.Location = new Point(1486, 346);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(167, 89);
            btnProducto.TabIndex = 5;
            btnProducto.Text = "PRODUCTOS";
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Black;
            btnStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnStock.ForeColor = SystemColors.Window;
            btnStock.Location = new Point(1486, 83);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(167, 148);
            btnStock.TabIndex = 4;
            btnStock.Text = "STOCK";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 441);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LogoDark;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(793, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 266);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(groupBoxHerramientas);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "JuanApp";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBoxHerramientas.ResumeLayout(false);
            groupBoxHerramientas.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private Button btnEntradaConsulta;
        private Button btnEntradaCargarExcel;
        private Button btnSalidaConsulta;
        private GroupBox groupBoxHerramientas;
        private Button btnStock;
        private Button btnProducto;
        private Button btnCliente;
        private Button btnRemito;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private ToolStripButton toolStripButton2;
        private ToolStripButton ToolStripButtonAcercaDe;
    }
}