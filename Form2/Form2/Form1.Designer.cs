namespace Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.retrieveButton = new System.Windows.Forms.Button();
            this.purchButton = new System.Windows.Forms.Button();
            this.quoteMainPanel = new System.Windows.Forms.Panel();
            this.quoteMainReturnButton = new System.Windows.Forms.Button();
            this.quotesDataSet1 = new Form2.quotesDataSet1();
            this.quoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quoteTableAdapter = new Form2.quotesDataSet1TableAdapters.quoteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quoteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // retrieveButton
            // 
            this.retrieveButton.BackColor = System.Drawing.Color.LightBlue;
            this.retrieveButton.Location = new System.Drawing.Point(148, 161);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(174, 80);
            this.retrieveButton.TabIndex = 0;
            this.retrieveButton.Text = "Retrieve Quote";
            this.retrieveButton.UseVisualStyleBackColor = false;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // purchButton
            // 
            this.purchButton.BackColor = System.Drawing.Color.LightGreen;
            this.purchButton.Location = new System.Drawing.Point(424, 161);
            this.purchButton.Name = "purchButton";
            this.purchButton.Size = new System.Drawing.Size(174, 80);
            this.purchButton.TabIndex = 0;
            this.purchButton.Text = "Purchase Confirmation";
            this.purchButton.UseVisualStyleBackColor = false;
            // 
            // quoteMainPanel
            // 
            this.quoteMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quoteMainPanel.BackgroundImage")));
            this.quoteMainPanel.Controls.Add(this.dataGridView1);
            this.quoteMainPanel.Controls.Add(this.quoteMainReturnButton);
            this.quoteMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quoteMainPanel.Location = new System.Drawing.Point(0, 0);
            this.quoteMainPanel.Name = "quoteMainPanel";
            this.quoteMainPanel.Size = new System.Drawing.Size(755, 399);
            this.quoteMainPanel.TabIndex = 1;
            this.quoteMainPanel.Visible = false;
            // 
            // quoteMainReturnButton
            // 
            this.quoteMainReturnButton.Location = new System.Drawing.Point(668, 364);
            this.quoteMainReturnButton.Name = "quoteMainReturnButton";
            this.quoteMainReturnButton.Size = new System.Drawing.Size(75, 23);
            this.quoteMainReturnButton.TabIndex = 0;
            this.quoteMainReturnButton.Text = "Return";
            this.quoteMainReturnButton.UseVisualStyleBackColor = true;
            this.quoteMainReturnButton.Click += new System.EventHandler(this.quoteMainReturnButton_Click);
            // 
            // quotesDataSet1
            // 
            this.quotesDataSet1.DataSetName = "quotesDataSet1";
            this.quotesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quoteBindingSource
            // 
            this.quoteBindingSource.DataMember = "quote";
            this.quoteBindingSource.DataSource = this.quotesDataSet1;
            // 
            // quoteTableAdapter
            // 
            this.quoteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoteIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quoteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 140);
            this.dataGridView1.TabIndex = 1;
            // 
            // quoteIDDataGridViewTextBoxColumn
            // 
            this.quoteIDDataGridViewTextBoxColumn.DataPropertyName = "Quote ID";
            this.quoteIDDataGridViewTextBoxColumn.HeaderText = "Quote ID";
            this.quoteIDDataGridViewTextBoxColumn.Name = "quoteIDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 399);
            this.Controls.Add(this.quoteMainPanel);
            this.Controls.Add(this.purchButton);
            this.Controls.Add(this.retrieveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radon Quote Interface System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.quoteMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Button purchButton;
        private System.Windows.Forms.Panel quoteMainPanel;
        private System.Windows.Forms.Button quoteMainReturnButton;
        private quotesDataSet1 quotesDataSet1;
        private System.Windows.Forms.BindingSource quoteBindingSource;
        private quotesDataSet1TableAdapters.quoteTableAdapter quoteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

