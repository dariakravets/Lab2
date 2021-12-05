using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace FindEvent
{
    public partial class EventsForm : Form
    {
        private string path = "C:\\Users\\user\\Desktop\\KNU\\T3\\OOP\\FindEvent\\XMLEvents.xml";
        public void GetAllEvents()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@path);

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNotes = xRoot.SelectNodes("Event");

            for (int i = 0; i < childNotes.Count; i++)
            {
                XmlNode n = childNotes.Item(i);
                addItems(n);
            }
        }
        private void addItems(XmlNode n)
        {
            if (!comboBoxEventName.Items.Contains(n.SelectSingleNode("@EventName").Value))
                comboBoxEventName.Items.Add(n.SelectSingleNode("@EventName").Value);
            if (!comboBoxPersonName.Items.Contains(n.SelectSingleNode("@PersonName").Value))
                comboBoxPersonName.Items.Add(n.SelectSingleNode("@PersonName").Value);
            if (!comboBoxFaculty.Items.Contains(n.SelectSingleNode("@Faculty").Value))
                comboBoxFaculty.Items.Add(n.SelectSingleNode("@Faculty").Value);
            if (!comboBoxDepartment.Items.Contains(n.SelectSingleNode("@Department").Value))
                comboBoxDepartment.Items.Add(n.SelectSingleNode("@Department").Value);
            if (!comboBoxResponsible.Items.Contains(n.SelectSingleNode("@Responsible").Value))
                comboBoxResponsible.Items.Add(n.SelectSingleNode("@Responsible").Value);
            if (!comboBoxDoer.Items.Contains(n.SelectSingleNode("@Doer").Value))
                comboBoxDoer.Items.Add(n.SelectSingleNode("@Doer").Value);
            if (!comboBoxDeadline.Items.Contains(n.SelectSingleNode("@Deadline").Value))
                comboBoxDeadline.Items.Add(n.SelectSingleNode("@Deadline").Value);
            if (!comboBoxTime.Items.Contains(n.SelectSingleNode("@Time").Value))
                comboBoxTime.Items.Add(n.SelectSingleNode("@Time").Value);
            if (!comboBoxPlace.Items.Contains(n.SelectSingleNode("@Place").Value))
                comboBoxPlace.Items.Add(n.SelectSingleNode("@Place").Value);
            if (!comboBoxCharacteristic.Items.Contains(n.SelectSingleNode("@Characteristic").Value))
                comboBoxCharacteristic.Items.Add(n.SelectSingleNode("@Characteristic").Value);
        }
        public EventsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllEvents();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            richTextBox1.Text = "";
            Search search = new Search();
            if (checkEventName.Checked)
                search.EventName = comboBoxEventName.SelectedItem.ToString();
            if (checkPersonName.Checked)
                search.PersonName = comboBoxPersonName.SelectedItem.ToString();
            if (checkFaculty.Checked)
                search.Faculty = comboBoxFaculty.SelectedItem.ToString();
            if (checkDepartment.Checked)
                search.Department = comboBoxDepartment.SelectedItem.ToString();
            if (checkResponsible.Checked)
                search.Responsible = comboBoxResponsible.SelectedItem.ToString();
            if (checkDoer.Checked)
                search.Doer = comboBoxDoer.SelectedItem.ToString();
            if (checkDeadline.Checked)
                search.Deadline = comboBoxDeadline.SelectedItem.ToString();
            if (checkTime.Checked)
                search.Time = comboBoxTime.SelectedItem.ToString();
            if (checkPlace.Checked)
                search.Place = comboBoxPlace.SelectedItem.ToString();
            if (checkCharacteristic.Checked)
                search.Characteristic = comboBoxCharacteristic.SelectedItem.ToString();

            IStrategy strategy = new DOM();

            if (radioButtonDOM.Checked)
            {
                List<Search> results;
                strategy = new DOM();
                results = strategy.AnalyzeFile(search, path);
                ShowResult(results);
            }
            if (radioButtonSAX.Checked)
            {
                List<Search> results;
                strategy = new SAX();
                results = strategy.AnalyzeFile(search, path);
                ShowResult(results);
            }
            if (radioButtonLinqToXML.Checked)
            {
                List<Search> results;
                strategy = new LINQtoXml();
                results = strategy.AnalyzeFile(search, path);
                ShowResult(results);
            }
        }

        private void ShowResult(List<Search> result)
        {
            richTextBox1.Text = "";
            foreach (Search srch in result)
            {
                richTextBox1.Text += "Назва заходу: " + srch.EventName + "\n";
                richTextBox1.Text += "П.І.П: " + srch.PersonName + "\n";
                richTextBox1.Text += "Факультет: " + srch.Faculty + "\n";
                richTextBox1.Text += "Кафедра: " + srch.Department + "\n";
                richTextBox1.Text += "Відповідальна особа: " + srch.Responsible + "\n";
                richTextBox1.Text += "Виконавець доручення: " + srch.Doer + "\n";
                richTextBox1.Text += "Термін виконання: " + srch.Deadline + "\n";
                richTextBox1.Text += "Час: " + srch.Time + "\n";
                richTextBox1.Text += "Місце поведення: " + srch.Place + "\n";
                richTextBox1.Text += "Коротка характеристика: " + srch.Characteristic + "\n";

                richTextBox1.Text += "\n\n";
            }
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            transform();
        }

        private void transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"C:\Users\user\Desktop\KNU\T3\OOP\FindEvent\XSLTEvents.xslt");
            string fXML = @"C:\\Users\\user\\Desktop\\KNU\\T3\\OOP\\FindEvent\\XMLEvents.xml";
            string fHTML = @"C:\\Users\\user\\Desktop\\KNU\\T3\\OOP\\FindEvent\\HTMLEvents.html";
            xct.Transform(fXML, fHTML);
            MessageBox.Show("Успішно перетворено!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            checkEventName.Checked = false;
            checkPersonName.Checked = false;
            checkFaculty.Checked = false;
            checkDepartment.Checked = false;
            checkResponsible.Checked = false;
            checkDoer.Checked = false;
            checkDeadline.Checked = false;
            checkTime.Checked = false;
            checkPlace.Checked = false;
            checkCharacteristic.Checked = false;
            comboBoxEventName.SelectedIndex = -1;
            comboBoxPersonName.SelectedIndex = -1;
            comboBoxFaculty.SelectedIndex = -1;
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxResponsible.SelectedIndex = -1;
            comboBoxDoer.SelectedIndex = -1;
            comboBoxDeadline.SelectedIndex = -1;
            comboBoxTime.SelectedIndex = -1;
            comboBoxPlace.SelectedIndex = -1;
            comboBoxCharacteristic.SelectedIndex = -1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
