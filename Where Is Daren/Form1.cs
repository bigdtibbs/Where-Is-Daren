using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Text;

namespace Where_Is_Daren
{
    public partial class Form1 : Form
    {
        public string label2;
        public Form1()
        {
            InitializeComponent();
            _class1.setStrsList();
        }

        //Form form2view = new Form2();
        private Class1 _class1 = new Class1();
        private Form2 _frm2 = new Form2();
        bool hasBeenOpened = false;

        /*public List<string> strs = new List<string>
        {
            "Feeding Pop-Rocks to the ducks in the pond. It's called \"science\".",
            "Something classified, but too cool not to share - Fighting a rogue band of [REDACTED] in [REDACTED].\r\n\nGreat Cesar's ghost! You guys really are everywhere!",
            "At lunch with the Baroness of Winterbourne.",
            "Skydiving. Tandem style.",
            "Recovering from that tuna sandwich named \"Kevin\" that I ate from the company fridge yesterday.",
            "On the run! I found a sock on the floor in the Commons and am celebrating my freedom. Dobby is a free elf!",
            "On maternity leave. Don't ask questions. It gets real ugly real fast.",
            "Currently out of the office and probably [not] chilling on the beach.",
            "Gone, but not forgotten. Some stains are forever.",
            "Probably up to no good. What can I say, I took an oath (is \"solemnly swore\" an oath?).",
            "Currently searching for the secret to eternal youth. If you see me again, you can assume I failed.",
            "On vacation. If something is urgent, send me a message in a bottle.",
            "Currently not at my desk. But this Mesa is. You can talk to it, if you like. I call him \'Johnny 5\'.",
            "Trying to find myself too. Hopefully one of us is successful.",
            "Upgrading my \'Out-Of-Office\' tan.",
            "Hiking up a mountain. Either I made it and am enjoying a scenic view, or I collapsed shortly after starting. They're selling squares in Shipping, if you want in.",
            "Swamped! You can send an email if you like. It will be placed in queue. Current wait time is approximately 3 days.",
            "Performing a balancing act between workload and, I don't know how to say it - \r\ns, sa, saaannn, san - it - tee.",
            "So lost that even Google can't find me.",
            "Lecturing the Shipping staff on all the cool stuff they missed out on in the 80's and 90's.",
            "Trying to reign in my feral second child.",
            "On a secret quest. I can't say much, but it involves a dark lord, one ring, and a few breakfasts!"
        };*/

        // Create a standard response when the form is loaded.
        private void Form1_Load(object sender, EventArgs e)
        {
            _class1.setStrsList();
            Label1.Text = "Daren" + _class1.suffix;
            Label2.Text = "Somewhere. Where could he be? I don't know.";
            Label2.MaximumSize = new Size(800, 0);
            Label2.AutoSize = true;
        }

        // Random button.
        // A new Random instance is created that counts the number of items in the list.
        // It them selects one and populates it into the label, which is also formated for size.
        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();

            //int r = rnd.Next(_class1.strsList.Count());

            //Label2.MaximumSize = new Size(800, 0);
            //Label2.AutoSize = true;
            Label2.Text = _class1.getLabelValue();
            Label1.Text = _frm2.getUserName();
        }

        // Factual button.
        // Calls Form2 class and populates Label2 with user-selected value from dropdown menu.
        private void button2_Click(object sender, EventArgs e)
        {
            //Label2.MaximumSize = new Size(800, 0);
            //Label2.AutoSize = true;
            if (Label1.Text != "")
                hasBeenOpened = true;

            // Handle case if we have not been in the setting menu to set our real status yet.
            if (hasBeenOpened)
            {
                Label2.Text = _frm2.getFactualValue();
                Label1.Text = _frm2.getUserName();
            }
            else
            {
                _frm2.ShowDialog();
                Label2.Text = _frm2.getFactualValue();
                Label1.Text = _frm2.getUserName();
                hasBeenOpened = true;
            }

        }

        // Settings menu button.
        // User selects and sets values in Form2.
        private void button3_Click(object sender, EventArgs e)
        {
            _frm2.ShowDialog();
        }

        // Secret Menu. Was settings menu. Will figure out what to do with this (future state. Easter egg?)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //_frm2.ShowDialog();
        }

    }
}
