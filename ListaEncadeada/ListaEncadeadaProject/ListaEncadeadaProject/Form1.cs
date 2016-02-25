using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEncadeadaProject
{
    public partial class Form1 : Form
    {
        private Lista list;

        public Form1()
        {
            InitializeComponent();
            InicializarLista();
            ExibirLista();
            Numero.Text = "0";
        }

        class Element
        {
            #region Element
            public static int Nome;
            public Element anterior;
            public Element proximo;

            public Element(int value)
            {
                ValueSelf = value;
                proximo = null;
                anterior = null;
            }

            public Element(int value, Element next = null)
            {
                ValueSelf = value;
                proximo = next;
                anterior = null;
            }

            public Element(int value, Element next = null, Element previous = null) 
            {
                ValueSelf = value;
                proximo = next;
                anterior = previous;
            }

            public int ValueSelf
            {
                get
                {
                    return Nome;
                }
                set
                {
                    Nome = value;
                }
            }
            public Element NextSelf
            {
                get
                {
                    return proximo;
                }
                set
                {
                    proximo = value;
                }
            }

            public Element PreviousSelf
            {
                get
                {
                    return anterior;
                }
                set
                {
                    anterior = value;
                }
            }
            #endregion
        }

        class Lista
        {
            #region Lista
            private Element primeiro;
            public Element Primeiro
            {
                get
                {
                    return primeiro;
                }
                set
                {
                    primeiro = value;
                }
            }

            public Element Ultimo
            {
                get
                {
                    return BuscaUltimo();
                }
            }

            public Lista()
            {
            
            }

            public void Adiciona(Element e)
            {
                if (Primeiro == null)
                {
                    Primeiro = e;
                }
                else
                {
                    Ultimo.proximo = e;
                }
            }

            public Element BuscaUltimo()
            {
                Element current = Primeiro;
                while (current.proximo != null)
                {
                    current = current.proximo;
                }
                return current;
            }

            public int Count
            {
                get 
                {
                    int count = 1;
                    Element current = Primeiro;
                    while (current != null)
                    {
                        current = current.proximo;
                        count++;
                    }
                    return count;
                }
            }

            public void ImprimeLista()
            {
                Element current = Primeiro;
                while (current != null)
                {
                    current = current.proximo;
                }
            }
            #endregion
        }

        //private void CarregarPrograma(object sender, EventArgs e)
        //{
        //    list = new Lista();
        //}

        private void InicializarLista()
        {
            list = new Lista();
            Element NewElement = new Element(list.Count);            
            list.Adiciona(NewElement);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            InicializarLista();
            list = new Lista();
            Element NewElement = new Element(list.Count);
            list.Adiciona(NewElement);
            listBox1.Items.Add("Ordem na lista : " + NewElement + "Numero : " + Numero.Text);
            Numero.Clear();
            Numero.Text = "0";
        }

        private void ExibirLista()
        {
            list.ImprimeLista();
        }
    }
}
