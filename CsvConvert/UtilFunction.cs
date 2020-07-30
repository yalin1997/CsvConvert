using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace CsvConvert
{
    class UtilFunction
    {
        public static int getFeaturesNumber(Dictionary<int, string[]> csvCotent)
        {
            string[] eighthRow = csvCotent[8];
            return Int32.Parse(eighthRow[0]);
        }
        public static int getcsvData(Dictionary<int, string[]> csvCotent, int rowIndex, DataTable dt)
        {
            int endIndex = rowIndex + 2;
            while (true)
            {
                if (endIndex > csvCotent.Count)
                {
                    break;
                }
                string[] rowContext = csvCotent[endIndex];
                if (rowContext[0].Equals(String.Empty))
                {
                    break;
                }
                else
                {
                    var row = dt.NewRow();
                    row["Longitudinal_position"] = rowContext[0];
                    row["Circumferential_position"] = rowContext[1];
                    row["Depth"] = double.Parse(rowContext[2]).ToString("0.000000");
                    dt.Rows.Add(row);
                    endIndex++;
                }

            }
            return endIndex;
        }
        public static DataTable ToPivot(DataTable dt, DataColumn pivotColumn, DataColumn pivotValue)
        {
            // find primary key columns 
            //(i.e. everything but pivot column and pivot value)
            
            DataTable temp = dt.Copy();
            temp.Columns.Remove(pivotColumn.ColumnName);
            temp.Columns.Remove(pivotValue.ColumnName);
            string[] pkColumnNames = temp.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToArray();

            // prep results table
            DataTable result = temp.DefaultView.ToTable(true, pkColumnNames).Copy();
            result.Columns[0].ColumnName = " ";// 交會那格的內容
            result.PrimaryKey = result.Columns.Cast<DataColumn>().ToArray();
            dt.AsEnumerable()
                .Select(r => r[pivotColumn.ColumnName].ToString())
                .Distinct().OrderBy(columnValue => Convert.ToDouble(columnValue)).ToList()
                .ForEach(c => result.Columns.Add(c, pivotColumn.DataType));

            // load it
            foreach (DataRow row in dt.Rows)
            {
                // find row to update
                DataRow aggRow = result.Rows.Find(
                    pkColumnNames
                        .Select(c => row[c])
                        .ToArray());
                // the aggregate used here is LATEST 
                // adjust the next line if you want (SUM, MAX, etc...)
                aggRow[row[pivotColumn.ColumnName].ToString()] = row[pivotValue.ColumnName];
            }
            return result;
        }
        public static DataTable reduceTableRows(DataTable targetTable , double targetDenominator)
        {
            double denominator = targetDenominator;
            double rowCounter = 0.0;
            double totalRows = targetTable.Rows.Count;
            List<DataModel> modelList = new List<DataModel>();
            DataTable resultTable = new DataTable("resultTable");
            resultTable.Columns.Add("Longitudinal_position", typeof(double));
            resultTable.Columns.Add("Circumferential_position", typeof(string));
            resultTable.Columns.Add("Depth", typeof(double));
            resultTable.Columns["Longitudinal_position"].AllowDBNull = true;//不能空值
            resultTable.Columns["Longitudinal_position"].Unique = false;//建立唯一性
            resultTable.Columns["Circumferential_position"].MaxLength = 10;//長度
            resultTable.Columns["Circumferential_position"].AllowDBNull = true;//不能空值
            resultTable.Columns["Circumferential_position"].Unique = false;//建立唯一性
            resultTable.Columns["Depth"].Unique = false;//建立唯一性

            foreach (DataRow row in targetTable.Rows)
            {
                rowCounter++;
                modelList.Add(new DataModel() { 
                    Longitudinal_position = double.Parse(row["Longitudinal_position"].ToString()),
                    Circumferential_position = double.Parse(row["Circumferential_position"].ToString()),
                    Depth = double.Parse(row["Depth"].ToString())
                });
                if((rowCounter % denominator).Equals(0))
                {
                    DataModel newRow = new DataModel();
                    foreach (DataModel item in modelList)
                    {
                        newRow.Longitudinal_position += item.Longitudinal_position;
                        newRow.Circumferential_position += item.Circumferential_position;
                        newRow.Depth += item.Depth;
                    }
                    newRow.Longitudinal_position /= denominator;
                    newRow.Circumferential_position /= denominator;
                    newRow.Depth /= denominator;
                    DataRow resultRow = resultTable.NewRow();
                    resultRow["Longitudinal_position"] = newRow.Longitudinal_position;
                    resultRow["Circumferential_position"] = newRow.Circumferential_position.ToString("0.000000");
                    resultRow["Depth"] = newRow.Depth.ToString("0.000000");
                    resultTable.Rows.Add(resultRow);
                    modelList.Clear();
                }
                else
                {
                    if((totalRows - rowCounter) < denominator)
                    {
                        DataRow resultRow = resultTable.NewRow();
                        resultRow["Longitudinal_position"] = row["Longitudinal_position"];
                        resultRow["Circumferential_position"] = row["Circumferential_position"];
                        resultRow["Depth"] = row["Depth"];
                        resultTable.Rows.Add(resultRow);
                    }
                }
            }
            return resultTable;
        }
        public static void ToCSV(DataTable dt, string strFilePath)
        {
            using StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < dt.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dt.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
}
