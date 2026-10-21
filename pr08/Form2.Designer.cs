namespace pr08
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(899, 400);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 1;
            label1.Text = "Поиск";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 29);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 23);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 3;
            label2.Text = "Сортировка";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(483, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 29);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(651, 25);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 5;
            label3.Text = "фильтр";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(724, 23);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(162, 29);
            comboBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Location = new Point(3, 493);
            button1.Name = "button1";
            button1.Size = new Size(230, 62);
            button1.TabIndex = 7;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSpringGreen;
            button2.Location = new Point(330, 493);
            button2.Name = "button2";
            button2.Size = new Size(235, 62);
            button2.TabIndex = 8;
            button2.Text = "Сбросить";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSpringGreen;
            button3.Location = new Point(672, 498);
            button3.Name = "button3";
            button3.Size = new Size(230, 62);
            button3.TabIndex = 9;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 572);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form2";
            Text = "ПР08 Удалённые ветки";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}