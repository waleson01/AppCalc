using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCALC
{
    public partial class MainPage : ContentPage
    {
        string operacao = null, para_aparecer_no_visor = "";

        double memoria_de_calculo_pre_operacao = 0.0;
        double memoria_de_calculo_pos_operacao = 0.0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" || para_aparecer_no_visor == "-" || para_aparecer_no_visor == "*" || para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor = " ";
            }

        }

        private void btn_igual(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pos_operacao = Convert.ToDouble(visor.Text);

                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoria_de_calculo_pre_operacao + memoria_de_calculo_pos_operacao;
                        break;
                    case "-":
                        resultado = memoria_de_calculo_pre_operacao - memoria_de_calculo_pos_operacao;
                        break;
                    case "*":
                        resultado = memoria_de_calculo_pre_operacao * memoria_de_calculo_pos_operacao;
                        break;
                    case "/":
                        resultado = memoria_de_calculo_pre_operacao / memoria_de_calculo_pos_operacao;
                        break;
                }

                visor.Text = resultado.ToString();

            }
            catch(Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_somar(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);
                para_aparecer_no_visor = "+";
                operacao = "+";
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_subtrair(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);
                para_aparecer_no_visor = "-";
                operacao = "-";
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_multiplicar(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);
                para_aparecer_no_visor = "*";
                operacao = "*";
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_dividir(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);
                para_aparecer_no_visor = "/";
                operacao = "/";
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_zerar(object sender, EventArgs e)
        {
            try
            {

                visor.Text = "0";
                para_aparecer_no_visor = "";
                memoria_de_calculo_pos_operacao = 0.0;
                memoria_de_calculo_pre_operacao = 0.0;
                operacao = null;
            }
            catch(Exception ex)
            {
                visor.Text = ex.Message;
            }
           
         }

        private void btn_maismenos(object sender, EventArgs e)
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);

                valor_visor = valor_visor * -1;
                visor.Text = valor_visor.ToString();
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_porcento(object sender, EventArgs e)
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);

                valor_visor = valor_visor / 100;
                visor.Text = valor_visor.ToString();
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_ponto (object sender, EventArgs e)
        {
            try
            {
             para_aparecer_no_visor += ponto.Text;
             visor.Text = para_aparecer_no_visor;
            }
           catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }
         private void btn_0 (object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num0.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_1(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num1.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_2(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num2.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_3(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num3.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_4(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num4.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_5(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num5.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_6(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num6.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_7(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num7.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_8(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num8.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void btn_9(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();

                para_aparecer_no_visor += num9.Text;
                visor.Text = para_aparecer_no_visor;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

    }
}
