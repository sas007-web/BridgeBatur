namespace Bridge
{
    /// <summary>
    /// Repræsenterer en bil, der kan bruges til brobetaling.
    /// Nedarver fra <see cref="Vehicle"/>-klassen.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returnerer prisen for en bil, der krydser broen.
        /// Prisen er fastsat til 230 kr.
        /// </summary>
        /// <returns>En double-værdi på 230, som repræsenterer prisen.</returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returnerer typen af køretøj.
        /// </summary>
        /// <returns>En streng, der angiver køretøjstypen "Car".</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
