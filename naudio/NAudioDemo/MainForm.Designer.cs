namespace NAudioDemo
{
    partial class MainForm
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
            this.listBoxDemos = new System.Windows.Forms.ListBox();
            this.buttonLoadDemo = new System.Windows.Forms.Button();
            this.panelDemo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDemos
            // 
            this.listBoxDemos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxDemos.FormattingEnabled = true;
            this.listBoxDemos.ItemHeight = 12;
            this.listBoxDemos.Location = new System.Drawing.Point(12, 47);
            this.listBoxDemos.Name = "listBoxDemos";
            this.listBoxDemos.Size = new System.Drawing.Size(120, 304);
            this.listBoxDemos.TabIndex = 3;
            this.listBoxDemos.DoubleClick += new System.EventHandler(this.listBoxDemos_DoubleClick);
            // 
            // buttonLoadDemo
            // 
            this.buttonLoadDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadDemo.Location = new System.Drawing.Point(13, 366);
            this.buttonLoadDemo.Name = "buttonLoadDemo";
            this.buttonLoadDemo.Size = new System.Drawing.Size(75, 21);
            this.buttonLoadDemo.TabIndex = 4;
            this.buttonLoadDemo.Text = "Load";
            this.buttonLoadDemo.UseVisualStyleBackColor = true;
            this.buttonLoadDemo.Click += new System.EventHandler(this.buttonLoadDemo_Click);
            // 
            // panelDemo
            // 
            this.panelDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDemo.Location = new System.Drawing.Point(139, 13);
            this.panelDemo.Name = "panelDemo";
            this.panelDemo.Size = new System.Drawing.Size(681, 374);
            this.panelDemo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a demo, and click Load";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDemo);
            this.Controls.Add(this.buttonLoadDemo);
            this.Controls.Add(this.listBoxDemos);
            this.Name = "MainForm";
            this.Text = "NAudio Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDemos;
        private System.Windows.Forms.Button buttonLoadDemo;
        private System.Windows.Forms.Panel panelDemo;
        private System.Windows.Forms.Label label1;

    }
}

