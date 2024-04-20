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
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuItemSalir = new ToolStripMenuItem();
            groupBoxEntrada = new GroupBox();
            btnEntradaCargarExcel = new Button();
            btnEntradaConsulta = new Button();
            groupBoxSalida = new GroupBox();
            btnSalidaConsulta = new Button();
            groupBoxHerramientas = new GroupBox();
            btnRemito = new Button();
            btnCliente = new Button();
            btnProducto = new Button();
            btnStock = new Button();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBoxEntrada.SuspendLayout();
            groupBoxSalida.SuspendLayout();
            groupBoxHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(887, 26);
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(887, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { menuItemSalir });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuItemSalir
            // 
            menuItemSalir.Name = "menuItemSalir";
            menuItemSalir.Size = new Size(121, 26);
            menuItemSalir.Text = "Salir";
            menuItemSalir.Click += menuItemSalir_Click;
            // 
            // groupBoxEntrada
            // 
            groupBoxEntrada.Controls.Add(btnEntradaCargarExcel);
            groupBoxEntrada.Controls.Add(btnEntradaConsulta);
            groupBoxEntrada.Location = new Point(34, 46);
            groupBoxEntrada.Name = "groupBoxEntrada";
            groupBoxEntrada.Size = new Size(250, 189);
            groupBoxEntrada.TabIndex = 3;
            groupBoxEntrada.TabStop = false;
            groupBoxEntrada.Text = "Entrada";
            // 
            // btnEntradaCargarExcel
            // 
            btnEntradaCargarExcel.Location = new Point(54, 116);
            btnEntradaCargarExcel.Name = "btnEntradaCargarExcel";
            btnEntradaCargarExcel.Size = new Size(142, 54);
            btnEntradaCargarExcel.TabIndex = 4;
            btnEntradaCargarExcel.Text = "Cargar Excel";
            btnEntradaCargarExcel.UseVisualStyleBackColor = true;
            btnEntradaCargarExcel.Click += btnEntradaCargarExcel_Click;
            // 
            // btnEntradaConsulta
            // 
            btnEntradaConsulta.Location = new Point(54, 40);
            btnEntradaConsulta.Name = "btnEntradaConsulta";
            btnEntradaConsulta.Size = new Size(142, 54);
            btnEntradaConsulta.TabIndex = 3;
            btnEntradaConsulta.Text = "Consultas";
            btnEntradaConsulta.UseVisualStyleBackColor = true;
            btnEntradaConsulta.Click += btnEntradaConsulta_Click;
            // 
            // groupBoxSalida
            // 
            groupBoxSalida.Controls.Add(btnSalidaConsulta);
            groupBoxSalida.Location = new Point(34, 257);
            groupBoxSalida.Name = "groupBoxSalida";
            groupBoxSalida.Size = new Size(250, 118);
            groupBoxSalida.TabIndex = 4;
            groupBoxSalida.TabStop = false;
            groupBoxSalida.Text = "Salida";
            // 
            // btnSalidaConsulta
            // 
            btnSalidaConsulta.Location = new Point(59, 40);
            btnSalidaConsulta.Name = "btnSalidaConsulta";
            btnSalidaConsulta.Size = new Size(142, 54);
            btnSalidaConsulta.TabIndex = 3;
            btnSalidaConsulta.Text = "Consultas";
            btnSalidaConsulta.UseVisualStyleBackColor = true;
            btnSalidaConsulta.Click += btnSalidaConsulta_Click;
            // 
            // groupBoxHerramientas
            // 
            groupBoxHerramientas.Controls.Add(btnRemito);
            groupBoxHerramientas.Controls.Add(btnCliente);
            groupBoxHerramientas.Controls.Add(btnProducto);
            groupBoxHerramientas.Controls.Add(btnStock);
            groupBoxHerramientas.Location = new Point(307, 46);
            groupBoxHerramientas.Name = "groupBoxHerramientas";
            groupBoxHerramientas.Size = new Size(546, 329);
            groupBoxHerramientas.TabIndex = 5;
            groupBoxHerramientas.TabStop = false;
            groupBoxHerramientas.Text = "Herramientas";
            // 
            // btnRemito
            // 
            btnRemito.Location = new Point(61, 116);
            btnRemito.Name = "btnRemito";
            btnRemito.Size = new Size(142, 54);
            btnRemito.TabIndex = 7;
            btnRemito.Text = "Remitos";
            btnRemito.UseVisualStyleBackColor = true;
            btnRemito.Click += btnRemito_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(380, 40);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(142, 54);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(220, 40);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(142, 54);
            btnProducto.TabIndex = 5;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(61, 40);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(142, 54);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(groupBoxHerramientas);
            Controls.Add(groupBoxSalida);
            Controls.Add(groupBoxEntrada);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "Main";
            Text = "JuanApp";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBoxEntrada.ResumeLayout(false);
            groupBoxSalida.ResumeLayout(false);
            groupBoxHerramientas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private GroupBox groupBoxEntrada;
        private Button btnEntradaConsulta;
        private Button btnEntradaCargarExcel;
        private GroupBox groupBoxSalida;
        private Button btnSalidaConsulta;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemSalir;
        private GroupBox groupBoxHerramientas;
        private Button btnStock;
        private Button btnProducto;
        private Button btnCliente;
        private Button btnRemito;
    }
}