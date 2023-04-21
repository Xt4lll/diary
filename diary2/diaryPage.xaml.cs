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
    
    public partial class diaryPage : Page
    {
        public diaryPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            diaryFrame.Content = new listPage();
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            date.DisplayDate.AddMonths(1);
        }
    }
}
