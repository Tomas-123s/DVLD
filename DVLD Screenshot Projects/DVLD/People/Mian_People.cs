using Busniss_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class Main_People : Form
    {
        private static DataTable dt_People_List = CLS_Person.Get_People();

        private DataTable dt_SHOW = dt_People_List.DefaultView.ToTable(false,"PersonID", "NationalNo",
                 "FirstName", "SecondName", "ThirdName", "LastName","GendorCaption", "DateOfBirth", "CountryName","Phone", "Email");

        public Main_People()
        {
            InitializeComponent();
        }

        private void Main_People_Load(object sender, EventArgs e)
        {
            dgv_People_List.DataSource = dt_SHOW;
            CB_FilterBy.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
    }
}
