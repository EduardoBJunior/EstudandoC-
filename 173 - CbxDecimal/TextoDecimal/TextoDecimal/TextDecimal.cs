using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextoDecimal
{
    class TextDecimal : TextBox
    {
        //enumeracao da virgula  e do poonto

        public enum EnumSeparador
        {
            Virgula,
            Ponto
        }

        //propiedades (campos)
        private double _minvalor = 0;
        private double _maxvalor = 100;
        private bool _permitirDecimais = true;
        private int _numeroCasasDecimais = 2;
        private double _valorPadrao = 0;
        private EnumSeparador _separador = EnumSeparador.Virgula;

        #region operacionalizção das propriedades

        //valor minimo
        public double ValorMinimo
        {
            get { return _minvalor; }
            set { _minvalor = value; }
        }
        //valor maximo 
        public double ValorMaximo
        {
            get { return _maxvalor; }
            set { _maxvalor = value; }
        }
        //permitir casas decimais
        public bool PermitirDecimais
        {
            get { return _permitirDecimais; }
            set { _permitirDecimais = value; }
        }
        //numero de digitos casas decimal
        public int NumeroCasasDecimais
        {
            get { return _numeroCasasDecimais; }
            set { _numeroCasasDecimais = value; }
        }
        //valor padrão
        public double ValorPorPadrao
        {
            get { return _valorPadrao; }
            set { _valorPadrao = value; }
        }

        //define o tipo de caractere separador no decimal
        public EnumSeparador SeparadorDecimal
        {
            get { return _separador; }    
            set { _separador = value; }    
        }
        #endregion



        public TextDecimal()
        {
            //Eventos do controle (Caixa de texto com caixas decimais)

            this.KeyPress += TextDecimal_KeyPress;
            this.LostFocus += TextDecimal_LostFocus;
            this.TextChanged += TextDecimal_TextChanged;
        }

        private void TextDecimal_TextChanged(object sender, EventArgs e)
        {
            //verificar verificações quando o texto é alterado
            if (this.Focused) return;
            if (this.Text == "") return;

            // verificar se o valor atribuido a caixa esta dentro do limite
            try
            {
                double valor = double.Parse(this.Text);
                //verifica se o valor é inferior ao minimo
                if (valor < _minvalor)
                {
                    valor = _minvalor;
                    this.Text = valor.ToString();
                    TextDecimal_LostFocus(this, EventArgs.Empty);
                    return;
                }
                //verifica se o valor é superior ao maximo
                if (valor > _maxvalor)
                {
                    valor = _maxvalor;
                    this.Text = valor.ToString();
                    TextDecimal_LostFocus(this, EventArgs.Empty);
                    return;
                }

            }
            catch (Exception)
            {

                this.Text = _valorPadrao.ToString();
            } 
                
            

        }

        private void TextDecimal_LostFocus(object sender, EventArgs e)
        {
            //executar operações quando a caixa perde o focus

            if (this.Text == "") return;

            //-----------------------------------------------------------------

            #region Verifica qual é o separador

            char separador = ',';

            if (_separador == EnumSeparador.Ponto) separador = '.';

            #endregion
            //-----------------------------------------------------------------

            #region Substitui o separador caso ele exista na caixa e seja diferente do selecionado 

            if (separador == ',')
            {
                this.Text = this.Text.Replace('.', ',');
            }
            else
            {
                this.Text = this.Text.Replace(',', '.');
            }

            #endregion

            //-----------------------------------------------------------------

            #region se o valor inserido for apenas um separador

            if (this.Text == separador.ToString())
            {
                this.Text = ValorPorPadrao.ToString();
            }

            #endregion

            //-----------------------------------------------------------------

            #region Caso tenha casa decimais verifica se então corretas

            if(_permitirDecimais && this.Text.Contains(separador))
            {
                //se o número de casas decimais não é valido 
                string[] valores = this.Text.Split(separador);

                // se o número de casas decimais é inferior ao definido
                if(valores[1].Length< _numeroCasasDecimais)
                {
                    int emFalta = _numeroCasasDecimais - valores[1].Length;
                    valores[1] = valores[1] + new string('0', emFalta);
                    this.Text = valores[0] + separador + valores[1];
                }

                //se o numero de casas decimais é superior ao defini
                if(valores[1].Length > _numeroCasasDecimais)
                {
                    double resultado = Math.Round(double.Parse(this.Text), _numeroCasasDecimais);
                    this.Text = resultado.ToString();
                }
            }

            #endregion

            //-----------------------------------------------------------------

            #region Se a string comessar com sinal negativo mas contel em seguida coloque o separador
            if (this.Text.Contains('-'))
            {
                int loc = this.Text.IndexOf('-');
                if (loc!= 0)
                {
                    this.Text = "0";
                }
            }
            #endregion

            //-----------------------------------------------------------------

            double valor = double.Parse(this.Text);
            this.Text = valor.ToString();
            //-----------------------------------------------------------------

            #region verifica se foi respeitado o limite minimo e maximo
            if (valor < _minvalor)
            {
                this.Text = _minvalor.ToString();
                TextDecimal_LostFocus(this, EventArgs.Empty);

            }
            if (valor >_maxvalor)
            {
                this.Text = _maxvalor.ToString();
                TextDecimal_LostFocus(this, EventArgs.Empty);
            }

            #endregion


        }

        private void TextDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {

            //-----------------------------------------------------------------
            # region executar operações quando o utilizador pressiona teclas
            //definir as teclas aceitaveis no campo
            int[] codigosTeclas;

            if (_permitirDecimais)
            {
                codigosTeclas = new int[] { 44, 45, 46, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8 };
                
            }
            else
            {
                codigosTeclas = new int[] { 45, 46, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8 };
            }
            #endregion
            //-----------------------------------------------------------------
            #region verifica se o caractere é valido

            if (!codigosTeclas.Contains(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            #endregion

            //-----------------------------------------------------------------

            #region Verifica o separador
            if (_permitirDecimais)
            {
                char valido = ',';
                char invalido = '.';

                if (_separador == EnumSeparador.Ponto)
                {
                    valido = '.';
                    invalido = ',';
                }

                //verifica se pode ser inserido o separador
                if (e.KeyChar == valido || e.KeyChar == invalido)
                {
                    if (this.Text.Contains(valido))
                    {

                        e.Handled = true;
                        return;
                    }
                }

                //verifica se é necessario subtituir o separador

                if (e.KeyChar == invalido)
                {
                    e.KeyChar = valido;
                }

            }


            #endregion

            //-----------------------------------------------------------------

            #region verificar se ja tem sinal negativo

            if (this.Text.Contains('-') && e.KeyChar =='-')
            {
                e.Handled = true;
                return;
            }

            #endregion

            //-----------------------------------------------------------------

            #region verifica se esta tentabdi cikicar un subak negativo apos separador
            char CharValido = _separador == EnumSeparador.Virgula ? ',' : '.';

            if (this.Text.Contains(CharValido))
            {
                if (this.Text.IndexOf(CharValido) < this.SelectionStart && e.KeyChar == '-')
                {
                    e.Handled = true;
                    return;
                 }
            }

            #endregion
        }
    }
}