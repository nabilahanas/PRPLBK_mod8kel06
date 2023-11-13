namespace TempConvComp
{
    public class TempConvComp
    {
        public double cToR(double c)
        {
            return (double)(c * 0.8);
        }
        public double cToF(double c)
        {
            return (double)(c * 1.8 + 32);
        }
        public double cToK(double c)
        {
            return (double)(c + 273.15);
        }
        public double rToC(double r)
        {
            return (double)(r * 1.25);
        }
        public double rToF(double r)
        {
            return (double)(r * 2.25 + 32);
        }
        public double rToK(double r)
        {
            return (double)(r * 1.25 + 273.15);
        }
        public double fToC(double f)
        {
            return (double)((f - 32) * 0.56);
        }
        public double fToR(double f)
        {
            return (double)((f - 32) * 0.44);
        }
        public double fToK(double f)
        {
            return (double)((f - 32) * 0.56 + 273.15);
        }
        public double kToC(double k)
        {
            return (double)(k - 273.15);
        }
        public double kToR(double k)
        {
            return (double)((k - 273.15) * 0.8);
        }
        public double kToF(double k)
        {
            return (double)((k - 273.15) * 1.8 + 32);
        }
    }
}