using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace diary2
{
    public partial class listPage : Page
    {
        public listPage()
        {
            InitializeComponent();

            foodControl first = new foodControl();
            Uri burger = new Uri("burgerring.png", UriKind.Relative);
            first.nameBlck.Text = "БУРГЕР РИНГ";
            first.img.Source = new BitmapImage(burger);
            foodControl second = new foodControl();
            Uri meat = new Uri("meat.png", UriKind.Relative);
            second.img.Source = new BitmapImage(meat);
            second.nameBlck.Text = "Мясо";
            foodControl third = new foodControl();
            Uri fish = new Uri("fish.png", UriKind.Relative);
            third.img.Source = new BitmapImage(fish);
            third.nameBlck.Text = "Рыба";

            List<foodControl> food = new List<foodControl>() { first, second, third };
            productsLbx.ItemsSource = food;
        }

        private void returnBtn_Click(object sender, RoutedEventArgs e)
        {
            listFrame.Content = new diaryPage();
        }
    }
}
