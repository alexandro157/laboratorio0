namespace recuperacion.Models
{
    public class Persona
    {
        // Propiedades automáticas
        public int PersonaID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private double _age; // Campo privado para la edad

        // Propiedad para la edad con validación
        public double Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La edad no puede ser negativa.");
                }
                _age = value;
            }
        }

        // Propiedad para el lugar de nacimiento
        public string PlaceOfBirth { get; set; }
    }
}
