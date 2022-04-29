using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar uma arrayList
            ArrayList formaPagto = new ArrayList();
            formaPagto.Add(new FormaDePagto(1, "Seleção Opção"));
            formaPagto.Add(new FormaDePagto(2, "Cartão"));
            formaPagto.Add(new FormaDePagto(3, "Boleto"));
            formaPagto.Add(new FormaDePagto(4, "Pix"));
            formaPagto.Add(new FormaDePagto(5, "Dinheiro"));

            //vincular ao comboBox1
            comboBox1.DataSource = formaPagto;
            comboBox1.DisplayMember = "Descrição";
            comboBox1.ValueMember = "Descricao";
        }

        public class FormaDePagto
        {
            public int ID { get; set; }
            public string Descricao { get; set; }

            public FormaDePagto(int ID, string Descricao)
            {
                this.ID = ID;
                this.Descricao = Descricao;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int escolha = comboBox1.SelectedIndex;
            //lblEscolha.Text = escolha.ToString();

            switch (escolha)
            {
                case 0:
                    lblEscolha.Text = "Escolha opção";
                    listBoxParcelas.Visible = false;
                    btnCalcular.Visible = false;
                    txtNumeroParcelas.Visible = false;
                    lblParcelasTexto.Visible = false;
                    txtChave.Visible = false;
                    lblChavePix.Visible = false;
                    break;
                case 1:
                    lblEscolha.Text = "Cartão";
                    listBoxParcelas.Visible = true;
                    btnCalcular.Visible = true;
                    txtNumeroParcelas.Visible = true;
                    lblParcelasTexto.Visible = true;
                    txtChave.Visible = false;
                    lblChavePix.Visible = false;
                    break;
                case 2:
                    lblEscolha.Text = "Boleto";
                    listBoxParcelas.Visible = false;
                    btnCalcular.Visible = false;
                    txtNumeroParcelas.Visible = false;
                    lblParcelasTexto.Visible = false;
                    txtChave.Visible = false;
                    lblChavePix.Visible = false;
                    break;
                case 3:
                    lblEscolha.Text = "Pix";
                    listBoxParcelas.Visible = false;
                    btnCalcular.Visible = false;
                    txtNumeroParcelas.Visible = false;
                    lblParcelasTexto.Visible = false;
                    txtChave.Visible = true;
                    lblChavePix.Visible = true;
                    txtChave.Text = Guid.NewGuid().ToString();
                    break;
                case 4:
                    lblEscolha.Text = "Dinheiro";
                    listBoxParcelas.Visible = false;
                    btnCalcular.Visible = false;
                    txtNumeroParcelas.Visible = false;
                    lblParcelasTexto.Visible = false;
                    txtChave.Visible = false;
                    lblChavePix.Visible = false;
                    break;
                default:
                    lblEscolha.Text = "";
                    listBoxParcelas.Visible = false;
                    btnCalcular.Visible = false;
                    txtNumeroParcelas.Visible = false;
                    lblParcelasTexto.Visible = false;
                    txtChave.Visible = false;
                    lblChavePix.Visible = false;
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listBoxParcelas.Items.Clear();
            int numeroParcelas = int.Parse(txtNumeroParcelas.Text);
            decimal valorTotal = decimal.Parse(txtValor.Text);
            decimal totalParcelas = valorTotal / numeroParcelas;

            for (int i = 0; i < numeroParcelas; i++)
            {
              listBoxParcelas.Items.Add((i + 1) + " x " + totalParcelas.ToString("N2"));
            }
            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
