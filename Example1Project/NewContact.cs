using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1Project
{
    public partial class NewContact : Form
    {
        public NewContact()
        {
            InitializeComponent();
        }
        private Contact contact = new Contact { Email = "", Name = "", Phone = "" };
        private bool IsNew { get; set; } = true;
        private IRepo repo = new ListMemoryRepo();
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            DoCreate();


        }
       


        public void DoCreate()
        {
            var result = MessageBox.Show(text: "Are you sure to create?",
                                         caption: "Confirm",
                                         buttons: MessageBoxButtons.YesNo,
                                         icon: MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            //UIs to object
            contact.Email = txtEmail.Text;
            contact.Name = txtName.Text;
            contact.Phone = txtPhoneNo.Text;
            //db create in CRUD
            repo.Create(contact);
            //
            result = MessageBox.Show(text: "Created Successfully",
                                     caption: "Alert",
                                     buttons: MessageBoxButtons.OK,
                                     icon: MessageBoxIcon.Information);


            MessageBox.Show(text: contact.Name,
                                         caption: "Confirm",
                                         buttons: MessageBoxButtons.YesNo,
                                         icon: MessageBoxIcon.Question);

            DoNewContact();




        }

      
    private void DoNewContact()
        {
            //new contact object
            contact = new Contact { Email = "", Name = "", Phone = "" };
            //object to UIs
            txtEmail.Text = contact.Email;
            txtName.Text = contact.Name;
            txtPhoneNo.Text = contact.Phone;
            //new mode out of edit & new modes
           
           
            
            txtName.Focus();

            
        }


    }
}
