using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace youtility
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ifire : ContentPage
    {
        public Ifire()
        {
            InitializeComponent();

            var assembly = typeof(Ifire);
            iconImages.Source = ImageSource.FromResource("youtility.Assets.iFire.png", assembly);
            
        }

        private void Cal_Clicked(object sender, EventArgs e)
        {
            double a = Double.Parse(Udgifter.Text);
            double b = a * 12 / 0.04;

            res.Text = ("Portefølje Størrelse" + " " + b + " " + "kr.").ToString();
        }
    }
}