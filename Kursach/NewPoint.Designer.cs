namespace Kursach
{
    partial class NewPoint
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Out = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Distance_box = new System.Windows.Forms.TextBox();
            this.City_box = new System.Windows.Forms.TextBox();
            this.Country_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Растояние от пункта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Страна";
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(226, 203);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(75, 23);
            this.Out.TabIndex = 12;
            this.Out.Text = "Отмена";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(168, 141);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(193, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Добавить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Distance_box
            // 
            this.Distance_box.Location = new System.Drawing.Point(168, 94);
            this.Distance_box.Name = "Distance_box";
            this.Distance_box.Size = new System.Drawing.Size(193, 23);
            this.Distance_box.TabIndex = 10;
            // 
            // City_box
            // 
            this.City_box.Location = new System.Drawing.Point(168, 54);
            this.City_box.Name = "City_box";
            this.City_box.Size = new System.Drawing.Size(193, 23);
            this.City_box.TabIndex = 9;
            // 
            // Country_box
            // 
            this.Country_box.Location = new System.Drawing.Point(168, 12);
            this.Country_box.Name = "Country_box";
            this.Country_box.Size = new System.Drawing.Size(193, 23);
            this.Country_box.TabIndex = 8;
            // 
            // NewPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Distance_box);
            this.Controls.Add(this.City_box);
            this.Controls.Add(this.Country_box);
            this.Name = "NewPoint";
            this.Text = "NewPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button Out;
        private Button Save;
        private TextBox Distance_box;
        private TextBox City_box;
        private TextBox Country_box;
    }
}