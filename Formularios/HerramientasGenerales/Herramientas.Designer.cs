namespace JuanApp.Formularios.HerramientasGenerales
{
    partial class Herramientas
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
            btnResetearStock = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnResetearStock
            // 
            btnResetearStock.BackColor = Color.Black;
            btnResetearStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnResetearStock.ForeColor = SystemColors.Window;
            btnResetearStock.Location = new Point(41, 112);
            btnResetearStock.Name = "btnResetearStock";
            btnResetearStock.Size = new Size(253, 77);
            btnResetearStock.TabIndex = 4;
            btnResetearStock.Text = "RESETEAR STOCK";
            btnResetearStock.UseVisualStyleBackColor = false;
            btnResetearStock.Click += btnResetearStock_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(41, 36);
            label2.Name = "label2";
            label2.Size = new Size(342, 31);
            label2.TabIndex = 10;
            label2.Text = "Operaciones críticas del sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(41, 67);
            label1.Name = "label1";
            label1.Size = new Size(361, 25);
            label1.TabIndex = 11;
            label1.Text = "Usar estas herramientas implica validaciones";
            // 
            // HerramientasYConfiguracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(642, 350);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnResetearStock);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HerramientasYConfiguracion";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Herramientas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetearStock;
        private Label label2;
        private Label label1;
    }
}