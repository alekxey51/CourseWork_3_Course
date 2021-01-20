using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CourseTheCar
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;");

        public Form1()
        {
            InitializeComponent();
            gunaLabel1.Location = new Point(12, 9);
            _obj = this;
        }

        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Guna.UI.WinForms.GunaPanel PanelListMark
        {
            get { return gunaPanel2; }
            set { gunaPanel2 = value; }
        }
        public Guna.UI.WinForms.GunaLabel ListContent
        {
            get { return gunaLabel1; }
            set { gunaLabel1 = value; }
        }
        public Guna.UI.WinForms.GunaPictureBox button
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public Guna.UI.WinForms.GunaButton btnWord
        {
            get { return gunaButton4; }
            set { gunaButton4 = value; }
        }
        public Guna.UI.WinForms.GunaLabel Models
        {
            get { return gunaLabel32; }
            set { gunaLabel32 = value; }
        }
        public Guna.UI.WinForms.GunaLabel ChistoryMark
        {
            get { return gunaLabel31; }
            set { gunaLabel31 = value; }
        }
        public FlowLayoutPanel Model
        {
            get { return flowLayoutPanel1; }
            set { flowLayoutPanel1 = value; }
        }
        public Guna.UI.WinForms.GunaPanel GlInfo
        {
            get { return gunaPanel4; }
            set { gunaPanel4 = value; }
        }
        public Guna.UI.WinForms.GunaPanel GlInfoClose
        {
            get { return gunaPanel5; }
            set { gunaPanel5 = value; }
        }
        public Guna.UI.WinForms.GunaLabel mod
        {
            get { return gunaLabel78; }
            set { gunaLabel78 = value; }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintMark();
        }

        public void PrintMark()
        {
            try
            {
                tableLayoutPanel2.Controls.Clear();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Марка", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MarkControl Item = new MarkControl();

                    byte[] Photo = (byte[])(reader[2]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Item.gunaPictureBox1.Image = Image.FromStream(memoryStream);
                    Item.LabelMark.Text = reader[1].ToString();
                    tableLayoutPanel2.Controls.Add(Item);
                }
                reader.Close();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        public void PrintMarkENG(char ch)
        {
            try
            {
                tableLayoutPanel2.Controls.Clear();
                OleDbCommand command = new OleDbCommand($"SELECT * " +
                                                        $"FROM Марка " +
                                                        $"WHERE Название LIKE '{ch}%'", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MarkControl Item = new MarkControl();

                    byte[] Photo = (byte[])(reader[2]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Item.gunaPictureBox1.Image = Image.FromStream(memoryStream);
                    Item.LabelMark.Text = reader[1].ToString();
                    tableLayoutPanel2.Controls.Add(Item);
                }
                reader.Close();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        #region сортировка по букве
        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            PrintMarkENG('A');
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            PrintMarkENG('B');
        }

        private void gunaLabel29_Click(object sender, EventArgs e)
        {
            PrintMarkENG('C');
        }

        private void gunaLabel28_Click(object sender, EventArgs e)
        {
            PrintMarkENG('D');
        }

        private void gunaLabel27_Click(object sender, EventArgs e)
        {
            PrintMarkENG('E');
        }

        private void gunaLabel26_Click(object sender, EventArgs e)
        {
            PrintMarkENG('F');
        }

        private void gunaLabel25_Click(object sender, EventArgs e)
        {
            PrintMarkENG('G');
        }

        private void gunaLabel24_Click(object sender, EventArgs e)
        {
            PrintMarkENG('H');
        }

        private void gunaLabel23_Click(object sender, EventArgs e)
        {
            PrintMarkENG('I');
        }

        private void gunaLabel22_Click(object sender, EventArgs e)
        {
            PrintMarkENG('J');
        }

        private void gunaLabel21_Click(object sender, EventArgs e)
        {
            PrintMarkENG('K');
        }

        private void gunaLabel20_Click(object sender, EventArgs e)
        {
            PrintMarkENG('L');
        }

        private void gunaLabel19_Click(object sender, EventArgs e)
        {
            PrintMarkENG('M');
        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {
            PrintMarkENG('N');
        }

        private void gunaLabel17_Click(object sender, EventArgs e)
        {
            PrintMarkENG('O');
        }

        private void gunaLabel16_Click(object sender, EventArgs e)
        {
            PrintMarkENG('P');
        }

        private void gunaLabel15_Click(object sender, EventArgs e)
        {
            PrintMarkENG('Q');
        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {
            PrintMarkENG('R');
        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {
            PrintMarkENG('S');
        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {
            PrintMarkENG('T');
        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {
            PrintMarkENG('U');
        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {
            PrintMarkENG('V');
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {
            PrintMarkENG('W');
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {
            PrintMarkENG('X');
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {
            PrintMarkENG('Y');
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            PrintMarkENG('Z');
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            PrintMark();
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            gunaPanel2.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            gunaLabel1.Text = "Каталог автомобилей";
            gunaLabel1.Location = new Point(12, 9);
            btnBack.Visible = false;
            gunaPanel5.Visible = true;
            gunaButton4.Visible = false;
            gunaPanel4.AutoScroll = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ReferenceSystem reference = new ReferenceSystem();
            reference.Show();
        }

        public void printHaracteristic(string m)
        {
            try
            {
                OleDbCommand command = new OleDbCommand($"SELECT Страна.Название, Коробка.Название, Тормоза.Название, Привод.Название, Модификацы, Топливо, Росход, КоличествоДверей, КоличествоМест, Длина, Ширина, Высота, СнаряженнаяМасса, КолеснаяБаза, КолеяПереднихКолес, КолеяЗаднихКолес, ОбъемТопливногоБака, Разгон100, МаксимальнаяСкорость, КоличествоСтупеней " +
                                                        $"FROM Тормоза INNER JOIN (Страна INNER JOIN (Привод INNER JOIN (Коробка INNER JOIN Модификацыя ON Коробка.IDкоробка = Модификацыя.IDкоробка) ON Привод.IDпривод = Модификацыя.IDпривод) ON Страна.IDстраны = Модификацыя.IDстраны) ON Тормоза.IDтормоз = Модификацыя.IDтормоз " +
                                                        $"WHERE Модификацы = '{m}'", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gunaLabel77.Text = $"Разгон до 100 км/ч: {reader[17]}\r\nМакс.скорость: {reader[18]}";
                    gunaLabel76.Text = reader[5].ToString();
                    gunaLabel75.Text = $"{reader[1]}\r\n{reader[19]} ступеней";
                    gunaLabel74.Text = reader[6].ToString();

                    gunaLabel50.Text = reader[0].ToString();
                    gunaLabel49.Text = reader[7].ToString();
                    gunaLabel48.Text = reader[8].ToString();

                    gunaLabel39.Text = reader[2].ToString();
                    gunaLabel38.Text = reader[2].ToString();

                    gunaLabel47.Text = reader[9].ToString() + " мм";
                    gunaLabel46.Text = reader[10].ToString() + " мм";
                    gunaLabel45.Text = reader[11].ToString() + " мм";
                    gunaLabel44.Text = reader[12].ToString() + " кг";
                    gunaLabel43.Text = reader[13].ToString() + " мм";
                    gunaLabel42.Text = reader[14].ToString() + " мм";
                    gunaLabel41.Text = reader[15].ToString() + " мм";
                    gunaLabel40.Text = reader[16].ToString() + " л";

                    gunaLabel37.Text = reader[17].ToString() + " сек.";
                    gunaLabel36.Text = reader[18].ToString() + " км/ч";

                    gunaLabel35.Text = reader[1].ToString();
                    gunaLabel34.Text = reader[19].ToString();
                    gunaLabel33.Text = reader[3].ToString();
                }
                reader.Close();
                connection.Close();
                gunaLabel35.Visible = true;
            }
            catch
            {
                connection.Close();
            }
        }

            private void FindAndReplace(Word.Document wordApp, string ToFindText, string replaceWithText)
        {
            var range = wordApp.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: ToFindText, ReplaceWith: replaceWithText);
        }

        string fileTemp;
        private async void gunaButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(dlg.FileName);
                fileTemp = info.Directory.ToString() + @"\Temp.docx";
            }

            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Word Format (*.docx)|*.docx|All files (*.*)|*.*";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(dlgSave.FileName);

                await Task.Run(() =>
                {
                    var wordApp = new Word.Application();
                    wordApp.Visible = false;
                    var wordDocument = wordApp.Documents.Open(fileTemp);

                    this.FindAndReplace(wordDocument, "<24>", gunaLabel1.Text);
                    this.FindAndReplace(wordDocument, "<23>", "");
                    this.FindAndReplace(wordDocument, "История марки", "");
                    this.FindAndReplace(wordDocument, "<19>", gunaLabel77.Text);
                    this.FindAndReplace(wordDocument, "<20>", gunaLabel76.Text);
                    this.FindAndReplace(wordDocument, "<21>", gunaLabel75.Text);
                    this.FindAndReplace(wordDocument, "<22>", gunaLabel74.Text);
                    this.FindAndReplace(wordDocument, "<1>", gunaLabel50.Text);
                    this.FindAndReplace(wordDocument, "<2>", gunaLabel49.Text);
                    this.FindAndReplace(wordDocument, "<3>", gunaLabel48.Text);
                    this.FindAndReplace(wordDocument, "<4>", gunaLabel47.Text);
                    this.FindAndReplace(wordDocument, "<5>", gunaLabel46.Text);
                    this.FindAndReplace(wordDocument, "<6>", gunaLabel45.Text);
                    this.FindAndReplace(wordDocument, "<7>", gunaLabel44.Text);
                    this.FindAndReplace(wordDocument, "<8>", gunaLabel43.Text);
                    this.FindAndReplace(wordDocument, "<9>", gunaLabel42.Text);
                    this.FindAndReplace(wordDocument, "<10>", gunaLabel41.Text);
                    this.FindAndReplace(wordDocument, "<11>", gunaLabel40.Text);
                    this.FindAndReplace(wordDocument, "<12>", gunaLabel39.Text);
                    this.FindAndReplace(wordDocument, "<13>", gunaLabel38.Text);
                    this.FindAndReplace(wordDocument, "<14>", gunaLabel37.Text);
                    this.FindAndReplace(wordDocument, "<15>", gunaLabel36.Text);
                    this.FindAndReplace(wordDocument, "<16>", gunaLabel35.Text);
                    this.FindAndReplace(wordDocument, "<17>", gunaLabel34.Text);
                    this.FindAndReplace(wordDocument, "<18>", gunaLabel33.Text);
                    
                    wordDocument.SaveAs2(dlgSave.FileName);
                    wordApp.Quit();
                    MessageBox.Show("File Created!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
        }
    }
}
