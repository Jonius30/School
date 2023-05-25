using AufgabenverwaltungLib.Controller;
using AufgabenverwaltungLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenverwaltungWinForms
{
    public partial class FormNewAufgabe : Form
    {
        public FormNewAufgabe()
        {
            InitializeComponent();
            SubscribeEvents();
            FillCbBox();
            
        }

        private void FillCbBox()
        {
            cbUser.DisplayMember= "FullName";
            List<User> users = new UserContoller().GetAllUser();
            cbUser.Items.Clear();
            foreach (User user in users)
            {
                cbUser.Items.Add(user);
            }
        }

        private void SubscribeEvents()
        {
            txtBezeichnung.TextChanged += ChangedValue;
            txtBeschreibung.TextChanged += ChangedValue;
            cbUser.SelectedIndexChanged+= ChangedValue;
        }

        private void UnSubscribeEvents()
        {
            txtBezeichnung.TextChanged -= ChangedValue;
            txtBeschreibung.TextChanged -= ChangedValue;
            cbUser.SelectedIndexChanged -= ChangedValue;
        }

       

        private void ChangedValue(object? sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBezeichnung.Text) || string.IsNullOrWhiteSpace(txtBeschreibung.Text) || (User)cbUser.SelectedItem == null || ((User)cbUser.SelectedItem).Id <= 0)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            new AufgabenController().InsertAufgabe(new AufgabenController().SetNewAufgabe(txtBezeichnung.Text, txtBeschreibung.Text, ((User)cbUser.SelectedItem).Id, 0));
            UnSubscribeEvents();
            this.Close();
        }
    }
}
