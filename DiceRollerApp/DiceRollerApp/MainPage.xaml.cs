using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiceRollerApp
{
    public partial class MainPage : ContentPage
    {
        int randomValue;

        Label label;


        public MainPage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("DiceRollerApp.images.diegeneral.png");
            label = (Label)FindByName("number");

            label.Text = "Random Number";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            randomValue = new Random().Next(1, 7);
            image.Source = ImageSource.FromResource("DiceRollerApp.images.dice" + randomValue + ".png");
            label.Text = " " + randomValue;
        }
    }
}
