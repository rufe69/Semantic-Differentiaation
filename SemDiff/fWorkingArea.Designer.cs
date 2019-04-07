namespace SemDiff
{
    partial class fWorkingArea
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
            this.btCalculate = new System.Windows.Forms.Button();
            this.gboxTests = new System.Windows.Forms.GroupBox();
            this.btTestProvocation = new System.Windows.Forms.Button();
            this.btTestSuppression = new System.Windows.Forms.Button();
            this.btTestConflict = new System.Windows.Forms.Button();
            this.btTestAbuse = new System.Windows.Forms.Button();
            this.btTestBulling = new System.Windows.Forms.Button();
            this.btTestAggression = new System.Windows.Forms.Button();
            this.gboxResults = new System.Windows.Forms.GroupBox();
            this.btRProvocation = new System.Windows.Forms.Button();
            this.btRAggression = new System.Windows.Forms.Button();
            this.btRSuppression = new System.Windows.Forms.Button();
            this.btRBulling = new System.Windows.Forms.Button();
            this.btRConflict = new System.Windows.Forms.Button();
            this.btRAbuse = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.tbAddedInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxTests.SuspendLayout();
            this.gboxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(12, 314);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(406, 72);
            this.btCalculate.TabIndex = 1;
            this.btCalculate.Text = "Рассчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // gboxTests
            // 
            this.gboxTests.Controls.Add(this.btTestProvocation);
            this.gboxTests.Controls.Add(this.btTestSuppression);
            this.gboxTests.Controls.Add(this.btTestConflict);
            this.gboxTests.Controls.Add(this.btTestAbuse);
            this.gboxTests.Controls.Add(this.btTestBulling);
            this.gboxTests.Controls.Add(this.btTestAggression);
            this.gboxTests.Location = new System.Drawing.Point(12, 106);
            this.gboxTests.Name = "gboxTests";
            this.gboxTests.Size = new System.Drawing.Size(200, 202);
            this.gboxTests.TabIndex = 3;
            this.gboxTests.TabStop = false;
            this.gboxTests.Text = "Тесты";
            // 
            // btTestProvocation
            // 
            this.btTestProvocation.Location = new System.Drawing.Point(6, 164);
            this.btTestProvocation.Name = "btTestProvocation";
            this.btTestProvocation.Size = new System.Drawing.Size(188, 23);
            this.btTestProvocation.TabIndex = 5;
            this.btTestProvocation.Text = "Провокация";
            this.btTestProvocation.UseVisualStyleBackColor = true;
            this.btTestProvocation.Click += new System.EventHandler(this.btTestProvocation_Click);
            // 
            // btTestSuppression
            // 
            this.btTestSuppression.Location = new System.Drawing.Point(6, 135);
            this.btTestSuppression.Name = "btTestSuppression";
            this.btTestSuppression.Size = new System.Drawing.Size(188, 23);
            this.btTestSuppression.TabIndex = 4;
            this.btTestSuppression.Text = "Подавление";
            this.btTestSuppression.UseVisualStyleBackColor = true;
            this.btTestSuppression.Click += new System.EventHandler(this.btTestSuppression_Click);
            // 
            // btTestConflict
            // 
            this.btTestConflict.Location = new System.Drawing.Point(6, 106);
            this.btTestConflict.Name = "btTestConflict";
            this.btTestConflict.Size = new System.Drawing.Size(188, 23);
            this.btTestConflict.TabIndex = 3;
            this.btTestConflict.Text = "Конфликт";
            this.btTestConflict.UseVisualStyleBackColor = true;
            this.btTestConflict.Click += new System.EventHandler(this.btTestConflict_Click);
            // 
            // btTestAbuse
            // 
            this.btTestAbuse.Location = new System.Drawing.Point(6, 77);
            this.btTestAbuse.Name = "btTestAbuse";
            this.btTestAbuse.Size = new System.Drawing.Size(188, 23);
            this.btTestAbuse.TabIndex = 2;
            this.btTestAbuse.Text = "Абьюз";
            this.btTestAbuse.UseVisualStyleBackColor = true;
            this.btTestAbuse.Click += new System.EventHandler(this.btTestAbuse_Click);
            // 
            // btTestBulling
            // 
            this.btTestBulling.Location = new System.Drawing.Point(6, 48);
            this.btTestBulling.Name = "btTestBulling";
            this.btTestBulling.Size = new System.Drawing.Size(188, 23);
            this.btTestBulling.TabIndex = 1;
            this.btTestBulling.Text = "Буллинг";
            this.btTestBulling.UseVisualStyleBackColor = true;
            this.btTestBulling.Click += new System.EventHandler(this.btTestBulling_Click);
            // 
            // btTestAggression
            // 
            this.btTestAggression.Location = new System.Drawing.Point(6, 19);
            this.btTestAggression.Name = "btTestAggression";
            this.btTestAggression.Size = new System.Drawing.Size(188, 23);
            this.btTestAggression.TabIndex = 0;
            this.btTestAggression.Text = "Агрессия";
            this.btTestAggression.UseVisualStyleBackColor = true;
            this.btTestAggression.Click += new System.EventHandler(this.btTestAggression_Click);
            // 
            // gboxResults
            // 
            this.gboxResults.Controls.Add(this.btRProvocation);
            this.gboxResults.Controls.Add(this.btRAggression);
            this.gboxResults.Controls.Add(this.btRSuppression);
            this.gboxResults.Controls.Add(this.btRBulling);
            this.gboxResults.Controls.Add(this.btRConflict);
            this.gboxResults.Controls.Add(this.btRAbuse);
            this.gboxResults.Enabled = false;
            this.gboxResults.Location = new System.Drawing.Point(218, 106);
            this.gboxResults.Name = "gboxResults";
            this.gboxResults.Size = new System.Drawing.Size(200, 202);
            this.gboxResults.TabIndex = 4;
            this.gboxResults.TabStop = false;
            this.gboxResults.Text = "Результаты";
            // 
            // btRProvocation
            // 
            this.btRProvocation.Location = new System.Drawing.Point(6, 164);
            this.btRProvocation.Name = "btRProvocation";
            this.btRProvocation.Size = new System.Drawing.Size(188, 23);
            this.btRProvocation.TabIndex = 11;
            this.btRProvocation.Text = "Провокация";
            this.btRProvocation.UseVisualStyleBackColor = true;
            this.btRProvocation.Click += new System.EventHandler(this.btRProvocation_Click);
            // 
            // btRAggression
            // 
            this.btRAggression.Location = new System.Drawing.Point(6, 19);
            this.btRAggression.Name = "btRAggression";
            this.btRAggression.Size = new System.Drawing.Size(188, 23);
            this.btRAggression.TabIndex = 6;
            this.btRAggression.Text = "Агрессия";
            this.btRAggression.UseVisualStyleBackColor = true;
            this.btRAggression.Click += new System.EventHandler(this.btRAggression_Click);
            // 
            // btRSuppression
            // 
            this.btRSuppression.Location = new System.Drawing.Point(6, 135);
            this.btRSuppression.Name = "btRSuppression";
            this.btRSuppression.Size = new System.Drawing.Size(188, 23);
            this.btRSuppression.TabIndex = 10;
            this.btRSuppression.Text = "Подавление";
            this.btRSuppression.UseVisualStyleBackColor = true;
            this.btRSuppression.Click += new System.EventHandler(this.btRSuppression_Click);
            // 
            // btRBulling
            // 
            this.btRBulling.Location = new System.Drawing.Point(6, 48);
            this.btRBulling.Name = "btRBulling";
            this.btRBulling.Size = new System.Drawing.Size(188, 23);
            this.btRBulling.TabIndex = 7;
            this.btRBulling.Text = "Буллинг";
            this.btRBulling.UseVisualStyleBackColor = true;
            this.btRBulling.Click += new System.EventHandler(this.btRBulling_Click);
            // 
            // btRConflict
            // 
            this.btRConflict.Location = new System.Drawing.Point(6, 106);
            this.btRConflict.Name = "btRConflict";
            this.btRConflict.Size = new System.Drawing.Size(188, 23);
            this.btRConflict.TabIndex = 9;
            this.btRConflict.Text = "Конфликт";
            this.btRConflict.UseVisualStyleBackColor = true;
            this.btRConflict.Click += new System.EventHandler(this.btRConflict_Click);
            // 
            // btRAbuse
            // 
            this.btRAbuse.Location = new System.Drawing.Point(6, 77);
            this.btRAbuse.Name = "btRAbuse";
            this.btRAbuse.Size = new System.Drawing.Size(188, 23);
            this.btRAbuse.TabIndex = 8;
            this.btRAbuse.Text = "Абьюз";
            this.btRAbuse.UseVisualStyleBackColor = true;
            this.btRAbuse.Click += new System.EventHandler(this.btRAbuse_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 20);
            this.tbName.TabIndex = 5;
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(12, 54);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(67, 20);
            this.nudAge.TabIndex = 6;
            this.nudAge.ValueChanged += new System.EventHandler(this.nudAge_ValueChanged);
            // 
            // tbAddedInfo
            // 
            this.tbAddedInfo.Location = new System.Drawing.Point(12, 80);
            this.tbAddedInfo.Name = "tbAddedInfo";
            this.tbAddedInfo.Size = new System.Drawing.Size(256, 20);
            this.tbAddedInfo.TabIndex = 7;
            this.tbAddedInfo.TextChanged += new System.EventHandler(this.tbAddedInfo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Доп. Инфо.";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMenu,
            this.ToolStripMenuItemExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(428, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(108, 20);
            this.ToolStripMenuItemMenu.Text = "В главное меню";
            this.ToolStripMenuItemMenu.Click += new System.EventHandler(this.ToolStripMenuItemMenu_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // fWorkingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 399);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddedInfo);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.gboxResults);
            this.Controls.Add(this.gboxTests);
            this.Controls.Add(this.btCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fWorkingArea";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fWorkingArea";
            this.gboxTests.ResumeLayout(false);
            this.gboxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.GroupBox gboxTests;
        private System.Windows.Forms.Button btTestConflict;
        private System.Windows.Forms.Button btTestAbuse;
        private System.Windows.Forms.Button btTestBulling;
        private System.Windows.Forms.Button btTestAggression;
        private System.Windows.Forms.GroupBox gboxResults;
        private System.Windows.Forms.Button btTestProvocation;
        private System.Windows.Forms.Button btTestSuppression;
        private System.Windows.Forms.Button btRProvocation;
        private System.Windows.Forms.Button btRAggression;
        private System.Windows.Forms.Button btRSuppression;
        private System.Windows.Forms.Button btRBulling;
        private System.Windows.Forms.Button btRConflict;
        private System.Windows.Forms.Button btRAbuse;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.TextBox tbAddedInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}

