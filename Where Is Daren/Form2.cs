using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Where_Is_Daren
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string _labelString;
        public string LabelString
        {
            get { return _labelString; }
            set { _labelString = value; }
        }

        private string _label1UserName;
        public string Label1UserName
        {
            get { return _label1UserName; }
            set { _label1UserName = value; }
        }

        /*public List<string> optionsList = new List<string>
        {
            "Out of Office",
            "At Lunch",
            "On Shipping Dock",
            "On Manufacturing Floor",
            "Working From Home",
            "In a Meeting"
        };*/

        private Class1 _class1 = new Class1();
        private ComboItem _comboItem = new ComboItem();
        
        public int getRadioButtonValue()
        {
            _comboItem.ID = (int)ComboBox1.SelectedItem;
            return _comboItem.ID;
        }

        public string getFactualValue()
        {            
            if (_comboItem.Text == null)
            {
                _comboItem.Text = _class1.optionsList[6];
            }
            else
            {
                LabelString = _comboItem.Text;
            }
            
            return LabelString = _comboItem.Text;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            _comboItem.Text = (string)ComboBox1.SelectedItem;

            if (_comboItem.Text == _class1.optionsList[0])
                _comboItem.ID = 0;
            else if (_comboItem.Text == _class1.optionsList[1])
                _comboItem.ID = 1;
            else if (_comboItem.Text == _class1.optionsList[2])
                _comboItem.ID = 2;
            else if (_comboItem.Text == _class1.optionsList[3])
                _comboItem.ID = 3;
            else if (_comboItem.Text == _class1.optionsList[4])
                _comboItem.ID = 4;
            else if (_comboItem.Text == _class1.optionsList[5])
                _comboItem.ID = 5;
            else
            {
                _comboItem.Text = "Current Whereabout Unknown";
                _comboItem.ID = 3;
            }

            LabelString = _comboItem.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Label1UserName = textBox1.Text;
            _class1.setUserName(Label1UserName);
        }

        public string getUserName()
        {
            Label1UserName = textBox1.Text;
            _class1.setUserName(Label1UserName);

            return _class1.setUserName(Label1UserName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addListTB.Text = "";
        }

        private void addListBtn_Click(object sender, EventArgs e)
        {
            //_class1.strs = addListTB.Text;
            _class1.temp = addListTB.Text;
            //_class1.userAddedList.Add(_class1.strs);
            _class1.setUserAddedList(_class1.temp);
            //_class1.strsList.Add(_class1.strs);
            //_class1.addStrsList();
        }
    }
}
