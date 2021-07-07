using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iRentMe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            var timeOfDayGreeting = DateTime.Now;

            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                //Console.WriteLine("Good morning!");
                morningAnimation.IsVisible = true;
                normalAnimation.IsVisible = false;
                eveningAnimation.IsVisible = false;
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16)
            {
                //Console.WriteLine("Good afternoon!");
                morningAnimation.IsVisible = false;
                normalAnimation.IsVisible = true;
                eveningAnimation.IsVisible = false;
            }
            else
            {
                morningAnimation.IsVisible = false;
                normalAnimation.IsVisible = false;
                eveningAnimation.IsVisible = true;
                //Console.WriteLine("Good night!");
            }

            //Console.ReadKey();
        }
    }
}