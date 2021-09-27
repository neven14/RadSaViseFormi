using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaViseFormi
{
    class Student
    {
        private string ime, prezime, brojIndeksa, smjer;
        DateTime datumRodenja;

        public Student(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.smjer = smjer;
            this.datumRodenja = datumRodenja;
        }
    }
}
