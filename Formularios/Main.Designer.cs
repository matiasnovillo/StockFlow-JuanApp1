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
            btnSalidaFormulario = new Button();
            groupBoxHerramientas = new GroupBox();
            btnEstadisticas = new Button();
            btnEntradaFormulario = new Button();
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
            groupBoxEntrada.Controls.Add(btnEntradaFormulario);
            groupBoxEntrada.Location = new Point(34, 46);
            groupBoxEntrada.Name = "groupBoxEntrada";
            groupBoxEntrada.Size = new Size(250, 290);
            groupBoxEntrada.TabIndex = 3;
            groupBoxEntrada.TabStop = false;
            groupBoxEntrada.Text = "Entrada";
            // 
            // btnEntradaCargarExcel
            // 
            btnEntradaCargarExcel.Location = new Point(57, 211);
            btnEntradaCargarExcel.Name = "btnEntradaCargarExcel";
            btnEntradaCargarExcel.Size = new Size(142, 54);
            btnEntradaCargarExcel.TabIndex = 4;
            btnEntradaCargarExcel.Text = "Cargar Excel";
            btnEntradaCargarExcel.UseVisualStyleBackColor = true;
            // 
            // btnEntradaConsulta
            // 
            btnEntradaConsulta.Location = new Point(57, 135);
            btnEntradaConsulta.Name = "btnEntradaConsulta";
            btnEntradaConsulta.Size = new Size(142, 54);
            btnEntradaConsulta.TabIndex = 3;
            btnEntradaConsulta.Text = "Consultas";
            btnEntradaConsulta.UseVisualStyleBackColor = true;
            // 
            // groupBoxSalida
            // 
            groupBoxSalida.Controls.Add(btnSalidaConsulta);
            groupBoxSalida.Controls.Add(btnSalidaFormulario);
            groupBoxSalida.Location = new Point(326, 46);
            groupBoxSalida.Name = "groupBoxSalida";
            groupBoxSalida.Size = new Size(250, 290);
            groupBoxSalida.TabIndex = 4;
            groupBoxSalida.TabStop = false;
            groupBoxSalida.Text = "Salida";
            // 
            // btnSalidaConsulta
            // 
            btnSalidaConsulta.Location = new Point(57, 135);
            btnSalidaConsulta.Name = "btnSalidaConsulta";
            btnSalidaConsulta.Size = new Size(142, 54);
            btnSalidaConsulta.TabIndex = 3;
            btnSalidaConsulta.Text = "Consultas";
            btnSalidaConsulta.UseVisualStyleBackColor = true;
            // 
            // btnSalidaFormulario
            // 
            btnSalidaFormulario.Location = new Point(57, 59);
            btnSalidaFormulario.Name = "btnSalidaFormulario";
            btnSalidaFormulario.Size = new Size(142, 54);
            btnSalidaFormulario.TabIndex = 2;
            btnSalidaFormulario.Text = "Formulario";
            btnSalidaFormulario.UseVisualStyleBackColor = true;
            // 
            // groupBoxHerramientas
            // 
            groupBoxHerramientas.Controls.Add(btnEstadisticas);
            groupBoxHerramientas.Location = new Point(604, 46);
            groupBoxHerramientas.Name = "groupBoxHerramientas";
            groupBoxHerramientas.Size = new Size(250, 290);
            groupBoxHerramientas.TabIndex = 5;
            groupBoxHerramientas.TabStop = false;
            groupBoxHerramientas.Text = "Herramientas";
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(56, 59);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(142, 54);
            btnEstadisticas.TabIndex = 3;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnEntradaFormulario
            // 
            btnEntradaFormulario.Location = new Point(57, 59);
            btnEntradaFormulario.Name = "btnEntradaFormulario";
            btnEntradaFormulario.Size = new Size(142, 54);
            btnEntradaFormulario.TabIndex = 2;
            btnEntradaFormulario.Text = "Formulario";
            btnEntradaFormulario.UseVisualStyleBackColor = true;
            btnEntradaFormulario.Click += btnEntradaFormulario_Click;
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
        private Button btnSalidaFormulario;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem menuItemSalir;
        private GroupBox groupBoxHerramientas;
        private Button btnEstadisticas;
        private Button btnEntradaFormulario;
    }
}