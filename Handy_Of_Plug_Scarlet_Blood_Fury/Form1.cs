using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handy_Of_Plug_Scarlet_Blood_Fury
{
    public partial class Form_Login : Form
    {
        // Dictionary to store profiles and their respective passwords
        private Dictionary<string, string> profiles;
        private Random random;
        private Panel overlayPanel;

        public Form_Login()
        {
            InitializeComponent();
            InitializeProfiles();
            random = new Random();

            // Initialize overlay panel
            InitializeOverlayPanel();

            // Привязка обработчика события к кнопке About_butt
            About_butt.Click += new EventHandler(About_butt_Click);
        }

        private void InitializeProfiles()
        {
            // Initialize the dictionary with profiles and their passwords
            profiles = new Dictionary<string, string>
            {
                { "Stanley", "555" },
                { "NepNep", "12345" }
            };

            // Add profiles to the ComboBox
            foreach (var profile in profiles.Keys)
            {
                user_comboBox.Items.Add(profile);
            }

            // Optionally set a default selected index
            user_comboBox.SelectedIndex = 0;
        }

        private void InitializeOverlayPanel()
        {
            overlayPanel = new Panel
            {
                Size = this.ClientSize,
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(153, 0, 0, 0), // 153 is 60% transparency
                Visible = false
            };
            this.Controls.Add(overlayPanel);
            overlayPanel.BringToFront();
        }

        private void user_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add any actions you want to perform when the selection changes
        }

        private void password_Box_TextChanged(object sender, EventArgs e)
        {
            // You can add any actions you want to perform when the text in the password box changes
        }

        private void login_butt_Click(object sender, EventArgs e)
        {
            // Get the selected profile
            string selectedProfile = user_comboBox.SelectedItem.ToString();

            // Get the entered password
            string enteredPassword = password_Box.Text;

            // Check if the entered password matches the password for the selected profile
            if (profiles.ContainsKey(selectedProfile) && profiles[selectedProfile] == enteredPassword)
            {
                // Create an instance of Form_Admin
                Form_admin adminForm = new Form_admin();

                // Show the overlay panel
                overlayPanel.Visible = true;

                // Disable the login form
                this.Enabled = false;

                // Show the admin form
                adminForm.ShowDialog();

                // Re-enable the login form after adminForm is closed
                this.Enabled = true;

                // Hide the overlay panel
                overlayPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.");
            }
        }

        private void close_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            // Randomly select a background image
            string[] backgrounds = { "../../Content/Pic/main_bg1.jpg", "../../Content/Pic/main_bg2.png" };
            string selectedBackground = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, backgrounds[random.Next(backgrounds.Length)]);

            try
            {
                if (File.Exists(selectedBackground))
                {
                    // Set the background image
                    this.BackgroundImage = Image.FromFile(selectedBackground);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show($"Background file not found: {selectedBackground}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading background image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void About_butt_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы Form_about
            Form_about aboutForm = new Form_about();

            // Показываем overlay panel
            overlayPanel.Visible = true;

            // Отключаем форму входа
            this.Enabled = false;

            // Отображаем форму about
            aboutForm.ShowDialog();

            // Включаем форму входа после закрытия aboutForm
            this.Enabled = true;

            // Скрываем overlay panel
            overlayPanel.Visible = false;
        }
    }
}
