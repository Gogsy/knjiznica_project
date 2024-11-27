using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica
{
    public class Knjiznica
    {
        private List<Knjiga> knjige = new List<Knjiga>(); 

        
        public void DodajKnjigu(Knjiga knjiga)
        {
            knjige.Add(knjiga);
            Console.WriteLine("Knjiga je uspješno dodana.");
        }

        
        public List<Knjiga> DohvatiSveKnjige()
        {
            return knjige;
        }

        
        public void SpremiUDatoteku(string filePath)
        {
            using (var writer = new System.IO.StreamWriter(filePath))
            {
                foreach (var knjiga in knjige)
                {
                    writer.WriteLine($"{knjiga.ID}|{knjiga.Naslov}|{knjiga.Autor}|{knjiga.GodinaIzdavanja}");
                }
            }
            Console.WriteLine("Podaci su uspješno spremljeni u datoteku.");
        }

        
        public void UcitajIzDatoteke(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                var linije = System.IO.File.ReadAllLines(filePath);
                foreach (var linija in linije)
                {
                    var podaci = linija.Split('|');
                    var knjiga = new Knjiga
                    {
                        ID = int.Parse(podaci[0]),
                        Naslov = podaci[1],
                        Autor = podaci[2],
                        GodinaIzdavanja = int.Parse(podaci[3])
                    };
                    knjige.Add(knjiga);
                }
                Console.WriteLine("Podaci su uspješno učitani iz datoteke.");
            }
            else
            {
                Console.WriteLine("Datoteka ne postoji.");
            }
        }
    }
}