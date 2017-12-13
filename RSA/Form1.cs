/*************************************************************************
> Project Name: RSA
> Author: Woojin Lim
> Purpose: Functions to encrypt with RSA algorithm.
> Created Time: 2017/12/12
> Copyright (c) 2017, Woojin Lim
*************************************************************************/

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class RSA : Form
    {
        public void AppendText(string text, Color color)
        {
            Status_Textbox.SelectionStart = Status_Textbox.TextLength;
            Status_Textbox.SelectionLength = 0;

            Status_Textbox.SelectionColor = color;
            Status_Textbox.AppendText(text);
            Status_Textbox.SelectionColor = Status_Textbox.ForeColor;
        }
        ulong GetPowResult(ulong baseValue, ulong exp, ulong mod)
        {
            baseValue %= mod;
            ulong result = 1;
            while (exp > 0)
            {
                if ((exp & 1) == 1)
                {
                    result = (result * baseValue) % mod;
                }
                baseValue = (baseValue * baseValue) % mod;
                exp >>= 1;
            }
            return result;
        }
        //Thanks to https://stackoverflow.com/a/8498251

        public ulong GetRandomPrime(ulong exception)
        {
            Random rand = new Random();
            ulong random = 0;
            do
            {
                random = Convert.ToUInt64(rand.Next(2, 10000));
                random += (random % 2 == 0 ? Convert.ToUInt64(1) : Convert.ToUInt64(0));
            } while (random == exception || !IsPrime(random));
            return random;
        }

        public ulong GetGcd(ulong firstValue, ulong secondValue)
        {
            ulong r;
            while (secondValue != 0)
            {
                r = firstValue % secondValue;
                firstValue = secondValue;
                secondValue = r;
            }
            return firstValue;
        }

        public bool IsPrime(ulong value)
        {
            ulong i = 0;
            ulong sqrt = (ulong)Math.Sqrt(value);
            for (i = 2; i < sqrt; ++i)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public ulong GetEValue(ulong n, ulong pi_n)
        {
            Random rand = new Random();
            ulong random = Convert.ToUInt64(rand.Next(2, Convert.ToInt32(pi_n)));
            while (GetGcd(random, pi_n) != 1 || random == n)
            {
                if (random > pi_n)
                {
                    random = Convert.ToUInt64(rand.Next(2, Convert.ToInt32(pi_n)));
                }
                ++random;
            }
            return random;
        }

        public ulong GetDValue(ulong e, ulong pi_n)
        {
            Random rand = new Random();
            ulong random = Convert.ToUInt64(rand.Next(2, Convert.ToInt32(pi_n)));
            while ((e * random) % pi_n != 1)
            {
                if (random > pi_n)
                {
                    random = Convert.ToUInt64(rand.Next(2, Convert.ToInt32(pi_n)));
                }
                ++random;
            }
            return random;
        }

        public RSA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Random_Button_Click(object sender, EventArgs e)
        {
            //Basic Variable Declaration
            ulong p_value = 0;
            ulong q_value = 0;
            ulong n_value = 0;
            ulong pi_n_value = 0;
            ulong e_value = 0;
            ulong d_value = 0;

            Status_Textbox.Text = "";

            //Get Random Prime for p
            p_value = GetRandomPrime(1);
            P_Textbox.Text = p_value.ToString();

            //Get Random Prime for q        ( p != q )
            q_value = GetRandomPrime(p_value);
            Q_Textbox.Text = q_value.ToString();

            //n == p * q
            n_value = p_value * q_value;
            N_Textbox.Text = n_value.ToString();

            //𝜑(n) == (p-1) * (q-1)
            pi_n_value = (p_value - 1) * (q_value - 1);
            PI_N_Textbox.Text = pi_n_value.ToString();

            //e is random number.           ( GCD(𝜑(n), e) == 1 && e =! n )
            e_value = GetEValue(p_value, pi_n_value);
            Encryption_Key_Textbox.Text = e_value.ToString();

            //d is random number.           ( (e * d) % pi_n == 1 )
            d_value = GetDValue(e_value, pi_n_value);
            Decryption_Key_Textbox.Text = d_value.ToString();

            AppendText("Random number created!!!\n", Color.Black);
        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            //Basic Variable Declaration

            String temp = "";

            ulong p_value = 0;
            ulong q_value = 0;
            ulong n_value = 0;
            ulong pi_n_value = 0;
            ulong e_value = 0;
            ulong d_value = 0;

            String plain = Plain_Textbox.Text;
            String cipher = "";

            int error = 0;
            int len = plain.Length;

            Status_Textbox.Text = "";

            //Start checking error

            //Check if any values are empty
            if (P_Textbox.Text == "")
            {
                AppendText("p value is empty!!!\n", Color.Red);
                ++error;
            }
            if (Q_Textbox.Text == "")
            {
                AppendText("q value is empty!!!\n", Color.Red);
                ++error;
            }
            if (N_Textbox.Text == "")
            {
                AppendText("n value is empty!!!\n", Color.Red);
                ++error;
            }
            if (PI_N_Textbox.Text == "")
            {
                AppendText("𝜑(n) value is empty!!!\n", Color.Red);
                ++error;
            }
            if (Encryption_Key_Textbox.Text == "")
            {
                AppendText("e value is empty!!!\n", Color.Red);
                ++error;
            }
            if (Decryption_Key_Textbox.Text == "")
            {
                AppendText("d value is empty!!!\n", Color.Red);
                ++error;
            }
            if (Plain_Textbox.Text == "")
            {
                AppendText("Plain text is empty!!!\n", Color.Red);
                ++error;
            }

            if (error != 0)
            {
                return;
            }

            //Check if values are not a number
            try
            {
                p_value = Convert.ToUInt64(P_Textbox.Text);
            }
            catch
            {
                AppendText("p value is not a number!!!\n", Color.Red);
                ++error;
            }
            try
            {
                q_value = Convert.ToUInt64(Q_Textbox.Text);
            }
            catch
            {
                AppendText("q value is not a number!!!\n", Color.Red);
                ++error;
            }
            try
            {
                n_value = Convert.ToUInt64(N_Textbox.Text);
            }
            catch
            {
                AppendText("n value is not a number!!!\n", Color.Red);
                ++error;
            }
            try
            {
                pi_n_value = Convert.ToUInt64(PI_N_Textbox.Text);
            }
            catch
            {
                AppendText("𝜑(n) value is not a number!!!\n", Color.Red);
                ++error;
            }
            try
            {
                e_value = Convert.ToUInt64(Encryption_Key_Textbox.Text);
            }
            catch
            {
                AppendText("e value is not a number!!!\n", Color.Red);
                ++error;
            }
            try
            {
                d_value = Convert.ToUInt64(Decryption_Key_Textbox.Text);
            }
            catch
            {
                AppendText("d value is not a number!!!\n", Color.Red);
                ++error;
            }
            if (error != 0)
            {
                return;
            }

            //Check if values are wrong
            if (!IsPrime(p_value))
            {
                AppendText("P value is not Prime!!!\n", Color.Red);
                ++error;
            }
            if (!IsPrime(q_value))
            {
                AppendText("Q is not Prime!!!\n", Color.Red);
                ++error;
            }
            if (p_value * q_value != n_value)
            {
                AppendText("p * q is not n!!!\n", Color.Red);
                ++error;
            }

            if ((p_value - 1) * (q_value - 1) != pi_n_value)
            {
                AppendText("(p-1) * (q-1) is not 𝜑(n)!!!\n", Color.Red);
                ++error;
            }
            if (GetGcd(e_value, pi_n_value) != 1)
            {
                AppendText("e and 𝜑(n) is not Relatively prime!!!\n", Color.Red);
                ++error;
            }
            if ((e_value * d_value) % pi_n_value != 1)
            {
                AppendText("e * d % 𝜑(n) is not 1!!!\n", Color.Red);
                ++error;
            }
            if (error != 0)
            {
                return;
            }

            //End checking error

            //Encrypt String. (Character -> Decimal)
            for (int i = 0; i < len; ++i)
            {
                cipher += GetPowResult(plain[i], e_value, n_value).ToString() + (i == len - 1 ? "" : " ");
            }
            Cipher_Textbox.Text = cipher;
            AppendText("Encryption Complete!!!\n", Color.Black);

            //Copy values to clipboard
            System.Windows.Forms.Clipboard.SetText("Public Key : (" + n_value.ToString() + ", " + e_value.ToString() +
                                                   ")      Private Key : (" + n_value.ToString() + ", " + d_value.ToString() + ")      Cipher : " + cipher);
        }

        private void Decrypt_Buttion_Click(object sender, EventArgs e)
        {
            //Basic Variable Declaration
            ulong n_value = 0;
            ulong d_value = 0;

            String Cipher = Cipher_Textbox.Text;
            String plain = "";
            ulong temp = 0;

            String[] Cipher_Array = Cipher.Split(' ');

            int len = Cipher_Array.Length;
            int error = 0;

            Status_Textbox.Text = "";

            //Start checking error

            //Check if any values are empty
            if (N_Textbox.Text == "")
            {
                AppendText("n value is empty!!!\n", Color.Red);
                ++error;
            }
            if (Decryption_Key_Textbox.Text == "")
            {
                AppendText("d value is empty!!!\n", Color.Red);
                ++error;
            }
            if (Cipher_Textbox.Text == "")
            {
                AppendText("Cipher text is empty!!!", Color.Red);
                ++error;
            }

            if (error != 0)
            {
                return;
            }

            //Check if values are not a number
            try
            {
                n_value = Convert.ToUInt64(N_Textbox.Text);
            }
            catch
            {
                AppendText("n value is not a number!!!\n", Color.Red);
                return;
            }
            try
            {
                d_value = Convert.ToUInt64(Decryption_Key_Textbox.Text);
            }
            catch
            {
                AppendText("d value is not a number!!!\n", Color.Red);
                return;
            }

            if (error != 0)
            {
                return;
            }

            //End checking error

            //Decrypt String. (Number -> Character)
            for (int i = 0; i < len; ++i)
            {
                temp = Convert.ToUInt64(Cipher_Array[i]);
                plain += (char)GetPowResult(temp, d_value, n_value);

            }
            Plain_Textbox.Text = plain;

            AppendText("Decryption Complete!!!\n", Color.Black);

            //Copy plain text to clipboard
            System.Windows.Forms.Clipboard.SetText("Plain : " + Plain_Textbox.Text);
        }
    }
}