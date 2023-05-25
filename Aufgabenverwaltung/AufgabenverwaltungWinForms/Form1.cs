using AufgabenverwaltungLib.Controller;
using AufgabenverwaltungLib.Libraries;
using AufgabenverwaltungLib.Models;
using AufgabenverwaltungLib.RefItems;

namespace AufgabenverwaltungWinForms
{
    public partial class Form1 : Form
    {
        private Aufgabe? _Item = null;
        public Form1()
        {
            InitializeComponent();
            SetBinding();
            UpdateView();
           
        }

        private void SetBinding()
        {
            lbToDo.DisplayMember = "Bezeichnung";
            lbInProgress.DisplayMember = "Bezeichnung";
            lbReview.DisplayMember = "Bezeichnung";
            lbDone.DisplayMember = "Bezeichnung";
        }



        public void UpdateView()
        {
            var task = Task<List<AufgabenRefItem>>.Run(() => GetList());
            task.Wait();
            List<AufgabenRefItem> list = task.Result;
            FillListViews(list);
        }

        public async Task<List<AufgabenRefItem>> GetList()
        {
            return await Task<List<AufgabenRefItem>>.Run(() => AufgabenLib.GetAufgabenRefItems());
        }

        public void FillListViews(List<AufgabenRefItem> list)
        {
           
            lbToDo.Items.Clear();
            lbInProgress.Items.Clear();
            lbReview.Items.Clear();
            lbDone.Items.Clear();

            foreach (var item in list)
            {
                switch (item.Aufgabe.ZustandId)
                {
                    case 0:
                        lbToDo.Items.Add(item.Aufgabe);
                        break;
                    case 1:
                        lbInProgress.Items.Add(item.Aufgabe);
                        break;
                    case 2:
                        lbReview.Items.Add(item.Aufgabe);
                        break;
                    case 3:
                        lbDone.Items.Add(item.Aufgabe);
                        break;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void lbSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                Aufgabe aufgabe = (Aufgabe)(((ListBox)sender).SelectedItem);

                if (aufgabe.ZustandId != 0)
                    lbToDo.SelectedIndex = -1;
                if (aufgabe.ZustandId != 1)
                    lbInProgress.SelectedIndex = -1;
                if (aufgabe.ZustandId != 2)
                    lbReview.SelectedIndex = -1;
                if (aufgabe.ZustandId != 3)
                    lbDone.SelectedIndex = -1;

                _Item = aufgabe;
            }
        }

        private void btnMoveClick(object sender, EventArgs e)
        {
            if (_Item == null)
                return;
            if(sender == btnForward)
            {
                _Item.ZustandId++;
            }
            if(sender == btnBack)
            {
                if (_Item.ZustandId > 0)
                    _Item.ZustandId--;
                else
                    return;
            }
            new AufgabenController().UpdateAufgabe(_Item);
            UpdateView();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FormNewAufgabe().ShowDialog();
            UpdateView();
        }

        
    }
}