namespace JuanApp.Formularios.HerramientasGenerales
{
    partial class ValidarResetearStock
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
            txtAValidar = new TextBox();
            SuspendLayout();
            // 
            // btnResetearStock
            // 
            btnResetearStock.BackColor = Color.Black;
            btnResetearStock.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetearStock.ForeColor = SystemColors.Window;
            btnResetearStock.Location = new Point(367, 133);
            btnResetearStock.Name = "btnResetearStock";
            btnResetearStock.Size = new Size(157, 77);
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
            label2.Location = new Point(41, 41);
            label2.Name = "label2";
            label2.Size = new Size(413, 31);
            label2.TabIndex = 10;
            label2.Text = "OPERACIÓN CRÍTICA: RESETEAR STOCK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(41, 86);
            label1.Name = "label1";
            label1.Size = new Size(483, 28);
            label1.TabIndex = 11;
            label1.Text = "Para resetear, escriba debajo, la frase: PAMPA Y BRASA";
            // 
            // txtAValidar
            // 
            txtAValidar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAValidar.Location = new Point(41, 151);
            txtAValidar.Name = "txtAValidar";
            txtAValidar.Size = new Size(290, 34);
            txtAValidar.TabIndex = 12;
            // 
            // ValidarResetearStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(573, 258);
            Controls.Add(txtAValidar);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnResetearStock);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ValidarResetearStock";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validación necesaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetearStock;
        private Label label2;
        private Label label1;
        private TextBox txtAValidar;
    }
}