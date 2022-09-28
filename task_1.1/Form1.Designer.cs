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
            this.components = new System.ComponentModel.Container();
            this.button_bubble = new System.Windows.Forms.Button();
            this.button_quick = new System.Windows.Forms.Button();
            this.button_stupid = new System.Windows.Forms.Button();
            this.label_bubble_sorted = new System.Windows.Forms.Label();
            this.label_quick_sorted = new System.Windows.Forms.Label();
            this.label_stupid_sorted = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_stupid_time = new System.Windows.Forms.Label();
            this.label_quick_time = new System.Windows.Forms.Label();
            this.label_bubble_time = new System.Windows.Forms.Label();
            this.label_stupid_swaps = new System.Windows.Forms.Label();
            this.label_quick_swaps = new System.Windows.Forms.Label();
            this.label_bubble_swaps = new System.Windows.Forms.Label();
            this.label_stupid_comp = new System.Windows.Forms.Label();
            this.label_quick_comp = new System.Windows.Forms.Label();
            this.label_bubble_comp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_bubble
            // 
            this.button_bubble.Location = new System.Drawing.Point(6, 22);
            this.button_bubble.Name = "button_bubble";
            this.button_bubble.Size = new System.Drawing.Size(75, 23);
            this.button_bubble.TabIndex = 0;
            this.button_bubble.Text = "Bubble";
            this.button_bubble.UseVisualStyleBackColor = true;
            this.button_bubble.Click += new System.EventHandler(this.button_bubble_Click);
            // 
            // button_quick
            // 
            this.button_quick.Location = new System.Drawing.Point(6, 51);
            this.button_quick.Name = "button_quick";
            this.button_quick.Size = new System.Drawing.Size(75, 23);
            this.button_quick.TabIndex = 1;
            this.button_quick.Text = "Quick";
            this.button_quick.UseVisualStyleBackColor = true;
            this.button_quick.Click += new System.EventHandler(this.button_quick_Click);
            // 
            // button_stupid
            // 
            this.button_stupid.Location = new System.Drawing.Point(6, 80);
            this.button_stupid.Name = "button_stupid";
            this.button_stupid.Size = new System.Drawing.Size(75, 23);
            this.button_stupid.TabIndex = 2;
            this.button_stupid.Text = "Stupid";
            this.button_stupid.UseVisualStyleBackColor = true;
            this.button_stupid.Click += new System.EventHandler(this.button_stupid_Click);
            // 
            // label_bubble_sorted
            // 
            this.label_bubble_sorted.AutoSize = true;
            this.label_bubble_sorted.Location = new System.Drawing.Point(87, 26);
            this.label_bubble_sorted.Name = "label_bubble_sorted";
            this.label_bubble_sorted.Size = new System.Drawing.Size(47, 15);
            this.label_bubble_sorted.TabIndex = 3;
            this.label_bubble_sorted.Text = "Sorted: ";
            // 
            // label_quick_sorted
            // 
            this.label_quick_sorted.AutoSize = true;
            this.label_quick_sorted.Location = new System.Drawing.Point(87, 55);
            this.label_quick_sorted.Name = "label_quick_sorted";
            this.label_quick_sorted.Size = new System.Drawing.Size(47, 15);
            this.label_quick_sorted.TabIndex = 4;
            this.label_quick_sorted.Text = "Sorted: ";
            // 
            // label_stupid_sorted
            // 
            this.label_stupid_sorted.AutoSize = true;
            this.label_stupid_sorted.Location = new System.Drawing.Point(87, 84);
            this.label_stupid_sorted.Name = "label_stupid_sorted";
            this.label_stupid_sorted.Size = new System.Drawing.Size(47, 15);
            this.label_stupid_sorted.TabIndex = 5;
            this.label_stupid_sorted.Text = "Sorted: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_stupid_time);
            this.groupBox1.Controls.Add(this.label_quick_time);
            this.groupBox1.Controls.Add(this.label_bubble_time);
            this.groupBox1.Controls.Add(this.label_stupid_swaps);
            this.groupBox1.Controls.Add(this.label_quick_swaps);
            this.groupBox1.Controls.Add(this.label_bubble_swaps);
            this.groupBox1.Controls.Add(this.label_stupid_comp);
            this.groupBox1.Controls.Add(this.label_quick_comp);
            this.groupBox1.Controls.Add(this.label_bubble_comp);
            this.groupBox1.Controls.Add(this.button_bubble);
            this.groupBox1.Controls.Add(this.label_stupid_sorted);
            this.groupBox1.Controls.Add(this.button_quick);
            this.groupBox1.Controls.Add(this.label_quick_sorted);
            this.groupBox1.Controls.Add(this.button_stupid);
            this.groupBox1.Controls.Add(this.label_bubble_sorted);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label_stupid_time
            // 
            this.label_stupid_time.AutoSize = true;
            this.label_stupid_time.Location = new System.Drawing.Point(390, 84);
            this.label_stupid_time.Name = "label_stupid_time";
            this.label_stupid_time.Size = new System.Drawing.Size(39, 15);
            this.label_stupid_time.TabIndex = 14;
            this.label_stupid_time.Text = "Time: ";
            // 
            // label_quick_time
            // 
            this.label_quick_time.AutoSize = true;
            this.label_quick_time.Location = new System.Drawing.Point(390, 55);
            this.label_quick_time.Name = "label_quick_time";
            this.label_quick_time.Size = new System.Drawing.Size(39, 15);
            this.label_quick_time.TabIndex = 13;
            this.label_quick_time.Text = "Time: ";
            // 
            // label_bubble_time
            // 
            this.label_bubble_time.AutoSize = true;
            this.label_bubble_time.Location = new System.Drawing.Point(390, 26);
            this.label_bubble_time.Name = "label_bubble_time";
            this.label_bubble_time.Size = new System.Drawing.Size(39, 15);
            this.label_bubble_time.TabIndex = 12;
            this.label_bubble_time.Text = "Time: ";
            // 
            // label_stupid_swaps
            // 
            this.label_stupid_swaps.AutoSize = true;
            this.label_stupid_swaps.Location = new System.Drawing.Point(284, 84);
            this.label_stupid_swaps.Name = "label_stupid_swaps";
            this.label_stupid_swaps.Size = new System.Drawing.Size(46, 15);
            this.label_stupid_swaps.TabIndex = 11;
            this.label_stupid_swaps.Text = "Swaps: ";
            // 
            // label_quick_swaps
            // 
            this.label_quick_swaps.AutoSize = true;
            this.label_quick_swaps.Location = new System.Drawing.Point(284, 55);
            this.label_quick_swaps.Name = "label_quick_swaps";
            this.label_quick_swaps.Size = new System.Drawing.Size(46, 15);
            this.label_quick_swaps.TabIndex = 10;
            this.label_quick_swaps.Text = "Swaps: ";
            // 
            // label_bubble_swaps
            // 
            this.label_bubble_swaps.AutoSize = true;
            this.label_bubble_swaps.Location = new System.Drawing.Point(284, 26);
            this.label_bubble_swaps.Name = "label_bubble_swaps";
            this.label_bubble_swaps.Size = new System.Drawing.Size(46, 15);
            this.label_bubble_swaps.TabIndex = 9;
            this.label_bubble_swaps.Text = "Swaps: ";
            // 
            // label_stupid_comp
            // 
            this.label_stupid_comp.AutoSize = true;
            this.label_stupid_comp.Location = new System.Drawing.Point(161, 84);
            this.label_stupid_comp.Name = "label_stupid_comp";
            this.label_stupid_comp.Size = new System.Drawing.Size(62, 15);
            this.label_stupid_comp.TabIndex = 8;
            this.label_stupid_comp.Text = "Compare: ";
            // 
            // label_quick_comp
            // 
            this.label_quick_comp.AutoSize = true;
            this.label_quick_comp.Location = new System.Drawing.Point(161, 55);
            this.label_quick_comp.Name = "label_quick_comp";
            this.label_quick_comp.Size = new System.Drawing.Size(62, 15);
            this.label_quick_comp.TabIndex = 7;
            this.label_quick_comp.Text = "Compare: ";
            // 
            // label_bubble_comp
            // 
            this.label_bubble_comp.AutoSize = true;
            this.label_bubble_comp.Location = new System.Drawing.Point(161, 26);
            this.label_bubble_comp.Name = "label_bubble_comp";
            this.label_bubble_comp.Size = new System.Drawing.Size(62, 15);
            this.label_bubble_comp.TabIndex = 6;
            this.label_bubble_comp.Text = "Compare: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 143);
            this.textBox1.TabIndex = 7;
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 304);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_bubble;
        private Button button_quick;
        private Button button_stupid;
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
        private TextBox textBox1;
    }
}