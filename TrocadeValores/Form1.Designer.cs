namespace TrocadeValores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Lbl1 = new Label();
            Lbl2 = new Label();
            BtnClicar = new Button();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(138, 101);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(39, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "Valor1";
            Lbl1.Click += label1_Click;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(480, 98);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(39, 15);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "Valor2";
            // 
            // BtnClicar
            // 
            BtnClicar.BackColor = SystemColors.HighlightText;
            BtnClicar.Image = (Image)resources.GetObject("BtnClicar.Image");
            BtnClicar.Location = new Point(339, 202);
            BtnClicar.Name = "BtnClicar";
            BtnClicar.Size = new Size(102, 45);
            BtnClicar.TabIndex = 2;
            BtnClicar.UseVisualStyleBackColor = false;
            BtnClicar.Click += Btm1_Click;
            BtnClicar.MouseHover += BtmClicar_MouseHover;
            // 
            // Txt1
            // 
            Txt1.Location = new Point(183, 98);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(100, 23);
            Txt1.TabIndex = 3;
            Txt1.TextChanged += Txt1_TextChanged;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(541, 101);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(100, 23);
            Txt2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(Txt2);
            Controls.Add(Txt1);
            Controls.Add(BtnClicar);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Name = "Form1";
            Text = "Troca de Valores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Button BtnClicar;
        private TextBox Txt1;
        private TextBox Txt2;
    }
}
