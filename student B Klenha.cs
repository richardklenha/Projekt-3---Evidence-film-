using System;

namespace MojeEvidenceApp.Models
{
    public class Polozka
    {
        
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int Delka { get; set; } 
        public int Hodnoceni { get; set; } 
        public bool Precteno { get; set; } 

        
        public static bool JeVstupVPoradku(string nazev, string delkaText, out string chyba)
        {
            chyba = "";
            
            if (string.IsNullOrWhiteSpace(nazev))
            {
                chyba = "Musíš zadat název!";
                return false; 
            }
            
            if (!int.TryParse(delkaText, out int vyslednaDelka) || vyslednaDelka <= 0)
            {
                chyba = "Délka musí být číslo a větší než 0!";
                return false;
            }
            
            return true; 
        }
    }
}