namespace MédiaAluno
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
            lblNota1 = new Label();
            lblNota3 = new Label();
            lblNota2 = new Label();
            txtNota1 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            lblMed = new Label();
            lblSit = new Label();
            lblMedia = new Label();
            lblSituacao = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota1.Location = new Point(83, 15);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(69, 25);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota3.Location = new Point(83, 127);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(69, 25);
            lblNota3.TabIndex = 2;
            lblNota3.Text = "Nota 3";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota2.Location = new Point(83, 72);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(69, 25);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "Nota 2";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(158, 16);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(153, 27);
            txtNota1.TabIndex = 4;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(158, 125);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(153, 27);
            txtNota3.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(158, 72);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(153, 27);
            txtNota2.TabIndex = 6;
            // 
            // lblMed
            // 
            lblMed.AutoSize = true;
            lblMed.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMed.Location = new Point(40, 182);
            lblMed.Name = "lblMed";
            lblMed.Size = new Size(65, 25);
            lblMed.TabIndex = 7;
            lblMed.Text = "Média";
            // 
            // lblSit
            // 
            lblSit.AutoSize = true;
            lblSit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSit.Location = new Point(40, 230);
            lblSit.Name = "lblSit";
            lblSit.Size = new Size(85, 25);
            lblSit.TabIndex = 9;
            lblSit.Text = "Situação";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(160, 189);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(0, 20);
            lblMedia.TabIndex = 10;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(165, 236);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(0, 20);
            lblSituacao.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(97, 288);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(158, 46);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(326, 288);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(131, 46);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(lblSituacao);
            Controls.Add(lblMedia);
            Controls.Add(lblSit);
            Controls.Add(lblMed);
            Controls.Add(txtNota2);
            Controls.Add(txtNota3);
            Controls.Add(txtNota1);
            Controls.Add(lblNota2);
            Controls.Add(lblNota3);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Média Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota3;
        private Label lblNota2;
        private TextBox txtNota1;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private Label lblMed;
        private Label lblSit;
        private Label lblMedia;
        private Label lblSituacao;
        private Button btnCalcular;
        private Button btnLimpar;
    }
}