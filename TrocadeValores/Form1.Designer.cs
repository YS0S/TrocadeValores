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
            BtmClicar = new Button();
            LblValor1 = new Label();
            LblValor2 = new Label();
            TxTValor1 = new TextBox();
            TxtValor2 = new TextBox();
            SuspendLayout();
            // 
            // BtmClicar
            // 
            BtmClicar.Image = (Image)resources.GetObject("BtmClicar.Image");
            BtmClicar.Location = new Point(368, 169);
            BtmClicar.Name = "BtmClicar";
            BtmClicar.Size = new Size(75, 70);
            BtmClicar.TabIndex = 0;
            BtmClicar.UseVisualStyleBackColor = true;
            BtmClicar.Click += BtmClicar_Click;
            BtmClicar.MouseHover += BtmClicar_MouseHover;
            // 
            // LblValor1
            // 
            LblValor1.AutoSize = true;
            LblValor1.Location = new Point(190, 114);
            LblValor1.Name = "LblValor1";
            LblValor1.Size = new Size(45, 15);
            LblValor1.TabIndex = 1;
            LblValor1.Text = "Valor 1:";
            LblValor1.Click += LblValor1_Click;
            // 
            // LblValor2
            // 
            LblValor2.AutoSize = true;
            LblValor2.Location = new Point(450, 118);
            LblValor2.Name = "LblValor2";
            LblValor2.Size = new Size(45, 15);
            LblValor2.TabIndex = 2;
            LblValor2.Text = "Valor 2:";
            LblValor2.Click += LblValor2_Click;
            // 
            // TxTValor1
            // 
            TxTValor1.Location = new Point(241, 111);
            TxTValor1.Name = "TxTValor1";
            TxTValor1.Size = new Size(100, 23);
            TxTValor1.TabIndex = 3;
            TxTValor1.TextChanged += TxTValor1_TextChanged;
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(501, 114);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(100, 23);
            TxtValor2.TabIndex = 4;
            TxtValor2.TextChanged += TxtValor2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtValor2);
            Controls.Add(TxTValor1);
            Controls.Add(LblValor2);
            Controls.Add(LblValor1);
            Controls.Add(BtmClicar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtmClicar;
        private Label LblValor1;
        private Label LblValor2;
        private TextBox TxTValor1;
        private TextBox TxtValor2;
    }
}
