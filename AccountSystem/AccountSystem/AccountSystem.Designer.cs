namespace AccountSystem {
    partial class AccountSystem {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.accountEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneytotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalnumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalnumber2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalnumber3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.queryBox1 = new AccountSystem.QueryBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountEntityBindingSource
            // 
            this.accountEntityBindingSource.DataSource = typeof(AccountSystem.AccountEntity);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1352, 379);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountEntityBindingSource, "id", true));
            this.textBox9.Location = new System.Drawing.Point(89, 46);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(310, 28);
            this.textBox9.TabIndex = 31;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productEntityBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(506, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(388, 29);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "id";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntityBindingSource, "name", true));
            this.textBox2.Location = new System.Drawing.Point(506, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 28);
            this.textBox2.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntityBindingSource, "teika", true));
            this.textBox6.Location = new System.Drawing.Point(506, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(375, 28);
            this.textBox6.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntityBindingSource, "id", true));
            this.textBox8.Location = new System.Drawing.Point(506, 46);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(375, 28);
            this.textBox8.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.accountEntityBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 29);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "id";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountEntityBindingSource, "money_total", true));
            this.textBox5.Location = new System.Drawing.Point(89, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(310, 28);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountEntityBindingSource, "date_time", true));
            this.textBox4.Location = new System.Drawing.Point(89, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(310, 28);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountEntityBindingSource, "additional_number1", true));
            this.textBox3.Location = new System.Drawing.Point(89, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 28);
            this.textBox3.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountEntityBindingSource, "name", true));
            this.textBox1.Location = new System.Drawing.Point(89, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 28);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(442, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "daily_account";
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.AutoGenerateColumns = false;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.moneytotalDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.additionalnumber1DataGridViewTextBoxColumn,
            this.additionalnumber2DataGridViewTextBoxColumn,
            this.additionalnumber3DataGridViewTextBoxColumn});
            this.accountDataGridView.DataSource = this.accountEntityBindingSource;
            this.accountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountDataGridView.Location = new System.Drawing.Point(0, 512);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.RowTemplate.Height = 30;
            this.accountDataGridView.Size = new System.Drawing.Size(1352, 402);
            this.accountDataGridView.TabIndex = 33;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // moneytotalDataGridViewTextBoxColumn
            // 
            this.moneytotalDataGridViewTextBoxColumn.DataPropertyName = "money_total";
            this.moneytotalDataGridViewTextBoxColumn.HeaderText = "money_total";
            this.moneytotalDataGridViewTextBoxColumn.Name = "moneytotalDataGridViewTextBoxColumn";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "date_time";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "date_time";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // additionalnumber1DataGridViewTextBoxColumn
            // 
            this.additionalnumber1DataGridViewTextBoxColumn.DataPropertyName = "additional_number1";
            this.additionalnumber1DataGridViewTextBoxColumn.HeaderText = "additional_number1";
            this.additionalnumber1DataGridViewTextBoxColumn.Name = "additionalnumber1DataGridViewTextBoxColumn";
            // 
            // additionalnumber2DataGridViewTextBoxColumn
            // 
            this.additionalnumber2DataGridViewTextBoxColumn.DataPropertyName = "additional_number2";
            this.additionalnumber2DataGridViewTextBoxColumn.HeaderText = "additional_number2";
            this.additionalnumber2DataGridViewTextBoxColumn.Name = "additionalnumber2DataGridViewTextBoxColumn";
            // 
            // additionalnumber3DataGridViewTextBoxColumn
            // 
            this.additionalnumber3DataGridViewTextBoxColumn.DataPropertyName = "additional_number3";
            this.additionalnumber3DataGridViewTextBoxColumn.HeaderText = "additional_number3";
            this.additionalnumber3DataGridViewTextBoxColumn.Name = "additionalnumber3DataGridViewTextBoxColumn";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 379);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1352, 133);
            this.splitter2.TabIndex = 32;
            this.splitter2.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(662, 407);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(176, 63);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "検索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1124, 407);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(176, 63);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // queryBox1
            // 
            this.queryBox1.Location = new System.Drawing.Point(66, 415);
            this.queryBox1.Name = "queryBox1";
            this.queryBox1.Size = new System.Drawing.Size(543, 55);
            this.queryBox1.TabIndex = 36;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(855, 407);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(176, 63);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // AccountSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 914);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.queryBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.accountDataGridView);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "AccountSystem";
            this.Text = "AccountSystem";
            this.Load += new System.EventHandler(this.AccountSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource accountEntityBindingSource;
        private System.Windows.Forms.BindingSource productEntityBindingSource;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneytotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalnumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalnumber2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalnumber3DataGridViewTextBoxColumn;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private AccountSystem.QueryBox queryBox1;
        private System.Windows.Forms.Button buttonClear;
    }
}

