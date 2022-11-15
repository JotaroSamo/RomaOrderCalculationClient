namespace Kursach
{
    partial class NewCargo
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
            this.Save = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.NameCargo = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 109);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(186, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Добавить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(204, 109);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(75, 23);
            this.Out.TabIndex = 1;
            this.Out.Text = "Отмена";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // NameCargo
            // 
            this.NameCargo.Location = new System.Drawing.Point(12, 27);
            this.NameCargo.Name = "NameCargo";
            this.NameCargo.Size = new System.Drawing.Size(267, 23);
            this.NameCargo.TabIndex = 2;
            this.NameCargo.Text = "Name";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(12, 69);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(267, 23);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // NewCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 153);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.NameCargo);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Save);
            this.Name = "NewCargo";
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save;
        private Button Out;
        private TextBox NameCargo;
        private TextBox Price;
    }
}