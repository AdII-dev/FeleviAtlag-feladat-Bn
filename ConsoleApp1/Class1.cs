using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Adat
    {
        string TanuloNeve { get; set; }
        int OktatasiAzonosito { get; set; }
        int Halozatok1 { get; set; }
        int Halozatok2 { get; set; }
        int Programozas { get; set; }
        int ProgramozasGyakorlat {  get; set; }
        int AngolNyelv { get; set; }
        int MagyarNyelvÉsIrodalom { get; set; }
        int Matematika { get; set; }
        int Tortenelem { get; set; }

        public Adat(string sor) {
        var m = sor.Split(' ');
           
            TanuloNeve = m[0];
            OktatasiAzonosito = Convert.ToInt32(m[1]);
            Halozatok1 = Convert.ToInt32(m[2]);
            Halozatok2 = Convert.ToInt32(m[3]);
            Programozas = Convert.ToInt32(m[4]);
            ProgramozasGyakorlat = Convert.ToInt32(m[5]);
            AngolNyelv = Convert.ToInt32(m[6]);
            MagyarNyelvÉsIrodalom = Convert.ToInt32(m[7]);
            Matematika = Convert.ToInt32(m[8]);
            Tortenelem = Convert.ToInt32(m[9]);
            
        }

    }
}
