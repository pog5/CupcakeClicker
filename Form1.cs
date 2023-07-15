using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Management;
using System.Media;
using System.Security.Principal;


namespace ForceAdminClicker
{
    public partial class Form1 : Form
    {

        public static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

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
            else
            {
                cookies = 0;
                cupcakecount.Text = cookies.ToString();
                multiplier = 1;
                cupcakecount.Text = multiplier.ToString();
                level = 1;
                label8.Text = level.ToString();
            }
        }

        public int cookies { get; private set; }
        public int multiplier { get; private set; }
        public int level { get; private set; }
        public int multiplierprice { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            cookies = cookies + (1 * multiplier);
            cupcakecount.Text = cookies.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(cupcakecount.Text) >= 20) { multiplierprice = int.Parse(cupcakecount.Text) * 2 * 100; }
            else { multiplierprice = int.Parse(cupcakecount.Text) * 100; }
            if (int.Parse(cupcakecount.Text) >= multiplierprice)
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
                int remaining = multiplierprice - int.Parse(cupcakecount.Text);
                MessageBox.Show($"You need {remaining} more cupcakes!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (multiplier >= 50)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(label8.Text) >= 1)
            {
                MessageBox.Show("GG!");
                button5.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.ClientSize == new Size(452, 277))
            {
                button5.Text = "Hide <<<";
                this.ClientSize = new Size(852, 277);

            } else
            {
                button5.Text = "Show >>>";
                this.ClientSize = new Size(452, 277);
            }
        }

    }
}