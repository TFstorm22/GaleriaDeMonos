using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }
        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
    if (e.CurrentSelection.FirstOrDefault() is Monkey selectedMonkey)
    {
        // Create a new instance of MonkeyDetailPage and pass the selected monkey
        Page1 detailPage = new Page1(selectedMonkey);

        // Navigate to the MonkeyDetailPage
        await Navigation.PushAsync(detailPage);
    }
        }
        
                
        public MainPage()
            


        {
            InitializeComponent();

            Monkeys = new List<Monkey>();
            Monkeys.Add(new Monkey
{
    Name = "Baboon",
    Location = "Africa & Asia",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
    Description = "The baboon is a type of old world monkey known for its distinctive dog-like snout and powerful jaws."
});

Monkeys.Add(new Monkey
{
    Name = "Capuchin Monkey",
    Location = "Central & South America",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg",
    Description = "Capuchin monkeys are highly intelligent and agile primates found in Central and South America."
});

Monkeys.Add(new Monkey
{
    Name = "Blue Monkey",
    Location = "Central and East Africa",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
    Description = "The blue monkey is a primate native to Central and East Africa, known for its distinctive bluish fur."
});

Monkeys.Add(new Monkey
{
    Name = "Squirrel Monkey",
    Location = "Central & South America",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg",
    Description = "Squirrel monkeys are small, agile primates with distinctive white faces and long tails, found in Central and South America."
});

Monkeys.Add(new Monkey
{
    Name = "Golden Lion Tamarin",
    Location = "Brazil",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg",
    Description = "The golden lion tamarin is a small, golden-colored monkey native to the rainforests of Brazil."
});

Monkeys.Add(new Monkey
{
    Name = "Howler Monkey",
    Location = "South America",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg",
    Description = "Howler monkeys are known for their loud howling calls and are found in the forests of South America."
});

Monkeys.Add(new Monkey
{
    Name = "Japanese Macaque",
    Location = "Japan",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg",
    Description = "Japanese macaques, also known as snow monkeys, are native to Japan and are known for their adaptation to cold climates."
});

Monkeys.Add(new Monkey
{
    Name = "Mandrill",
    Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg",
    Description = "The mandrill is a colorful and social monkey, known for its distinct facial markings, found in central Africa."
});

Monkeys.Add(new Monkey
{
    Name = "Proboscis Monkey",
    Location = "Borneo",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg",
    Description = "Proboscis monkeys are named for their large, elongated noses and are native to the island of Borneo."
});

Monkeys.Add(new Monkey
{
    Name = "Red-shanked Douc",
    Location = "Vietnam, Laos",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg",
    Description = "The red-shanked douc is a colorful and arboreal monkey found in the forests of Vietnam and Laos."
});

Monkeys.Add(new Monkey
{
    Name = "Gray-shanked Douc",
    Location = "Vietnam",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg",
    Description = "The gray-shanked douc is a primate native to Vietnam, known for its striking colors and arboreal lifestyle."
});

Monkeys.Add(new Monkey
{
    Name = "Golden Snub-nosed Monkey",
    Location = "China",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg",
    Description = "Golden snub-nosed monkeys are adapted to cold climates and are found in the mountainous regions of China."
});

Monkeys.Add(new Monkey
{
    Name = "Black Snub-nosed Monkey",
    Location = "China",
    ImageUrl = "https://upload.wikimedia.org/wikipedia.commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg",
    Description = "The black snub-nosed monkey is an arboreal primate native to China, known for its dark fur and snub nose."
});

Monkeys.Add(new Monkey
{
    Name = "Tonkin Snub-nosed Monkey",
    Location = "Vietnam",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg",
    Description = "The Tonkin snub-nosed monkey is a critically endangered primate found in northern Vietnam."
});

Monkeys.Add(new Monkey
{
    Name = "Thomas's Langur",
    Location = "Indonesia",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg",
    Description = "Thomas's langur is a leaf-eating monkey found in the rainforests of Indonesia."
});

Monkeys.Add(new Monkey
{
    Name = "Purple-faced Langur",
    Location = "Sri Lanka",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG",
    Description = "Purple-faced langurs are endemic to Sri Lanka and are known for their distinctive purple faces."
});

Monkeys.Add(new Monkey
{
    Name = "Gelada",
    Location = "Ethiopia",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg",
    Description = "Geladas, also known as bleeding-heart monkeys, are found in the Ethiopian highlands and are known for their unique appearance."
});


            BindingContext = this;
        }
    }
}