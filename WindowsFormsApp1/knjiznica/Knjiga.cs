using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznica
{
    public class Knjiga
    {
        public int ID { get; set; } 
        public string Naslov { get; set; } 
        public string Autor { get; set; } 
        public int GodinaIzdavanja { get; set; } 

        
        public void PrikaziInformacije()
        {
            Console.WriteLine($"ID: {ID}, Naslov: {Naslov}, Autor: {Autor}, Godina: {GodinaIzdavanja}");
        }
    }
}
