namespace TreesZaimov
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
            lblName = new Label();
            lblNameBG = new Label();
            txtName = new TextBox();
            txtNameBG = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 26);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblNameBG
            // 
            lblNameBG.AutoSize = true;
            lblNameBG.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameBG.Location = new Point(178, 11);
            lblNameBG.Name = "lblNameBG";
            lblNameBG.Size = new Size(106, 25);
            lblNameBG.TabIndex = 1;
            lblNameBG.Text = "Name_BG:";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(101, 23);
            txtName.TabIndex = 2;
            // 
            // txtNameBG
            // 
            txtNameBG.Location = new Point(178, 39);
            txtNameBG.Name = "txtNameBG";
            txtNameBG.Size = new Size(122, 23);
            txtNameBG.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(85, 82);
            button1.Name = "button1";
            button1.Size = new Size(127, 78);
            button1.TabIndex = 4;
            button1.Text = "Insert into razred";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(312, 214);
            Controls.Add(button1);
            Controls.Add(txtNameBG);
            Controls.Add(txtName);
            Controls.Add(lblNameBG);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Conecting Table";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblNameBG;
        private TextBox txtName;
        private TextBox txtNameBG;
        private Button button1;
    }
}
