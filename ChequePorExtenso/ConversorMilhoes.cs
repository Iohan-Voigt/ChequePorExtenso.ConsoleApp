using System;


namespace ChequePorExtenso
{
    public class ConversorMilhoes : Numeros
    {
        public String ConverteMilhoes(string numero)
        {
            char[] numeroChar = numero.ToCharArray();
            if (numeroChar[0].Equals('0') && numeroChar[1].Equals('0') && numeroChar[0].Equals('0'))
                return "";

            if (numeroChar.Length == 9)
            {
                if (numeroChar[1].Equals('0'))
                {
                    if (numeroChar[2].Equals('0'))
                        return $"{RetornaCentenas(numeroChar[0])} milhões";
                    else
                        return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaUnidades(numeroChar[2])} milhões";
                }
                else
                {
                    if (numeroChar[1].Equals('1'))
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} milhões";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaPrimeirasDezenas(numeroChar[2])} milhões";
                    }
                    else
                    {
                        if (numeroChar[2].Equals('0'))
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} milhões";
                        else
                            return $"{RetornaPrimeirasCentenas(numeroChar[0])} e {RetornaDezenas(numeroChar[1])} e {RetornaUnidades(numeroChar[2])} milhões";
                    }
                }
            }
            else if (numeroChar.Length == 8)
            {

                if (numeroChar[1].Equals('0'))
                    return $"{RetornaDezenas(numeroChar[0])} milhões";

                else if (numeroChar[0].Equals('1'))
                    return $"{RetornaPrimeirasDezenas(numeroChar[1])} milhões";

                else
                    return $"{RetornaDezenas(numeroChar[0])} e {RetornaUnidades(numeroChar[1])} milhões";

            }
            else if (numeroChar.Length == 7)
            {
                if (numeroChar[0].Equals('1'))
                    return $"{RetornaUnidades(numeroChar[0])} milhão";

                else if (!(numeroChar[0].Equals('0')))
                    return $"{RetornaUnidades(numeroChar[0])} milhões";
            }

            return "";
        }
    }
}
