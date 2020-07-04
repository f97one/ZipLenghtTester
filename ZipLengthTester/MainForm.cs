using System;
using System.Collections.Generic;
using System.IO;
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
                this.FileePathLabel.Text = "(ファイルは選択されていません)";
            }
            else
            {
                this.testFilePath = Path.IsPathRooted(filepath) ? filepath : Path.GetFullPath(filepath);
                this.FileePathLabel.Text = Path.GetFileName(this.testFilePath);
            }
        }

        /// <summary>
        /// 設定の値を画面に反映する。
        /// </summary>
        private void SetConfigFromPreference()
        {
            var props = Properties.Settings.Default;

            this.ThousandIsBitCheck.Checked = props.ThousandIsBit;
            this.FileLenghtLimitBox.Text = props.DefaultLenghtLimit.ToString();
            this.UnitSelectionBox.SelectedValue = props.DefaultUnit;

        }

        /// <summary>
        /// ドロップダウンの項目を作る。
        /// </summary>
        /// <returns>ドロップダウンの項目</returns>
        private IDictionary<int, string> CreateUnitSelectionItems()
        {
            IDictionary<int, string> ret = new Dictionary<int, String>();
            ret[6] = "MB";
            ret[3] = "KB";

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
            props.DefaultLenghtLimit = long.Parse(this.FileLenghtLimitBox.Text);

            props.Save();
            this.toolStripStatusLabel1.Text = "設定を保存しました。";
        }
    }
}