using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCliente
{
    public partial class Form1 : Form
    {
       // string opcionesTotales = "";
        int aut = 0;
        String[] titulos;
        // ArrayList choices = new ArrayList();
        static DataTable ejemplos = new DataTable();
        int filas = ejemplos.Rows.Count;
        string[,] matrizTotal;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChoices_Click(object sender, EventArgs e)
        {
            AgregarChoices();
            dtgEjemplos.DataSource = ejemplos;
        }
        private void AgregarChoices()
        {
            //choices.Add(txtChoices.Text);


            ejemplos.Columns.Add(txtChoices.Text);
            txtChoices.Text = "";

        }

        private void btnEjemplos_Click(object sender, EventArgs e)
        {
            string words = txtEjemplo.Text;

            string[] filaEjemplo = words.Split(',');

            ejemplos.Rows.Add(filaEjemplo);
            txtEjemplo.Text = "";

            aut++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            titulos = new string[dtgEjemplos.Columns.Count - 1];
            for (int i = 0; i < dtgEjemplos.Columns.Count - 1; i++)
            {

                titulos[i] = dtgEjemplos.Columns[i].HeaderText.ToString();

            }
            int g = ejemplos.Columns.Count;

            llenarMatriz(dtgEjemplos);

        }
        private void llenarMatriz(DataGridView Grid)
        {
            int valorX = Grid.Columns.Count;
            int valorY = Grid.Rows.Count;
            matrizTotal = new string[valorY, valorX];
            if (Grid.Rows.Count > 1)
            {

                for (int j = Grid.Columns.Count - 1; j >= 0; j--)
                {
                    for (int i = Grid.Rows.Count - 2; i >= 0; i--)
                    {

                        // MessageBox.Show(dtgEjemplos.Rows[i].Cells[j].Value.ToString());
                        matrizTotal[i, j] = dtgEjemplos.Rows[i].Cells[j].Value.ToString();
                    }

                }
                imprimirTabla(matrizTotal, ejemplos.Rows.Count, ejemplos.Columns.Count);
                // MessageBox.Show((ejemplos.Columns.Count-1).ToString());


            }

        }
        public void imprimirTabla(String[,] tab, int y, int x) // y -> filas,x->columnas
        {
            for (int i = 0; i < y; i++) //filas
            {
                for (int j = 0; j < x; j++) //Colunmas

                {
                    Console.Write("  " + tab[i, j]);
                    listBoxLista.Items.Add("  " + tab[i, j]);

                }
                Console.WriteLine(" ");
                listBoxLista.Items.Add("  ");

            }

            //  textBox1.Multiline = true;

            Console.WriteLine(" Numero Filas: {0}", x);
            listBoxLista.Items.Add(" Numero Filas:" + x);
            Console.WriteLine(" Numero Columnas: {0}", y);
            //Console.WriteLine(" MtrizTotal Filas: {0}", matrizTotal.Length);
            listBoxLista.Items.Add(" Numero Columnas:" + y);
        }

        private void btnID3_Click(object sender, EventArgs e)
        {
            AlgoritmoID3();
        }
        public void AlgoritmoID3()
        {
            //  MessageBox.Show(Convert.ToString( ejemplos.Columns.Count - 1));

            Calculos calculos = new Calculos(ejemplos.Columns.Count - 1); //total de elementos x en la matriz

            int totalAtributos = ejemplos.Columns.Count - 1;
            // int posdecision = ejemplos.Columns.Count-1;

            int posdecision = ejemplos.Columns.Count - 1;
            int filas = dtgEjemplos.Rows.Count - 1;
            //MessageBox.Show("filas: "+ filas.ToString());
            int columnas = dtgEjemplos.Columns.Count;
            // MessageBox.Show(columnas.ToString());
            int totalEjemplos = filas; //num filas

            // MessageBox.Show(totalEjemplos.ToString());


            double[] resultados = new double[3];
            String atri = "";
            double suma;

            for (int posAtributo = 0; posAtributo < posdecision; posAtributo++) //posAtributo -> i
            {
                suma = 0;
                calculos.setIndiceAtri(0);
                //recorre cada fila x cada ejemplo
                for (int j = 0; j < totalEjemplos; j++)

                {
                    atri = matrizTotal[j, posAtributo];
                    if (!calculos.procesarAtri(atri))
                    {
                        resultados = calculos.atributoDesicion(atri, posAtributo, posdecision, matrizTotal, totalEjemplos);
                        //Console.WriteLine("_________________________");
                        //Console.WriteLine(resultados[0]);
                        //Console.WriteLine(resultados[1]);
                        //Console.WriteLine(resultados[2]);
                        //        Console.WriteLine("POSI" + (double)(resultados[0] / resultados[2]));
                        // float VALORPARCIAL = (Convert.ToInt32(resultados.ToString()[0]) / Convert.ToInt32( resultados.ToString()[2]));
                        double VALORPARCIAL = (resultados[0] / resultados[2]);
                        double VALORPARCIAL2 = (resultados[1] / resultados[2]);
                        // MessageBox.Show(VALORPARCIAL.ToString());
                        // Console.WriteLine("NO POSI" + resultados[1] / resultados[2]);
                        //                       float infor = calculos.infor((float) (resultados[0] / resultados[2]), (float) (resultados[1] / resultados[2]));
                        double infor = calculos.infor(VALORPARCIAL, VALORPARCIAL2);
                        suma = suma + (double)(resultados[2] / totalEjemplos * infor);
                        double auxsuma = (double)(resultados[2] / totalEjemplos);
                        double auxInfor = infor * auxsuma;
                        //Console.WriteLine("VALOR PERDIDO" + resultados[2]);
                        // MessageBox.Show(infor.ToString());
                        //Console.WriteLine("SUMA ANTES" + suma);
                        // suma = suma + (double)(resultados[2] / totalEjemplos * infor);

                        //Console.WriteLine("SUMA despues" + suma); 

                        Console.WriteLine("{0} pos ({1}) nega ({2}) -> Total ({3})     total/ejemplos {4}   Infor ({5}) -  Infor* Total({6})", atri, resultados[0], resultados[1], resultados[2], auxsuma, infor, auxInfor);
                        listBoxLista.Items.Add(atri + "positivos" + resultados[0] + "Negativos" + resultados[1] + "Total" + resultados[2] + " " + "Total/Ejemplos" + auxsuma + "Datos " + infor + "Datos*Total" + auxInfor);


                        // listBoxLista.Items.Add();

                    }
                    calculos.adicionarAtri(atri);
                }
                Console.WriteLine("*************");
                listBoxLista.Items.Add("" + dtgEjemplos.Columns[posAtributo].HeaderText.ToString() + "====>" + suma);
                Console.WriteLine(" {0} --> {1}", dtgEjemplos.Columns[posAtributo].HeaderText.ToString(), suma);
                Console.WriteLine("*************");
                Console.WriteLine("*************");
                calculos.adicionarValorAtri(suma);

            }//for 
            calculos.ordenar(titulos);
            calculos.imprimeV(titulos);
            // Console.WriteLine("*******************Atributos Ordenados*****************");
            listBoxLista.Items.Add("*******************Atributos Ordenados*****************");
            for (int i = 0; i < titulos.Length; i++)
            {
                //     Console.WriteLine("{0}.......{1}", atri[i], titulos[i]);
                listBoxLista.Items.Add(titulos[i] + "-..........-" + calculos.valoresAtri[i]);
            }
            listBoxLista.Items.Add("Menor DP -> " + titulos[0]);
        }//Metodo

    }
}
