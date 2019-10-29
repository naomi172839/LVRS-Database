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

namespace LVRS_Database
{
    /// <summary>
    /// Interaction logic for AddMemberDetails.xaml
    /// </summary>
    public partial class AddMemberDetails : Page
    {
        public AddMemberDetails()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            foreach(UIElement control in all.Children)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                if (control is DatePicker)
                {
                    ((DatePicker)control).Text = "";
                }
                if (control is CheckBox)
                {
                    ((CheckBox)control).IsChecked = false;
                }
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }
    }
}
