using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Handy_Of_Plug_Scarlet_Blood_Fury
{
    public partial class Form_admin : Form
    {
        private string connectionString;

        public Form_admin()
        {
            InitializeComponent();
            // Добавляем свойство для DataBaseGrid
            DataBaseGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Задаем относительный путь к базе данных
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string relativePath = Path.Combine(projectDirectory, @"DB\bd auto.accdb");

            connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={relativePath}";

            // Добавляем значения в ComboBox
            Status_ComboBox.Items.Add("Активен");
            Status_ComboBox.Items.Add("Не активен");
        }

        private void Form_admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM avto"; // Replace 'YourTableName' with the actual table name
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DataBaseGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void DataBaseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mark_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Owner_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Discounts_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Debt_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date2_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO avto (ID, [Марка автомобиля], Владелец, [Дата и время въезда], [Дата и время выезда], [Стоимость стоянки], Скидки, [Задолженности по оплате], Статус) " +
                                   "VALUES (@ID, @Марка_автомобиля, @Владелец, @Дата_и_время_въезда, @Дата_и_время_выезда, @Стоимость_стоянки, @Скидки, @Задолженности_по_оплате, @Статус)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID_Box.Text);
                        command.Parameters.AddWithValue("@Марка_автомобиля", Mark_Box.Text);
                        command.Parameters.AddWithValue("@Владелец", Owner_Box.Text);
                        command.Parameters.AddWithValue("@Дата_и_время_въезда", Date_Box.Text);
                        command.Parameters.AddWithValue("@Дата_и_время_выезда", Date2_Box.Text);
                        command.Parameters.AddWithValue("@Стоимость_стоянки", Price_Box.Text);
                        command.Parameters.AddWithValue("@Скидки", Discounts_Box.Text);
                        command.Parameters.AddWithValue("@Задолженности_по_оплате", Debt_Box.Text);
                        command.Parameters.AddWithValue("@Статус", Status_ComboBox.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно добавлены!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
        }

        private void Edit_butt_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE avto SET [Марка автомобиля]=@Марка_автомобиля, Владелец=@Владелец, [Дата и время въезда]=@Дата_и_время_въезда, [Дата и время выезда]=@Дата_и_время_выезда, [Стоимость стоянки]=@Стоимость_стоянки, Скидки=@Скидки, [Задолженности по оплате]=@Задолженности_по_оплате,[Статус] Статус=@Статус WHERE ID=@ID";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Марка_автомобиля", Mark_Box.Text);
                        command.Parameters.AddWithValue("@Владелец", Owner_Box.Text);
                        command.Parameters.AddWithValue("@Дата_и_время_въезда", Date_Box.Text);
                        command.Parameters.AddWithValue("@Дата_и_время_выезда", Date2_Box.Text);
                        command.Parameters.AddWithValue("@Стоимость_стоянки", Price_Box.Text);
                        command.Parameters.AddWithValue("@Скидки", Discounts_Box.Text);
                        command.Parameters.AddWithValue("@Задолженности_по_оплате", Debt_Box.Text);
                        command.Parameters.AddWithValue("@Статус", Status_ComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@ID", ID_Box.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно обновлены!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
        }

        private void Delete_butt_Click(object sender, EventArgs e)
        {
            if (DataBaseGrid.SelectedRows.Count > 0)
            {
                var id = DataBaseGrid.SelectedRows[0].Cells["ID"].Value.ToString();
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM avto WHERE ID=@ID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Данные успешно удалены!");
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.");
            }
        }

        private void Close_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
