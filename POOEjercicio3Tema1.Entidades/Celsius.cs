namespace POOEjercicio3Tema1.Entidades
{
    public class Celsius
    {
        private float _grados;
        public float GetGrados() => _grados;
        public Celsius(float grados)
        {
            _grados = grados;
        }
        public Celsius() : this(0) { }
        public static implicit operator float(Celsius celsius)
        {
            return celsius.GetGrados();
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetGrados() - 32) * 5 / 9);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((k.GetGrados() - 273.15f));
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.GetGrados() == c2.GetGrados();
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1==c2);
        }

        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.GetGrados()+c2.GetGrados());
        }
        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.GetGrados() - c2.GetGrados());
        }

        public static Celsius operator+(Celsius c, Fahrenheit f)
        {
            return c + (Celsius)f;
        }
        public static Celsius operator+(Celsius c, Kelvin k)
        {
            return c+(Celsius)k;
        }
        public static Celsius operator-(Celsius c, Fahrenheit f)
        {
            return c-(Celsius)f;
        }
        public static Celsius operator-(Celsius c,Kelvin k)
        {
            return c-(Celsius)k;
        }
    }
}