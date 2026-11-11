namespace Project_dict
{
    public partial class Form1 : Form
    {
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

    }
}
