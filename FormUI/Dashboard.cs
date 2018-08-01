using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Wareneingang> wareneingang = new List<Wareneingang>();
        List<WareneingangPosZusammenfassung> wareneingangPos = new List<WareneingangPosZusammenfassung>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateWareneingangBinding();
        }

        private void UpdateWareneingangBinding()
        {
            wareneingangFoundListbox.DataSource = wareneingang;
            wareneingangFoundListbox.DisplayMember = "FullInfo";
        }

        private void UpdatePositionBinding()
        {
            PositionListbox.DataSource = wareneingangPos;
            PositionListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            wareneingang = db.GetWareneingang(wareneingangText.Text);

            UpdateWareneingangBinding();
        }

        private void wareneingangFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            wareneingangPos = db.GetPosition(wareneingang[wareneingangFoundListbox.SelectedIndex].Wareneingang_SID);
            UpdatePositionBinding();
        }


        //private void insertRecordButton_Click(object sender, EventArgs e)
        //{
        //    DataAccess db = new DataAccess();

        //    db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);

        //    firstNameInsText.Text = "";
        //    lastNameInsText.Text = "";
        //    emailAddressInsText.Text = "";
        //    phoneNumberInsText.Text = "";
        //}
    }
}
