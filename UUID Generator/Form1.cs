using System;
using System.Windows.Forms;

namespace UUID_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        public static string[] GenerateUUIDs(int count)
        {
            string[] uuids = new string[count];
            for (int i = 0; i < count; i++)
            {
                uuids[i] = Guid.NewGuid().ToString("N").Substring(0, 8) + "-" +
                           Guid.NewGuid().ToString("N").Substring(0, 4) + "-" +
                           Guid.NewGuid().ToString("N").Substring(0, 4) + "-" +
                           Guid.NewGuid().ToString("N").Substring(0, 4) + "-" +
                           Guid.NewGuid().ToString("N").Substring(0, 12);
            }
            return uuids;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDown1.Value;
            string[] uuids = GenerateUUIDs(amount);
            string result = string.Join(Environment.NewLine, uuids);
            textBox1.Text = result;
            MessageBox.Show($"Generated {amount} UUIDs!");
        }
    }
}
