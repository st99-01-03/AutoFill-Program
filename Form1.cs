using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        List<StudentInfo> listOfStudents;
        Word.Application wordApp;
        Word.Document document;
        public static int countRows(Excel.Worksheet sheet)
        {
            int n = 1;
            bool flag = true;
            while(flag)
            {
                string tmp = sheet.Cells[n, 1].Text;
                if (tmp != "")
                    n++;
                else
                    flag = false;
            }
            return n-1;
        }

        public void loadExcel()
        {
            var dlg = new OpenFileDialog();
            dlg.DefaultExt = "*.xls;*.xlsx";
            dlg.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            dlg.Title = "Выберите документ Excel";
            if (dlg.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                var fileExcelPath = String.Empty;
                fileExcelPath = dlg.FileName;

                Excel.Application excl = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbook xlWb = excl.Workbooks.Open(fileExcelPath);
                Excel.Worksheet xlSheet = xlWb.ActiveSheet;

                loadStudents(excl, xlSheet);

                xlWb.Close();
                excl.Quit();
            }
            catch
            {
                MessageBox.Show("Ошибка! Выбран некорректный файл!");
            }
        }

        private void loadStudents(Excel.Application excl, Worksheet xlSheet)
        {
            int numberOfRows = countRows(excl.Worksheets.get_Item(1));

            for (int i = 1; i <= numberOfRows; i++)
            {
                StudentInfo tmp = new StudentInfo();
                tmp.name = (xlSheet.Cells[i, 1] as Excel.Range).Value2.ToString();
                tmp.fname = (xlSheet.Cells[i, 2] as Excel.Range).Value2.ToString();
                tmp.surname = (xlSheet.Cells[i, 3] as Excel.Range).Value2.ToString();
                tmp.rank = (xlSheet.Cells[i, 4] as Excel.Range).Value2.ToString();
                tmp.occupation = (xlSheet.Cells[i, 5] as Excel.Range).Value2.ToString();
                if((xlSheet.Cells[i, 6] as Excel.Range).Value2!= null)
                    tmp.document_date = (xlSheet.Cells[i, 6] as Excel.Range).Value2.ToString();
                if ((xlSheet.Cells[i, 7] as Excel.Range).Value2 != null)
                    tmp.document_number = (xlSheet.Cells[i, 7] as Excel.Range).Value2.ToString();
                listOfStudents.Add(tmp);
            }
        }

        public Form1()
        {
            InitializeComponent();
            listOfStudents = new List<StudentInfo>();
        }

        private void btTemplate_Click(object sender, EventArgs e)
        {
            loadWord();
            if(document != null)
            {
                showLoadResult();
            }
        }

        private void showLoadResult()
        {
            lbTemplate.Text = "Шаблон загружен";
        }

        private void fillInWord()
        {
            for(int i = 0; i < listOfStudents.Count() - 1; i++)
            {
                document.Tables[1].Rows.Add(document.Tables[1].Rows[1]);
            }

            for(int i = 0; i < listOfStudents.Count(); i++)
            {
                document.Tables[1].Cell(i + 1, 1).Range.Text = listOfStudents[i].getStudentName();
                document.Tables[1].Cell(i + 1, 2).Range.Text = listOfStudents[i].getStudentInfo();
            }    
        }

        private void saveWord()
        {
            document.SaveAs2(@"C:\Autofill\output.docx");
            document.Close();
            wordApp.Quit();
        }

        private void loadWord()
        {
            var dlg = new OpenFileDialog();
            dlg.DefaultExt = "*.doc;*.docx";
            dlg.Filter = "Microsoft Word (*.docx*)|*.docx*";
            dlg.Title = "Выберите документ Word";
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                var fileWordPath = String.Empty;
                fileWordPath = dlg.FileName;

                wordApp = new Word.Application();
                document = wordApp.Documents.Add(fileWordPath);
            }
            catch
            {
                MessageBox.Show("Ошибка! Выбран некорректный файл!");
            }
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            loadExcel();
            showLoadedStudentsCount();
        }

        private void showLoadedStudentsCount()
        {
            lbFile.Text = "Загружено " + listOfStudents.Count.ToString() + " студентов!";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            fillInWord();
            saveWord();
            showProcessResult();
        }

        private void showProcessResult()
        {
            lbTemplate.Text = "Успешно выполнилась";
            lbFile.Text = "генерация файла";
        }
    }

    public class StudentInfo
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string fname { get; set; }
        public string occupation { get; set; }
        public string rank { get; set; }
        public string document_date { get; set; }
        public string document_number { get; set; }



        public StudentInfo()
        {
            this.name = "";
            this.surname = "";
            this.fname = "";
            this.occupation = "";
            this.rank = "";
            this.document_date = "";
            this.document_number = "";
        }

        public string getStudentName()
        {
            return surname.ToUpper() + " " + name + " " + fname + ",";
        }

        public string getStudentInfo()
        {
            if (document_date != "")
            {
                return rank + ", " + occupation + ", Договор: №" + document_number + " от " + document_date + ";";
            }
            return rank + ", " + occupation + ";";
        }
    }
}
