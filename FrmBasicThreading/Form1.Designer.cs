namespace FrmBasicThreading
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
            saveFileDialog1 = new SaveFileDialog();
            lblThread = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThread.Location = new Point(62, 38);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(214, 19);
            lblThread.TabIndex = 0;
            lblThread.Text = "- Before Starting Thread -";
            lblThread.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(130, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 145);
            Controls.Add(button1);
            Controls.Add(lblThread);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Label lblThread;
        private Button button1;
    }
}