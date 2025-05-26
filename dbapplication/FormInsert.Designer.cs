namespace labproject
{
    partial class FormInsert
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox3Insert = new System.Windows.Forms.TextBox();
            this.textBox2Insert = new System.Windows.Forms.TextBox();
            this.textBox1Insert = new System.Windows.Forms.TextBox();
            this.label3Insert = new System.Windows.Forms.Label();
            this.label2Insert = new System.Windows.Forms.Label();
            this.label1Insert = new System.Windows.Forms.Label();
            this.ActiveTicked = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(350, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(350, 85);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(350, 60);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox3Insert
            // 
            this.textBox3Insert.Location = new System.Drawing.Point(151, 108);
            this.textBox3Insert.Name = "textBox3Insert";
            this.textBox3Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox3Insert.TabIndex = 24;
            // 
            // textBox2Insert
            // 
            this.textBox2Insert.Location = new System.Drawing.Point(151, 85);
            this.textBox2Insert.Name = "textBox2Insert";
            this.textBox2Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox2Insert.TabIndex = 23;
            // 
            // textBox1Insert
            // 
            this.textBox1Insert.Location = new System.Drawing.Point(151, 63);
            this.textBox1Insert.Name = "textBox1Insert";
            this.textBox1Insert.Size = new System.Drawing.Size(173, 20);
            this.textBox1Insert.TabIndex = 22;
            // 
            // label3Insert
            // 
            this.label3Insert.Location = new System.Drawing.Point(41, 110);
            this.label3Insert.Name = "label3Insert";
            this.label3Insert.Size = new System.Drawing.Size(99, 22);
            this.label3Insert.TabIndex = 19;
            this.label3Insert.Text = "New Access Code";
            // 
            // label2Insert
            // 
            this.label2Insert.Location = new System.Drawing.Point(41, 87);
            this.label2Insert.Name = "label2Insert";
            this.label2Insert.Size = new System.Drawing.Size(151, 22);
            this.label2Insert.TabIndex = 18;
            this.label2Insert.Text = "New Employee Name";
            // 
            // label1Insert
            // 
            this.label1Insert.Location = new System.Drawing.Point(41, 65);
            this.label1Insert.Name = "label1Insert";
            this.label1Insert.Size = new System.Drawing.Size(99, 17);
            this.label1Insert.TabIndex = 17;
            this.label1Insert.Text = "New Employee ID";
            // 
            // ActiveTicked
            // 
            this.ActiveTicked.AutoSize = true;
            this.ActiveTicked.Location = new System.Drawing.Point(12, 12);
            this.ActiveTicked.Name = "ActiveTicked";
            this.ActiveTicked.Size = new System.Drawing.Size(55, 17);
            this.ActiveTicked.TabIndex = 0;
            this.ActiveTicked.TabStop = true;
            this.ActiveTicked.Text = "Active";
            this.ActiveTicked.UseVisualStyleBackColor = true;
            this.ActiveTicked.CheckedChanged += new System.EventHandler(this.RBSchool_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Access Code";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 36;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ActiveTicked);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox3Insert);
            this.Controls.Add(this.textBox2Insert);
            this.Controls.Add(this.textBox1Insert);
            this.Controls.Add(this.label3Insert);
            this.Controls.Add(this.label2Insert);
            this.Controls.Add(this.label1Insert);
            this.Name = "FormInsert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox3Insert;
        private System.Windows.Forms.TextBox textBox2Insert;
        private System.Windows.Forms.TextBox textBox1Insert;
        private System.Windows.Forms.Label label3Insert;
        private System.Windows.Forms.Label label2Insert;
        private System.Windows.Forms.Label label1Insert;
        private System.Windows.Forms.RadioButton ActiveTicked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}