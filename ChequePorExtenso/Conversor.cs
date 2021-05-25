using System;
using System.Globalization;
using System.Linq;

namespace ChequePorExtenso
{
    public class Conversor
    {
        private string numeroExtenso = "";
        private double numero;

        ConversorCentavos convCentavos = new ConversorCentavos();
        ConversorReais convReais = new ConversorReais();
        ConversorMilhares convMilhares = new ConversorMilhares();
        ConversorMilhoes convMilhoes = new ConversorMilhoes();
        ConversorBilhoes convBilhoes = new ConversorBilhoes();

        public String Converte(object valor)
        {
            if (ValidadorEntrada(valor))
            {
                numero = Convert.ToDouble(valor.ToString());
                String numeroString = numero.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"));
                Console.Write($"R${numeroString} : ");
                string[] separadosCentavosDoReal = numeroString.Split(',');

                string reaisStr = separadosCentavosDoReal[0];
                string centavos = separadosCentavosDoReal[1];
                double reaisDoub = Convert.ToDouble(reaisStr);
                reaisStr = Convert.ToString(reaisDoub);
                char[] numeroChar = reaisStr.ToCharArray();

                if (reaisStr.Length == 1 && reaisStr.Equals("0"))
                    numeroExtenso += $"{convCentavos.ConverteCentavos(centavos)} de real";
                else
                {

                    if (reaisStr.Length <= 12 && reaisStr.Length >= 10)
                    {

                        numeroExtenso += $"{convBilhoes.ConverteBilhoes(reaisStr)} ";
                        #region Remover elementos já escritos
                        if (reaisStr.Length == 12)
                            numeroChar = RemoveTresElementos(numeroChar);
                        else if (reaisStr.Length == 11)
                            numeroChar = RemoveDoisElementos(numeroChar);
                        else if (reaisStr.Length == 10)
                            numeroChar = RemoveUmElemento(numeroChar);
                        reaisStr = new string(numeroChar);
                        #endregion
                    }

                    if (reaisStr.Length <= 9 && reaisStr.Length >= 7)
                    {
                        if (numeroChar.Length == 9 && ((numeroChar[0]).Equals('0')) && ((numeroChar[1]).Equals('0')) && ((numeroChar[2]).Equals('0')))
                            numeroExtenso += "";
                        else
                            numeroExtenso += $"{convMilhoes.ConverteMilhoes(reaisStr)} ";
                        #region Remover elementos já escritos
                        if (reaisStr.Length == 9)
                            numeroChar = RemoveTresElementos(numeroChar);
                        else if (reaisStr.Length == 8)
                            numeroChar = RemoveDoisElementos(numeroChar);
                        else if (reaisStr.Length == 7)
                            numeroChar = RemoveUmElemento(numeroChar);
                        reaisStr = new string(numeroChar);
                        #endregion
                    }

                    if (reaisStr.Length <= 6 && reaisStr.Length >= 4)
                    {
                        if (numeroChar.Length == 6 && ((numeroChar[0]).Equals('0')) && ((numeroChar[1]).Equals('0')) && ((numeroChar[2]).Equals('0')))
                            numeroExtenso += "";
                        else
                            numeroExtenso += $"{convMilhares.ConverteMilhares(reaisStr)} ";

                        #region Remover elementos já escritos
                        if (reaisStr.Length == 6)
                            numeroChar = RemoveTresElementos(numeroChar);
                        else if (reaisStr.Length == 5)
                            numeroChar = RemoveDoisElementos(numeroChar);
                        else if (reaisStr.Length == 4)
                            numeroChar = RemoveUmElemento(numeroChar);
                        reaisStr = new string(numeroChar);
                        #endregion
                    }

                    if (reaisStr.Length <= 3)
                        numeroExtenso += $"{convReais.ConverteReais(reaisStr)}";

                    if (centavos != "00")
                        numeroExtenso += $" e {convCentavos.ConverteCentavos(centavos)}";
                }





                return numeroExtenso;
            }
            else
            {
                return "Entrada Inválida";
            }
        }
        #region Métodos privados
        private bool ValidadorEntrada(object valor)
        {
            bool resultado = true;
            string valorAux = valor.ToString();


            if (!(Double.TryParse(valorAux, out double var)))
                resultado = false;
            else if ((valor.Equals("0")))
                resultado = false;
            else if (Convert.ToDouble(valorAux) > 999999999999)
                resultado = false;
            return resultado;

        }

        private char[] RemoveUmElemento(char[] charArr)
        {
            charArr = charArr.Where((source, index) => index != 0).ToArray();
            return charArr;
        }

        private char[] RemoveDoisElementos(char[] charArr)
        {
            charArr = charArr.Where((source, index) => index != 0).ToArray();
            charArr = charArr.Where((source, index) => index != 0).ToArray();
            return charArr;
        }

        private char[] RemoveTresElementos(char[] charArr)
        {
            charArr = charArr.Where((source, index) => index != 0).ToArray();
            charArr = charArr.Where((source, index) => index != 0).ToArray();
            charArr = charArr.Where((source, index) => index != 0).ToArray();
            return charArr;
        }
        #endregion

    }
}
