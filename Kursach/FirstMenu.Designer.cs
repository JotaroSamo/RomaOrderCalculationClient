namespace Kursach
{
    partial class FirstMenu
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
            this.Save_file = new System.Windows.Forms.Button();
            this.Processing = new System.Windows.Forms.Button();
            this.New_Cargo = new System.Windows.Forms.Button();
            this.NewPoint = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.Pricetoplivo = new System.Windows.Forms.Label();
            this.Cargo_box = new System.Windows.Forms.ComboBox();
            this.To_Box = new System.Windows.Forms.ComboBox();
            this.From_box = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.GetPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_file
            // 
            this.Save_file.Location = new System.Drawing.Point(320, 292);
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(240, 23);
            this.Save_file.TabIndex = 27;
            this.Save_file.Text = "Сохранить отчет в файле";
            this.Save_file.UseVisualStyleBackColor = true;
            this.Save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // Processing
            // 
            this.Processing.Location = new System.Drawing.Point(372, 240);
            this.Processing.Name = "Processing";
            this.Processing.Size = new System.Drawing.Size(121, 23);
            this.Processing.TabIndex = 26;
            this.Processing.Text = "Рассчитать";
            this.Processing.UseVisualStyleBackColor = true;
            this.Processing.Click += new System.EventHandler(this.Processing_Click);
            // 
            // New_Cargo
            // 
            this.New_Cargo.Location = new System.Drawing.Point(372, 57);
            this.New_Cargo.Name = "New_Cargo";
            this.New_Cargo.Size = new System.Drawing.Size(168, 23);
            this.New_Cargo.TabIndex = 25;
            this.New_Cargo.Text = "Доавить новый товар";
            this.New_Cargo.UseVisualStyleBackColor = true;
            this.New_Cargo.Click += new System.EventHandler(this.New_Cargo_Click);
            // 
            // NewPoint
            // 
            this.NewPoint.Location = new System.Drawing.Point(7, 57);
            this.NewPoint.Name = "NewPoint";
            this.NewPoint.Size = new System.Drawing.Size(323, 23);
            this.NewPoint.TabIndex = 24;
            this.NewPoint.Text = "Добавить новый пункт";
            this.NewPoint.UseVisualStyleBackColor = true;
            this.NewPoint.Click += new System.EventHandler(this.NewPoint_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(7, 175);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(130, 15);
            this.Price.TabIndex = 23;
            this.Price.Text = "Стоимость перевозки:";
            // 
            // Pricetoplivo
            // 
            this.Pricetoplivo.AutoSize = true;
            this.Pricetoplivo.Location = new System.Drawing.Point(7, 405);
            this.Pricetoplivo.Name = "Pricetoplivo";
            this.Pricetoplivo.Size = new System.Drawing.Size(179, 15);
            this.Pricetoplivo.TabIndex = 22;
            this.Pricetoplivo.Text = "Цена топлива  сегодня: 2.8 BYN";
            // 
            // Cargo_box
            // 
            this.Cargo_box.FormattingEnabled = true;
            this.Cargo_box.Location = new System.Drawing.Point(372, 12);
            this.Cargo_box.Name = "Cargo_box";
            this.Cargo_box.Size = new System.Drawing.Size(168, 23);
            this.Cargo_box.TabIndex = 21;
            // 
            // To_Box
            // 
            this.To_Box.FormattingEnabled = true;
            this.To_Box.Location = new System.Drawing.Point(178, 12);
            this.To_Box.Name = "To_Box";
            this.To_Box.Size = new System.Drawing.Size(152, 23);
            this.To_Box.TabIndex = 20;
            // 
            // From_box
            // 
            this.From_box.FormattingEnabled = true;
            this.From_box.Location = new System.Drawing.Point(7, 12);
            this.From_box.Name = "From_box";
            this.From_box.Size = new System.Drawing.Size(165, 23);
            this.From_box.TabIndex = 19;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(418, 415);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(139, 23);
            this.Refresh.TabIndex = 28;
            this.Refresh.Text = "Обновить данные";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // GetPrice
            // 
            this.GetPrice.AutoSize = true;
            this.GetPrice.Location = new System.Drawing.Point(143, 175);
            this.GetPrice.Name = "GetPrice";
            this.GetPrice.Size = new System.Drawing.Size(0, 15);
            this.GetPrice.TabIndex = 29;
            // 
            // FirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.GetPrice);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Processing);
            this.Controls.Add(this.New_Cargo);
            this.Controls.Add(this.NewPoint);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Pricetoplivo);
            this.Controls.Add(this.Cargo_box);
            this.Controls.Add(this.To_Box);
            this.Controls.Add(this.From_box);
            this.Name = "FirstMenu";
            this.Text = "FirstMenu";
            this.Load += new System.EventHandler(this.FirstMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save_file;
        private Button Processing;
        private Button New_Cargo;
        private Button NewPoint;
        private Label Price;
        private Label Pricetoplivo;
        private ComboBox Cargo_box;
        private ComboBox To_Box;
        private ComboBox From_box;
        private Button Refresh;
        private Label GetPrice;
    }
}