namespace GeneticAlgorithm
{
    partial class Statistic
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
            this.pictureBox_statistic = new System.Windows.Forms.PictureBox();
            this.tb_individuals_in_popup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_variable_in_population = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_statistic
            // 
            this.pictureBox_statistic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_statistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_statistic.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_statistic.Name = "pictureBox_statistic";
            this.pictureBox_statistic.Size = new System.Drawing.Size(550, 286);
            this.pictureBox_statistic.TabIndex = 0;
            this.pictureBox_statistic.TabStop = false;
            this.pictureBox_statistic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_statistic_Paint);
            // 
            // tb_individuals_in_popup
            // 
            this.tb_individuals_in_popup.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_individuals_in_popup.Location = new System.Drawing.Point(419, 0);
            this.tb_individuals_in_popup.Name = "tb_individuals_in_popup";
            this.tb_individuals_in_popup.Size = new System.Drawing.Size(131, 20);
            this.tb_individuals_in_popup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Особей в популяции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Переменных:";
            // 
            // tb_variable_in_population
            // 
            this.tb_variable_in_population.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_variable_in_population.Location = new System.Drawing.Point(265, 0);
            this.tb_variable_in_population.Name = "tb_variable_in_population";
            this.tb_variable_in_population.Size = new System.Drawing.Size(27, 20);
            this.tb_variable_in_population.TabIndex = 3;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_variable_in_population);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_individuals_in_popup);
            this.Controls.Add(this.pictureBox_statistic);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Resize += new System.EventHandler(this.Statistic_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_statistic;
        private System.Windows.Forms.TextBox tb_individuals_in_popup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_variable_in_population;
    }
}