namespace animation_sql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.season_label = new System.Windows.Forms.Label();
            this.season_combobox = new System.Windows.Forms.ComboBox();
            this.year_combobox = new System.Windows.Forms.ComboBox();
            this.year_label = new System.Windows.Forms.Label();
            this.season_btn = new System.Windows.Forms.Button();
            this.how_many_btn = new System.Windows.Forms.Button();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.gender_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // season_label
            // 
            this.season_label.AutoSize = true;
            this.season_label.Location = new System.Drawing.Point(82, 34);
            this.season_label.Name = "season_label";
            this.season_label.Size = new System.Drawing.Size(35, 12);
            this.season_label.TabIndex = 1;
            this.season_label.Text = "season";
            // 
            // season_combobox
            // 
            this.season_combobox.FormattingEnabled = true;
            this.season_combobox.Location = new System.Drawing.Point(123, 31);
            this.season_combobox.Name = "season_combobox";
            this.season_combobox.Size = new System.Drawing.Size(121, 20);
            this.season_combobox.TabIndex = 2;
            // 
            // year_combobox
            // 
            this.year_combobox.FormattingEnabled = true;
            this.year_combobox.Location = new System.Drawing.Point(341, 31);
            this.year_combobox.Name = "year_combobox";
            this.year_combobox.Size = new System.Drawing.Size(121, 20);
            this.year_combobox.TabIndex = 4;
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(302, 34);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(25, 12);
            this.year_label.TabIndex = 3;
            this.year_label.Text = "year";
            // 
            // season_btn
            // 
            this.season_btn.Location = new System.Drawing.Point(521, 29);
            this.season_btn.Name = "season_btn";
            this.season_btn.Size = new System.Drawing.Size(121, 22);
            this.season_btn.TabIndex = 5;
            this.season_btn.Text = "season_year_query";
            this.season_btn.UseVisualStyleBackColor = true;
            this.season_btn.Click += new System.EventHandler(this.season_btn_Click);
            // 
            // how_many_btn
            // 
            this.how_many_btn.Location = new System.Drawing.Point(521, 72);
            this.how_many_btn.Name = "how_many_btn";
            this.how_many_btn.Size = new System.Drawing.Size(75, 23);
            this.how_many_btn.TabIndex = 10;
            this.how_many_btn.Text = "how_many";
            this.how_many_btn.UseVisualStyleBackColor = true;
            this.how_many_btn.Click += new System.EventHandler(this.how_many_btn_Click);
            // 
            // gender_combobox
            // 
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Location = new System.Drawing.Point(123, 74);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(121, 20);
            this.gender_combobox.TabIndex = 7;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(84, 77);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(37, 12);
            this.gender_label.TabIndex = 6;
            this.gender_label.Text = "gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 448);
            this.Controls.Add(this.how_many_btn);
            this.Controls.Add(this.gender_combobox);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.season_btn);
            this.Controls.Add(this.year_combobox);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.season_combobox);
            this.Controls.Add(this.season_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label season_label;
        private System.Windows.Forms.ComboBox season_combobox;
        private System.Windows.Forms.ComboBox year_combobox;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Button season_btn;
        private System.Windows.Forms.Button how_many_btn;
        private System.Windows.Forms.ComboBox gender_combobox;
        private System.Windows.Forms.Label gender_label;
    }
}

