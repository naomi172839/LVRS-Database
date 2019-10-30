using System;
using System.Windows;
using System.Windows.Controls;

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
            foreach (UIElement control in all.Children)
            {
                if (control is TextBox)
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

        private bool addressPresent()
        {
            if (addressStreet.Text != "") { return true; }
            if (addressCity.Text != "") { return true; }
            if (addressState.Text != "") { return true; }
            if (addressZip.Text != "") { return true; }
            return false;
        }

        private bool birthdayPresent()
        {
            if (birthDate.Text != "") { return true; }
            return false;
        }

        private bool emailPresent()
        {
            if (email.Text != "") { return true; }
            return false;
        }

        private bool phonePresent()
        {
            if (phone.Text != "") { return true; }
            return false;
        }

        private bool countyNumberPresent()
        {
            if (countyNumberDate.Text != "") { return true; }
            if (countyNumber.Text != "") { return true; }
            return false;
        }

        private bool jotFormPresent()
        {
            if (jotDate.Text != "") { return true; }
            if (jotComments.Text != "") { return true; }
            return false;
        }

        private bool interviewContactPresent()
        {
            if (contactDate.Text != "") { return true; }
            if (contactComments.Text != "") { return true; }
            return false;
        }

        private bool interviewDatePresent()
        {
            if (interviewDate.Text != "") { return true; }
            if (interviewComments.Text != "") { return true; }
            return false;
        }

        private bool fingerprintPresent()
        {
            if (fingerprintDate.Text != "") { return true; }
            if (fingerprintComments.Text != "") { return true; }
            return false;
        }

        private bool physicalPresent()
        {
            if (physicalDate.Text != "") { return true; }
            if (physicalPass.IsChecked == true) { return true; }
            if (physicalComments.Text != "") { return true; }
            return false;
        }

        private bool backgroundPresent()
        {
            if (backgroundDate.Text != "") { return true; }
            if (backgroundPass.IsChecked == true) { return true; }
            if (backgroundComments.Text != "") { return true; }
            return false;
        }

        private bool vrsPresent()
        {
            if(vrsDate.Text != "") { return true; }
            if(vrsPass.IsChecked == true) { return true; }
            if (vrsComments.Text != "") { return true; }
            return false;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            LVRSMEMBERSEntities context = new LVRSMEMBERSEntities();
            int memID = Int32.Parse(memberID.Text);

            if (birthdayPresent())
            {
                birthday tempBirthday = new birthday();
                tempBirthday.memberID = memID;
                tempBirthday.birthDate = DateTime.Parse(birthDate.Text);
                context.birthdays.Add(tempBirthday);
            }

            if (addressPresent())
            {
                address tempAddress = new address();
                tempAddress.memberID = memID;
                tempAddress.addressStreet = addressStreet.Text;
                tempAddress.addressCity = addressCity.Text;
                tempAddress.addressState = addressState.Text;
                tempAddress.addressZip = Int32.Parse(addressZip.Text);
                context.addresses.Add(tempAddress);
            }

            if (emailPresent())
            {
                email tempEmail = new email();
                tempEmail.memberID = memID;
                tempEmail.emailAddress = email.Text;
                context.emails.Add(tempEmail);
            }

            if (phonePresent())
            {
                phone tempPhone = new phone();
                tempPhone.memberID = memID;
                tempPhone.phoneNumber = phone.Text;
                context.phones.Add(tempPhone);
            }

            if (countyNumberPresent())
            {
                countyNumber tempCountyNumber = new countyNumber();
                tempCountyNumber.memberID = memID;
                tempCountyNumber.dateCountyNumberReceived = DateTime.Parse(countyNumberDate.Text).Date;
                tempCountyNumber.counNum = Int32.Parse(countyNumber.Text);
                context.countyNumbers.Add(tempCountyNumber);
            }

            if (jotFormPresent())
            {
                jotForm tempJotForm = new jotForm();
                tempJotForm.memberID = memID;
                tempJotForm.jotFormReceived = DateTime.Parse(jotDate.Text).Date;
                tempJotForm.comments = jotComments.Text;
                context.jotForms.Add(tempJotForm);
            }

            if (interviewContactPresent())
            {
                interviewContact tempInterviewContact = new interviewContact();
                tempInterviewContact.memberID = memID;
                tempInterviewContact.contactDate = DateTime.Parse(contactDate.Text).Date;
                tempInterviewContact.comments = contactComments.Text;
                context.interviewContacts.Add(tempInterviewContact);
            }

            if (interviewDatePresent())
            {
                interviewSchedule tempInterviewSchedule = new interviewSchedule();
                tempInterviewSchedule.memberID = memID;
                tempInterviewSchedule.interviewScheduled = DateTime.Parse(interviewDate.Text).Date;
                tempInterviewSchedule.comments = interviewComments.Text;
                context.interviewSchedules.Add(tempInterviewSchedule);
            }

            if (fingerprintPresent())
            {
                fingerprint tempFingerprint = new fingerprint();
                tempFingerprint.memberID = memID;
                tempFingerprint.fingerprintAppointmentDate = DateTime.Parse(fingerprintDate.Text).Date;
                tempFingerprint.comments = fingerprintComments.Text;
                context.fingerprints.Add(tempFingerprint);
            }

            if(physicalPresent())
            {
                physicalPassed tempPhysicalPassed = new physicalPassed();
                physicalSchedule tempPhysicalSchedule = new physicalSchedule();
                tempPhysicalPassed.memberID = memID;
                tempPhysicalPassed.passPhysical = (bool)physicalPass.IsChecked;
                tempPhysicalPassed.comments = physicalComments.Text;
                tempPhysicalSchedule.memberID = memID;
                tempPhysicalSchedule.physicalScheduleDate = physicalDate.SelectedDate;
                context.physicalSchedules.Add(tempPhysicalSchedule);
                context.physicalPasseds.Add(tempPhysicalPassed);
            }

            if(backgroundPresent())
            {
                background tempBackground = new background();
                tempBackground.memberID = memID;
                tempBackground.dateBackgroundPassed = backgroundDate.SelectedDate;
                tempBackground.backgroundSuccess = (bool)backgroundPass.IsChecked;
                tempBackground.comments = backgroundComments.Text;
                context.backgrounds.Add(tempBackground);
            }

            if(vrsPresent())
            {
                vr tempVrs = new vr();
                tempVrs.memberID = memID;
                tempVrs.dateVrsCompleted = vrsDate.SelectedDate;
                tempVrs.vrsPassed = (bool)vrsPass.IsChecked;
                tempVrs.comments = vrsComments.Text;
            }

            context.SaveChanges();


        }
    }
}
