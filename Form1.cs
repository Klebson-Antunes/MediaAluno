namespace MédiaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaração de variaveis
            double nota1, nota2, nota3, media;

            //Entrada de Dados
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            // Calcular media e exibir media
            media = (nota1 + nota2 + nota3) / 3;
            lblMedia.Text = media.ToString();

            // Condição para Situação do aluno >= a 7 e Aprovado
            if (media >= 7.0)
            {
                lblSituacao.Text = "Aluno Aprovado";
            }
            else
            {
                lblSituacao.Text = "Aluno Reprovado";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            lblMedia.Text = string.Empty;
            lblSituacao.Text = string.Empty;
        }
    }
}