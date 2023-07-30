namespace POOEjercicio3Tema1.Entidades
{
    public class Kelvin
    {
        private float _grados;
        public float GetGrados() => _grados;
        public Kelvin(float grados)
        {
            _grados = grados;
        }
        public Kelvin() : this(0) { }
        public static implicit operator float(Kelvin kelvin)
        {
            return kelvin.GetGrados();
        }
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin( c.GetGrados() +273.15f);
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetGrados() +459.67f) *5/9);
        }


        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.GetGrados() == k2.GetGrados();
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.GetGrados() + k2.GetGrados());
        }
        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.GetGrados() - k2.GetGrados());
        }
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return k + (Kelvin)c;
        }
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return k+(Kelvin)f;
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return k - (Kelvin)c;
        }
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return k-(Kelvin)f;
        }

    }
}
