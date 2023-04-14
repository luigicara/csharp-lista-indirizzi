using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            if (name == null || name == String.Empty)
                throw new ArgumentNullException(nameof(name), $"Impossibile creare Indirizzo senza");
            else
                Name = name;

            if (surname == null || surname == String.Empty)
                throw new ArgumentNullException(nameof(surname), $"Impossibile creare Indirizzo senza");
            else
                Surname = surname;

            if (street == null || street == String.Empty)
                throw new ArgumentNullException(nameof(street), $"Impossibile creare Indirizzo senza");

            if (city == null || city == String.Empty)
                throw new ArgumentNullException(nameof(city), $"Impossibile creare Indirizzo senza");
            else
                City = city;

            if (province == null || province == String.Empty)
                throw new ArgumentNullException(nameof(province), $"Impossibile creare Indirizzo senza");
            else
                Province = province;

            if (zip == null || zip == String.Empty)
                throw new ArgumentNullException(nameof(zip), $"Impossibile creare Indirizzo senza");
            else
                Zip = zip;

            if (!char.IsDigit(street[0]))
                throw new Exception($"Il campo {nameof(street)} deve iniziare per numero");
            else
                Street = street;


        }

        public override string ToString()
        {
            return Name + " " + Surname + ", " + Street + ", " + City + " (" + Province + ") " + Zip;
        }
    }
}