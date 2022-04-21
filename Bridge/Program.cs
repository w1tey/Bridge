using System;

namespace Bridge
{
    public static class Program
    {
        public static void Main()
        {
            GamingPage page = new("Lets Go", "Grey");

            page.printColor();
        }
    }
}