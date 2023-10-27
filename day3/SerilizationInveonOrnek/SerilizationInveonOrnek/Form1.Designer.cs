namespace SerilizationInveonOrnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtDepartman = new TextBox();
            txtMaas = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 91);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 140);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefon : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 184);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 234);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Departman : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 295);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Maaş : ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(391, 88);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(391, 137);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(391, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(391, 226);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(100, 23);
            txtDepartman.TabIndex = 8;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(391, 292);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(100, 23);
            txtMaas.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(388, 349);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Serialized";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(501, 349);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "DeSerialized";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartman);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDepartman;
        private TextBox txtMaas;
        private Button button1;
        private Button button2;
    }
}