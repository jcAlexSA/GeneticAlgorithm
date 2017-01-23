namespace GeneticAlgorithm
{
    partial class Form1
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
            this.btn_counting = new System.Windows.Forms.Button();
            this.textBox_initial_popup = new System.Windows.Forms.TextBox();
            this.textBox_final_popup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDown_count_X = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Mutation_probability = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDown_Count_Chromosome = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Size_Population = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_point_to_point = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_changed_delta = new System.Windows.Forms.TextBox();
            this.tb_count_epoch = new System.Windows.Forms.TextBox();
            this.rb_changed_delta = new System.Windows.Forms.RadioButton();
            this.rb_count_epochs = new System.Windows.Forms.RadioButton();
            this.rb_single_point = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Breeding = new System.Windows.Forms.RadioButton();
            this.rb_Inbreeding = new System.Windows.Forms.RadioButton();
            this.rb_Outbreeding = new System.Windows.Forms.RadioButton();
            this.rb_Panmixia = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_count_iterations = new System.Windows.Forms.TextBox();
            this.tb_show_delta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save_result_counting = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.cb_load_old_popup = new System.Windows.Forms.CheckBox();
            this.cb_save_new_popup = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_count_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Count_Chromosome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_counting
            // 
            this.btn_counting.Location = new System.Drawing.Point(8, 118);
            this.btn_counting.Name = "btn_counting";
            this.btn_counting.Size = new System.Drawing.Size(177, 39);
            this.btn_counting.TabIndex = 0;
            this.btn_counting.Text = "Расчитать";
            this.btn_counting.UseVisualStyleBackColor = true;
            this.btn_counting.Click += new System.EventHandler(this.btn_counting_Click);
            // 
            // textBox_initial_popup
            // 
            this.textBox_initial_popup.Location = new System.Drawing.Point(12, 36);
            this.textBox_initial_popup.Multiline = true;
            this.textBox_initial_popup.Name = "textBox_initial_popup";
            this.textBox_initial_popup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_initial_popup.Size = new System.Drawing.Size(200, 430);
            this.textBox_initial_popup.TabIndex = 1;
            // 
            // textBox_final_popup
            // 
            this.textBox_final_popup.Location = new System.Drawing.Point(670, 36);
            this.textBox_final_popup.Multiline = true;
            this.textBox_final_popup.Name = "textBox_final_popup";
            this.textBox_final_popup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_final_popup.Size = new System.Drawing.Size(204, 430);
            this.textBox_final_popup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество переменных (N)";
            // 
            // numUpDown_count_X
            // 
            this.numUpDown_count_X.Location = new System.Drawing.Point(161, 29);
            this.numUpDown_count_X.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_count_X.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDown_count_X.Name = "numUpDown_count_X";
            this.numUpDown_count_X.Size = new System.Drawing.Size(52, 20);
            this.numUpDown_count_X.TabIndex = 5;
            this.numUpDown_count_X.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вероятность мутации [0:1]";
            // 
            // tb_Mutation_probability
            // 
            this.tb_Mutation_probability.Location = new System.Drawing.Point(149, 68);
            this.tb_Mutation_probability.Name = "tb_Mutation_probability";
            this.tb_Mutation_probability.Size = new System.Drawing.Size(63, 20);
            this.tb_Mutation_probability.TabIndex = 7;
            this.tb_Mutation_probability.Text = "0,3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество хромосом";
            // 
            // numUpDown_Count_Chromosome
            // 
            this.numUpDown_Count_Chromosome.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDown_Count_Chromosome.Location = new System.Drawing.Point(149, 102);
            this.numUpDown_Count_Chromosome.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_Count_Chromosome.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDown_Count_Chromosome.Name = "numUpDown_Count_Chromosome";
            this.numUpDown_Count_Chromosome.ReadOnly = true;
            this.numUpDown_Count_Chromosome.Size = new System.Drawing.Size(63, 20);
            this.numUpDown_Count_Chromosome.TabIndex = 9;
            this.numUpDown_Count_Chromosome.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество особей в популяции";
            // 
            // cb_Size_Population
            // 
            this.cb_Size_Population.FormattingEnabled = true;
            this.cb_Size_Population.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "150",
            "200",
            "300",
            "400",
            "500",
            "1000"});
            this.cb_Size_Population.Location = new System.Drawing.Point(149, 133);
            this.cb_Size_Population.Name = "cb_Size_Population";
            this.cb_Size_Population.Size = new System.Drawing.Size(64, 21);
            this.cb_Size_Population.TabIndex = 11;
            this.cb_Size_Population.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GeneticAlgorithm.Properties.Resources.Снимок1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(15, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_point_to_point);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rb_single_point);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.numUpDown_count_X);
            this.groupBox1.Controls.Add(this.cb_Size_Population);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Mutation_probability);
            this.groupBox1.Controls.Add(this.numUpDown_Count_Chromosome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(424, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 454);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // rb_point_to_point
            // 
            this.rb_point_to_point.AutoSize = true;
            this.rb_point_to_point.Checked = true;
            this.rb_point_to_point.Location = new System.Drawing.Point(18, 426);
            this.rb_point_to_point.Name = "rb_point_to_point";
            this.rb_point_to_point.Size = new System.Drawing.Size(154, 17);
            this.rb_point_to_point.TabIndex = 24;
            this.rb_point_to_point.TabStop = true;
            this.rb_point_to_point.Text = "Двухточечный кроссовер";
            this.rb_point_to_point.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_changed_delta);
            this.groupBox3.Controls.Add(this.tb_count_epoch);
            this.groupBox3.Controls.Add(this.rb_changed_delta);
            this.groupBox3.Controls.Add(this.rb_count_epochs);
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 72);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Условия остановки";
            // 
            // tb_changed_delta
            // 
            this.tb_changed_delta.Location = new System.Drawing.Point(123, 45);
            this.tb_changed_delta.Name = "tb_changed_delta";
            this.tb_changed_delta.Size = new System.Drawing.Size(56, 20);
            this.tb_changed_delta.TabIndex = 3;
            this.tb_changed_delta.Text = "0,3";
            // 
            // tb_count_epoch
            // 
            this.tb_count_epoch.Enabled = false;
            this.tb_count_epoch.Location = new System.Drawing.Point(123, 19);
            this.tb_count_epoch.Name = "tb_count_epoch";
            this.tb_count_epoch.Size = new System.Drawing.Size(56, 20);
            this.tb_count_epoch.TabIndex = 2;
            this.tb_count_epoch.Text = "3000";
            // 
            // rb_changed_delta
            // 
            this.rb_changed_delta.AutoSize = true;
            this.rb_changed_delta.Checked = true;
            this.rb_changed_delta.Location = new System.Drawing.Point(14, 48);
            this.rb_changed_delta.Name = "rb_changed_delta";
            this.rb_changed_delta.Size = new System.Drawing.Size(109, 17);
            this.rb_changed_delta.TabIndex = 1;
            this.rb_changed_delta.TabStop = true;
            this.rb_changed_delta.Text = "Изменения delta";
            this.rb_changed_delta.UseVisualStyleBackColor = true;
            this.rb_changed_delta.CheckedChanged += new System.EventHandler(this.rb_changed_delta_CheckedChanged);
            // 
            // rb_count_epochs
            // 
            this.rb_count_epochs.AutoSize = true;
            this.rb_count_epochs.Location = new System.Drawing.Point(13, 20);
            this.rb_count_epochs.Name = "rb_count_epochs";
            this.rb_count_epochs.Size = new System.Drawing.Size(110, 17);
            this.rb_count_epochs.TabIndex = 0;
            this.rb_count_epochs.Text = "Количество эпох";
            this.rb_count_epochs.UseVisualStyleBackColor = true;
            this.rb_count_epochs.CheckedChanged += new System.EventHandler(this.rb_count_epochs_CheckedChanged);
            // 
            // rb_single_point
            // 
            this.rb_single_point.AutoSize = true;
            this.rb_single_point.Location = new System.Drawing.Point(18, 403);
            this.rb_single_point.Name = "rb_single_point";
            this.rb_single_point.Size = new System.Drawing.Size(155, 17);
            this.rb_single_point.TabIndex = 23;
            this.rb_single_point.Text = "Одноточечный кроссовер";
            this.rb_single_point.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-3.14 < Xj <= 3.14";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Breeding);
            this.groupBox2.Controls.Add(this.rb_Inbreeding);
            this.groupBox2.Controls.Add(this.rb_Outbreeding);
            this.groupBox2.Controls.Add(this.rb_Panmixia);
            this.groupBox2.Location = new System.Drawing.Point(15, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 69);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метод отбора родителей";
            // 
            // rb_Breeding
            // 
            this.rb_Breeding.AutoSize = true;
            this.rb_Breeding.Location = new System.Drawing.Point(3, 44);
            this.rb_Breeding.Name = "rb_Breeding";
            this.rb_Breeding.Size = new System.Drawing.Size(93, 17);
            this.rb_Breeding.TabIndex = 15;
            this.rb_Breeding.Text = "Селективный";
            this.rb_Breeding.UseVisualStyleBackColor = true;
            // 
            // rb_Inbreeding
            // 
            this.rb_Inbreeding.AutoSize = true;
            this.rb_Inbreeding.Location = new System.Drawing.Point(105, 44);
            this.rb_Inbreeding.Name = "rb_Inbreeding";
            this.rb_Inbreeding.Size = new System.Drawing.Size(80, 17);
            this.rb_Inbreeding.TabIndex = 17;
            this.rb_Inbreeding.Text = "Инбридинг";
            this.rb_Inbreeding.UseVisualStyleBackColor = true;
            // 
            // rb_Outbreeding
            // 
            this.rb_Outbreeding.AutoSize = true;
            this.rb_Outbreeding.Checked = true;
            this.rb_Outbreeding.Location = new System.Drawing.Point(105, 19);
            this.rb_Outbreeding.Name = "rb_Outbreeding";
            this.rb_Outbreeding.Size = new System.Drawing.Size(83, 17);
            this.rb_Outbreeding.TabIndex = 14;
            this.rb_Outbreeding.TabStop = true;
            this.rb_Outbreeding.Text = "Аутбридинг";
            this.rb_Outbreeding.UseVisualStyleBackColor = true;
            // 
            // rb_Panmixia
            // 
            this.rb_Panmixia.AutoSize = true;
            this.rb_Panmixia.Location = new System.Drawing.Point(3, 21);
            this.rb_Panmixia.Name = "rb_Panmixia";
            this.rb_Panmixia.Size = new System.Drawing.Size(83, 17);
            this.rb_Panmixia.TabIndex = 16;
            this.rb_Panmixia.Text = "Панмиксия";
            this.rb_Panmixia.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Количество итераций:";
            // 
            // tb_count_iterations
            // 
            this.tb_count_iterations.Location = new System.Drawing.Point(13, 178);
            this.tb_count_iterations.Name = "tb_count_iterations";
            this.tb_count_iterations.Size = new System.Drawing.Size(172, 20);
            this.tb_count_iterations.TabIndex = 21;
            // 
            // tb_show_delta
            // 
            this.tb_show_delta.Location = new System.Drawing.Point(13, 31);
            this.tb_show_delta.Multiline = true;
            this.tb_show_delta.Name = "tb_show_delta";
            this.tb_show_delta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_show_delta.Size = new System.Drawing.Size(170, 121);
            this.tb_show_delta.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Изменения delta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Начальная популяция";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(670, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Результирующая популяция";
            // 
            // btn_save_result_counting
            // 
            this.btn_save_result_counting.Enabled = false;
            this.btn_save_result_counting.Location = new System.Drawing.Point(8, 11);
            this.btn_save_result_counting.Name = "btn_save_result_counting";
            this.btn_save_result_counting.Size = new System.Drawing.Size(177, 43);
            this.btn_save_result_counting.TabIndex = 27;
            this.btn_save_result_counting.Text = "Сохранить результаты вычислений";
            this.btn_save_result_counting.UseVisualStyleBackColor = true;
            this.btn_save_result_counting.Click += new System.EventHandler(this.btn_save_result_counting_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(8, 64);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(177, 41);
            this.btn_statistic.TabIndex = 28;
            this.btn_statistic.Text = "Статистика";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // cb_load_old_popup
            // 
            this.cb_load_old_popup.AutoSize = true;
            this.cb_load_old_popup.Location = new System.Drawing.Point(8, 11);
            this.cb_load_old_popup.Name = "cb_load_old_popup";
            this.cb_load_old_popup.Size = new System.Drawing.Size(175, 17);
            this.cb_load_old_popup.TabIndex = 29;
            this.cb_load_old_popup.Text = "Загрузить старую популяцию";
            this.cb_load_old_popup.UseVisualStyleBackColor = true;
            this.cb_load_old_popup.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_save_new_popup
            // 
            this.cb_save_new_popup.AutoSize = true;
            this.cb_save_new_popup.Location = new System.Drawing.Point(8, 39);
            this.cb_save_new_popup.Name = "cb_save_new_popup";
            this.cb_save_new_popup.Size = new System.Drawing.Size(171, 17);
            this.cb_save_new_popup.TabIndex = 29;
            this.cb_save_new_popup.Text = "Сохранить новую популяцию";
            this.cb_save_new_popup.UseVisualStyleBackColor = true;
            this.cb_save_new_popup.CheckedChanged += new System.EventHandler(this.cb_save_new_popup_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_save_result_counting);
            this.panel1.Controls.Add(this.btn_counting);
            this.panel1.Controls.Add(this.btn_statistic);
            this.panel1.Location = new System.Drawing.Point(226, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 168);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_load_old_popup);
            this.panel2.Controls.Add(this.cb_save_new_popup);
            this.panel2.Location = new System.Drawing.Point(226, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 69);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tb_show_delta);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tb_count_iterations);
            this.panel3.Location = new System.Drawing.Point(226, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 205);
            this.panel3.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_final_popup);
            this.Controls.Add(this.textBox_initial_popup);
            this.Name = "Form1";
            this.Text = "Генетический алгоритм";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_count_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Count_Chromosome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_counting;
        private System.Windows.Forms.TextBox textBox_initial_popup;
        private System.Windows.Forms.TextBox textBox_final_popup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDown_count_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Mutation_probability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDown_Count_Chromosome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Size_Population;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_Outbreeding;
        private System.Windows.Forms.RadioButton rb_Breeding;
        private System.Windows.Forms.RadioButton rb_Panmixia;
        private System.Windows.Forms.RadioButton rb_Inbreeding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_count_iterations;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_changed_delta;
        private System.Windows.Forms.RadioButton rb_count_epochs;
        private System.Windows.Forms.TextBox tb_changed_delta;
        private System.Windows.Forms.TextBox tb_count_epoch;
        private System.Windows.Forms.TextBox tb_show_delta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_point_to_point;
        private System.Windows.Forms.RadioButton rb_single_point;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save_result_counting;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.CheckBox cb_load_old_popup;
        private System.Windows.Forms.CheckBox cb_save_new_popup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

