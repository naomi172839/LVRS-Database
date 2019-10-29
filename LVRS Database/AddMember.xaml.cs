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
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Page
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            lastName.Text = "";
            firstName.Text = "";
            middleName.Text = "";
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            LVRSMEMBERSEntities context = new LVRSMEMBERSEntities();
            member temp = new member();
            temp.lastName = lastName.Text;
            temp.firstName = firstName.Text;
            temp.middleName = middleName.Text;

            if(temp.lastName == "" || temp.firstName == "")
            {
                MessageBox.Show("Please ensure that a value is entered for both first and last name");
            } 
            else
            {
                context.members.Add(temp);
                context.SaveChanges();

                var memberID = context.members.Where(n => n.lastName == temp.lastName)
                                                .Where(n => n.firstName == temp.firstName)
                                                .OrderByDescending(n => n.memberID)
                                                .FirstOrDefault();
                MessageBox.Show("Added Member " + temp.lastName + ", " + temp.firstName + " with MemberID " + memberID.memberID);
                lastName.Text = "";
                firstName.Text = "";
                middleName.Text = "";
            }
        }
    }
}
