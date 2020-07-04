using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZipLengthTester
{
    public partial class MainForm : Form
    {
        private string testFilePath;

        public MainForm()
        {
            InitializeComponent();

            InitDropdown();
            SetConfigFromPreference();

            ConfigureFilePathWhenInit("");
        }

        public MainForm(string filepath)
        {
            InitializeComponent();

            InitDropdown();
            SetConfigFromPreference();

            ConfigureFilePathWhenInit(filepath);
        }

        private void ConfigureFilePathWhenInit(string filepath)
        {
            if (filepath.Trim().Length > 0)
            {
                this.testFilePath = Path.IsPathRooted(filepath) ? filepath : Path.GetFullPath(filepath);
                this.FileePathLabel.Text = Path.GetFileName(this.testFilePath);
            }
            else
            {
                this.testFilePath = "";
                this.FileePathLabel.Text = "(ファイルは選択されていません)";
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
            this.UnitSelectionBox.SelectedText = props.DefaultUnit;

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

        private void InitDropdown()
        {
            this.UnitSelectionBox.DataSource = new BindingSource(CreateUnitSelectionItems(), null);
            this.UnitSelectionBox.DisplayMember = "Value";
            this.UnitSelectionBox.ValueMember = "Key";
        }
    }
}