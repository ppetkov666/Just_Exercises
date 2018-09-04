
namespace _02___InsertIntoDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = tbName.Text;
            emp.Age = int.Parse(tbAge.Text);
            emp.Identity_Number = int.Parse(tbIDNumber.Text);
            emp.TownID = int.Parse(tbTownID.Text);
            SaveToMyDataBase(emp); 

        }

        private void SaveToMyDataBase(Employee emp)
        {
            PetkoTestDBEntities petkoDb = new PetkoTestDBEntities();
            petkoDb.Employees.Add(emp);
            petkoDb.SaveChanges();
            tbName.Clear();
            tbAge.Clear();
            tbIDNumber.Clear();
            tbTownID.Clear();

            MessageBox.Show("Enter Another Recond or click Exit");
            
            

        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
