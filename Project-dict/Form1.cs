using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Project_dict
{
    public partial class Form1 : Form
    {
        private readonly string savedConnString = $"Data Source={Path.Combine(Application.StartupPath, "dictionary.db") }; Version=3;";
        public Form1()
        {
            InitializeComponent();

            // ComboBox-д утгуудыг код хувьд нэмэх
            cmbLanguage.Items.Add("Бүгд");
            cmbLanguage.Items.Add("Англи");
            cmbLanguage.Items.Add("Монгол");
            cmbLanguage.Items.Add("Орос");

            // Програм асах үед анхнаасаа "Бүгд" гэсэн сонголттой харагдах бол:
            cmbLanguage.SelectedIndex = 0;
        }
        private void LoadSavedWords()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(savedConnString))
                {
                    conn.Open();
                    string checkTableQuery = "CREATE TABLE IF NOT EXISTS saved_words (id INTEGER PRIMARY KEY AUTOINCREMENT, eng TEXT, mon TEXT, rus TEXT)";
                    using (SQLiteCommand createCmd = new SQLiteCommand(checkTableQuery, conn))
                    {
                        createCmd.ExecuteNonQuery();
                    }

                    string selectQuery = "SELECT id, eng AS Англи, mon AS Монгол, rus AS Орос FROM saved_words";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Хэрэв Form дээр dgvSaved нэртэй DataGridView байгаа бол энд холбоно
                        if (this.Controls.Find("dgvSaved", true).Length > 0 && this.Controls.Find("dgvSaved", true)[0] is DataGridView dgvSaved)
                        {
                            dgvSaved.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хадгалсан үгсийг уншихад алдаа гарлаа: " + ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvWords.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvWords.SelectedRows[0];

                // Хүснэгтийн багануудын нэрээс хамаарч индекс эсвэл нэрээр нь авна
                string eng = selectedRow.Cells["Англи"].Value.ToString();
                string mon = selectedRow.Cells["Монгол"].Value.ToString();
                string rus = selectedRow.Cells["Орос"].Value.ToString();

                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(savedConnString))
                    {
                        conn.Open();
                        string query = "INSERT INTO saved_words (eng, mon, rus) VALUES (@eng, @mon, @rus)";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@eng", eng);
                            cmd.Parameters.AddWithValue("@mon", mon);
                            cmd.Parameters.AddWithValue("@rus", rus);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadSavedWords();
                    MessageBox.Show("Үг амжилттай санагдлаа!", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Алдаа гарлаа: " + ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Хадгалах үгээ эхлээд сонгоно уу!", "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvSaved_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
