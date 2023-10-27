using System.Data;
using System.Data.SqlClient;

namespace OdemeFormApp
{
    public partial class Form1 : Form
    {
        public string tur = "";
        private OdemeIslemi odemeIslemi;
        private IOdemeTipi odemeTipi;

        SqlConnection conn = new SqlConnection(@"Server=FurkanLebit\SQLEXPRESS;Database=inveonDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");


        public Form1()
        {
            InitializeComponent();

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //convert, casting 
            if (txtTutar.Text.Trim().Length == 0)
            {
                MessageBox.Show("l�tfen tutar yaz�n�z...");
            }
            else
            {
                double tutar = Convert.ToDouble(txtTutar.Text);


                //if (tur == "Kredi Kart�")
                //{
                //    KrediKarti krediKarti = new KrediKarti();
                //    odemeIslemi = new OdemeIslemi(krediKarti);
                //    lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
                //}

                //else if (tur == "Mail Order")
                //{
                //    MailOrder mailOrder = new MailOrder();
                //    odemeIslemi = new OdemeIslemi(mailOrder);
                //    lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
                //}

                //else if (tur == "Sms �deme")
                //{
                //    SmsOdeme smsOdeme = new SmsOdeme();
                //    odemeIslemi = new OdemeIslemi(smsOdeme);
                //    lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
                //}

                OdemeIslemiFactory factory = new OdemeIslemiFactory();
                odemeTipi = factory.GetInstance(tur);
                odemeIslemi = new OdemeIslemi(odemeTipi);
                lblSonuc.Text = odemeIslemi.OdemeYap(tutar);



            }


        }

        private void cmbOdemeYontemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            tur = cmbOdemeYontemleri.SelectedValue.ToString();
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("select * from OdemeYontemleri", conn);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cmbOdemeYontemleri.DataSource = dt;
            cmbOdemeYontemleri.DisplayMember = "Display_member";
            cmbOdemeYontemleri.ValueMember = "Display_value";
            reader.Close();
            conn.Close();
        }
    }
}