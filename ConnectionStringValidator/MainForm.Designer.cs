namespace ConnectionStringValidator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            textBox = new TextBox();
            buttonCheck = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 0;
            label1.Text = "Connection String:";
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 12F);
            textBox.Location = new Point(12, 45);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Enter your connection string here ...";
            textBox.Size = new Size(500, 51);
            textBox.TabIndex = 1;
            // 
            // buttonCheck
            // 
            buttonCheck.Font = new Font("Segoe UI", 12F);
            buttonCheck.Location = new Point(112, 114);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(300, 44);
            buttonCheck.TabIndex = 2;
            buttonCheck.Text = "CHECK CONNECTION";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 216);
            Controls.Add(buttonCheck);
            Controls.Add(textBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection String Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private Button buttonCheck;
    }
}
