namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputModel = new System.Windows.Forms.TextBox();
            this.inputMetal = new System.Windows.Forms.TextBox();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.inputBreak = new System.Windows.Forms.CheckBox();
            this.CreateTestCar = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.clearShearch = new System.Windows.Forms.Button();
            this.CreateCustomCar = new System.Windows.Forms.Button();
            this.Grid2xml = new System.Windows.Forms.Button();
            this.Xml2grid = new System.Windows.Forms.Button();
            this.TestWWF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-45, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // inputModel
            // 
            this.inputModel.Location = new System.Drawing.Point(345, 186);
            this.inputModel.Name = "inputModel";
            this.inputModel.Size = new System.Drawing.Size(100, 20);
            this.inputModel.TabIndex = 3;
            // 
            // inputMetal
            // 
            this.inputMetal.Location = new System.Drawing.Point(345, 212);
            this.inputMetal.Name = "inputMetal";
            this.inputMetal.Size = new System.Drawing.Size(100, 20);
            this.inputMetal.TabIndex = 4;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(345, 238);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(100, 20);
            this.inputAge.TabIndex = 5;
            // 
            // inputBreak
            // 
            this.inputBreak.AutoSize = true;
            this.inputBreak.Location = new System.Drawing.Point(345, 264);
            this.inputBreak.Name = "inputBreak";
            this.inputBreak.Size = new System.Drawing.Size(53, 17);
            this.inputBreak.TabIndex = 7;
            this.inputBreak.Text = "break";
            this.inputBreak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inputBreak.UseVisualStyleBackColor = true;
            // 
            // CreateTestCar
            // 
            this.CreateTestCar.Location = new System.Drawing.Point(12, 157);
            this.CreateTestCar.Name = "CreateTestCar";
            this.CreateTestCar.Size = new System.Drawing.Size(121, 23);
            this.CreateTestCar.TabIndex = 8;
            this.CreateTestCar.Text = "TestCar";
            this.CreateTestCar.UseVisualStyleBackColor = true;
            this.CreateTestCar.Click += new System.EventHandler(this.CreateTestCar_Click_1);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(139, 186);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 20);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // clearShearch
            // 
            this.clearShearch.Location = new System.Drawing.Point(139, 211);
            this.clearShearch.Name = "clearShearch";
            this.clearShearch.Size = new System.Drawing.Size(75, 22);
            this.clearShearch.TabIndex = 10;
            this.clearShearch.Text = "Clean";
            this.clearShearch.UseVisualStyleBackColor = true;
            this.clearShearch.Click += new System.EventHandler(this.ClearShearch_Click);
            // 
            // CreateCustomCar
            // 
            this.CreateCustomCar.Location = new System.Drawing.Point(345, 157);
            this.CreateCustomCar.Name = "CreateCustomCar";
            this.CreateCustomCar.Size = new System.Drawing.Size(100, 23);
            this.CreateCustomCar.TabIndex = 11;
            this.CreateCustomCar.Text = "Create";
            this.CreateCustomCar.UseVisualStyleBackColor = true;
            this.CreateCustomCar.Click += new System.EventHandler(this.CreateCustomCar_Click_1);
            // 
            // Grid2xml
            // 
            this.Grid2xml.Location = new System.Drawing.Point(12, 239);
            this.Grid2xml.Name = "Grid2xml";
            this.Grid2xml.Size = new System.Drawing.Size(121, 23);
            this.Grid2xml.TabIndex = 12;
            this.Grid2xml.Text = "Save";
            this.Grid2xml.UseVisualStyleBackColor = true;
            this.Grid2xml.Click += new System.EventHandler(this.Grid2xml_Click_1);
            // 
            // Xml2grid
            // 
            this.Xml2grid.Location = new System.Drawing.Point(12, 268);
            this.Xml2grid.Name = "Xml2grid";
            this.Xml2grid.Size = new System.Drawing.Size(121, 23);
            this.Xml2grid.TabIndex = 13;
            this.Xml2grid.Text = "Load";
            this.Xml2grid.UseVisualStyleBackColor = true;
            this.Xml2grid.Click += new System.EventHandler(this.Xml2grid_Click_1);
            // 
            // TestWWF
            // 
            this.TestWWF.Location = new System.Drawing.Point(264, 157);
            this.TestWWF.Name = "TestWWF";
            this.TestWWF.Size = new System.Drawing.Size(75, 23);
            this.TestWWF.TabIndex = 14;
            this.TestWWF.Text = "test";
            this.TestWWF.UseVisualStyleBackColor = true;
            this.TestWWF.Click += new System.EventHandler(this.TestWWF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 301);
            this.Controls.Add(this.TestWWF);
            this.Controls.Add(this.Xml2grid);
            this.Controls.Add(this.Grid2xml);
            this.Controls.Add(this.CreateCustomCar);
            this.Controls.Add(this.clearShearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CreateTestCar);
            this.Controls.Add(this.inputBreak);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputMetal);
            this.Controls.Add(this.inputModel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox inputModel;
        private System.Windows.Forms.TextBox inputMetal;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.CheckBox inputBreak;
        private System.Windows.Forms.Button CreateTestCar;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button clearShearch;
        private System.Windows.Forms.Button CreateCustomCar;
        private System.Windows.Forms.Button Grid2xml;
        private System.Windows.Forms.Button Xml2grid;
        private System.Windows.Forms.Button TestWWF;
    }
}

