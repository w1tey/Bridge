using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface WebPage
    {
        string Title { get; set; }
        ITheme Theme { get; set; }

        public void printColor();

    }

    public class GamingPage : WebPage
    {
        public string Title { get; set; }
        public ITheme Theme { get; set; }

        public GamingPage(string _Title, string _Theme)
        {
            Title = _Title;

            if (_Theme == "Black")
            {
                Theme = new BlackTheme();
            }

            else if (_Theme == "White")
            {
                Theme = new WhiteTheme();
            }

            else if (_Theme == "Grey")
            {
                Theme = new GreyTheme();
            }

            else
            {
                Theme = new RandomColorTheme();
            }
        }

        public void printColor()
        {
            Console.WriteLine($"Theme: {Theme.Color} Title: {Title}");
        }
    }

    public class ShoppingPage : WebPage
    {
        public string Title { get; set; }
        public ITheme Theme { get; set; }

        public ShoppingPage(string _Title, string _Theme)
        {
            Title = _Title;

            if (_Theme == "Black")
            {
                Theme = new BlackTheme();
            }

            else if (_Theme == "White")
            {
                Theme = new WhiteTheme();
            }

            else if (_Theme == "Grey")
            {
                Theme = new GreyTheme();
            }

            else
            {
                Theme = new RandomColorTheme();
            }
        }

        public void printColor()
        {
            Console.WriteLine($"Theme: {Theme.Color} Title: {Title}");
        }
    }

    public class MerchPage : WebPage
    {
        public string Title { get; set; }
        public ITheme Theme { get; set; }

        public MerchPage(string _Title, string _Theme)
        {
            Title = _Title;

            if (_Theme == "Black")
            {
                Theme = new BlackTheme();
            }

            else if (_Theme == "White")
            {
                Theme = new WhiteTheme();
            }

            else if (_Theme == "Grey")
            {
                Theme = new GreyTheme();
            }

            else
            {
                Theme = new RandomColorTheme();
            }
        }

        public void printColor()
        {
            Console.WriteLine($"Theme: {Theme.Color} Title: {Title}");
        }
    }



    public interface ITheme
    {
        string Color { get; set; }

    }


    public class BlackTheme : ITheme
    {
        public string Color { get; set; }

        public BlackTheme()
        {
            Color = "Black";
        }
    }

    public class WhiteTheme : ITheme
    {
        public string Color { get; set; }

        public WhiteTheme()
        {
            Color = "White";
        }
    }

    public class GreyTheme : ITheme
    {
        public string Color { get; set; }

        public GreyTheme()
        {
            Color = "Grey";
        }
    }

    public class RandomColorTheme : ITheme
    {
        public string Color { get; set; }

        public RandomColorTheme()
        {
            Color = "Multicolor";
        }
    }
}
