using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCliente
{
    public class Calculos
    {
        Form1 fr = new Form1();
        int indice; //indie atraibutos
        int indiceValor; //valores indice

        String[] atributos; //atributos procesados
        public double[] valoresAtri; //valores Acumulados atributos

        public Calculos(int canAtriV)
        {
            atributos = new string[1000];//atributos colchon
            valoresAtri = new double[canAtriV];//valores atributos
            indiceValor = 0;
            indice = 0;
        }

        public void setIndiceAtri(int valor)
        {
            indice = valor;
        }

        public void adicionarAtri(String atri)
        {
            atributos[indice] = atri;
            indice++;
        }
        public void adicionarValorAtri(double vAtri)
        {
            valoresAtri[indiceValor] = vAtri;
            indiceValor++;
        }
        public double[] atributoDesicion(String atributo, int pos, int deci, String[,] matriz, int ejemplos)
        {
            int sis = 0;
            int nos = 0;
            double[] resp = new double[3];
            for (int i = pos; i < pos + 1; i++)
            {
                for (int k = 0; k < ejemplos; k++)
                {
                    if (matriz[k, i].Equals(atributo)) //Error Null Pointer
                    {
                        if (matriz[k, deci].Equals("SI")) //fr.txtResult1.Text
                        {
                            sis++;
                        }
                        else if (matriz[k, deci].Equals("NO")) //fr.txtResult2.Text
                        {
                            nos++;
                        }

                    }
                }
            }
            resp[0] = sis;
            resp[1] = nos;
            resp[2] = nos + sis;
            return resp;
        }

        public double log2(double num)
        {
            return (double)(Math.Log(num) / Math.Log(2));
        }
        public double infor(double pos, double nega)
        {
            double posi = 0;
            double negai = 0;
            if (pos == 0)
            {
                posi = 0;
            }
            else
            {
                posi = -pos * log2(pos);
                //  Console.WriteLine("agregando una variable positiva" + posi);
            }

            if (nega == 0)
            {
                negai = 0;
            }
            else
            {
                negai = -nega * log2(nega);
                //Console.WriteLine("agregando una variable negativa" + negai);
            }

            double total = posi + negai;
            //  Console.WriteLine("SUMATOTAL" + total);
            return total;
        }

        public bool procesarAtri(String atri)
        {
            for (int i = 0; i < indice; i++)
            {
                if (atributos[i].Equals(atri))
                {
                    return true;
                }
            }
            return false;
        }

        public void ordenar(String[] atri)
        {
            double aux = 0;
            String auxA = "";
            for (int i = 0; i < valoresAtri.Length - 1; i++)
            {
                for (int k = 0; k < valoresAtri.Length - 1; k++)
                {
                    if (valoresAtri[k] > valoresAtri[k + 1])
                    {
                        aux = valoresAtri[k];
                        auxA = atri[k];
                        valoresAtri[k] = valoresAtri[k + 1];
                        atri[k] = atri[k + 1];
                        valoresAtri[k + 1] = aux;
                        atri[k + 1] = auxA;
                    }
                }
            }
        }
        public void imprimeV(String[] atri)
        {
            Form1 a = new Form1();

            Console.WriteLine("*******************Atributos Ordenados*****************");
            a.listBoxLista.Items.Add("*******************Atributos Ordenados*****************");
            for (int i = 0; i < valoresAtri.Length; i++)
            {
                Console.WriteLine("{0}.......{1}", atri[i], valoresAtri[i]);
                a.listBoxLista.Items.Add(atri[i] + "-..........-" + valoresAtri[i]);
            }
        }

    }
}
