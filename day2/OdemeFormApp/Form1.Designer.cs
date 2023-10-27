namespace OdemeFormApp
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
            paymentCombo = new ComboBox();
            label2 = new Label();
            priceInput = new TextBox();
            label3 = new Label();
            odemeResult = new Label();
            paymentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 125);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Yöntemi :";
            // 
            // paymentCombo
            // 
            paymentCombo.FormattingEnabled = true;
            paymentCombo.Items.AddRange(new object[] { "Seçiniz", "Mail Order", "Kredi Kartı" });
            paymentCombo.Location = new Point(413, 122);
            paymentCombo.Name = "paymentCombo";
            paymentCombo.Size = new Size(121, 23);
            paymentCombo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 187);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Tutar :";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(413, 184);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(121, 23);
            priceInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 310);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Ödeme  : ";
            // 
            // odemeResult
            // 
            odemeResult.AutoSize = true;
            odemeResult.Location = new Point(413, 310);
            odemeResult.Name = "odemeResult";
            odemeResult.Size = new Size(0, 15);
            odemeResult.TabIndex = 5;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(459, 244);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(75, 23);
            paymentButton.TabIndex = 6;
            paymentButton.Text = "Öde";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paymentButton);
            Controls.Add(odemeResult);
            Controls.Add(label3);
            Controls.Add(priceInput);
            Controls.Add(label2);
            Controls.Add(paymentCombo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox paymentCombo;
        private Label label2;
        private TextBox priceInput;
        private Label label3;
        private Label odemeResult;
        private Button paymentButton;
    }
}