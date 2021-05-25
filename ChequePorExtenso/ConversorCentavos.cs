using System;

namespace ChequePorExtenso
{
    public class ConversorCentavos : Numeros
    {
        public String ConverteCentavos(string numero)
        {
            char[] numeroChar = numero.ToCharArray();

            if (numeroChar[0] == '0')
            {
                if (numeroChar[1] == '1')
                    return $"{RetornaUnidades(numeroChar[1])} centavo";
                else
                    return $"{RetornaUnidades(numeroChar[1])} centavos";
            }
            else
            {
                if (numeroChar[0] == '1')
                {
                    return $"{RetornaPrimeirasDezenas(numeroChar[1])} centavos";
                }
                else
                {
                    if (numeroChar[1] == '0')
                        return $"{RetornaDezenas(numeroChar[0])} centavos";
                    else
                        return $"{RetornaDezenas(numeroChar[0])} e {RetornaUnidades(numeroChar[1])} centavos";
                }
            }
        }

    }
}
