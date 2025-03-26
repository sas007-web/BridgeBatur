using System;

namespace Bridge
{
    /// <summary>
    /// Repræsenterer et generisk køretøj, der kan bruges til brobillettering.
    /// Denne klasse fungerer som en basisklasse for specifikke køretøjstyper som biler og motorcykler.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Privat felt til at gemme nummerpladen.
        /// </summary>
        private string _LicensPlate;

        /// <summary>
        /// Henter eller sætter køretøjets nummerplade.
        /// Nummerpladen må højst være 7 tegn lang, ellers kastes en undtagelse.
        /// </summary>
        /// <exception cref="ArgumentException">Kastes hvis nummerpladen er længere end 7 tegn.</exception>
        public string LicensePlate
        {
            get => _LicensPlate;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                _LicensPlate = value; // Rettelse: Korrekt tildeling af værdi
            }



        }

        /// <summary>
        /// Henter eller sætter datoen for, hvornår køretøjet registreres til brokørsel.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Abstrakt metode, der skal implementeres i afledte klasser.
        /// Returnerer prisen for at krydse broen.
        /// </summary>
        /// <returns>En double-værdi, der repræsenterer billetprisen.</returns>
        public abstract double Price();

        /// <summary>
        /// Abstrakt metode, der skal implementeres i afledte klasser.
        /// Returnerer typen af køretøj.
        /// </summary>
        /// <returns>En streng, der angiver køretøjstypen.</returns>
        public abstract string VehicleType();

        /// <summary>
        /// Angiver, om køretøjet har en BroBizz-enhed.
        /// Hvis denne værdi er sand (true), får køretøjet 10% rabat på billetprisen.
        /// </summary>
        public bool HasBroBizz { get; set; }

        /// <summary>
        /// Beregner den endelige billetpris.
        /// Hvis køretøjet har en BroBizz, gives der 10% rabat.
        /// </summary>
        /// <returns>Den endelige pris efter eventuel rabat.</returns>
        public double GetPrice()
        {
            double price = Price();
            if (HasBroBizz)
            {
                price *= 0.9; // Anvend 10% rabat, hvis BroBizz bruges
            }
            return price;
        }
    }
    public string navn { get; set; }
    }
}
