namespace FormUI
{
    partial class Dashboard
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
            this.wareneingangFoundListbox = new System.Windows.Forms.ListBox();
            this.wareneingangText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.PositionListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wareneingangFoundListbox
            // 
            this.wareneingangFoundListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareneingangFoundListbox.FormattingEnabled = true;
            this.wareneingangFoundListbox.Location = new System.Drawing.Point(43, 106);
            this.wareneingangFoundListbox.Name = "wareneingangFoundListbox";
            this.wareneingangFoundListbox.Size = new System.Drawing.Size(751, 147);
            this.wareneingangFoundListbox.TabIndex = 0;
            this.wareneingangFoundListbox.SelectedIndexChanged += new System.EventHandler(this.wareneingangFoundListbox_SelectedIndexChanged);
            // 
            // wareneingangText
            // 
            this.wareneingangText.Location = new System.Drawing.Point(243, 50);
            this.wareneingangText.Name = "wareneingangText";
            this.wareneingangText.Size = new System.Drawing.Size(197, 31);
            this.wareneingangText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 53);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(199, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Wareneingang_UID";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(477, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(144, 31);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // PositionListbox
            // 
            this.PositionListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionListbox.FormattingEnabled = true;
            this.PositionListbox.Location = new System.Drawing.Point(43, 325);
            this.PositionListbox.Name = "PositionListbox";
            this.PositionListbox.Size = new System.Drawing.Size(751, 160);
            this.PositionListbox.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 591);
            this.Controls.Add(this.PositionListbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.wareneingangText);
            this.Controls.Add(this.wareneingangFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wareneingangFoundListbox;
        private System.Windows.Forms.TextBox wareneingangText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox PositionListbox;
    }
}

