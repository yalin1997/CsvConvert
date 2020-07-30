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
        public string csvPath { get; private set; }
        DataTable pivotTable;
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
                        Dictionary<int, string[]> csvContent = reader.readCsv();
                        int featureNumber = UtilFunction.getFeaturesNumber(csvContent);
                        label1.Text = String.Format("共有 {0} 個特徵 要第幾個?", featureNumber);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
        private void csvProcessing(Dictionary<int, string[]> csvContent , int featureNumber)
        {
            int row = 17;
            int featureCounter = 0;
            while (featureNumber > 0 && row <= csvContent.Count)
            {
                string[] temp = csvContent[row];
                if (temp[0].Equals("Grid profile:"))
                {
                    featureNumber--;
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
                        UtilFunction.getcsvData(csvContent, row, dt);
                        pivotTable = UtilFunction.ToPivot(dt, dt.Columns["Circumferential_position"], dt.Columns["Depth"]);

                    }
                }
                row++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void getOutputPathBtn_Click(object sender, EventArgs e)
        {
            int featureNum = 0;

            if ((!textBox2.Text.Equals(String.Empty)) && int.TryParse(textBox2.Text, out featureNum))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "csv files (*.csv)|*.csv";
                saveFile.Title = "Save an csv File";
                saveFile.InitialDirectory = "'C://";
                saveFile.DefaultExt = "csv";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    UtilFunction.ToCSV(this.pivotTable, String.Format("output_{0}.csv", textBox2.Text));
                }
            }
        }
    }
}
