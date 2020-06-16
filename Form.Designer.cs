namespace Database
{
    partial class Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.serverNameTxt = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.enterButon = new System.Windows.Forms.Button();
            this.tableNameTxt = new System.Windows.Forms.TextBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.columnNameTxt = new System.Windows.Forms.TextBox();
            this.typeListComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newDatabaseLink = new System.Windows.Forms.LinkLabel();
            this.newTableLink = new System.Windows.Forms.LinkLabel();
            this.newColumnLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(21, 28);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(69, 13);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "Server Name";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(21, 69);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(84, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Database Name";
            // 
            // serverNameTxt
            // 
            this.serverNameTxt.Location = new System.Drawing.Point(137, 28);
            this.serverNameTxt.Name = "serverNameTxt";
            this.serverNameTxt.Size = new System.Drawing.Size(242, 20);
            this.serverNameTxt.TabIndex = 2;
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(137, 64);
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(242, 20);
            this.databaseTxt.TabIndex = 3;
            // 
            // enterButon
            // 
            this.enterButon.Location = new System.Drawing.Point(107, 170);
            this.enterButon.Name = "enterButon";
            this.enterButon.Size = new System.Drawing.Size(355, 23);
            this.enterButon.TabIndex = 4;
            this.enterButon.Text = "Connection";
            this.enterButon.UseVisualStyleBackColor = true;
            this.enterButon.Click += new System.EventHandler(this.enterButon_Click);
            // 
            // tableNameTxt
            // 
            this.tableNameTxt.Location = new System.Drawing.Point(137, 101);
            this.tableNameTxt.Name = "tableNameTxt";
            this.tableNameTxt.Size = new System.Drawing.Size(242, 20);
            this.tableNameTxt.TabIndex = 6;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(21, 104);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(72, 13);
            this.tableNameLabel.TabIndex = 5;
            this.tableNameLabel.Text = "Table\'s Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 260);
            this.dataGridView1.TabIndex = 9;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(107, 199);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 22);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(362, 199);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // columnNameTxt
            // 
            this.columnNameTxt.Location = new System.Drawing.Point(137, 136);
            this.columnNameTxt.Name = "columnNameTxt";
            this.columnNameTxt.Size = new System.Drawing.Size(128, 20);
            this.columnNameTxt.TabIndex = 15;
            // 
            // typeListComboBox
            // 
            this.typeListComboBox.AllowDrop = true;
            this.typeListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeListComboBox.FormattingEnabled = true;
            this.typeListComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typeListComboBox.Items.AddRange(new object[] {
            "char",
            "date",
            "datetime",
            "float",
            "image",
            "int",
            "nchar",
            "ntext",
            "nvarchar(50)",
            "nvarchar(MAX)",
            "real",
            "smallint",
            "text",
            "time",
            "varchar(50)",
            "varchar(MAX)",
            "year"});
            this.typeListComboBox.Location = new System.Drawing.Point(271, 135);
            this.typeListComboBox.Name = "typeListComboBox";
            this.typeListComboBox.Size = new System.Drawing.Size(108, 21);
            this.typeListComboBox.Sorted = true;
            this.typeListComboBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newDatabaseLink
            // 
            this.newDatabaseLink.AutoSize = true;
            this.newDatabaseLink.Location = new System.Drawing.Point(402, 69);
            this.newDatabaseLink.Name = "newDatabaseLink";
            this.newDatabaseLink.Size = new System.Drawing.Size(109, 13);
            this.newDatabaseLink.TabIndex = 20;
            this.newDatabaseLink.TabStop = true;
            this.newDatabaseLink.Text = "+ New Database Add";
            this.newDatabaseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newDatabaseLink_LinkClicked);
            // 
            // newTableLink
            // 
            this.newTableLink.AutoSize = true;
            this.newTableLink.Location = new System.Drawing.Point(402, 106);
            this.newTableLink.Name = "newTableLink";
            this.newTableLink.Size = new System.Drawing.Size(90, 13);
            this.newTableLink.TabIndex = 21;
            this.newTableLink.TabStop = true;
            this.newTableLink.Text = "+ New Table Add";
            this.newTableLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newTableLink_LinkClicked);
            // 
            // newColumnLink
            // 
            this.newColumnLink.AutoSize = true;
            this.newColumnLink.Location = new System.Drawing.Point(402, 135);
            this.newColumnLink.Name = "newColumnLink";
            this.newColumnLink.Size = new System.Drawing.Size(98, 13);
            this.newColumnLink.TabIndex = 22;
            this.newColumnLink.TabStop = true;
            this.newColumnLink.Text = "+ New Column Add";
            this.newColumnLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newColumnLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Column Name";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(566, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 214);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newColumnLink);
            this.Controls.Add(this.newTableLink);
            this.Controls.Add(this.newDatabaseLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeListComboBox);
            this.Controls.Add(this.columnNameTxt);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.tableNameTxt);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.enterButon);
            this.Controls.Add(this.databaseTxt);
            this.Controls.Add(this.serverNameTxt);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.serverNameLabel);
            this.Name = "Form";
            this.Size = new System.Drawing.Size(1001, 492);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox serverNameTxt;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Button enterButon;
        private System.Windows.Forms.TextBox tableNameTxt;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox columnNameTxt;
        private System.Windows.Forms.ComboBox typeListComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel newDatabaseLink;
        private System.Windows.Forms.LinkLabel newTableLink;
        private System.Windows.Forms.LinkLabel newColumnLink;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView1;
    }
}
