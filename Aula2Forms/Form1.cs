using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //add itens manualmente no comboBox
            cboLista.Items.Add(txtTexto.Text);
            //exibe a quantidade de itens do ComboBox
            lblQdte.Text = cboLista.Items.Count.ToString();
            //Limpa a caixa de texto
            txtTexto.Clear();
            //foco para a caixa de texto
            txtTexto.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //Ativa a propriedade para ordenar a lista no combo
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica se está vazio ou não
            if (cboLista.SelectedIndex != -1)
            {
                //remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                //exibe a quantidade de itens do combo box
                lblQdte.Text = cboLista.Items.Count.ToString();
                //limpa o resto da lista do combo 
                cboLista.ResetText();



            }

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //verifica se existe um item selecionado no combo 
            if (cboLista.SelectedIndex != -1)
            { 
                //Exibe o conteúdo (texto do combo)
                labelllll.Text = cboLista.SelectedItem.ToString();
                //Exibe o indice (posição) do item do combo
                labeeel.Text = cboLista.SelectedIndex.ToString();
            }
        }
    }
}
