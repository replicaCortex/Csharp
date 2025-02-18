namespace lab2
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            grid2xml = new Button();
            xml2grid = new Button();
            clearShearch = new Button();
            inputId = new TextBox();
            inputMetal = new TextBox();
            inputName = new TextBox();
            id = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            label5 = new Label();
            label1 = new Label();
            inputAge = new TextBox();
            inputBreak = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 159);
            button1.Name = "button1";
            button1.Size = new Size(181, 40);
            button1.TabIndex = 0;
            button1.Text = "Test Car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-43, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(436, 154);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(118, 205);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 21);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // grid2xml
            // 
            grid2xml.Location = new Point(12, 259);
            grid2xml.Name = "grid2xml";
            grid2xml.Size = new Size(181, 23);
            grid2xml.TabIndex = 6;
            grid2xml.Text = "Сохранить в xml";
            grid2xml.UseVisualStyleBackColor = true;
            grid2xml.Click += grid2xml_Click;
            // 
            // xml2grid
            // 
            xml2grid.Location = new Point(12, 288);
            xml2grid.Name = "xml2grid";
            xml2grid.Size = new Size(181, 23);
            xml2grid.TabIndex = 7;
            xml2grid.Text = "Загрузить с xml";
            xml2grid.UseVisualStyleBackColor = true;
            xml2grid.Click += xml2grid_Click;
            // 
            // clearShearch
            // 
            clearShearch.Location = new Point(118, 232);
            clearShearch.Name = "clearShearch";
            clearShearch.Size = new Size(75, 23);
            clearShearch.TabIndex = 8;
            clearShearch.Text = "Очистить";
            clearShearch.UseVisualStyleBackColor = true;
            clearShearch.Click += clearShearch_Click;
            // 
            // inputId
            // 
            inputId.Location = new Point(250, 182);
            inputId.Name = "inputId";
            inputId.Size = new Size(100, 21);
            inputId.TabIndex = 9;
            inputId.TextChanged += textBox2_TextChanged;
            // 
            // inputMetal
            // 
            inputMetal.Location = new Point(250, 209);
            inputMetal.Name = "inputMetal";
            inputMetal.Size = new Size(100, 21);
            inputMetal.TabIndex = 11;
            // 
            // inputName
            // 
            inputName.Location = new Point(250, 236);
            inputName.Name = "inputName";
            inputName.Size = new Size(100, 21);
            inputName.TabIndex = 13;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(356, 185);
            id.Name = "id";
            id.Size = new Size(17, 13);
            id.TabIndex = 17;
            id.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 240);
            label2.Name = "label2";
            label2.Size = new Size(34, 13);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 212);
            label3.Name = "label3";
            label3.Size = new Size(33, 13);
            label3.TabIndex = 19;
            label3.Text = "Metal";
            label3.Click += label3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(250, 159);
            button4.Name = "button4";
            button4.Size = new Size(100, 17);
            button4.TabIndex = 24;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 161);
            label5.Name = "label5";
            label5.Size = new Size(31, 13);
            label5.TabIndex = 25;
            label5.Text = "Save";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 268);
            label1.Name = "label1";
            label1.Size = new Size(26, 13);
            label1.TabIndex = 22;
            label1.Text = "Age";
            label1.Click += label1_Click;
            // 
            // inputAge
            // 
            inputAge.Location = new Point(250, 263);
            inputAge.Name = "inputAge";
            inputAge.Size = new Size(100, 21);
            inputAge.TabIndex = 21;
            // 
            // inputBreak
            // 
            inputBreak.AutoSize = true;
            inputBreak.Location = new Point(250, 294);
            inputBreak.Name = "inputBreak";
            inputBreak.Size = new Size(53, 17);
            inputBreak.TabIndex = 26;
            inputBreak.Text = "Break";
            inputBreak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 330);
            Controls.Add(inputBreak);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(inputAge);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(id);
            Controls.Add(inputName);
            Controls.Add(inputMetal);
            Controls.Add(inputId);
            Controls.Add(clearShearch);
            Controls.Add(xml2grid);
            Controls.Add(grid2xml);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button grid2xml;
        private Button xml2grid;
        private Button clearShearch;
        private TextBox inputId;
        private TextBox inputMetal;
        private TextBox inputName;
        private Label id;
        private Label label2;
        private Label label3;
        private Button button4;
        private Label label5;
        private Label label1;
        private TextBox inputAge;
        private CheckBox inputBreak;
    }
}
