using System;

namespace ChequePorExtenso
{
    public class Numeros
    {
        public String RetornaUnidades(char valor)
        {
            switch (valor)
            {
                case '1': return "um"; break;
                case '2': return "dois"; break;
                case '3': return "três"; break;
                case '4': return "quatro"; break;
                case '5': return "cinco"; break;
                case '6': return "seis"; break;
                case '7': return "sete"; break;
                case '8': return "oito"; break;
                case '9': return "nove"; break;
            }
            return "";
        }
        public String RetornaPrimeirasDezenas(char valor)
        {
            switch (valor)
            {
                case '0': return "dez"; break;
                case '1': return "onze"; break;
                case '2': return "doze"; break;
                case '3': return "treze"; break;
                case '4': return "quatorze"; break;
                case '5': return "quinze"; break;
                case '6': return "dezesseis"; break;
                case '7': return "dezessete"; break;
                case '8': return "dezoito"; break;
                case '9': return "dezenove"; break;
            }
            return "";
        }
        public String RetornaDezenas(char valor)
        {
            switch (valor)
            {
                case '1': return "dez"; break;
                case '2': return "vinte"; break;
                case '3': return "trinta"; break;
                case '4': return "quarenta"; break;
                case '5': return "cinquenta"; break;
                case '6': return "sessenta"; break;
                case '7': return "setenta"; break;
                case '8': return "oitenta"; break;
                case '9': return "noventa"; break;
            }
            return "";
        }

        public String RetornaPrimeirasCentenas(char valor)
        {
            switch (valor)
            {
                case '1': return "cento"; break;
                case '2': return "duzentos"; break;
                case '3': return "trezentos"; break;
                case '4': return "quatocentos"; break;
                case '5': return "quinhentos"; break;
                case '6': return "seiscentos"; break;
                case '7': return "setecentos"; break;
                case '8': return "oitocentos"; break;
                case '9': return "novecentos"; break;
            }
            return "";
        }
        public String RetornaCentenas(char valor)
        {
            switch (valor)
            {
                case '1': return "cem"; break;
                case '2': return "duzentos"; break;
                case '3': return "trezentos"; break;
                case '4': return "quatocentos"; break;
                case '5': return "quinhentos"; break;
                case '6': return "seiscentos"; break;
                case '7': return "setecentos"; break;
                case '8': return "oitocentos"; break;
                case '9': return "novecentos"; break;
            }
            return "";
        }

    }
}
