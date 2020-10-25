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

        private void igualr_Clicked(object sender, EventArgs e)
        {

        }

        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" || para_aparecer_no_visor == "-" || para_aparecer_no_visor == "*" || para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor == "";
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
                operacao "+";
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



    }
}
