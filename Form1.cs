using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TelephonesListUsingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form_Show(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load("Phones_Data.xml");
            foreach (XElement item in xDocument.Element("phones").Elements("phone"))
            {
                if (!company_list.Items.Contains(item.Attribute("company").Value))
                {
                    company_list.Items.Add(item.Attribute("company").Value);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load("Phones_Data.xml");
            foreach (XElement item in xDocument.Element("phones").Elements("phone"))
            {
                if (item.Attribute("model").Value == model_list.SelectedItem.ToString())
                {
                    model_list.Items.RemoveAt(model_list.SelectedIndex);
                    model_list.SelectedText = String.Empty;
                    model_text.Text = String.Empty;
                    company_text.Text = String.Empty;
                    price_text.Text = String.Empty;
                    size_text.Text = String.Empty;
                    memory_text.Text = String.Empty;
                    item.Remove();
                }
            }
            xDocument.Save("Phones_Data.xml");
        }

        private void company_Cnhg(object sender, EventArgs e)
        {
            model_list.Items.Clear();
            XDocument xDocument = XDocument.Load("Phones_Data.xml");
            foreach (XElement item in xDocument.Element("phones").Elements("phone"))
            {
                if (item.Attribute("company").Value == company_list.SelectedItem.ToString())
                {
                    model_list.Items.Add(item.Attribute("model").Value);
                }
            }
            model_list.Text = String.Empty;
            model_list.Enabled = true;
        }

        private void model_Chng(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load("Phones_Data.xml");
            foreach (XElement item in xDocument.Element("phones").Elements("phone"))
            {
                if (item.Attribute("model").Value == model_list.SelectedItem.ToString())
                {
                    model_text.Text = item.Attribute("model").Value;
                    company_text.Text = item.Attribute("company").Value;
                    price_text.Text = item.Attribute("price").Value;
                    memory_text.Text = item.Attribute("memory").Value;
                    size_text.Text = item.Attribute("screenSize").Value;
                }
            }
            delete.Enabled = true;
        }

        private void form_Closing(object sender, FormClosingEventArgs e)
        {
            if (model_text.Text.Length > 0 && company_text.Text.Length > 0 && price_text.Text.Length > 0 && memory_text.Text.Length > 0 && size_text.Text.Length > 0)
            {
                XDocument xDocument = XDocument.Load("Phones_Data.xml");
                foreach (var item in xDocument.Element("phones").Elements("phone"))
                {
                    if (item.Attribute("model").Value == model_list.SelectedItem.ToString())
                    {
                        item.Attribute("model").Value = model_text.Text;
                        item.Attribute("price").Value = price_text.Text;
                        item.Attribute("company").Value = company_text.Text;
                        item.Attribute("memory").Value = memory_text.Text;
                        item.Attribute("screenSize").Value = size_text.Text;
                    }
                }
                xDocument.Save("Phones_Data.xml");
            }
            else if (model_list.SelectedItem != null && company_list.SelectedItem != null)
            {
                MessageBox.Show("Данныне не будут сохранены.");
            }
        }
    }
}