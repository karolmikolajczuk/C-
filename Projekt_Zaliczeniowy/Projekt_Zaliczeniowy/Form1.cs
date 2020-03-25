using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt_Zaliczeniowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                FileStream fs = new FileStream("baza.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadLine();
                    int size = text.Length;
                    if (size > 9)
                    {
                        listBox1.Items.Add(text);
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1.SelectedIndex = 1;
            webBrowser1.Navigate(@"https://www.wsb.pl");
            Image image = Image.FromFile("wsb.png");
            pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tłoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            string text = listBox1.SelectedItem.ToString();
            string[] text_arr = text.Split(',');
            if (text_arr.Length == 9)
            {
                textBox1.Text = text_arr[0];
                textBox5.Text = text_arr[1];
                textBox4.Text = text_arr[2];
                textBox3.Text = text_arr[3];
                textBox2.Text = text_arr[4];

                if (text_arr[5].Contains("Matematyka Dyskretna"))
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if (text_arr[5].Contains("Matematyka"))
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (text_arr[5].Contains("Analiza Matematyczna"))
                {
                    comboBox1.SelectedIndex = 2;
                }
                else if (text_arr[5].Contains("Fizyka"))
                {
                    comboBox1.SelectedIndex = 3;
                }
                else if (text_arr[5].Contains("W-F"))
                {
                    comboBox1.SelectedIndex = 4;
                }
                else if (text_arr[5].Contains("Programowanie Komputerowe"))
                {
                    comboBox1.SelectedIndex = 5;
                }
                else
                {
                    comboBox1.SelectedIndex = 6;
                }
                numericUpDown1.Value = Convert.ToDecimal(text_arr[6]);
                if (text_arr[7].Contains("Tak"))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (text_arr[8].Contains("Tak"))
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void zakończToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void żółtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void białyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void szaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // wyczysc przycisk
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            progressBar1.Value = 1;
            numericUpDown1.Value = 2;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty ||
                textBox2.Text == string.Empty ||
                textBox3.Text == string.Empty ||
                textBox4.Text == string.Empty ||
                textBox5.Text == string.Empty)
            {
                MessageBox.Show("Pole tekstowe nie może być puste.");
                return;
            }

            // stworz string 
            string v1 = (radioButton1.Checked == true) ? "Tak" : "Nie";
            string v2 = (checkBox1.Checked == true) ? "Tak" : "Nie";
            string value = textBox1.Text + "," + textBox5.Text + "," +
                           textBox4.Text + "," + textBox3.Text + "," +
                           textBox2.Text + "," + comboBox1.Text + "," +numericUpDown1.Value + "," +
                           v1 + "," + v2 + "\n";

            // dodaj do listy
            listBox1.Items.Add(value);

            // wyczysc przycisk
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            progressBar1.Value = 1;
            numericUpDown1.Value = 2;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;

            // zapisz do pliku
            var lines = new List<string>();
            for (int i=0; i<listBox1.Items.Count; i++)
            {
                lines.Add(listBox1.Items[i].ToString());
            }
            // wyczysc plik
            File.WriteAllText("baza.txt", string.Empty);
            
            // otworz plik i wstaw zawartosc listboxa
            FileStream plik = new FileStream("baza.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(plik);
            
            for (int i=0; i<listBox1.Items.Count; i++)
            {
                sw.WriteLine(lines[i]);
            }

            sw.Close();
            plik.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            var value = listBox1.SelectedIndex;

            string str_value;
            try
            {
                str_value = listBox1.SelectedItem.ToString();
                string whole_file = File.ReadAllText("baza.txt");
                string new_text = whole_file.Replace(str_value, "");
                new_text = string.Join("", new_text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                File.WriteAllText("baza.txt", new_text);
                listBox1.Items.RemoveAt(value);
                listBox1.SelectedIndex = -1;

                // wyczysc przycisk
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                progressBar1.Value = 1;
                numericUpDown1.Value = 2;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            if (textBox1.Text != "")
            {
                progressBar1.Value++;
            }
            if (textBox2.Text != "")
            {
                progressBar1.Value++;
            }
            if (textBox3.Text != "")
            {
                progressBar1.Value++;
            }
            if (textBox4.Text != "")
            {
                progressBar1.Value++;
            }
            if (textBox5.Text != "")
            {
                progressBar1.Value++;
            }
            if (comboBox1.Text != "")
            {
                progressBar1.Value++;
            }
            if (numericUpDown1.Value >= 2 && numericUpDown1.Value <= 5)
            {
                progressBar1.Value++;
            }
        }
    }
}
