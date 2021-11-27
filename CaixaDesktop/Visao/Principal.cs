using System;
using System.Windows.Forms;
using CaixaDesktop.Controle;

namespace caixa
{
    public partial class Principal : Form
    {
        Controladora controle;
        public Principal()
        {
            InitializeComponent();
            controle = new Controladora();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
          
            try
            {

                int valor = Convert.ToInt32(tbxValor.Text);
                if(btnStatus.Text == "Aberto")
                {
                    if (valor > 0)
                    {
                        if(tbxMotivo.Text != "")
                        {
                            if(cbxTipo.SelectedIndex >= 0 && cbxTipo.SelectedIndex < 2)
                            {
                                if (controle.Gravar(valor, tbxMotivo.Text, cbxTipo.SelectedIndex == 0 ? 'E' : 'S', DateTime.Now))
                                {
                                    MessageBox.Show("Gravou", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Não Gravou", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tipo não é valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Você precisa dizer o motivo da movimentação no caixa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor precisa ser positivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                     MessageBox.Show("Caixa precisa estar aberto.", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex1)
            {
                Console.WriteLine(ex1);
                MessageBox.Show("Digite um valor válido","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if(btnStatus.Text == "Aberto")
            {
                btnStatus.Text = "Fechado";
                btnStatus.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                btnStatus.Text = "Aberto";
                btnStatus.BackColor = System.Drawing.Color.Green;
            }
            btnStatus.Refresh();
        }
    }
}
