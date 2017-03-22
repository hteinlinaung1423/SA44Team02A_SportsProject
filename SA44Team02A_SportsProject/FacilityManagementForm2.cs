using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA44Team02A_SportsProject
{
    public partial class FacilityManagementForm2 : Form
    {
        List<Facility> facList;
        List<TimeSlot> timeList;
        SA44Team02A_SportsDBEntities2 context;
        
        public FacilityManagementForm2()
        {
            InitializeComponent();
        }

       
        private void FacilityManagementForm2_Load(object sender, EventArgs e)
        {
            context = new SA44Team02A_SportsDBEntities2();
            facilityCombo.Text = "Badminton";
            comboBox1.Text = "7am-8am";
            comboBox2.Text = "Good";
            timeList = context.TimeSlots.ToList();


            

        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                toolStripStatusLabel1.Text = "Please fill the required field!";
            }
            else if (Convert.ToInt32(textBox5.Text) > Convert.ToInt32(textBox4.Text))
            {
                toolStripStatusLabel1.Text = "Available slot should be the same or smaller than total stock!";
                MessageBox.Show("Update failed!");
            }
            else if (comboBox2.Text=="Repair" && Convert.ToInt32(textBox5.Text)>0)
            {
                toolStripStatusLabel1.Text = "Available slot should be '0' because status of facility is 'Repair'";
                MessageBox.Show("Update failed!");
            }
            else
            {
                facList = context.Facilities.Where(x => x.FacilityName == facilityCombo.Text).ToList();

                if (comboBox1.Text == "All Section")
                {

                    for (int i = 0; i < facList.Count(); i++)
                    {
                        PublishText(i);
                    }


                }

                else
                {
                    int i = timeList.FindIndex(x => x.TimeSlot1 == comboBox1.Text);

                    string timeid = timeList[i].TimeID;

                    int j = facList.FindIndex(x => x.TimeID == timeid && x.FacilityName == facilityCombo.Text);

                    PublishText(j);

                }

                context.SaveChanges();
                MessageBox.Show("Successfully updated!");
                toolStripStatusLabel1.Text = "";

            }
            

        }

        private void PublishText(int i)
        {            
            facList[i].TotalStock = Convert.ToInt32(textBox4.Text);
            facList[i].AvailableSlot = Convert.ToInt32(textBox5.Text);
            facList[i].RentalCost = Convert.ToInt32(textBox6.Text);
            facList[i].Status = comboBox2.Text;
        }

        
    }
}
