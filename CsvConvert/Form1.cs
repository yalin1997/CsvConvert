using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string csvPath { get; set; }
        private int featureNumber {get;set;}
        DataTable pivotTable;
        Dictionary<int, string[]> csvContentDic;
        private string outputFile {  get;  set; }
        private void getPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog pathReader = new OpenFileDialog();
            pathReader.Filter = "csv files (*.csv)|*.csv";
            pathReader.InitialDirectory = "'C://";
            pathReader.DefaultExt = "csv";
            pathReader.FilterIndex = 2;
            if (pathReader.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((pathReader.OpenFile()) != null)
                    {
                        csvPath = pathReader.FileName;
                        textBox1.Text = csvPath;
                        CsvReaderClass reader = new CsvReaderClass(csvPath);
                        this.csvContentDic = reader.readCsv();
                        featureNumber = UtilFunction.getFeaturesNumber(this.csvContentDic);
                        label1.Text = String.Format("共有 {0} 個特徵 要第幾個?", featureNumber);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
        private void csvProcessing(int featureNumber)
        {
            int row = 17;
            int featureCounter = 0;
            while (featureNumber > 0 && row <= this.csvContentDic.Count)
            {
                string[] temp = this.csvContentDic[row];
                if (temp[0].Equals("Grid profile:"))
                {
                    featureCounter++;
                    if (featureNumber.Equals(featureCounter))
                    {
                        using DataTable dt = new DataTable("csvTable");
                        dt.Columns.Add("Longitudinal_position", typeof(String));
                        dt.Columns.Add("Circumferential_position", typeof(String));
                        dt.Columns.Add("Depth", typeof(Double));
                        dt.Columns["Longitudinal_position"].MaxLength = 10;//長度
                        dt.Columns["Longitudinal_position"].AllowDBNull = true;//不能空值
                        dt.Columns["Longitudinal_position"].Unique = false;//建立唯一性
                        dt.Columns["Circumferential_position"].MaxLength = 10;//長度
                        dt.Columns["Circumferential_position"].AllowDBNull = true;//不能空值
                        dt.Columns["Circumferential_position"].Unique = false;//建立唯一性
                        dt.Columns["Depth"].Unique = false;//建立唯一性
                        UtilFunction.getcsvData(this.csvContentDic, row, dt);
                        pivotTable = UtilFunction.ToPivot(dt, dt.Columns["Circumferential_position"], dt.Columns["Depth"]);
                        break;
                    }
                }
                row++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(String.Empty))
            {
                textBox2.ReadOnly = false;
                textBox2.Enabled = true;
                button1.Enabled = true;
                getOutputPathBtn.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int featureNum;
            if(int.TryParse(textBox2.Text, out featureNum))
            {
                csvProcessing(featureNum);
                UtilFunction.ToCSV(this.pivotTable, outputFile);
                MessageBox.Show(String.Format("已經完成 ，檔案輸出到 : {0}", outputFile));
                outputFile = String.Empty;
                outputPath.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("輸入指定 features 請輸入數字");
            }
        }

        private void getOutputPathBtn_Click(object sender, EventArgs e)
        {
            int featureNum = 0;

            if ((!textBox2.Text.Equals(String.Empty)) && (!textBox1.Text.Equals(String.Empty)) &&  int.TryParse(textBox2.Text, out featureNum))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "csv files (*.csv)|*.csv";
                saveFile.Title = "Save an csv File";
                saveFile.InitialDirectory = "'C://";
                saveFile.DefaultExt = "csv";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    this.outputFile = saveFile.FileName;
                    this.outputPath.Text = outputFile;
                    // 
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int textBox2Int;
            if (int.TryParse(textBox2.Text, out textBox2Int))
            {
                textBox2Int = textBox2Int > featureNumber ? featureNumber : textBox2Int;
                textBox2.Text = textBox2Int.ToString();
            }
            else
            {
                MessageBox.Show("輸入指定 features 請輸入數字");
                textBox2.Text = "1";
            }
        }
    }
}
