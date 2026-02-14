namespace JH_Manager
{
    struct Numb
    {
        public int million, millier, centaine, dizaine;
    }
    internal class Alphabet
    {
        private static Numb Composition(long n)
        {
            Numb numb = new Numb()
            {
                million = (int)(n / 1000000),
                millier = (int)(n % 1000000) / 1000,
                centaine = (int)((n % 1000000) % 1000) / 100,
                dizaine = (int)((n % 1000000) % 1000) % 100
            };

            return numb;
        }

        private static string ToDizaine(int n)
        {
            string str = "";
            switch (n)
            {
                case 1:
                    str = "un ";
                    break;
                case 2:
                    str = "deux ";
                    break;
                case 3:
                    str = "troix ";
                    break;
                case 4:
                    str = "quatre ";
                    break;
                case 5:
                    str = "cinq ";
                    break;
                case 6:
                    str = "six ";
                    break;
                case 7:
                    str = "sept ";
                    break;
                case 8:
                    str = "huit ";
                    break;
                case 9:
                    str = "neuf ";
                    break;
                case 10:
                    str = "dix ";
                    break;
                case 11:
                    str = "onze ";
                    break;
                case 12:
                    str = "douze ";
                    break;
                case 13:
                    str = "treize ";
                    break;
                case 14:
                    str = "quatorze ";
                    break;
                case 15:
                    str = "quinze ";
                    break;
                case 16:
                    str = "seize ";
                    break;
                case 17:
                    str = "dix-sept ";
                    break;
                case 18:
                    str = "dix-huit ";
                    break;
                case 19:
                    str = "dix-neuf ";
                    break;
                default:
                    str = "";
                    break;
            }
            return str;
        }

        private static string TransformDictionary(int n)
        {
            string str = "";
            // 0 -> 19
            if (n >= 0 && n < 20) return ToDizaine(n);
            else if (n >= 20 && n < 30) // 20 -> 29
                str += "vingt";
            else if (n >= 30 && n < 40) // 30 -> 39
                str += "trente";
            else if (n >= 40 && n < 50) // 40 -> 49
                str += "quarante";
            else if (n >= 50 && n < 60) // 50 -> 59
                str += "cinquante";
            else if (n >= 60 && n < 70 || n >= 70 && n < 80) // 60 -> 79
                str += "soixante";
            else if (n >= 80 && n < 90 || n >= 90 && n < 100) // 80 -> 99
                str += "quatre-vingt";
            else if (n >= 100 && n < 1000)
            {
                Numb comp = Composition(n);
                if (comp.centaine == 1) str += $"cent {TransformDictionary(comp.dizaine)}";
                else str += $"{ToDizaine(comp.centaine)}cent {TransformDictionary(comp.dizaine)}";
            }
            else
            {
                Numb comp = Composition(n);
                str += $"{ToMillier(comp)} ";
            }

            if (n % 10 == 0 && n < 100)
                str += ' ';
            else if (n >= 70 && n < 80 || n >= 90 && n < 100)
                str += '-' + ToDizaine(n % 10 + 10);
            else if (n < 100) str += '-' + ToDizaine(n % 10);


            return str;
        }

        private static string ToMillier(Numb number)
        {
            string str = "";

            if (number.million > 0) str += $"{TransformDictionary(number.million)}million ";

            if (number.millier == 1) str += "mille ";
            else if (number.millier > 0) str += $"{TransformDictionary(number.millier)}mille ";

            if (number.centaine == 1) str += "cent ";
            else if (number.centaine > 0) str += $"{TransformDictionary(number.centaine)}cent ";

            if (number.dizaine > 0) str += $"{TransformDictionary(number.dizaine)}";

            return str;
        }
        public static string NumberToAlphabet(long n)
        {
            string str = ToMillier(Composition(n));

            return str;
        }
    }
}
