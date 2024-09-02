using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConversorDeMoedas
{
    public partial class Form1 : Form
    {
        // Dicionário para armazenar as taxas de câmbio
        private Dictionary<string, double> taxasDeCambio = new Dictionary<string, double>
        {
            { "USD_BRL", 5.25 },
            { "EUR_BRL", 6.20 },
            { "BRL_USD", 0.19 },
            { "BRL_EUR", 0.16 },
            // Adicione mais pares de moedas conforme necessário
        };

        public Form1()
        {
            InitializeComponent();
            // Preencher as ComboBoxes com moedas
            List<string> moedas = new List<string> { "USD", "EUR", "BRL" };
            cmbMoedaOrigem.DataSource = new List<string>(moedas);
            cmbMoedaDestino.DataSource = new List<string>(moedas);

            // Opcional: Selecionar o primeiro item por padrão
            cmbMoedaOrigem.SelectedIndex = 0;
            cmbMoedaDestino.SelectedIndex = 0;

            // Configurar o Label de resultado
            lblResultado.Text = "Resultado: ";
            lblResultado.Font = new Font(lblResultado.Font.FontFamily, 12, FontStyle.Bold);
            lblResultado.ForeColor = Color.Blue;
            lblResultado.TextAlign = ContentAlignment.MiddleLeft;
        }

        private string ObterSimboloMoeda(string moeda)
        {
            switch (moeda)
            {
                case "USD":
                    return "$";
                case "EUR":
                    return "€";
                case "BRL":
                    return "R$";
                // Adicione mais moedas conforme necessário
                default:
                    return "";
            }
        }

        private double? ObterTaxaDeCambio(string origem, string destino)
        {
            string chaveDireta = $"{origem}_{destino}";
            if (taxasDeCambio.ContainsKey(chaveDireta))
            {
                return taxasDeCambio[chaveDireta];
            }

            // Tentar conversão indireta via BRL
            string chaveViaBRLOrigem = $"{origem}_BRL";
            string chaveViaBRLDestino = $"BRL_{destino}";

            if (taxasDeCambio.ContainsKey(chaveViaBRLOrigem) && taxasDeCambio.ContainsKey(chaveViaBRLDestino))
            {
                double taxaOrigemBRL = taxasDeCambio[chaveViaBRLOrigem];
                double taxaBRLDestino = taxasDeCambio[chaveViaBRLDestino];
                return taxaOrigemBRL * taxaBRLDestino;
            }

            // Taxa não disponível
            return null;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // 1. Validar a entrada do usuário
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, insira um valor para converter.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (!double.TryParse(txtValor.Text, out double valor) || valor <= 0)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido maior que zero.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Clear();
                txtValor.Focus();
                return;
            }

            // 2. Obter as moedas selecionadas
            if (cmbMoedaOrigem.SelectedItem == null || cmbMoedaDestino.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione as moedas de origem e destino.", "Seleção de Moeda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string moedaOrigem = cmbMoedaOrigem.SelectedItem.ToString();
            string moedaDestino = cmbMoedaDestino.SelectedItem.ToString();

            // 3. Calcular o valor convertido usando função auxiliar
            double? taxa = ObterTaxaDeCambio(moedaOrigem, moedaDestino);

            if (taxa.HasValue)
            {
                double resultado = valor * taxa.Value;

                string simboloMoedaDestino = ObterSimboloMoeda(moedaDestino);
                lblResultado.Text = $"Resultado: {simboloMoedaDestino}{resultado:F2} {moedaDestino}";
            }
            else
            {
                MessageBox.Show($"Taxa de câmbio para {moedaOrigem} para {moedaDestino} não está disponível.", "Taxa de Câmbio Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            cmbMoedaOrigem.SelectedIndex = 0;
            cmbMoedaDestino.SelectedIndex = 0;
            lblResultado.Text = "Resultado: ";
            txtValor.Focus();
        }
    }
}