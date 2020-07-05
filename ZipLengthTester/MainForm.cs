using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZipLengthTester
{
    public partial class MainForm : Form
    {
        private string testFilePath;

        public MainForm()
        {
            InitializeComponent();

            InitUi("");
        }

        public MainForm(string filepath)
        {
            InitializeComponent();

            InitUi(filepath);
        }

        private void InitUi(string filepath)
        {
            InitDropdown();
            SetConfigFromPreference();

            ConfigureFilePathWhenInit(filepath);
        }

        /// <summary>
        /// 初期化時にファイルパスを構成する。
        /// </summary>
        /// <param name="filepath">起動時に渡されたファイルのパス</param>
        private void ConfigureFilePathWhenInit(string filepath)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                this.testFilePath = "";
                this.FilePathLabel.Text = "(ファイルは選択されていません)";
            }
            else
            {
                this.testFilePath = Path.IsPathRooted(filepath) ? filepath : Path.GetFullPath(filepath);
                this.FilePathLabel.Text = Path.GetFileName(this.testFilePath);
            }
        }

        /// <summary>
        /// 設定の値を画面に反映する。
        /// </summary>
        private void SetConfigFromPreference()
        {
            var props = Properties.Settings.Default;

            this.ThousandIsBitCheck.Checked = props.ThousandIsBit;
            this.FileLengthLimitBox.Text = props.DefaultLenghtLimit.ToString();
            this.UnitSelectionBox.SelectedValue = props.DefaultUnit;

        }

        /// <summary>
        /// ドロップダウンの項目を作る。
        /// </summary>
        /// <returns>ドロップダウンの項目</returns>
        private IDictionary<int, string> CreateUnitSelectionItems()
        {
            IDictionary<int, string> ret = new Dictionary<int, string>();
            ret[2] = "MB";
            ret[1] = "KB";

            return ret;
        }

        /// <summary>
        /// ドロップダウンを初期化する。
        /// </summary>
        private void InitDropdown()
        {
            this.UnitSelectionBox.DataSource = new BindingSource(CreateUnitSelectionItems(), null);
            this.UnitSelectionBox.DisplayMember = "Value";
            this.UnitSelectionBox.ValueMember = "Key";
        }

        /// <summary>
        /// 設定保存を押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickSaveSettingsBtn(object sender, EventArgs e)
        {
            var props = Properties.Settings.Default;
            props.ThousandIsBit = this.ThousandIsBitCheck.Checked;
            props.DefaultUnit = (int) this.UnitSelectionBox.SelectedValue;
            props.DefaultLenghtLimit = long.Parse(this.FileLengthLimitBox.Text);

            props.Save();
            this.toolStripStatusLabel1.Text = "設定を保存しました。";
        }

        private void FileLengthLimitBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var tb = (TextBox) sender;
            var inputText = tb.Text;
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(inputText))
            {
                this.errorProvider1.SetError(tb, "半角数字のみ");
                e.Cancel = true;
            }

            var length = long.Parse(inputText);
            if (length < 1 || length > 999999)
            {
                this.errorProvider1.SetError(tb, "1以上999999以下");
                e.Cancel = true;
            }
        }

        private void FileLengthLimitBox_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError((TextBox) sender, null);
        }

        /// <summary>
        /// 操作可能なUIコンポーネントのロックを設定する。
        /// </summary>
        /// <param name="locked">ロックするときtrue、そうでないときfalse</param>
        private void LockUi(bool locked)
        {
            this.FileLengthLimitBox.Enabled = locked;
            this.UnitSelectionBox.Enabled = locked;
            this.ThousandIsBitCheck.Enabled = locked;
            this.CalcLengthBtn.Enabled = locked;
            this.FileSelectionBtn.Enabled = locked;
            this.SaveSetteingsBtn.Enabled = locked;

        }

        private void FileSelectionBtn_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

            OpenFileDialog ofd = new OpenFileDialog
            {
                CheckFileExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "開くファイルを選択してください"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var bytes = default(byte[]);
                using (var memstream = new MemoryStream())
                {
                    ofd.OpenFile().CopyTo(memstream);
                    bytes = memstream.ToArray();
                }

                var zfo = new ZipFileOperation();
                if (zfo.IsPkZipCompressedData(bytes))
                {
                    this.testFilePath = Path.GetFullPath(ofd.FileName);
                    this.FilePathLabel.Text = ofd.SafeFileName;
                }
                else
                {
                    toolStripStatusLabel1.Text = "ファイルはZip圧縮されたものではありません。";
                }
            }
        }

        private void CalcLengthBtn_Click(object sender, EventArgs e)
        {
            LockUi(false);

            if (File.Exists(testFilePath))
            {
                try
                {
                    int multiplier = (int) this.UnitSelectionBox.SelectedValue;
                    string unit = CreateUnitSelectionItems()[multiplier];

                    bool thousandIsBit = this.ThousandIsBitCheck.Checked;
                    double totalLen = new ZipFileOperation().CountLength(testFilePath, multiplier, thousandIsBit);

                    string msg = $"このファイルの展開後のサイズは {totalLen:##.##} {unit} です。";
                    var sb = new StringBuilder(msg);
                    
                    var t = thousandIsBit ? 1024 : 1000;
                    var limitLen = long.Parse(this.FileLengthLimitBox.Text);

                    var deltas = totalLen - limitLen;
                    if (deltas > 0)
                    {
                        sb.Append(Environment.NewLine).Append($"{deltas:##.##} {unit} 超過しています。");
                    }

                    this.ResultLabel.Text = sb.ToString();
                    this.ResultLabel.Visible = true;
                }
                catch (Exception)
                {
                    toolStripStatusLabel1.Text = "ファイルを読み取ることができませんでした";
                    this.ResultLabel.Visible = false;
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "選択しているファイルが存在しません。";
                this.ResultLabel.Visible = false;
            }

            LockUi(true);
        }
    }
}