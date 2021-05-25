using System;

namespace ChequePorExtenso
{
    public class ConversorMilhares : Numeros
    {
        public String ConverteMilhares(string numero)
        {
            char[] numeroChar = numero.ToCharArray();
            if (numeroChar[0].Equals('0') && numeroChar[1].Equals('0') && numeroChar[0].Equals('0'))
                return "";


            if (numeroChar.Length == 6)
            {
                if (numeroChar[1].Equals('0'))
                {
                    if (numeroChar[2].Equals('0'))
                        return $"{RetornaCentenas(numeroChar[0])} mil";
                    else
                        return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaUnidades(numeroChar[2])} mil";
                }
                else
                {
                    if (numeroChar[1].Equals('1'))
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} mil";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaPrimeirasDezenas(numeroChar[2])} mil";
                    }
                    else
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} mil";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} e {RetornaUnidades(numeroChar[2])} mil";
                    }
                }
            }
            else if (numeroChar.Length == 5)
            {
                if (numeroChar[1].Equals('0'))
                    return $"{RetornaDezenas(numeroChar[0])} mil";
                else if (numeroChar[0].Equals('1'))
                    return $"{RetornaPrimeirasDezenas(numeroChar[1])} mil";
                else
                    return $"{RetornaDezenas(numeroChar[0])} e {RetornaUnidades(numeroChar[1])} mil";
            }
            else if (numeroChar.Length == 4)
            {
                if (numeroChar[0].Equals('1'))
                    return $"{RetornaUnidades(numeroChar[0])} mil";
                else if (!(numeroChar[0].Equals('0')))
                    return $"{RetornaUnidades(numeroChar[0])} mil";
            }

            return "";
        }
    }
}
