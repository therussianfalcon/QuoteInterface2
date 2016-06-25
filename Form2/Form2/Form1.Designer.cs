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
            this.quoteMainReturnButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quoteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quoteMainPanel = new System.Windows.Forms.Panel();
            this.refreshQuoteButton = new System.Windows.Forms.Button();
            this.deleteQuoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quoteIDtextbox = new System.Windows.Forms.TextBox();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.quoteIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.quoteIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.retrieveQuoteButton = new System.Windows.Forms.Button();
            this.quoteRetrievePanel = new System.Windows.Forms.Panel();
            this.priceDetailButton = new System.Windows.Forms.Button();
            this.modifyQuoteButton = new System.Windows.Forms.Button();
            this.quoteRetrievalReturnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QuoteIDDisplay = new System.Windows.Forms.TextBox();
            this.quoteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotesDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quotesDataSet2 = new Form2.quotesDataSet2();
            this.quoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotesDataSet1 = new Form2.quotesDataSet1();
            this.quoteTableAdapter = new Form2.quotesDataSet1TableAdapters.quoteTableAdapter();
            this.quoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quotesDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quoteTableAdapter1 = new Form2.quotesDataSet2TableAdapters.quoteTableAdapter();
            this.custNameDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quoteDisplayRefresh = new System.Windows.Forms.Button();
            this.commentDisplay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource2)).BeginInit();
            this.quoteMainPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            this.quoteRetrievePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // retrieveButton
            // 
            this.retrieveButton.BackColor = System.Drawing.Color.LightBlue;
            this.retrieveButton.Location = new System.Drawing.Point(78, 161);
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
            this.purchButton.Location = new System.Drawing.Point(328, 161);
            this.purchButton.Name = "purchButton";
            this.purchButton.Size = new System.Drawing.Size(174, 80);
            this.purchButton.TabIndex = 0;
            this.purchButton.Text = "Purchase Confirmation";
            this.purchButton.UseVisualStyleBackColor = false;
            // 
            // quoteMainReturnButton
            // 
            this.quoteMainReturnButton.Location = new System.Drawing.Point(480, 357);
            this.quoteMainReturnButton.Name = "quoteMainReturnButton";
            this.quoteMainReturnButton.Size = new System.Drawing.Size(75, 23);
            this.quoteMainReturnButton.TabIndex = 0;
            this.quoteMainReturnButton.Text = "Return";
            this.quoteMainReturnButton.UseVisualStyleBackColor = true;
            this.quoteMainReturnButton.Click += new System.EventHandler(this.quoteMainReturnButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoteIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.quoteStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quoteBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 134);
            this.dataGridView1.TabIndex = 1;
            // 
            // quoteBindingSource2
            // 
            this.quoteBindingSource2.DataMember = "quote";
            this.quoteBindingSource2.DataSource = this.quotesDataSet2BindingSource1;
            // 
            // quoteMainPanel
            // 
            this.quoteMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quoteMainPanel.BackgroundImage")));
            this.quoteMainPanel.Controls.Add(this.refreshQuoteButton);
            this.quoteMainPanel.Controls.Add(this.deleteQuoteButton);
            this.quoteMainPanel.Controls.Add(this.label1);
            this.quoteMainPanel.Controls.Add(this.quoteIDtextbox);
            this.quoteMainPanel.Controls.Add(this.searchToolStrip);
            this.quoteMainPanel.Controls.Add(this.retrieveQuoteButton);
            this.quoteMainPanel.Controls.Add(this.dataGridView1);
            this.quoteMainPanel.Controls.Add(this.quoteMainReturnButton);
            this.quoteMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quoteMainPanel.Location = new System.Drawing.Point(0, 0);
            this.quoteMainPanel.Name = "quoteMainPanel";
            this.quoteMainPanel.Size = new System.Drawing.Size(572, 407);
            this.quoteMainPanel.TabIndex = 1;
            this.quoteMainPanel.Visible = false;
            // 
            // refreshQuoteButton
            // 
            this.refreshQuoteButton.Location = new System.Drawing.Point(480, 169);
            this.refreshQuoteButton.Name = "refreshQuoteButton";
            this.refreshQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.refreshQuoteButton.TabIndex = 6;
            this.refreshQuoteButton.Text = "Refresh";
            this.refreshQuoteButton.UseVisualStyleBackColor = true;
            this.refreshQuoteButton.Click += new System.EventHandler(this.refreshQuoteButton_Click);
            // 
            // deleteQuoteButton
            // 
            this.deleteQuoteButton.Location = new System.Drawing.Point(480, 248);
            this.deleteQuoteButton.Name = "deleteQuoteButton";
            this.deleteQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteQuoteButton.TabIndex = 5;
            this.deleteQuoteButton.Text = "Delete";
            this.deleteQuoteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Quote ID";
            // 
            // quoteIDtextbox
            // 
            this.quoteIDtextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.quoteIDtextbox.Location = new System.Drawing.Point(408, 221);
            this.quoteIDtextbox.Name = "quoteIDtextbox";
            this.quoteIDtextbox.Size = new System.Drawing.Size(66, 20);
            this.quoteIDtextbox.TabIndex = 3;
            this.quoteIDtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quoteIDToolStripLabel,
            this.quoteIDToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(572, 25);
            this.searchToolStrip.TabIndex = 2;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // quoteIDToolStripLabel
            // 
            this.quoteIDToolStripLabel.Name = "quoteIDToolStripLabel";
            this.quoteIDToolStripLabel.Size = new System.Drawing.Size(54, 22);
            this.quoteIDToolStripLabel.Text = "QuoteID:";
            // 
            // quoteIDToolStripTextBox
            // 
            this.quoteIDToolStripTextBox.Name = "quoteIDToolStripTextBox";
            this.quoteIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // retrieveQuoteButton
            // 
            this.retrieveQuoteButton.Location = new System.Drawing.Point(480, 219);
            this.retrieveQuoteButton.Name = "retrieveQuoteButton";
            this.retrieveQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveQuoteButton.TabIndex = 2;
            this.retrieveQuoteButton.Text = "Retrieve";
            this.retrieveQuoteButton.UseVisualStyleBackColor = true;
            this.retrieveQuoteButton.Click += new System.EventHandler(this.retrieveQuoteButton_Click);
            // 
            // quoteRetrievePanel
            // 
            this.quoteRetrievePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quoteRetrievePanel.BackgroundImage")));
            this.quoteRetrievePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quoteRetrievePanel.Controls.Add(this.quoteDisplayRefresh);
            this.quoteRetrievePanel.Controls.Add(this.priceDetailButton);
            this.quoteRetrievePanel.Controls.Add(this.modifyQuoteButton);
            this.quoteRetrievePanel.Controls.Add(this.quoteRetrievalReturnButton);
            this.quoteRetrievePanel.Controls.Add(this.label5);
            this.quoteRetrievePanel.Controls.Add(this.label4);
            this.quoteRetrievePanel.Controls.Add(this.label3);
            this.quoteRetrievePanel.Controls.Add(this.label2);
            this.quoteRetrievePanel.Controls.Add(this.commentDisplay);
            this.quoteRetrievePanel.Controls.Add(this.priceDisplay);
            this.quoteRetrievePanel.Controls.Add(this.custNameDisplay);
            this.quoteRetrievePanel.Controls.Add(this.QuoteIDDisplay);
            this.quoteRetrievePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quoteRetrievePanel.Location = new System.Drawing.Point(0, 0);
            this.quoteRetrievePanel.Name = "quoteRetrievePanel";
            this.quoteRetrievePanel.Size = new System.Drawing.Size(572, 407);
            this.quoteRetrievePanel.TabIndex = 7;
            this.quoteRetrievePanel.Visible = false;
            // 
            // priceDetailButton
            // 
            this.priceDetailButton.Location = new System.Drawing.Point(480, 278);
            this.priceDetailButton.Name = "priceDetailButton";
            this.priceDetailButton.Size = new System.Drawing.Size(75, 23);
            this.priceDetailButton.TabIndex = 4;
            this.priceDetailButton.Text = "Price Detail";
            this.priceDetailButton.UseVisualStyleBackColor = true;
            // 
            // modifyQuoteButton
            // 
            this.modifyQuoteButton.Location = new System.Drawing.Point(480, 317);
            this.modifyQuoteButton.Name = "modifyQuoteButton";
            this.modifyQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.modifyQuoteButton.TabIndex = 3;
            this.modifyQuoteButton.Text = "Modify";
            this.modifyQuoteButton.UseVisualStyleBackColor = true;
            // 
            // quoteRetrievalReturnButton
            // 
            this.quoteRetrievalReturnButton.Location = new System.Drawing.Point(480, 356);
            this.quoteRetrievalReturnButton.Name = "quoteRetrievalReturnButton";
            this.quoteRetrievalReturnButton.Size = new System.Drawing.Size(75, 23);
            this.quoteRetrievalReturnButton.TabIndex = 2;
            this.quoteRetrievalReturnButton.Text = "Return";
            this.quoteRetrievalReturnButton.UseVisualStyleBackColor = true;
            this.quoteRetrievalReturnButton.Click += new System.EventHandler(this.quoteRetrievalReturnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QuoteID";
            // 
            // QuoteIDDisplay
            // 
            this.QuoteIDDisplay.Location = new System.Drawing.Point(152, 28);
            this.QuoteIDDisplay.Name = "QuoteIDDisplay";
            this.QuoteIDDisplay.ReadOnly = true;
            this.QuoteIDDisplay.Size = new System.Drawing.Size(60, 20);
            this.QuoteIDDisplay.TabIndex = 0;
            this.QuoteIDDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quoteIDDataGridViewTextBoxColumn
            // 
            this.quoteIDDataGridViewTextBoxColumn.DataPropertyName = "QuoteID";
            this.quoteIDDataGridViewTextBoxColumn.HeaderText = "QuoteID";
            this.quoteIDDataGridViewTextBoxColumn.Name = "quoteIDDataGridViewTextBoxColumn";
            this.quoteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quoteStatusDataGridViewTextBoxColumn
            // 
            this.quoteStatusDataGridViewTextBoxColumn.DataPropertyName = "QuoteStatus";
            this.quoteStatusDataGridViewTextBoxColumn.HeaderText = "QuoteStatus";
            this.quoteStatusDataGridViewTextBoxColumn.Name = "quoteStatusDataGridViewTextBoxColumn";
            this.quoteStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quotesDataSet2BindingSource1
            // 
            this.quotesDataSet2BindingSource1.DataSource = this.quotesDataSet2;
            this.quotesDataSet2BindingSource1.Position = 0;
            // 
            // quotesDataSet2
            // 
            this.quotesDataSet2.DataSetName = "quotesDataSet2";
            this.quotesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quoteBindingSource
            // 
            this.quoteBindingSource.DataMember = "quote";
            this.quoteBindingSource.DataSource = this.quotesDataSet1;
            // 
            // quotesDataSet1
            // 
            this.quotesDataSet1.DataSetName = "quotesDataSet1";
            this.quotesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quoteTableAdapter
            // 
            this.quoteTableAdapter.ClearBeforeFill = true;
            // 
            // quoteBindingSource1
            // 
            this.quoteBindingSource1.DataMember = "quote";
            this.quoteBindingSource1.DataSource = this.quotesDataSet2;
            // 
            // quotesDataSet2BindingSource
            // 
            this.quotesDataSet2BindingSource.DataSource = this.quotesDataSet2;
            this.quotesDataSet2BindingSource.Position = 0;
            // 
            // quoteTableAdapter1
            // 
            this.quoteTableAdapter1.ClearBeforeFill = true;
            // 
            // custNameDisplay
            // 
            this.custNameDisplay.Location = new System.Drawing.Point(152, 54);
            this.custNameDisplay.Name = "custNameDisplay";
            this.custNameDisplay.Size = new System.Drawing.Size(123, 20);
            this.custNameDisplay.TabIndex = 0;
            this.custNameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // priceDisplay
            // 
            this.priceDisplay.Location = new System.Drawing.Point(152, 80);
            this.priceDisplay.Name = "priceDisplay";
            this.priceDisplay.Size = new System.Drawing.Size(123, 20);
            this.priceDisplay.TabIndex = 0;
            this.priceDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Price";
            // 
            // quoteDisplayRefresh
            // 
            this.quoteDisplayRefresh.Location = new System.Drawing.Point(480, 25);
            this.quoteDisplayRefresh.Name = "quoteDisplayRefresh";
            this.quoteDisplayRefresh.Size = new System.Drawing.Size(75, 23);
            this.quoteDisplayRefresh.TabIndex = 4;
            this.quoteDisplayRefresh.Text = "Refresh";
            this.quoteDisplayRefresh.UseVisualStyleBackColor = true;
            // 
            // commentDisplay
            // 
            this.commentDisplay.Location = new System.Drawing.Point(152, 106);
            this.commentDisplay.Multiline = true;
            this.commentDisplay.Name = "commentDisplay";
            this.commentDisplay.Size = new System.Drawing.Size(322, 136);
            this.commentDisplay.TabIndex = 0;
            this.commentDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Comment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 407);
            this.Controls.Add(this.quoteRetrievePanel);
            this.Controls.Add(this.quoteMainPanel);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.purchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radon Quote Interface System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource2)).EndInit();
            this.quoteMainPanel.ResumeLayout(false);
            this.quoteMainPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.quoteRetrievePanel.ResumeLayout(false);
            this.quoteRetrievePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button retrieveButton;
        private quotesDataSet1 quotesDataSet1;
        private System.Windows.Forms.BindingSource quoteBindingSource;
        private quotesDataSet1TableAdapters.quoteTableAdapter quoteTableAdapter;
        private System.Windows.Forms.Button purchButton;
        private System.Windows.Forms.Button quoteMainReturnButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel quoteMainPanel;
        private quotesDataSet2 quotesDataSet2;
        private System.Windows.Forms.BindingSource quotesDataSet2BindingSource;
        private System.Windows.Forms.BindingSource quoteBindingSource1;
        private quotesDataSet2TableAdapters.quoteTableAdapter quoteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource quoteBindingSource2;
        private System.Windows.Forms.BindingSource quotesDataSet2BindingSource1;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel quoteIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox quoteIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.Button retrieveQuoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quoteIDtextbox;
        private System.Windows.Forms.Button deleteQuoteButton;
        private System.Windows.Forms.Button refreshQuoteButton;
        private System.Windows.Forms.Panel quoteRetrievePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuoteIDDisplay;
        private System.Windows.Forms.Button quoteRetrievalReturnButton;
        private System.Windows.Forms.Button modifyQuoteButton;
        private System.Windows.Forms.Button priceDetailButton;
        private System.Windows.Forms.Button quoteDisplayRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceDisplay;
        private System.Windows.Forms.TextBox custNameDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox commentDisplay;
    }
}

