using System;

namespace ChequePorExtenso
{
    public class ConversorBilhoes : Numeros
    {
        public String ConverteBilhoes(string numero)
        {
            char[] numeroChar = numero.ToCharArray();
            if (numeroChar[0].Equals('0') && numeroChar[1].Equals('0') && numeroChar[0].Equals('0'))
                return "";


            if (numeroChar.Length == 12)
            {
                if (numeroChar[1].Equals('0'))
                {
                    if (numeroChar[2].Equals('0'))
                        return $"{RetornaCentenas(numeroChar[0])} bilhões";
                    else
                        return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaUnidades(numeroChar[2])} bilhões";
                }
                else
                {
                    if (numeroChar[1].Equals('1'))
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} bilhões";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaPrimeirasDezenas(numeroChar[2])} bilhões";
                    }
                    else
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} bilhões";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} e {RetornaUnidades(numeroChar[2])} bilhões";
                    }
                }
            }
            else if (numeroChar.Length == 11)
            {
                if (numeroChar[1].Equals('0'))
                    return $"{RetornaDezenas(numeroChar[0])} bilhões";

                else if (numeroChar[0].Equals('1'))
                    return $"{RetornaPrimeirasDezenas(numeroChar[1])} bilhões";

                else
                    return $"{RetornaDezenas(numeroChar[0])} e {RetornaUnidades(numeroChar[1])} bilhões";
            }
            else if (numeroChar.Length == 10)
            {
                if (numeroChar[0].Equals('1'))
                    return $"{RetornaUnidades(numeroChar[0])} bilhão";

                else if (!(numeroChar[0].Equals('0')))
                    return $"{RetornaUnidades(numeroChar[0])} bilhões";
            }

            return "";
        }
    }
}
