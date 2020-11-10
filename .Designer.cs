namespace SearchForlder
{
    partial class SearchFolder
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
            this.components = new System.ComponentModel.Container();
            this.TextPath = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.FloderButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.SaveText = new System.Windows.Forms.Button();
            this.TextFind = new System.Windows.Forms.ListView();
            this.ColumnDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenDuplicateFolder = new System.Windows.Forms.Button();
            this.DeleteDuplicateFolder = new System.Windows.Forms.Button();
            this.OpenTextFindFolderWithWindows = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenJsonButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextPath
            // 
            this.TextPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPath.Location = new System.Drawing.Point(998, 12);
            this.TextPath.Name = "TextPath";
            this.TextPath.Size = new System.Drawing.Size(442, 20);
            this.TextPath.TabIndex = 3;
            this.TextPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextPath_KeyDown);
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(960, 16);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(32, 13);
            this.PathLabel.TabIndex = 4;
            this.PathLabel.Text = "Path:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(758, 44);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(781, 484);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // FloderButton
            // 
            this.FloderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FloderButton.Location = new System.Drawing.Point(1444, 11);
            this.FloderButton.Name = "FloderButton";
            this.FloderButton.Size = new System.Drawing.Size(98, 22);
            this.FloderButton.TabIndex = 6;
            this.FloderButton.Text = "Указать путь";
            this.FloderButton.UseVisualStyleBackColor = true;
            this.FloderButton.Click += new System.EventHandler(this.FloderButton_Click_1);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(758, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(95, 22);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(859, 12);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(95, 22);
            this.Forward.TabIndex = 8;
            this.Forward.Text = "Вперёд";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(513, 12);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(106, 23);
            this.ButtonSearch.TabIndex = 10;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // SaveText
            // 
            this.SaveText.Location = new System.Drawing.Point(236, 41);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(106, 23);
            this.SaveText.TabIndex = 18;
            this.SaveText.Text = "Копировать путь";
            this.SaveText.UseVisualStyleBackColor = true;
            this.SaveText.Click += new System.EventHandler(this.SaveText_Click);
            // 
            // TextFind
            // 
            this.TextFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextFind.CheckBoxes = true;
            this.TextFind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnDir,
            this.ColumnSize});
            this.TextFind.HideSelection = false;
            this.TextFind.Location = new System.Drawing.Point(12, 74);
            this.TextFind.Name = "TextFind";
            this.TextFind.Size = new System.Drawing.Size(740, 454);
            this.TextFind.TabIndex = 19;
            this.TextFind.UseCompatibleStateImageBehavior = false;
            this.TextFind.View = System.Windows.Forms.View.Details;
            this.TextFind.DoubleClick += new System.EventHandler(this.TextFind_DoubleClick);
            // 
            // ColumnDir
            // 
            this.ColumnDir.Text = "Путь";
            this.ColumnDir.Width = 599;
            // 
            // ColumnSize
            // 
            this.ColumnSize.Text = "Размер";
            this.ColumnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnSize.Width = 71;
            // 
            // OpenDuplicateFolder
            // 
            this.OpenDuplicateFolder.Location = new System.Drawing.Point(513, 41);
            this.OpenDuplicateFolder.Name = "OpenDuplicateFolder";
            this.OpenDuplicateFolder.Size = new System.Drawing.Size(106, 23);
            this.OpenDuplicateFolder.TabIndex = 20;
            this.OpenDuplicateFolder.Text = "Перейти";
            this.OpenDuplicateFolder.UseVisualStyleBackColor = true;
            this.OpenDuplicateFolder.Click += new System.EventHandler(this.OpenDuplicateFolder_Click);
            // 
            // DeleteDuplicateFolder
            // 
            this.DeleteDuplicateFolder.Location = new System.Drawing.Point(12, 12);
            this.DeleteDuplicateFolder.Name = "DeleteDuplicateFolder";
            this.DeleteDuplicateFolder.Size = new System.Drawing.Size(106, 23);
            this.DeleteDuplicateFolder.TabIndex = 21;
            this.DeleteDuplicateFolder.Text = "Удалить";
            this.DeleteDuplicateFolder.UseVisualStyleBackColor = true;
            this.DeleteDuplicateFolder.Click += new System.EventHandler(this.DeleteDuplicateFolder_Click);
            // 
            // OpenTextFindFolderWithWindows
            // 
            this.OpenTextFindFolderWithWindows.Location = new System.Drawing.Point(236, 12);
            this.OpenTextFindFolderWithWindows.Name = "OpenTextFindFolderWithWindows";
            this.OpenTextFindFolderWithWindows.Size = new System.Drawing.Size(106, 23);
            this.OpenTextFindFolderWithWindows.TabIndex = 22;
            this.OpenTextFindFolderWithWindows.Text = "Открыть папку";
            this.OpenTextFindFolderWithWindows.UseVisualStyleBackColor = true;
            this.OpenTextFindFolderWithWindows.Click += new System.EventHandler(this.OpenTextFindFolderWithWindows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Удалить папку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Копировать адрес папки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Открыть папку в проводнике";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Перейти к папке";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Поиск дубликатов";
            // 
            // OpenJsonButton
            // 
            this.OpenJsonButton.Location = new System.Drawing.Point(12, 41);
            this.OpenJsonButton.Name = "OpenJsonButton";
            this.OpenJsonButton.Size = new System.Drawing.Size(106, 23);
            this.OpenJsonButton.TabIndex = 30;
            this.OpenJsonButton.Text = "Открыть JSON";
            this.OpenJsonButton.UseVisualStyleBackColor = true;
            this.OpenJsonButton.Click += new System.EventHandler(this.OpenJsonButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Вдушенеебучтоэто";
            // 
            // SearchFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1551, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenJsonButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenTextFindFolderWithWindows);
            this.Controls.Add(this.DeleteDuplicateFolder);
            this.Controls.Add(this.OpenDuplicateFolder);
            this.Controls.Add(this.TextFind);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.FloderButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.TextPath);
            this.Name = "SearchFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextPath;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button FloderButton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button SaveText;
        private System.Windows.Forms.ListView TextFind;
        private System.Windows.Forms.ColumnHeader ColumnDir;
        private System.Windows.Forms.ColumnHeader ColumnSize;
        private System.Windows.Forms.Button OpenDuplicateFolder;
        private System.Windows.Forms.Button DeleteDuplicateFolder;
        private System.Windows.Forms.Button OpenTextFindFolderWithWindows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenJsonButton;
        private System.Windows.Forms.Label label2;
    }
}

