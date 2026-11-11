namespace Project_dict
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            cmbLanguage = new ComboBox();
            label2 = new Label();
            dgvWords = new DataGridView();
            dgvSaved = new ListBox();
            txtEng = new TextBox();
            txtMon = new TextBox();
            txtRus = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Хайх:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Хайх нууц үг";
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLanguage.Location = new Point(497, 25);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(142, 28);
            cmbLanguage.TabIndex = 2;
            cmbLanguage.Text = "Бүгд";
            cmbLanguage.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 33);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Хэл:";
            // 
            // dgvWords
            // 
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Location = new Point(37, 95);
            dgvWords.Name = "dgvWords";
            dgvWords.RowHeadersWidth = 51;
            dgvWords.Size = new Size(399, 203);
            dgvWords.TabIndex = 4;
            // 
            // dgvSaved
            // 
            dgvSaved.FormattingEnabled = true;
            dgvSaved.Location = new Point(463, 95);
            dgvSaved.Name = "dgvSaved";
            dgvSaved.Size = new Size(325, 204);
            dgvSaved.TabIndex = 5;
            // 
            // txtEng
            // 
            txtEng.Location = new Point(88, 342);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(125, 27);
            txtEng.TabIndex = 6;
            // 
            // txtMon
            // 
            txtMon.Location = new Point(294, 339);
            txtMon.Name = "txtMon";
            txtMon.Size = new Size(125, 27);
            txtMon.TabIndex = 7;
            // 
            // txtRus
            // 
            txtRus.Location = new Point(479, 338);
            txtRus.Name = "txtRus";
            txtRus.Size = new Size(125, 27);
            txtRus.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 349);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "Англи:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 349);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "Монгол:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 346);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 11;
            label5.Text = "Орос:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(172, 390);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "✎ Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(308, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "🗑 Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 390);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "⟳ Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(584, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "💾 Санах";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRus);
            Controls.Add(txtMon);
            Controls.Add(txtEng);
            Controls.Add(dgvSaved);
            Controls.Add(dgvWords);
            Controls.Add(label2);
            Controls.Add(cmbLanguage);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox cmbLanguage;
        private Label label2;
        private DataGridView dgvWords;
        private ListBox dgvSaved;
        private TextBox txtEng;
        private TextBox txtMon;
        private TextBox txtRus;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
    }
}
