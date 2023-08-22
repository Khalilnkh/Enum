using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometryHelper.Kvadrat(2);
            GeometryHelper.Ucbucag(2,4);
            GeometryHelper.Daire(2,5);


        }
    }
    public static class GeometryHelper
    {
        public static decimal Kvadrat(decimal a)
        {
            decimal s = a * a;
            return s;
        }
        public static decimal Ucbucag(decimal a,decimal h)
        {
            decimal s = a * h / 2;
            return s;   
        }
        public static decimal Daire(decimal r,decimal p)
        {
            decimal s=p*(r*r);
            return s;
        }
    }
}
