namespace EisenhowerMatrix.view
{
    partial class FormAdd
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxImp = new System.Windows.Forms.CheckBox();
            this.checkBoxQui = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 26);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(526, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // checkBoxImp
            // 
            this.checkBoxImp.AutoSize = true;
            this.checkBoxImp.Location = new System.Drawing.Point(231, 183);
            this.checkBoxImp.Name = "checkBoxImp";
            this.checkBoxImp.Size = new System.Drawing.Size(131, 24);
            this.checkBoxImp.TabIndex = 4;
            this.checkBoxImp.Text = "checkBoxImp";
            this.checkBoxImp.UseVisualStyleBackColor = true;
            // 
            // checkBoxQui
            // 
            this.checkBoxQui.AutoSize = true;
            this.checkBoxQui.Location = new System.Drawing.Point(231, 209);
            this.checkBoxQui.Name = "checkBoxQui";
            this.checkBoxQui.Size = new System.Drawing.Size(128, 24);
            this.checkBoxQui.TabIndex = 5;
            this.checkBoxQui.Text = "checkBoxQui";
            this.checkBoxQui.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 255);
            this.Controls.Add(this.checkBoxQui);
            this.Controls.Add(this.checkBoxImp);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxImp;
        private System.Windows.Forms.CheckBox checkBoxQui;
    }
}