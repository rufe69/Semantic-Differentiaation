namespace SemDiff
{
    partial class fTest
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DefinPositive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositiveMax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PositiveMid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PositiveMin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Neutral = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NegativeMin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NegativeMid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NegativeMax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DefinNegative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddResult = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DefinPositive,
            this.PositiveMax,
            this.PositiveMid,
            this.PositiveMin,
            this.Neutral,
            this.NegativeMin,
            this.NegativeMid,
            this.NegativeMax,
            this.DefinNegative});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(915, 458);
            this.dataGridView.TabIndex = 1;
            // 
            // DefinPositive
            // 
            this.DefinPositive.HeaderText = "Определение";
            this.DefinPositive.Name = "DefinPositive";
            this.DefinPositive.ReadOnly = true;
            this.DefinPositive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PositiveMax
            // 
            this.PositiveMax.HeaderText = "Очень";
            this.PositiveMax.Name = "PositiveMax";
            this.PositiveMax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PositiveMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PositiveMid
            // 
            this.PositiveMid.HeaderText = "Средне";
            this.PositiveMid.Name = "PositiveMid";
            this.PositiveMid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PositiveMid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PositiveMin
            // 
            this.PositiveMin.HeaderText = "Слабо";
            this.PositiveMin.Name = "PositiveMin";
            this.PositiveMin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PositiveMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Neutral
            // 
            this.Neutral.HeaderText = "Нейтрально";
            this.Neutral.Name = "Neutral";
            this.Neutral.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Neutral.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NegativeMin
            // 
            this.NegativeMin.HeaderText = "Слабо";
            this.NegativeMin.Name = "NegativeMin";
            this.NegativeMin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NegativeMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NegativeMid
            // 
            this.NegativeMid.HeaderText = "Средне";
            this.NegativeMid.Name = "NegativeMid";
            this.NegativeMid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NegativeMid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NegativeMax
            // 
            this.NegativeMax.HeaderText = "Очень";
            this.NegativeMax.Name = "NegativeMax";
            this.NegativeMax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NegativeMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DefinNegative
            // 
            this.DefinNegative.HeaderText = "Определение";
            this.DefinNegative.Name = "DefinNegative";
            this.DefinNegative.ReadOnly = true;
            this.DefinNegative.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btAddResult
            // 
            this.btAddResult.Location = new System.Drawing.Point(657, 464);
            this.btAddResult.Name = "btAddResult";
            this.btAddResult.Size = new System.Drawing.Size(120, 37);
            this.btAddResult.TabIndex = 2;
            this.btAddResult.Text = "Добавить";
            this.btAddResult.UseVisualStyleBackColor = true;
            this.btAddResult.Click += new System.EventHandler(this.btAddResult_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(783, 464);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 37);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 510);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddResult);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTest";
            this.Load += new System.EventHandler(this.fTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btAddResult;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefinPositive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PositiveMax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PositiveMid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PositiveMin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Neutral;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NegativeMin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NegativeMid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NegativeMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefinNegative;
    }
}