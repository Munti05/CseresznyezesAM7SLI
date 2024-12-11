namespace WinFormsApp1
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
            panel1 = new Panel();
            buttonVinyls = new Button();
            buttonusers = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 371);
            panel1.TabIndex = 0;
            // 
            // buttonVinyls
            // 
            buttonVinyls.Anchor = AnchorStyles.Bottom;
            buttonVinyls.Location = new Point(194, 428);
            buttonVinyls.Name = "buttonVinyls";
            buttonVinyls.Size = new Size(215, 23);
            buttonVinyls.TabIndex = 0;
            buttonVinyls.Text = "Vinyls";
            buttonVinyls.UseVisualStyleBackColor = true;
            buttonVinyls.Click += buttonVinyls_Click;
            // 
            // buttonusers
            // 
            buttonusers.Anchor = AnchorStyles.Bottom;
            buttonusers.Location = new Point(415, 428);
            buttonusers.Name = "buttonusers";
            buttonusers.Size = new Size(215, 23);
            buttonusers.TabIndex = 1;
            buttonusers.Text = "Users";
            buttonusers.UseVisualStyleBackColor = true;
            buttonusers.Click += buttonusers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 463);
            Controls.Add(buttonusers);
            Controls.Add(buttonVinyls);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonVinyls;
        private Button buttonusers;
    }
}