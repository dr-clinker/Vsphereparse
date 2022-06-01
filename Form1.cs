using System;
using System.Windows.Forms;
using System.IO;

namespace Vsphereparse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }
        public string Getfile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    return fileContent;
                }
                else
                {
                    this.Close();
                    return "";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string filecontent = Getfile();   
            string[] splittedstring = filecontent.Split('\n');
            int datastrcount = 0;
            while(datastrcount == 0)
            {
                for (int i = 0; i < splittedstring.Length; i++)
                {
                    if (splittedstring[i] == "" || splittedstring[i] == null || splittedstring[i] == string.Empty || splittedstring[i] == "\r")
                    {
                        datastrcount = i;
                        break;
                    }
                }
            }

            
            int strnum = 0;
            int columnum = 0;
            dataGridView1.ColumnCount = datastrcount ;
            dataGridView1.RowCount = (splittedstring.Length + datastrcount) / (datastrcount + 1);
           //dataGridView1.RowCount = 20;
            foreach (string line in splittedstring)
            {
                if (line != "\r" && line != "" && line != null && line != string.Empty)
                {
                    dataGridView1.Rows[strnum].Cells[columnum].Value = line;
                    if (columnum < datastrcount - 1)
                    {
                        columnum++;
                    }
                    else
                    {
                        columnum = 0;
                        strnum++;
                    }
                }
                
            }
            
        }

        private void SizeToGB_Click(object sender, EventArgs e)
        {
            try
            {
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string value = "";
                    string rank = "";
                    double doubleval = 0;
                    string strvalue = dataGridView1.Rows[i].Cells[columnindex].Value.ToString();
                    int j = 0;
                    while ((int.TryParse(strvalue[j].ToString(), out int a) || strvalue[j] == ',') && j < strvalue.Length)
                    {
                        value += strvalue[j];
                        j++;
                    }
                    if (strvalue.Replace(value, "").Contains("GB"))
                    {
                        doubleval = double.Parse(value);
                    }
                    else if (strvalue.Replace(value, "").Contains("TB"))
                    {
                        doubleval = double.Parse(value) * 1024;
                    }
                    else if (strvalue.Replace(value, "").Contains("MB"))
                    {
                        doubleval = double.Parse(value) / 1024;
                    }
                    else
                    {
                        doubleval = double.Parse(value);
                    }
                    dataGridView1.Rows[i].Cells[columnindex].Value = Math.Round(doubleval, 2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("выберите нужный столбец");
            }
           
        }

        private void AnotherFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void ExcellExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
