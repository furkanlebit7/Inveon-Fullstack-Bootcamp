using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace SerilizationInveonOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = txtAd.Text,
                Phone = txtTelefon.Text,
                DoB = dateTimePicker1.Value,
                Department = txtDepartman.Text,
                Salary = Convert.ToInt32(txtMaas.Text),
                additionalInfo = "Serileþtirme Olmayacak"
            };
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, emp);
                    MessageBox.Show("Veriler serilize edildi");
                    txtAd.Text = "";
                    txtTelefon.Text = "";
                    txtDepartman.Text = "";
                    txtMaas.Text = "";
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                fsout.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            XmlSerializer xs = new XmlSerializer (typeof(Employee));

            FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Employee)xs.Deserialize(fsin);
                    txtAd.Text = emp.Name;
                    txtTelefon.Text = emp.Phone;
                    dateTimePicker1.Value = emp.DoB;
                    txtDepartman.Text = emp.Department;
                    txtMaas.Text = Convert.ToString(emp.Salary);
                    MessageBox.Show("Deserilize edildi");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}