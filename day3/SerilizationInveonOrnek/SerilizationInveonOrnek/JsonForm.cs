using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerilizationInveonOrnek
{
    public partial class JsonForm : Form
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "Product1";
            product.ExpireDate = DateTime.Now;
            product.Price = 3.14;

            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"D:\inveonBootcamp\day3\SerilizationInveonOrnek\SerilizationInveonOrnek\products.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
                MessageBox.Show("Serilize Edildi");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            using (StreamReader file = File.OpenText(@"D:\inveonBootcamp\day3\SerilizationInveonOrnek\SerilizationInveonOrnek\products.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product product = (Product) serializer.Deserialize(reader,typeof(Product));
                MessageBox.Show(product.Name);
            }
        }
    }
}
