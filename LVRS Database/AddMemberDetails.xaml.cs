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

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            LVRSMEMBERSEntities context = new LVRSMEMBERSEntities();
            int memID = Int32.Parse(memberID.Text);
            if (birthDate.Text != "")
            {
                birthday tempBirthday = new birthday();
                tempBirthday.memberID = memID;
                tempBirthday.birthDate = DateTime.Parse(birthDate.Text);
                context.birthdays.Add(tempBirthday);
            }
            address tempAddress = new address();
            tempAddress.memberID = memID;
            tempAddress.addressStreet = addressStreet.Text;
            tempAddress.addressCity = addressCity.Text;
            tempAddress.addressState = addressState.Text;
            tempAddress.addressZip = Int32.Parse(addressZip.Text);

            context.addresses.Add(tempAddress);
            
            context.SaveChanges();


        }
    }
}
