namespace AulasWindowsForms
{
    partial class FormRestoDivisao
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
            txtDivisor = new TextBox();
            btnRestodaDivisao = new Button();
            lblDividendo = new Label();
            lblDivisor = new Label();
            lblResto = new Label();
            txtDividendo = new TextBox();
            txtResto = new TextBox();
            SuspendLayout();
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(550, 72);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 1;
            // 
            // btnRestodaDivisao
            // 
            btnRestodaDivisao.Location = new Point(135, 202);
            btnRestodaDivisao.Name = "btnRestodaDivisao";
            btnRestodaDivisao.Size = new Size(136, 42);
            btnRestodaDivisao.TabIndex = 2;
            btnRestodaDivisao.Text = "Resto da Divisao";
            btnRestodaDivisao.UseVisualStyleBackColor = true;
            btnRestodaDivisao.Click += btnRestodaDivisao_Click;
            // 
            // lblDividendo
            // 
            lblDividendo.AutoSize = true;
            lblDividendo.Location = new Point(135, 72);
            lblDividendo.Name = "lblDividendo";
            lblDividendo.Size = new Size(61, 15);
            lblDividendo.TabIndex = 4;
            lblDividendo.Text = "Dividendo";
            lblDividendo.Click += label1_Click;
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(498, 74);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(43, 15);
            lblDivisor.TabIndex = 5;
            lblDivisor.Text = "Divisor";
            // 
            // lblResto
            // 
            lblResto.AutoSize = true;
            lblResto.Location = new Point(498, 229);
            lblResto.Name = "lblResto";
            lblResto.Size = new Size(36, 15);
            lblResto.TabIndex = 6;
            lblResto.Text = "Resto";
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(202, 69);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(100, 23);
            txtDividendo.TabIndex = 0;
            // 
            // txtResto
            // 
            txtResto.Location = new Point(550, 221);
            txtResto.Name = "txtResto";
            txtResto.Size = new Size(100, 23);
            txtResto.TabIndex = 8;
            txtResto.TabStop = false;
            // 
            // FormRestoDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResto);
            Controls.Add(txtDividendo);
            Controls.Add(lblResto);
            Controls.Add(lblDivisor);
            Controls.Add(lblDividendo);
            Controls.Add(btnRestodaDivisao);
            Controls.Add(txtDivisor);
            MaximizeBox = false;
            Name = "FormRestoDivisao";
            Text = "Resto da Divisao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDivisor;
        private Button btnRestodaDivisao;
        private Label lblDividendo;
        private Label lblDivisor;
        private Label lblResto;
        private TextBox txtDividendo;
        private TextBox txtResto;
    }
}