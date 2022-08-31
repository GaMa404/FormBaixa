using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBaixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvVenda.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgvVenda.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgvVenda.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgvVenda.Columns.Insert(3, new DataGridViewTextBoxColumn());
            dgvVenda.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgvVenda.Columns.Insert(5, new DataGridViewTextBoxColumn());
            dgvVenda.Columns.Insert(6, new DataGridViewTextBoxColumn());

            dgvVenda.Columns[0].Name = "Selecionar";
            dgvVenda.Columns[1].Name = "ID";
            dgvVenda.Columns[2].Name = "EAN";
            dgvVenda.Columns[3].Name = "Produto";
            dgvVenda.Columns[4].Name = "Valor Compra";
            dgvVenda.Columns[5].Name = "Valor Venda";
            dgvVenda.Columns[6].Name = "Estoque";

            dgvVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVenda.ReadOnly = true;
            dgvVenda.AllowUserToAddRows = false;
            dgvVenda.AllowUserToDeleteRows = false;
            dgvVenda.AllowUserToOrderColumns = true;

            dgvVenda.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVenda.Columns[4].DefaultCellStyle.Format = " R$ ###,###,##0.00";

            dgvVenda.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVenda.Columns[5].DefaultCellStyle.Format = "R$ ###,###,##0.00";
        }

        private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvVenda.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvVenda.CurrentRow.Cells[0].Value) == false)
                {
                    dgvVenda.CurrentRow.Cells[0].Value = true;
                }
                else 
                {
                    dgvVenda.CurrentRow.Cells[0].Value = false;
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvVenda.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            String linha;
            
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string id = dados[0];
                string ean = dados[1];
                string produto = dados[2];
                double valor_compra = double.Parse(dados[3]);
                double valor_venda = double.Parse(dados[4]);
                string estoque = dados[5];

                dgvVenda.Rows.Add(false, id, ean, produto, valor_compra, valor_venda, estoque);
            }
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dgvVenda.Rows)
            {
                linha.Cells[0].Value = true;
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow linha in dgvVenda.Rows)
            {
                linha.Cells[0].Value = false;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = dgvVenda.RowCount - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dgvVenda.Rows[i].Cells[0].Value) == true)
                {
                    dgvVenda.Rows.Remove(dgvVenda.Rows[i]);
                }
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            double aumento = double.Parse(txtAumento.Text)/100;

            foreach(DataGridViewRow row in dgvVenda.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    row.Cells[5].Value = (Convert.ToDouble(row.Cells[5].Value) + Convert.ToDouble(row.Cells[5].Value) * aumento).ToString("C");

                    /*double preço_antigo = Convert.ToDouble(row.Cells[5].Value);
                    double preço_atual = preço_antigo + preço_antigo * (aumento / 100);

                    row.Cells[5].Value = preço_atual.ToString("C");

                    preço_antigo = 0;
                    preço_atual = 0;*/
                    
                }
            }

            txtAumento.Clear();
        }
    }
}
