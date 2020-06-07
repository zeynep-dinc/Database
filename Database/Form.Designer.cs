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
            this.insertButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.databaseInsert = new System.Windows.Forms.Button();
            this.columnNameTxt = new System.Windows.Forms.TextBox();
            this.newColumn = new System.Windows.Forms.Button();
            this.typeTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(21, 28);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(72, 13);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "Server Name:";
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
            this.enterButon.Location = new System.Drawing.Point(23, 188);
            this.enterButon.Name = "enterButon";
            this.enterButon.Size = new System.Drawing.Size(456, 23);
            this.enterButon.TabIndex = 4;
            this.enterButon.Text = "Enter and Select All";
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
            this.tableNameLabel.Size = new System.Drawing.Size(75, 13);
            this.tableNameLabel.TabIndex = 5;
            this.tableNameLabel.Text = "Table\'s Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 227);
            this.dataGridView1.TabIndex = 9;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(405, 99);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(171, 23);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "TABLE ADD";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(24, 160);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(148, 22);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(193, 160);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(145, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // databaseInsert
            // 
            this.databaseInsert.Location = new System.Drawing.Point(405, 62);
            this.databaseInsert.Name = "databaseInsert";
            this.databaseInsert.Size = new System.Drawing.Size(171, 23);
            this.databaseInsert.TabIndex = 14;
            this.databaseInsert.Text = "Database Name";
            this.databaseInsert.UseVisualStyleBackColor = true;
            this.databaseInsert.Click += new System.EventHandler(this.databaseInsert_Click);
            // 
            // columnNameTxt
            // 
            this.columnNameTxt.Location = new System.Drawing.Point(137, 130);
            this.columnNameTxt.Name = "columnNameTxt";
            this.columnNameTxt.Size = new System.Drawing.Size(144, 20);
            this.columnNameTxt.TabIndex = 15;
            // 
            // newColumn
            // 
            this.newColumn.Location = new System.Drawing.Point(24, 131);
            this.newColumn.Name = "newColumn";
            this.newColumn.Size = new System.Drawing.Size(89, 23);
            this.newColumn.TabIndex = 16;
            this.newColumn.Text = "New Column";
            this.newColumn.UseVisualStyleBackColor = true;
            this.newColumn.Click += new System.EventHandler(this.newColumn_Click);
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(301, 131);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(100, 20);
            this.typeTxt.TabIndex = 17;
            // 
            // ThereAreTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.newColumn);
            this.Controls.Add(this.columnNameTxt);
            this.Controls.Add(this.databaseInsert);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.tableNameTxt);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.enterButon);
            this.Controls.Add(this.databaseTxt);
            this.Controls.Add(this.serverNameTxt);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.serverNameLabel);
            this.Name = "ThereAreTable";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ThereAreTable_Load);
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
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button databaseInsert;
        private System.Windows.Forms.TextBox columnNameTxt;
        private System.Windows.Forms.Button newColumn;
        private System.Windows.Forms.TextBox typeTxt;
    }
}
