namespace ZipLengthTester
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.FileLengthLimitBox = new System.Windows.Forms.TextBox();
            this.UnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.ThousandIsBitCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FileSelectionBtn = new System.Windows.Forms.Button();
            this.CalcLengthBtn = new System.Windows.Forms.Button();
            this.SaveSetteingsBtn = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "展開後のファイルサイズ上限";
            // 
            // FileLengthLimitBox
            // 
            this.FileLengthLimitBox.Location = new System.Drawing.Point(158, 13);
            this.FileLengthLimitBox.MaxLength = 6;
            this.FileLengthLimitBox.Name = "FileLengthLimitBox";
            this.FileLengthLimitBox.Size = new System.Drawing.Size(53, 19);
            this.FileLengthLimitBox.TabIndex = 1;
            this.FileLengthLimitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FileLengthLimitBox.Validating += new System.ComponentModel.CancelEventHandler(this.FileLengthLimitBox_Validating);
            this.FileLengthLimitBox.Validated += new System.EventHandler(this.FileLengthLimitBox_Validated);
            // 
            // UnitSelectionBox
            // 
            this.UnitSelectionBox.FormattingEnabled = true;
            this.UnitSelectionBox.Location = new System.Drawing.Point(217, 13);
            this.UnitSelectionBox.Name = "UnitSelectionBox";
            this.UnitSelectionBox.Size = new System.Drawing.Size(55, 20);
            this.UnitSelectionBox.TabIndex = 2;
            // 
            // ThousandIsBitCheck
            // 
            this.ThousandIsBitCheck.AutoSize = true;
            this.ThousandIsBitCheck.Location = new System.Drawing.Point(158, 39);
            this.ThousandIsBitCheck.Name = "ThousandIsBitCheck";
            this.ThousandIsBitCheck.Size = new System.Drawing.Size(163, 16);
            this.ThousandIsBitCheck.TabIndex = 3;
            this.ThousandIsBitCheck.Text = "1024単位でサイズを計算する";
            this.ThousandIsBitCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "読み込むファイル";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(158, 70);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(43, 12);
            this.FilePathLabel.TabIndex = 5;
            this.FilePathLabel.Text = "filepath";
            // 
            // FileSelectionBtn
            // 
            this.FileSelectionBtn.Location = new System.Drawing.Point(158, 86);
            this.FileSelectionBtn.Name = "FileSelectionBtn";
            this.FileSelectionBtn.Size = new System.Drawing.Size(75, 23);
            this.FileSelectionBtn.TabIndex = 6;
            this.FileSelectionBtn.Text = "参照";
            this.FileSelectionBtn.UseVisualStyleBackColor = true;
            this.FileSelectionBtn.Click += new System.EventHandler(this.FileSelectionBtn_Click);
            // 
            // CalcLengthBtn
            // 
            this.CalcLengthBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcLengthBtn.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalcLengthBtn.Location = new System.Drawing.Point(131, 115);
            this.CalcLengthBtn.Name = "CalcLengthBtn";
            this.CalcLengthBtn.Size = new System.Drawing.Size(214, 55);
            this.CalcLengthBtn.TabIndex = 7;
            this.CalcLengthBtn.Text = "展開後のサイズを計算";
            this.CalcLengthBtn.UseVisualStyleBackColor = true;
            this.CalcLengthBtn.Click += new System.EventHandler(this.CalcLengthBtn_Click);
            // 
            // SaveSetteingsBtn
            // 
            this.SaveSetteingsBtn.Location = new System.Drawing.Point(401, 12);
            this.SaveSetteingsBtn.Name = "SaveSetteingsBtn";
            this.SaveSetteingsBtn.Size = new System.Drawing.Size(77, 43);
            this.SaveSetteingsBtn.TabIndex = 8;
            this.SaveSetteingsBtn.Text = "設定保存";
            this.SaveSetteingsBtn.UseVisualStyleBackColor = true;
            this.SaveSetteingsBtn.Click += new System.EventHandler(this.OnClickSaveSettingsBtn);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLabel.Location = new System.Drawing.Point(14, 183);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(464, 94);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "このファイルの展開後のサイズは 63.5 MB です。";
            this.ResultLabel.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(490, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(ZipLengthTester.Program);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 299);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SaveSetteingsBtn);
            this.Controls.Add(this.CalcLengthBtn);
            this.Controls.Add(this.FileSelectionBtn);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThousandIsBitCheck);
            this.Controls.Add(this.UnitSelectionBox);
            this.Controls.Add(this.FileLengthLimitBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zip Length Tester";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileLengthLimitBox;
        private System.Windows.Forms.ComboBox UnitSelectionBox;
        private System.Windows.Forms.CheckBox ThousandIsBitCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Button FileSelectionBtn;
        private System.Windows.Forms.Button CalcLengthBtn;
        private System.Windows.Forms.Button SaveSetteingsBtn;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

