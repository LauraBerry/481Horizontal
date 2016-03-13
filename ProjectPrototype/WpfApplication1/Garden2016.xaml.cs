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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Garden2016.xaml
    /// </summary>
    public partial class Garden2016 : UserControl, Switchable
    {
        public Garden2016()
        {
            this.InitializeComponent();
        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new HomeScreen());
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PlantSearch());
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new RemoveFromGarden());
        }

        private void Pomegranit_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CarrotInformationPage());
        }
    }
}
