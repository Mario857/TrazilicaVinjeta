using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace PretragaVinjete
{


    public partial class Form1 : Form
    {
        List<Elementi_u_referenci> fajlovi = new List<Elementi_u_referenci>();
        public Form1()
        {
            InitializeComponent();
        }

        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;


            try
            {
                foreach (string str in File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "reference.txt"))
                {
                    fajlovi.Add(new Elementi_u_referenci { referenca = str });
                    AzururajListu();
                }
            }
            catch {

            }
        }

        private void AzururajListu() {
         
            listBox1.Items.Clear();
            col.Clear();
            foreach (Elementi_u_referenci reference in fajlovi)
            {
               

                var provjeri = reference.PopuniElemente();

                if (provjeri != Elementi_u_referenci.ElementState.elem_ok)
                {
                    MessageBox.Show(Enum.GetName(typeof(Elementi_u_referenci.ElementState), provjeri));
                    return;
                }

                foreach (string elem in reference.elementi)
                        col.Add(elem);

                listBox1.Items.Add(reference.referenca);
            }

            string[] clist = listBox1.Items.OfType<string>().ToArray();

            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "reference.txt", clist);

            textBox1.AutoCompleteCustomSource = col;
        }

        private void dodaj_ref_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                var postojeli = fajlovi.FindAll(x => x.referenca == openFileDialog.FileName);

                if (postojeli.Count > 0)
                {
                    MessageBox.Show("Referenca vec unesena");
                    return;
                }

                fajlovi.Add(new Elementi_u_referenci {referenca = openFileDialog.FileName});
            }

            AzururajListu();
        }

        private void izbiris_ref_Click(object sender, EventArgs e)
        {
            if (fajlovi.Count == 0 || listBox1.SelectedIndex < 0)
                return;

            fajlovi.RemoveAt(listBox1.SelectedIndex);
            AzururajListu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Elementi_u_referenci str in fajlovi) {
                foreach (string elem in str.elementi)
                    if (elem.ToUpper() == textBox1.Text.ToUpper())
                    {
                        XLWorkbook xLWorkbook = new XLWorkbook(str.referenca);


                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Excel.Workbook workbook = app.Workbooks.Open(str.referenca,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[elem];
                        worksheet.Activate();
                        app.Visible = true;
                        break;
                    }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
        }
    }
    class Elementi_u_referenci
    {
        public enum ElementState { 
           elem_nema_ref = 0,
           elem_ok = 1,
           elem_greska_prilikom_citanja = 2,
        }
        public string referenca;
        public List<String> elementi;

 

        public ElementState PopuniElemente() {
            if (referenca == "")
                return ElementState.elem_nema_ref;

            try
            {
                XLWorkbook xLWorkbook = new XLWorkbook(referenca);
                elementi = new List<string>();
                elementi.Clear();
                foreach (IXLWorksheet worksheet in xLWorkbook.Worksheets)
                {
                    elementi.Add(worksheet.Name);
                }
                return ElementState.elem_ok;
            }
            catch
            {
             
            }
            return ElementState.elem_ok;
        }
    };
}
