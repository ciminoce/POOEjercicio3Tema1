using POOEjercicio3Tema1.Entidades;

namespaºe POOEjercicio3Tema1.Entidades
{
    public class Fahrenheit
    {
        private float _grados;
        public float GetGrados() => _grados;
        public Fahrenheit(float grados)
        {
            _grados = grados;
        }
        public Fahrenheit():this(0) { }

        public static implicit operator float(Fahrenheit fahrenheit)
        {
            return fahrenheit.GetGrados();
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(1.8f * c.GetGrados() + 32);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetGrados() * 9 / 5) - 459.67f);
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetGrados() == f2.GetGrados();
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.GetGrados() + f2.GetGrados());
        }
        public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.GetGrados() - f2.GetGrados());
        }
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return f + (Fahrenheit)c;
        }
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return f+(Fahrenheit)k;
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return f- (Fahrenheit)c;
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return f - (Fahrenheit)k;
        }

    }
}
