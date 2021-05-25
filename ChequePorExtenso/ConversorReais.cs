using System;

namespace ChequePorExtenso
{
    public class ConversorReais : Numeros
    {
        public String ConverteReais(string numero)
        {
            char[] numeroChar = numero.ToCharArray();

            if (numeroChar.Length == 3)
            {
                if (numeroChar[0].Equals('0') && numeroChar[1].Equals('0') && numeroChar[0].Equals('0'))
                    return "reais";
            }

            if (numeroChar.Length == 3)
            {
                if (numeroChar[1].Equals('0'))
                {
                    if (numeroChar[2].Equals('0'))
                        return $"{RetornaCentenas(numeroChar[0])} reais";
                    else
                        return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaUnidades(numeroChar[2])} reais";
                }
                else
                {
                    if (numeroChar[1].Equals('1'))
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} reais";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaPrimeirasDezenas(numeroChar[2])} reais";
                    }
                    else
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} reais";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} e {RetornaUnidades(numeroChar[2])} reais";
                    }
                }
            }
            else if (numeroChar.Length == 2)
            {
                if (numeroChar[1].Equals('0'))
                    return $"{RetornaDezenas(numeroChar[0])} reais";
                else if (numeroChar[0].Equals('1'))
                    return $"{RetornaPrimeirasDezenas(numeroChar[1])} reais";
                else
                    return $"{RetornaDezenas(numeroChar[0])} e {RetornaUnidades(numeroChar[1])} reais";
            }
            else if (numeroChar.Length == 1)
            {
                if (numeroChar[0].Equals('1'))
                    return $"{RetornaUnidades(numeroChar[0])} real";
                else if (!(numeroChar[0].Equals('0')))
                    return $"{RetornaUnidades(numeroChar[0])} reais";
            }

            return "";
        }
    }
}
