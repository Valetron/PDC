namespace task1
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
            this.label_bubble_sorted = new System.Windows.Forms.Label();
            this.label_quick_sorted = new System.Windows.Forms.Label();
            this.label_stupid_sorted = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.checkBoxThreading = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_stupid_time = new System.Windows.Forms.Label();
            this.label_quick_time = new System.Windows.Forms.Label();
            this.label_bubble_time = new System.Windows.Forms.Label();
            this.label_stupid_swaps = new System.Windows.Forms.Label();
            this.label_quick_swaps = new System.Windows.Forms.Label();
            this.label_bubble_swaps = new System.Windows.Forms.Label();
            this.label_stupid_comp = new System.Windows.Forms.Label();
            this.label_quick_comp = new System.Windows.Forms.Label();
            this.label_bubble_comp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_bubble_sorted
            // 
            this.label_bubble_sorted.AutoSize = true;
            this.label_bubble_sorted.Location = new System.Drawing.Point(241, 19);
            this.label_bubble_sorted.Name = "label_bubble_sorted";
            this.label_bubble_sorted.Size = new System.Drawing.Size(47, 15);
            this.label_bubble_sorted.TabIndex = 3;
            this.label_bubble_sorted.Text = "Sorted: ";
            // 
            // label_quick_sorted
            // 
            this.label_quick_sorted.AutoSize = true;
            this.label_quick_sorted.Location = new System.Drawing.Point(241, 48);
            this.label_quick_sorted.Name = "label_quick_sorted";
            this.label_quick_sorted.Size = new System.Drawing.Size(47, 15);
            this.label_quick_sorted.TabIndex = 4;
            this.label_quick_sorted.Text = "Sorted: ";
            // 
            // label_stupid_sorted
            // 
            this.label_stupid_sorted.AutoSize = true;
            this.label_stupid_sorted.Location = new System.Drawing.Point(241, 77);
            this.label_stupid_sorted.Name = "label_stupid_sorted";
            this.label_stupid_sorted.Size = new System.Drawing.Size(47, 15);
            this.label_stupid_sorted.TabIndex = 5;
            this.label_stupid_sorted.Text = "Sorted: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalTime);
            this.groupBox1.Controls.Add(this.checkBoxThreading);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label_stupid_time);
            this.groupBox1.Controls.Add(this.label_quick_time);
            this.groupBox1.Controls.Add(this.label_bubble_time);
            this.groupBox1.Controls.Add(this.label_stupid_swaps);
            this.groupBox1.Controls.Add(this.label_quick_swaps);
            this.groupBox1.Controls.Add(this.label_bubble_swaps);
            this.groupBox1.Controls.Add(this.label_stupid_comp);
            this.groupBox1.Controls.Add(this.label_quick_comp);
            this.groupBox1.Controls.Add(this.label_bubble_comp);
            this.groupBox1.Controls.Add(this.label_stupid_sorted);
            this.groupBox1.Controls.Add(this.label_quick_sorted);
            this.groupBox1.Controls.Add(this.label_bubble_sorted);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(518, 109);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(65, 15);
            this.labelTotalTime.TabIndex = 24;
            this.labelTotalTime.Text = "Total time: ";
            // 
            // checkBoxThreading
            // 
            this.checkBoxThreading.AutoSize = true;
            this.checkBoxThreading.Location = new System.Drawing.Point(29, 48);
            this.checkBoxThreading.Name = "checkBoxThreading";
            this.checkBoxThreading.Size = new System.Drawing.Size(127, 19);
            this.checkBoxThreading.TabIndex = 23;
            this.checkBoxThreading.Text = "Use multithreading";
            this.checkBoxThreading.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Stupid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bubble";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(29, 77);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(120, 23);
            this.buttonSort.TabIndex = 17;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Arrays size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1000",
            "10000",
            "50000",
            "100000",
            "500000"});
            this.comboBox1.Location = new System.Drawing.Point(74, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // label_stupid_time
            // 
            this.label_stupid_time.AutoSize = true;
            this.label_stupid_time.Location = new System.Drawing.Point(544, 77);
            this.label_stupid_time.Name = "label_stupid_time";
            this.label_stupid_time.Size = new System.Drawing.Size(39, 15);
            this.label_stupid_time.TabIndex = 14;
            this.label_stupid_time.Text = "Time: ";
            // 
            // label_quick_time
            // 
            this.label_quick_time.AutoSize = true;
            this.label_quick_time.Location = new System.Drawing.Point(544, 48);
            this.label_quick_time.Name = "label_quick_time";
            this.label_quick_time.Size = new System.Drawing.Size(39, 15);
            this.label_quick_time.TabIndex = 13;
            this.label_quick_time.Text = "Time: ";
            // 
            // label_bubble_time
            // 
            this.label_bubble_time.AutoSize = true;
            this.label_bubble_time.Location = new System.Drawing.Point(544, 19);
            this.label_bubble_time.Name = "label_bubble_time";
            this.label_bubble_time.Size = new System.Drawing.Size(39, 15);
            this.label_bubble_time.TabIndex = 12;
            this.label_bubble_time.Text = "Time: ";
            // 
            // label_stupid_swaps
            // 
            this.label_stupid_swaps.AutoSize = true;
            this.label_stupid_swaps.Location = new System.Drawing.Point(438, 77);
            this.label_stupid_swaps.Name = "label_stupid_swaps";
            this.label_stupid_swaps.Size = new System.Drawing.Size(46, 15);
            this.label_stupid_swaps.TabIndex = 11;
            this.label_stupid_swaps.Text = "Swaps: ";
            // 
            // label_quick_swaps
            // 
            this.label_quick_swaps.AutoSize = true;
            this.label_quick_swaps.Location = new System.Drawing.Point(438, 48);
            this.label_quick_swaps.Name = "label_quick_swaps";
            this.label_quick_swaps.Size = new System.Drawing.Size(46, 15);
            this.label_quick_swaps.TabIndex = 10;
            this.label_quick_swaps.Text = "Swaps: ";
            // 
            // label_bubble_swaps
            // 
            this.label_bubble_swaps.AutoSize = true;
            this.label_bubble_swaps.Location = new System.Drawing.Point(438, 19);
            this.label_bubble_swaps.Name = "label_bubble_swaps";
            this.label_bubble_swaps.Size = new System.Drawing.Size(46, 15);
            this.label_bubble_swaps.TabIndex = 9;
            this.label_bubble_swaps.Text = "Swaps: ";
            // 
            // label_stupid_comp
            // 
            this.label_stupid_comp.AutoSize = true;
            this.label_stupid_comp.Location = new System.Drawing.Point(315, 77);
            this.label_stupid_comp.Name = "label_stupid_comp";
            this.label_stupid_comp.Size = new System.Drawing.Size(62, 15);
            this.label_stupid_comp.TabIndex = 8;
            this.label_stupid_comp.Text = "Compare: ";
            // 
            // label_quick_comp
            // 
            this.label_quick_comp.AutoSize = true;
            this.label_quick_comp.Location = new System.Drawing.Point(315, 48);
            this.label_quick_comp.Name = "label_quick_comp";
            this.label_quick_comp.Size = new System.Drawing.Size(62, 15);
            this.label_quick_comp.TabIndex = 7;
            this.label_quick_comp.Text = "Compare: ";
            // 
            // label_bubble_comp
            // 
            this.label_bubble_comp.AutoSize = true;
            this.label_bubble_comp.Location = new System.Drawing.Point(315, 19);
            this.label_bubble_comp.Name = "label_bubble_comp";
            this.label_bubble_comp.Size = new System.Drawing.Size(62, 15);
            this.label_bubble_comp.TabIndex = 6;
            this.label_bubble_comp.Text = "Compare: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 186);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label_bubble_sorted;
        private Label label_quick_sorted;
        private Label label_stupid_sorted;
        private GroupBox groupBox1;
        private Label label_stupid_time;
        private Label label_quick_time;
        private Label label_bubble_time;
        private Label label_stupid_swaps;
        private Label label_quick_swaps;
        private Label label_bubble_swaps;
        private Label label_stupid_comp;
        private Label label_quick_comp;
        private Label label_bubble_comp;
        private ComboBox comboBox1;
        private Label label1;
        private Button buttonSort;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBoxThreading;
        private Label labelTotalTime;
    }
}