namespace labproject
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.UpdateRecord = new System.Windows.Forms.Button();
            this.InsertRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(377, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "E X I T";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Silver;
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(18, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(87, 38);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Disconnected";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpdateRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateRecord.Location = new System.Drawing.Point(114, 60);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(85, 39);
            this.UpdateRecord.TabIndex = 6;
            this.UpdateRecord.Text = "UpdateRecord";
            this.UpdateRecord.UseVisualStyleBackColor = false;
            this.UpdateRecord.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertRecord
            // 
            this.InsertRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.InsertRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertRecord.Location = new System.Drawing.Point(21, 60);
            this.InsertRecord.Name = "InsertRecord";
            this.InsertRecord.Size = new System.Drawing.Size(87, 39);
            this.InsertRecord.TabIndex = 7;
            this.InsertRecord.Text = "InsertRecord";
            this.InsertRecord.UseVisualStyleBackColor = false;
            this.InsertRecord.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecord.Location = new System.Drawing.Point(205, 61);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(85, 38);
            this.DeleteRecord.TabIndex = 8;
            this.DeleteRecord.Text = "DeleteRecord";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(135, 13);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(308, 37);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "Enter Access Code";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 353);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.InsertRecord);
            this.Controls.Add(this.UpdateRecord);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DatabaseApp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button UpdateRecord;
        private System.Windows.Forms.Button InsertRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

