namespace GUIDemo
{
    partial class return_book
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
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.friday = new System.Windows.Forms.RadioButton();
            this.thursday = new System.Windows.Forms.RadioButton();
            this.wednesday = new System.Windows.Forms.RadioButton();
            this.tuesday = new System.Windows.Forms.RadioButton();
            this.monday = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.submit.Location = new System.Drawing.Point(106, 219);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 39);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label2.Location = new System.Drawing.Point(135, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "everyday 8am to 5pm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "return book";
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(79, 182);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(66, 20);
            this.friday.TabIndex = 12;
            this.friday.TabStop = true;
            this.friday.Text = "Friday";
            this.friday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(79, 156);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(85, 20);
            this.thursday.TabIndex = 11;
            this.thursday.TabStop = true;
            this.thursday.Text = "Thursday";
            this.thursday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(79, 130);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(102, 20);
            this.wednesday.TabIndex = 10;
            this.wednesday.TabStop = true;
            this.wednesday.Text = "Wednesday";
            this.wednesday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(79, 104);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(82, 20);
            this.tuesday.TabIndex = 9;
            this.tuesday.TabStop = true;
            this.tuesday.Text = "Tuesday";
            this.tuesday.UseVisualStyleBackColor = true;
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(79, 75);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(77, 20);
            this.monday.TabIndex = 8;
            this.monday.TabStop = true;
            this.monday.Text = "Monday";
            this.monday.UseVisualStyleBackColor = true;
            // 
            // return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 281);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Name = "return_book";
            this.Text = "return_book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton friday;
        private System.Windows.Forms.RadioButton thursday;
        private System.Windows.Forms.RadioButton wednesday;
        private System.Windows.Forms.RadioButton tuesday;
        private System.Windows.Forms.RadioButton monday;
    }
}