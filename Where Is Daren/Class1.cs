using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Where_Is_Daren
{
    internal class Class1
    {

        private string _label2;
        private int _radioValue;
        public string suffix = " is ...";

        public Class1()
        {
            //Form2 frm2 = new Form2();
        }

        public string Label2
        {
            get { return _label2; }
            set { _label2 = value; }
        }

        private string _userName;

        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _strs;

        public string strs
        {
            get { return _strs; }
            set { _strs = value; }
        }

        public string temp;

        public List<string> optionsList = new List<string>
        {
            "Out of Office",
            "At Lunch",
            "On Shipping Dock",
            "On Manufacturing Floor",
            "Working From Home",
            "In a Meeting",
            "Current Whereabouts Unknown"
        };

        public List<string> masterList = new List<string>
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
        };

        /*public List<string> strsList = new List<string>
        {
            "Feeding Pop-Rocks to the ducks in the pond. It's called \"science\".",
            "Something classified, but too cool not to share - Fighting a rogue band of [REDACTED] in [REDACTED].\r\n\nGreat Cesar's ghost! You guys really are everywhere!",
            "At lunch with the Baroness of Winterbourne.",
            "Skydiving. Tandem style.",
            "Recovering from that tuna sandwich named \"Kevin\" that I ate from the company fridge yesterday.",
            "On the run! I found a sock on the floor in the Commons and am celebrating my freedom. Dobby is a free elf!",
            "On maternity leave. Don't ask questions. It gets real ugly real fast.",
            "Currently [not] out of the office and probably [not] chilling on the beach.",
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
            "On a secret quest. I can't say much, but it involves one ring, a dark lord, and a rockin' Fellowship!"
        };*/
        
        //private List<string> stringList = new List<string>();

        public List<string> strsList = new List<string>();
        //public List<string> strsList = new List<string> { };
        /*public List<string> strsList
        {
            get { return stringList; }
            set { stringList = value; }
        }*/

        public List<string> userAddedList = new List<string>();
        /*public List<string> userAddedList
        {
            get { return stringList; }
            set { stringList = value; }
        }*/
        
        
        public void setStrsList()
        {
            foreach (string s in masterList)
            {
                strsList.Add(s);
            }
        }

        public List<string> setUserAddedList(string temp)
        {
            userAddedList.Add(temp);
            int x = userAddedList.Count();
            addStrsList();
            return userAddedList;
        }

        public List<string> addStrsList()
        //public void addstrsList(string temp)
        {
            //setStrsList();
            int z = strsList.Count();
            foreach (string s in userAddedList)
            {
                strsList.Add(s);
            }

            int y = strsList.Count();
            return strsList;
        }

        public string getLabelValue()
        {
            //strsList = addStrsList();
            //strsList = setUserAddedList();
            Random rnd = new Random();
            int r = rnd.Next(strsList.Count());
            return strs = strsList[r];
        }

        public string setUserName(string value)
        {
            userName = value;
            return userName + suffix;
        }
    }
}
