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
            this.FileLenghtLimitBox = new System.Windows.Forms.TextBox();
            this.UnitSelectionBox = new System.Windows.Forms.ComboBox();
            this.ThousandIsBitCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileePathLabel = new System.Windows.Forms.Label();
            this.FileSelectionBtn = new System.Windows.Forms.Button();
            this.CalcLengthBtn = new System.Windows.Forms.Button();
            this.SaveSetteingsBtn = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // FileLenghtLimitBox
            // 
            this.FileLenghtLimitBox.Location = new System.Drawing.Point(158, 13);
            this.FileLenghtLimitBox.MaxLength = 6;
            this.FileLenghtLimitBox.Name = "FileLenghtLimitBox";
            this.FileLenghtLimitBox.Size = new System.Drawing.Size(53, 19);
            this.FileLenghtLimitBox.TabIndex = 1;
            this.FileLenghtLimitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // FileePathLabel
            // 
            this.FileePathLabel.AutoSize = true;
            this.FileePathLabel.Location = new System.Drawing.Point(158, 70);
            this.FileePathLabel.Name = "FileePathLabel";
            this.FileePathLabel.Size = new System.Drawing.Size(43, 12);
            this.FileePathLabel.TabIndex = 5;
            this.FileePathLabel.Text = "filepath";
            // 
            // FileSelectionBtn
            // 
            this.FileSelectionBtn.Location = new System.Drawing.Point(158, 86);
            this.FileSelectionBtn.Name = "FileSelectionBtn";
            this.FileSelectionBtn.Size = new System.Drawing.Size(75, 23);
            this.FileSelectionBtn.TabIndex = 6;
            this.FileSelectionBtn.Text = "参照";
            this.FileSelectionBtn.UseVisualStyleBackColor = true;
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
            // 
            // SaveSetteingsBtn
            // 
            this.SaveSetteingsBtn.Location = new System.Drawing.Point(401, 12);
            this.SaveSetteingsBtn.Name = "SaveSetteingsBtn";
            this.SaveSetteingsBtn.Size = new System.Drawing.Size(77, 43);
            this.SaveSetteingsBtn.TabIndex = 8;
            this.SaveSetteingsBtn.Text = "設定保存";
            this.SaveSetteingsBtn.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLabel.Location = new System.Drawing.Point(14, 183);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(464, 107);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "このファイルの展開後のサイズは 63.5 MB です。";
            this.ResultLabel.Visible = false;
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
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SaveSetteingsBtn);
            this.Controls.Add(this.CalcLengthBtn);
            this.Controls.Add(this.FileSelectionBtn);
            this.Controls.Add(this.FileePathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThousandIsBitCheck);
            this.Controls.Add(this.UnitSelectionBox);
            this.Controls.Add(this.FileLenghtLimitBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zip Length Tester";
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileLenghtLimitBox;
        private System.Windows.Forms.ComboBox UnitSelectionBox;
        private System.Windows.Forms.CheckBox ThousandIsBitCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FileePathLabel;
        private System.Windows.Forms.Button FileSelectionBtn;
        private System.Windows.Forms.Button CalcLengthBtn;
        private System.Windows.Forms.Button SaveSetteingsBtn;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.BindingSource programBindingSource;
    }
}

