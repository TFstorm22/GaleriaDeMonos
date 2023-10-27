using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(Monkey selectedMonkey)
        {
            // Display the selected monkey's details
            InitializeComponent();            // Display the selected monkey's details
            NameLabel.Text = selectedMonkey.Name;
            LocationLabel.Text = selectedMonkey.Location;
            DescriptionLabel.Text = selectedMonkey.Description;
            MonkeyImage.Source = selectedMonkey.ImageUrl;
        }
    }
}