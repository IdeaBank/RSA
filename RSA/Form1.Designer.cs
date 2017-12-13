namespace RSA
{
    partial class RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            this.First_Prime_Label = new System.Windows.Forms.Label();
            this.Second_Prime_Label = new System.Windows.Forms.Label();
            this.Encryption_Key_Label = new System.Windows.Forms.Label();
            this.Decryption_Key_Label = new System.Windows.Forms.Label();
            this.N_Label = new System.Windows.Forms.Label();
            this.PI_N_Label = new System.Windows.Forms.Label();
            this.P_Textbox = new System.Windows.Forms.TextBox();
            this.Q_Textbox = new System.Windows.Forms.TextBox();
            this.Encryption_Key_Textbox = new System.Windows.Forms.TextBox();
            this.Decryption_Key_Textbox = new System.Windows.Forms.TextBox();
            this.Plain_Label = new System.Windows.Forms.Label();
            this.Cipher_Label = new System.Windows.Forms.Label();
            this.Plain_Textbox = new System.Windows.Forms.TextBox();
            this.Cipher_Textbox = new System.Windows.Forms.TextBox();
            this.Random_Button = new System.Windows.Forms.Button();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.Decrypt_Buttion = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.N_Textbox = new System.Windows.Forms.TextBox();
            this.PI_N_Textbox = new System.Windows.Forms.TextBox();
            this.Status_Textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // First_Prime_Label
            // 
            this.First_Prime_Label.AutoSize = true;
            this.First_Prime_Label.Location = new System.Drawing.Point(12, 9);
            this.First_Prime_Label.Name = "First_Prime_Label";
            this.First_Prime_Label.Size = new System.Drawing.Size(13, 13);
            this.First_Prime_Label.TabIndex = 0;
            this.First_Prime_Label.Text = "p";
            // 
            // Second_Prime_Label
            // 
            this.Second_Prime_Label.AutoSize = true;
            this.Second_Prime_Label.Location = new System.Drawing.Point(12, 36);
            this.Second_Prime_Label.Name = "Second_Prime_Label";
            this.Second_Prime_Label.Size = new System.Drawing.Size(13, 13);
            this.Second_Prime_Label.TabIndex = 1;
            this.Second_Prime_Label.Text = "q";
            // 
            // Encryption_Key_Label
            // 
            this.Encryption_Key_Label.AutoSize = true;
            this.Encryption_Key_Label.Location = new System.Drawing.Point(12, 110);
            this.Encryption_Key_Label.Name = "Encryption_Key_Label";
            this.Encryption_Key_Label.Size = new System.Drawing.Size(13, 13);
            this.Encryption_Key_Label.TabIndex = 2;
            this.Encryption_Key_Label.Text = "e";
            // 
            // Decryption_Key_Label
            // 
            this.Decryption_Key_Label.AutoSize = true;
            this.Decryption_Key_Label.Location = new System.Drawing.Point(12, 136);
            this.Decryption_Key_Label.Name = "Decryption_Key_Label";
            this.Decryption_Key_Label.Size = new System.Drawing.Size(13, 13);
            this.Decryption_Key_Label.TabIndex = 3;
            this.Decryption_Key_Label.Text = "d";
            // 
            // N_Label
            // 
            this.N_Label.AutoSize = true;
            this.N_Label.Location = new System.Drawing.Point(11, 63);
            this.N_Label.Name = "N_Label";
            this.N_Label.Size = new System.Drawing.Size(21, 13);
            this.N_Label.TabIndex = 4;
            this.N_Label.Text = "N :";
            // 
            // PI_N_Label
            // 
            this.PI_N_Label.AutoSize = true;
            this.PI_N_Label.Location = new System.Drawing.Point(12, 85);
            this.PI_N_Label.Name = "PI_N_Label";
            this.PI_N_Label.Size = new System.Drawing.Size(32, 13);
            this.PI_N_Label.TabIndex = 5;
            this.PI_N_Label.Text = "𝜑(n) :";
            // 
            // P_Textbox
            // 
            this.P_Textbox.Location = new System.Drawing.Point(31, 6);
            this.P_Textbox.Name = "P_Textbox";
            this.P_Textbox.Size = new System.Drawing.Size(330, 20);
            this.P_Textbox.TabIndex = 0;
            // 
            // Q_Textbox
            // 
            this.Q_Textbox.Location = new System.Drawing.Point(31, 32);
            this.Q_Textbox.Name = "Q_Textbox";
            this.Q_Textbox.Size = new System.Drawing.Size(330, 20);
            this.Q_Textbox.TabIndex = 2;
            // 
            // Encryption_Key_Textbox
            // 
            this.Encryption_Key_Textbox.Location = new System.Drawing.Point(31, 107);
            this.Encryption_Key_Textbox.Name = "Encryption_Key_Textbox";
            this.Encryption_Key_Textbox.Size = new System.Drawing.Size(330, 20);
            this.Encryption_Key_Textbox.TabIndex = 5;
            // 
            // Decryption_Key_Textbox
            // 
            this.Decryption_Key_Textbox.Location = new System.Drawing.Point(31, 133);
            this.Decryption_Key_Textbox.Name = "Decryption_Key_Textbox";
            this.Decryption_Key_Textbox.Size = new System.Drawing.Size(330, 20);
            this.Decryption_Key_Textbox.TabIndex = 6;
            // 
            // Plain_Label
            // 
            this.Plain_Label.AutoSize = true;
            this.Plain_Label.Location = new System.Drawing.Point(11, 165);
            this.Plain_Label.Name = "Plain_Label";
            this.Plain_Label.Size = new System.Drawing.Size(30, 13);
            this.Plain_Label.TabIndex = 10;
            this.Plain_Label.Text = "Plain";
            // 
            // Cipher_Label
            // 
            this.Cipher_Label.AutoSize = true;
            this.Cipher_Label.Location = new System.Drawing.Point(11, 190);
            this.Cipher_Label.Name = "Cipher_Label";
            this.Cipher_Label.Size = new System.Drawing.Size(37, 13);
            this.Cipher_Label.TabIndex = 11;
            this.Cipher_Label.Text = "Cipher";
            // 
            // Plain_Textbox
            // 
            this.Plain_Textbox.Location = new System.Drawing.Point(50, 162);
            this.Plain_Textbox.Name = "Plain_Textbox";
            this.Plain_Textbox.Size = new System.Drawing.Size(478, 20);
            this.Plain_Textbox.TabIndex = 7;
            // 
            // Cipher_Textbox
            // 
            this.Cipher_Textbox.Location = new System.Drawing.Point(50, 187);
            this.Cipher_Textbox.Name = "Cipher_Textbox";
            this.Cipher_Textbox.Size = new System.Drawing.Size(478, 20);
            this.Cipher_Textbox.TabIndex = 9;
            // 
            // Random_Button
            // 
            this.Random_Button.Location = new System.Drawing.Point(367, 4);
            this.Random_Button.Name = "Random_Button";
            this.Random_Button.Size = new System.Drawing.Size(75, 23);
            this.Random_Button.TabIndex = 1;
            this.Random_Button.Text = "Random";
            this.Random_Button.UseVisualStyleBackColor = true;
            this.Random_Button.Click += new System.EventHandler(this.Random_Button_Click);
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.Location = new System.Drawing.Point(534, 160);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_Button.TabIndex = 8;
            this.Encrypt_Button.Text = "Encrypt!";
            this.Encrypt_Button.UseVisualStyleBackColor = true;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // Decrypt_Buttion
            // 
            this.Decrypt_Buttion.Location = new System.Drawing.Point(534, 187);
            this.Decrypt_Buttion.Name = "Decrypt_Buttion";
            this.Decrypt_Buttion.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_Buttion.TabIndex = 11;
            this.Decrypt_Buttion.Text = "Decrypt!";
            this.Decrypt_Buttion.UseVisualStyleBackColor = true;
            this.Decrypt_Buttion.Click += new System.EventHandler(this.Decrypt_Buttion_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(11, 254);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 17;
            this.Status.Text = "Status";
            // 
            // N_Textbox
            // 
            this.N_Textbox.Location = new System.Drawing.Point(31, 58);
            this.N_Textbox.Name = "N_Textbox";
            this.N_Textbox.Size = new System.Drawing.Size(330, 20);
            this.N_Textbox.TabIndex = 3;
            // 
            // PI_N_Textbox
            // 
            this.PI_N_Textbox.Location = new System.Drawing.Point(50, 82);
            this.PI_N_Textbox.Name = "PI_N_Textbox";
            this.PI_N_Textbox.Size = new System.Drawing.Size(311, 20);
            this.PI_N_Textbox.TabIndex = 4;
            // 
            // Status_Textbox
            // 
            this.Status_Textbox.Location = new System.Drawing.Point(12, 270);
            this.Status_Textbox.Name = "Status_Textbox";
            this.Status_Textbox.ReadOnly = true;
            this.Status_Textbox.Size = new System.Drawing.Size(608, 235);
            this.Status_Textbox.TabIndex = 20;
            this.Status_Textbox.Text = "";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 517);
            this.Controls.Add(this.Status_Textbox);
            this.Controls.Add(this.PI_N_Textbox);
            this.Controls.Add(this.N_Textbox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Decrypt_Buttion);
            this.Controls.Add(this.Encrypt_Button);
            this.Controls.Add(this.Random_Button);
            this.Controls.Add(this.Cipher_Textbox);
            this.Controls.Add(this.Plain_Textbox);
            this.Controls.Add(this.Cipher_Label);
            this.Controls.Add(this.Plain_Label);
            this.Controls.Add(this.Decryption_Key_Textbox);
            this.Controls.Add(this.Encryption_Key_Textbox);
            this.Controls.Add(this.Q_Textbox);
            this.Controls.Add(this.P_Textbox);
            this.Controls.Add(this.PI_N_Label);
            this.Controls.Add(this.N_Label);
            this.Controls.Add(this.Decryption_Key_Label);
            this.Controls.Add(this.Encryption_Key_Label);
            this.Controls.Add(this.Second_Prime_Label);
            this.Controls.Add(this.First_Prime_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSA";
            this.Text = "RSA Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label First_Prime_Label;
        private System.Windows.Forms.Label Second_Prime_Label;
        private System.Windows.Forms.Label Encryption_Key_Label;
        private System.Windows.Forms.Label Decryption_Key_Label;
        private System.Windows.Forms.Label N_Label;
        private System.Windows.Forms.Label PI_N_Label;
        private System.Windows.Forms.TextBox P_Textbox;
        private System.Windows.Forms.TextBox Q_Textbox;
        private System.Windows.Forms.TextBox Encryption_Key_Textbox;
        private System.Windows.Forms.TextBox Decryption_Key_Textbox;
        private System.Windows.Forms.Label Plain_Label;
        private System.Windows.Forms.Label Cipher_Label;
        private System.Windows.Forms.TextBox Plain_Textbox;
        private System.Windows.Forms.TextBox Cipher_Textbox;
        private System.Windows.Forms.Button Random_Button;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.Button Decrypt_Buttion;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox N_Textbox;
        private System.Windows.Forms.TextBox PI_N_Textbox;
        private System.Windows.Forms.RichTextBox Status_Textbox;
    }
}

