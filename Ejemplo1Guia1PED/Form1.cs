using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1Guia1PED
{
    public partial class Ejemplo1 : Form
    {
        public Ejemplo1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void Ejemplo1_Load(object sender, EventArgs e)
        {

        }
        
        private void limpiar_pantalla() //Para limpiar el textbox llamado "Pantalla"
        {
            Pantalla.Text = "";
        }

        public double obtener_valor() //Para transformar lo que se digite en el textbox a formato numerico
        {
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiar_pantalla();
            return valor;
        }

        public void actualizar_pantalla(String texto) //Para actualizar lo que se visualiza en el textbox
        {
            Pantalla.Text = Pantalla.Text + texto;
        }

        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int Operacion;

        private void btn0_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 1;      //"1" indicará la operacion matematica "resta"
            }
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 2;      //"2" indicará la operacion matematica "multiplicacion"
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 3;      //"3" indicará la operacion matematica "division"
            }
        }

        private void btnsen_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                double Conversion = Num1 * Math.PI / 180.0;
                Resultado = Math.Sin(Conversion);
                actualizar_pantalla(""+ Conversion + "");
            }
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                double Conversion = Num1 * Math.PI / 180.0;
                Resultado = Math.Cos(Conversion);
                actualizar_pantalla("" + Conversion + "");
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                double Conversion = Num1 * Math.PI / 180.0;
                Resultado = Math.Tan(Conversion);
                actualizar_pantalla("" + Conversion + "");
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                double Logaritmo = Math.Log10(Num1);
                actualizar_pantalla("" + Logaritmo + "");    
            }
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                double Logaritmo = Math.Log(Num1);
                actualizar_pantalla("" + Logaritmo + "");
            }
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            Num1 = obtener_valor();
            //Num2 = obtener_valor2();
            Resultado = Math.Pow(Num1, Num2);
            actualizar_pantalla("" + Resultado + "");
        }


            private void btnC_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;     //actualizamos el valor de la variable de control
                Operacion = 0;      //"0" indicará la operacion matematica "suma"
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operacion == 0)     //Si se ha presionado el boton de la "suma"
                {
                    Num2 = obtener_valor(); //Para obtener el segundo valor de la operacion suma
                    actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                    Is1 = false;
                }
                else
                {
                    MessageBox.Show("Seleccione una operacion para realizar");
                }
            }

            catch
            {
                MessageBox.Show("Esta operacion requiere dos operandos");
            }
        }

        public double operar(double operador1, double operador2, String signo)
        {
            double Resultado = 0.0;
            switch (signo)
            {
                case "+":
                    Resultado = operador1 + operador2;
                    break;

                case "-":
                    Resultado = operador1 - operador2;
                    break;

                case "*":
                    Resultado = operador1 * operador2;
                    break;

                case "/":
                    Resultado = operador1 / operador2;
                    break;

                case "x":
                    Resultado = Math.Pow(operador1, operador2);
                    break;


                default:
                    break;
            }
            return Resultado;
        }
    }
}
