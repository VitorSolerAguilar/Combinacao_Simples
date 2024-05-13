namespace matematicaDiscreta
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
            ValorK = new TextBox();
            ValorN = new TextBox();
            arranjoSimples = new Button();
            combinacaoSimples = new Button();
            label1 = new Label();
            labelResultado = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ValorK
            // 
            ValorK.Location = new Point(121, 57);
            ValorK.Name = "ValorK";
            ValorK.Size = new Size(187, 31);
            ValorK.TabIndex = 1;
            // 
            // ValorN
            // 
            ValorN.Location = new Point(121, 12);
            ValorN.Name = "ValorN";
            ValorN.Size = new Size(187, 31);
            ValorN.TabIndex = 2;
            // 
            // arranjoSimples
            // 
            arranjoSimples.Location = new Point(6, 120);
            arranjoSimples.Name = "arranjoSimples";
            arranjoSimples.Size = new Size(150, 34);
            arranjoSimples.TabIndex = 3;
            arranjoSimples.Text = "Arranjo Simples";
            arranjoSimples.UseVisualStyleBackColor = true;
            arranjoSimples.Click += arranjoSimples_Click;
            // 
            // combinacaoSimples
            // 
            combinacaoSimples.Location = new Point(162, 120);
            combinacaoSimples.Name = "combinacaoSimples";
            combinacaoSimples.Size = new Size(187, 34);
            combinacaoSimples.TabIndex = 4;
            combinacaoSimples.Text = "Combinação Simples";
            combinacaoSimples.UseVisualStyleBackColor = true;
            combinacaoSimples.Click += combinacaoSimples_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 196);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 5;
            label1.Text = "Resultado:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(121, 196);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(24, 28);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "0";
            labelResultado.Visible = false;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 7;
            label2.Text = "Valor de N:";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(109, 31);
            label3.TabIndex = 8;
            label3.Text = "Valor de K:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelResultado);
            Controls.Add(label1);
            Controls.Add(combinacaoSimples);
            Controls.Add(arranjoSimples);
            Controls.Add(ValorN);
            Controls.Add(ValorK);
            Name = "Form1";
            Text = "Combinação Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ValorK;
        private TextBox ValorN;
        private Button arranjoSimples;
        private Button combinacaoSimples;
        private Label label1;
        private Label labelResultado;
        private Label label2;
        private Label label3;
    }
}
