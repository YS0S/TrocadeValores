namespace AulasWindowsForms
{
    partial class FrmRestoDivisao
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
            TxtResto = new TextBox();
            TxtDivisor = new TextBox();
            TxtDividendo = new TextBox();
            LblDividendo = new Label();
            BtnRestodaDivisao = new Button();
            LblDivisor = new Label();
            LblResto = new Label();
            SuspendLayout();
            // 
            // TxtResto
            // 
            TxtResto.Enabled = false;
            TxtResto.Location = new Point(465, 174);
            TxtResto.Name = "TxtResto";
            TxtResto.ReadOnly = true;
            TxtResto.Size = new Size(100, 23);
            TxtResto.TabIndex = 0;
            // 
            // TxtDivisor
            // 
            TxtDivisor.Location = new Point(464, 100);
            TxtDivisor.Name = "TxtDivisor";
            TxtDivisor.Size = new Size(100, 23);
            TxtDivisor.TabIndex = 1;
            // 
            // TxtDividendo
            // 
            TxtDividendo.Location = new Point(183, 100);
            TxtDividendo.Name = "TxtDividendo";
            TxtDividendo.Size = new Size(100, 23);
            TxtDividendo.TabIndex = 3;
            // 
            // LblDividendo
            // 
            LblDividendo.AutoSize = true;
            LblDividendo.Location = new Point(116, 103);
            LblDividendo.Name = "LblDividendo";
            LblDividendo.Size = new Size(64, 15);
            LblDividendo.TabIndex = 4;
            LblDividendo.Text = "Dividendo:";
            // 
            // BtnRestodaDivisao
            // 
            BtnRestodaDivisao.Location = new Point(156, 169);
            BtnRestodaDivisao.Name = "BtnRestodaDivisao";
            BtnRestodaDivisao.Size = new Size(127, 23);
            BtnRestodaDivisao.TabIndex = 5;
            BtnRestodaDivisao.Text = "Resto da Divisão";
            BtnRestodaDivisao.UseVisualStyleBackColor = true;
            BtnRestodaDivisao.Click += BtnRestodaDivisao_Click;
            // 
            // LblDivisor
            // 
            LblDivisor.AutoSize = true;
            LblDivisor.Location = new Point(412, 103);
            LblDivisor.Name = "LblDivisor";
            LblDivisor.Size = new Size(46, 15);
            LblDivisor.TabIndex = 6;
            LblDivisor.Text = "Divisor:";
            // 
            // LblResto
            // 
            LblResto.AutoSize = true;
            LblResto.Location = new Point(420, 177);
            LblResto.Name = "LblResto";
            LblResto.Size = new Size(39, 15);
            LblResto.TabIndex = 7;
            LblResto.Text = "Resto:";
            // 
            // FrmRestoDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResto);
            Controls.Add(LblDivisor);
            Controls.Add(BtnRestodaDivisao);
            Controls.Add(LblDividendo);
            Controls.Add(TxtDividendo);
            Controls.Add(TxtDivisor);
            Controls.Add(TxtResto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRestoDivisao";
            Text = "RestoDaDivisao";
            Load += FrmRestoDivisao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResto;
        private TextBox TxtDivisor;
        private TextBox TxtDividendo;
        private Label LblDividendo;
        private Button BtnRestodaDivisao;
        private Label LblDivisor;
        private Label LblResto;
    }
}