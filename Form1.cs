using DemoLibrary;
using System.Net.Mail;

namespace DatabaseTest
{
    public partial class Form1 : Form
    {
        List<PeopleClass> people = new List<PeopleClass>();

        public Form1()
        {
            InitializeComponent();
            LoadPeopleData();
        }

        private void LoadPeopleData()
        {
            people = SqliteDataAccess.LoadPeople();

            WirePeopleListBox();
        }

        private void DisplayInfo(int index)
        {
            labdisName.Text = people[index].FirstName;
            labdisSur.Text = people[index].LastName;
            labdisAge.Text = people[index].Age.ToString();
            labdisAddress.Text = people[index].EAdd;

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtbName.Text) || string.IsNullOrWhiteSpace(txtbSurName.Text) || string.IsNullOrWhiteSpace(txtbAge.Text) || string.IsNullOrEmpty(txtbEmail.Text)) && int.TryParse(txtbAge.Text, out int res) && res > 15 && res < 19 && MailAddress.TryCreate(txtbEmail.Text, out MailAddress mail))
            {
                PeopleClass newPerson = new PeopleClass();
                newPerson.FirstName = txtbName.Text;
                newPerson.LastName = txtbSurName.Text;
                newPerson.Age = res;
                newPerson.EAdd = mail.ToString();
                SqliteDataAccess.SavePerson(newPerson);
                txtbName.Text = "";
                txtbSurName.Text = "";
                txtbAge.Text = "";
                txtbEmail.Text = "";
                
                LoadPeopleData();
            }
        }

        private void WirePeopleListBox()
        {
            listBox.DataSource = people;
            listBox.DisplayMember = "FullName";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayInfo(listBox.SelectedIndex);
        }
    }
}