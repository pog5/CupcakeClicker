using System.Media;


namespace ForceAdminClicker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            DialogResult cloud = MessageBox.Show("Would you like to restore your progress from the cloud?", "Load Cloud Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            InitializeComponent();
            this.ClientSize = new Size(452, 277);
            if (cloud == DialogResult.Yes)
            {
                Random rng = new Random();
                Thread.Sleep(rng.Next(1200, 4500));
            }
            cookies = 0;
            cupcakecount.Text = cookies.ToString();
            multiplier = 1;
            cupcakecount.Text = multiplier.ToString();
            level = 1;
            label8.Text = level.ToString();
        }

        public Int64 cookies { get; private set; }
        public Int64 multiplier { get; private set; }
        public Int64 level { get; private set; }
        public Int64 multiplierprice { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            cookies = cookies + (1 * multiplier);
            cupcakecount.Text = cookies.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int64.Parse(cupcakecount.Text) >= 20) { multiplierprice = Int64.Parse(cupcakecount.Text) * 2 * 100; }
            else { multiplierprice = Int64.Parse(cupcakecount.Text) * 100; }
            if (Int64.Parse(cupcakecount.Text) >= multiplierprice)
            {
                cookies = cookies - multiplierprice;
                cupcakecount.Text = cookies.ToString();
                multiplier = multiplier + 1;
                multipliercount.Text = multiplier.ToString();
                SoundPlayer levelup = new SoundPlayer("C:\\\\Windows\\\\Media\\\\Windows Proximity Notification.wav");
                levelup.Play();
            }
            else
            {
                Int64 remaining = multiplierprice - Int64.Parse(cupcakecount.Text);
                string text = $"You need {remaining} more cupcakes!";
                MessageBox.Show(text, "Unmet requirements", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (multiplier >= 50)
            {
                cookies = multiplier * 14 * level;
                cupcakecount.Text = cookies.ToString();
                multiplier = 1;
                multipliercount.Text = multiplier.ToString();
                level = level + 1;
                label8.Text = level.ToString();
                if (level >= 10)
                {
                    button4.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Multiplier 50 needed.", "Unmet requirements", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (level >= 10)
            {
                MessageBox.Show("GG!", "You win! :D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button5.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.ClientSize == new Size(452, 277))
            {
                button5.Text = "Hide <<<";
                this.ClientSize = new Size(852, 277);

            }
            else
            {
                button5.Text = "Show >>>";
                this.ClientSize = new Size(452, 277);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = cookies.ToString();
            textBox2.Text = multiplier.ToString();
            textBox3.Text = level.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cookies = Int64.Parse(textBox1.Text);
                multiplier = Int64.Parse(textBox2.Text);
                level = Int64.Parse(textBox3.Text);
                multiplierprice = Int64.Parse(cupcakecount.Text) * 100;
                cupcakecount.Text = cookies.ToString();
                multipliercount.Text = multiplier.ToString();
                label8.Text = level.ToString();
            }
            catch
            {
                MessageBox.Show("You either: \n 1. Put something bigger than 9,223,372,036,854,775,807\n 1. Put something smaller than -9,223,372,036,854,775,807\n 2. Did not put a actual number\n 3. Forgot to fill in some fields", "Error while setting values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            level = 10;
            button4.Enabled = true;
        }
    }
}