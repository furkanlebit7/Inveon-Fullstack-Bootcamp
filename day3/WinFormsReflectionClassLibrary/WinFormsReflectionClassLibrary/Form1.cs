using ClassLibraryInveonOrnek;
namespace WinFormsReflectionClassLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Matematik m = new Matematik();
           int gelenSonuc = m.Topla(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));

            MessageBox.Show("Toplam : " + gelenSonuc);
        }
    }
}