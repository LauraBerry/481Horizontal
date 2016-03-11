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
    /// Interaction logic for CreateNewGarden.xaml
    /// </summary>
    public partial class CreateNewGarden : UserControl, Switchable
    {
        public CreateNewGarden()
        {
            this.InitializeComponent();
        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion
        private void GardenName_TextChanged(object sender, TextChangedEventArgs e)
        {
            GardenName.Text = "";
        }
    }
}
