namespace OdemeFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }



        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (priceInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("l�tfen tutar yaz�n�z...");
            }
            else
            {
                double tutar = Convert.ToDouble(priceInput.Text);

                //if (paymentCombo.Text == "Kredi Kart�")
                //{
                //    KrediKart� kk = new KrediKart�();
                //    odemeResult.Text = kk.Ode(tutar);
                //}

                //if (paymentCombo.Text == "Mail Order")
                //{
                //    MailOrder mo = new MailOrder();
                //    odemeResult.Text = mo.Ode(tutar); ;
                //}

                OdemeIslemiFactory factory = new OdemeIslemiFactory();
                //odemeIslemi = factory.GetInstance(paymentCombo.Text);

            }
        }
    }
}