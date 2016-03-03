using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Random r = new Random();
            //r.Next(1,100) + (2 * DateTime.Now.Second)
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
            AtualizaListaNoForm();
        }

        private void AtualizaListaNoForm()
        {
            listBox1.Items.Clear();
            Elemento current = lista.Primeiro;
            AddIntoListBox(current);
            while (current.Proximo != null)
            {
                current = current.Proximo;
                AddIntoListBox(current);
            }
        }

        private void AddIntoListBox(Elemento current)
        {
            if (current.Proximo == null)
            {
                listBox1.Items.Add("Valor : " + current.Valor + " Aponta para : null");
            }
            else
            {
                listBox1.Items.Add("Valor : " + current.Valor + " Aponta para : " + current.Proximo.Valor);
            }
        }

        public void ExcluirElemento(object sender, EventArgs e)
        {
            Elemento current = new Elemento(lista.Count);
            if (listBox1.SelectedIndex != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            //listBox1.Items.Clear();
        }
    }
}
