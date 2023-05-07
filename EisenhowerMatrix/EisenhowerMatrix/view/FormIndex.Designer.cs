namespace EisenhowerMatrix
{
    partial class FormIndex
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCaseClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxQuick = new System.Windows.Forms.CheckBox();
            this.checkBoxImportant = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCaseHeaven = new System.Windows.Forms.Button();
            this.buttonCaseAdd = new System.Windows.Forms.Button();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.labelLabel = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panelIQ = new System.Windows.Forms.Panel();
            this.labelIQ = new System.Windows.Forms.Label();
            this.panelINQ = new System.Windows.Forms.Panel();
            this.labelINQ = new System.Windows.Forms.Label();
            this.panelNIQ = new System.Windows.Forms.Panel();
            this.labelNIQ = new System.Windows.Forms.Label();
            this.panelNINQ = new System.Windows.Forms.Panel();
            this.labelNINQ = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panelIQ.SuspendLayout();
            this.panelINQ.SuspendLayout();
            this.panelNIQ.SuspendLayout();
            this.panelNINQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(185)))), ((int)(((byte)(205)))));
            this.panelButtons.Controls.Add(this.buttonSettings);
            this.panelButtons.Controls.Add(this.buttonCaseClose);
            this.panelButtons.Controls.Add(this.groupBox1);
            this.panelButtons.Controls.Add(this.buttonExit);
            this.panelButtons.Controls.Add(this.buttonCaseHeaven);
            this.panelButtons.Controls.Add(this.buttonCaseAdd);
            this.panelButtons.Controls.Add(this.panelLabel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(240, 844);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(7, 654);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(222, 76);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonCaseClose
            // 
            this.buttonCaseClose.FlatAppearance.BorderSize = 0;
            this.buttonCaseClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaseClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCaseClose.Location = new System.Drawing.Point(13, 302);
            this.buttonCaseClose.Name = "buttonCaseClose";
            this.buttonCaseClose.Size = new System.Drawing.Size(222, 76);
            this.buttonCaseClose.TabIndex = 5;
            this.buttonCaseClose.Text = "Закрыть событие";
            this.buttonCaseClose.UseVisualStyleBackColor = true;
            this.buttonCaseClose.Click += new System.EventHandler(this.buttonCaseClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxQuick);
            this.groupBox1.Controls.Add(this.checkBoxImportant);
            this.groupBox1.Location = new System.Drawing.Point(13, 555);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxQuick
            // 
            this.checkBoxQuick.AutoSize = true;
            this.checkBoxQuick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxQuick.Location = new System.Drawing.Point(6, 55);
            this.checkBoxQuick.Name = "checkBoxQuick";
            this.checkBoxQuick.Size = new System.Drawing.Size(101, 29);
            this.checkBoxQuick.TabIndex = 1;
            this.checkBoxQuick.Text = "Срочно";
            this.checkBoxQuick.UseVisualStyleBackColor = true;
            // 
            // checkBoxImportant
            // 
            this.checkBoxImportant.AutoSize = true;
            this.checkBoxImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxImportant.Location = new System.Drawing.Point(6, 25);
            this.checkBoxImportant.Name = "checkBoxImportant";
            this.checkBoxImportant.Size = new System.Drawing.Size(94, 29);
            this.checkBoxImportant.TabIndex = 0;
            this.checkBoxImportant.Text = "Важно";
            this.checkBoxImportant.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(7, 736);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(222, 76);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCaseHeaven
            // 
            this.buttonCaseHeaven.FlatAppearance.BorderSize = 0;
            this.buttonCaseHeaven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaseHeaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCaseHeaven.Location = new System.Drawing.Point(7, 220);
            this.buttonCaseHeaven.Name = "buttonCaseHeaven";
            this.buttonCaseHeaven.Size = new System.Drawing.Size(222, 76);
            this.buttonCaseHeaven.TabIndex = 2;
            this.buttonCaseHeaven.Text = "Выполненные события";
            this.buttonCaseHeaven.UseVisualStyleBackColor = true;
            this.buttonCaseHeaven.Click += new System.EventHandler(this.buttonCaseHeaven_Click);
            // 
            // buttonCaseAdd
            // 
            this.buttonCaseAdd.FlatAppearance.BorderSize = 0;
            this.buttonCaseAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaseAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCaseAdd.Location = new System.Drawing.Point(7, 138);
            this.buttonCaseAdd.Name = "buttonCaseAdd";
            this.buttonCaseAdd.Size = new System.Drawing.Size(222, 76);
            this.buttonCaseAdd.TabIndex = 1;
            this.buttonCaseAdd.Text = "Добавить событие";
            this.buttonCaseAdd.UseVisualStyleBackColor = true;
            this.buttonCaseAdd.Click += new System.EventHandler(this.buttonCaseAdd_Click);
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(146)))), ((int)(((byte)(163)))));
            this.panelLabel.Controls.Add(this.labelLabel);
            this.panelLabel.Location = new System.Drawing.Point(0, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(240, 100);
            this.panelLabel.TabIndex = 0;
            // 
            // labelLabel
            // 
            this.labelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLabel.Location = new System.Drawing.Point(0, 0);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(240, 100);
            this.labelLabel.TabIndex = 0;
            this.labelLabel.Text = "Helltale";
            this.labelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLabel.Click += new System.EventHandler(this.labelLabel_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(211)))), ((int)(((byte)(240)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(240, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1438, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(324, 643);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(635, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(324, 643);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(966, 169);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(324, 643);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1296, 169);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(324, 643);
            this.dataGridView4.TabIndex = 5;
            // 
            // panelIQ
            // 
            this.panelIQ.BackColor = System.Drawing.Color.Brown;
            this.panelIQ.Controls.Add(this.labelIQ);
            this.panelIQ.Location = new System.Drawing.Point(305, 123);
            this.panelIQ.Name = "panelIQ";
            this.panelIQ.Size = new System.Drawing.Size(324, 40);
            this.panelIQ.TabIndex = 6;
            // 
            // labelIQ
            // 
            this.labelIQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIQ.Location = new System.Drawing.Point(0, 0);
            this.labelIQ.Name = "labelIQ";
            this.labelIQ.Size = new System.Drawing.Size(324, 40);
            this.labelIQ.TabIndex = 0;
            this.labelIQ.Text = "Важно | Срочно";
            this.labelIQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelINQ
            // 
            this.panelINQ.BackColor = System.Drawing.Color.DarkOrange;
            this.panelINQ.Controls.Add(this.labelINQ);
            this.panelINQ.Location = new System.Drawing.Point(635, 123);
            this.panelINQ.Name = "panelINQ";
            this.panelINQ.Size = new System.Drawing.Size(324, 40);
            this.panelINQ.TabIndex = 7;
            // 
            // labelINQ
            // 
            this.labelINQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelINQ.Location = new System.Drawing.Point(0, 0);
            this.labelINQ.Name = "labelINQ";
            this.labelINQ.Size = new System.Drawing.Size(324, 40);
            this.labelINQ.TabIndex = 0;
            this.labelINQ.Text = "Важно | Не срочно";
            this.labelINQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNIQ
            // 
            this.panelNIQ.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelNIQ.Controls.Add(this.labelNIQ);
            this.panelNIQ.Location = new System.Drawing.Point(966, 123);
            this.panelNIQ.Name = "panelNIQ";
            this.panelNIQ.Size = new System.Drawing.Size(324, 40);
            this.panelNIQ.TabIndex = 7;
            // 
            // labelNIQ
            // 
            this.labelNIQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNIQ.Location = new System.Drawing.Point(0, 0);
            this.labelNIQ.Name = "labelNIQ";
            this.labelNIQ.Size = new System.Drawing.Size(324, 40);
            this.labelNIQ.TabIndex = 0;
            this.labelNIQ.Text = "Не важно | Срочно";
            this.labelNIQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNINQ
            // 
            this.panelNINQ.BackColor = System.Drawing.Color.Olive;
            this.panelNINQ.Controls.Add(this.labelNINQ);
            this.panelNINQ.Location = new System.Drawing.Point(1296, 123);
            this.panelNINQ.Name = "panelNINQ";
            this.panelNINQ.Size = new System.Drawing.Size(324, 40);
            this.panelNINQ.TabIndex = 7;
            // 
            // labelNINQ
            // 
            this.labelNINQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNINQ.Location = new System.Drawing.Point(0, 0);
            this.labelNINQ.Name = "labelNINQ";
            this.labelNINQ.Size = new System.Drawing.Size(324, 40);
            this.labelNINQ.TabIndex = 0;
            this.labelNINQ.Text = "Не срочно | Не важно";
            this.labelNINQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.panelNINQ);
            this.Controls.Add(this.panelNIQ);
            this.Controls.Add(this.panelINQ);
            this.Controls.Add(this.panelIQ);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрица Эйзенхауэра";
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panelIQ.ResumeLayout(false);
            this.panelINQ.ResumeLayout(false);
            this.panelNIQ.ResumeLayout(false);
            this.panelNINQ.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonCaseHeaven;
        private System.Windows.Forms.Button buttonCaseAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panelIQ;
        private System.Windows.Forms.Label labelIQ;
        private System.Windows.Forms.Panel panelINQ;
        private System.Windows.Forms.Label labelINQ;
        private System.Windows.Forms.Panel panelNIQ;
        private System.Windows.Forms.Panel panelNINQ;
        private System.Windows.Forms.Label labelNIQ;
        private System.Windows.Forms.Label labelNINQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxQuick;
        private System.Windows.Forms.CheckBox checkBoxImportant;
        private System.Windows.Forms.Button buttonCaseClose;
        private System.Windows.Forms.Button buttonSettings;
    }
}

