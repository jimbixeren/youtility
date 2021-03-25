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
    public partial class Convert : ContentPage
    {
        public Convert()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int tal1 = int.Parse(entryTal1.Text);
            int tal2 = int.Parse(entryTal2.Text);

            Regnemaskine plusRegnemaskine = new Regnemaskine();
            

            finalResult.Text = plusRegnemaskine.Plus(tal1, tal2);
        }

        //læg mærke til at kaldet til "minus"-metoden er lettere, fordi den er statisk. jeg skal ikke lave et "objekt" først, som jeg skal ovenover (med "new" keywordet).
        private void btnMinus_Clicked(object sender, EventArgs e)
        {
            int tal1 = int.Parse(entryTal1.Text);
            int tal2 = int.Parse(entryTal2.Text);

            finalResult.Text = Regnemaskine.Minus(tal1, tal2);
        }
    }
}