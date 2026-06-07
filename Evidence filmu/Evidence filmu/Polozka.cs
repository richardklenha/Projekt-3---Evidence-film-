using System;

namespace Evidence_filmu
{
    public class Polozka
    {
        // Klasické vlastnosti, co o tom filmu/knize chceme vědět
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int Delka { get; set; } // počet stran nebo minut
        public int Hodnoceni { get; set; } // třeba 1 až 5 hvězd
        public bool Precteno { get; set; }

        // Funkce na kontrolu, jestli uživatel nezadal blbost
        public static bool JeVstupVPoradku(string nazev, string delkaText, out string chyba)
        {
            chyba = "";

            // Kontrola, jestli tam vůbec něco napsal
            if (string.IsNullOrWhiteSpace(nazev))
            {
                chyba = "Musíš zadat název!";
                return false;
            }

            // Kontrola, jestli je délka fakt číslo a ne písmena
            if (!int.TryParse(delkaText, out int vyslednaDelka) || vyslednaDelka <= 0)
            {
                chyba = "Délka musí být číslo a větší než 0!";
                return false;
            }

            return true; // Všechno je cajk
        }
    }
}