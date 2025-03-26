using System;

namespace Bridge
{
    /// <summary>
    /// Repræsenterer en motorcykel (MC), der kan bruges til brobetaling.
    /// Nedarver fra <see cref="Vehicle"/>-klassen.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returnerer prisen for en motorcykel, der krydser broen.
        /// Prisen er fastsat til 120 kr.
        /// </summary>
        /// <returns>En double-værdi på 120, som repræsenterer prisen.</returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returnerer typen af køretøj.
        /// </summary>
        /// <returns>En streng, der angiver køretøjstypen "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
