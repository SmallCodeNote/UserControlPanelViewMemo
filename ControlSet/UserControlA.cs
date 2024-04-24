using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlPanelViewSet;

namespace ControlSet
{

    public partial class UserControlA : UserControl, IPanelChildUserControl
    {
        //===================
        // Constructor
        //===================
        public UserControlA()
        {
            InitializeComponent();
        }

        //===================
        // Member variable
        //===================
        public int ChildIndex { get; set; }
        public Action<int> DeleteThis { get; set; }
        public Action ControlContentsChanged { get; set; }

        string Param1
        {
            get
            {
                return textBox_Param1.Text;
            }
            set
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(((Action)(() => Param1 = value)));
                }
                else
                {
                    textBox_Param1.Text = value;
                }
            }
        }
        string Param2
        {
            get
            {
                return textBox_Param2.Text;
            }
            set
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(((Action)(() => Param2 = value)));
                }
                else
                {
                    textBox_Param2.Text = value;
                }
            }
        }

        //===================
        // Member function
        //===================
        public void ParamSetFromString(string Line)
        {
            List<string> cols = new List<string>(Line.Split('\t'));
            if (cols[0] == this.GetType().Name) { cols.RemoveAt(0); }

            if (cols.Count > 0) Param1 = cols[0];
            if (cols.Count > 1) Param2 = cols[1];
        }

        public IPanelChildUserControl Clone()
        {
            UserControlA childControl = new UserControlA();
            childControl.ParamSetFromString(this.ToString());
            return childControl;
        }

        public IPanelChildUserControl New(string Line)
        {
            UserControlA childControl = new UserControlA();
            childControl.ParamSetFromString(Line);
            return childControl;
        }

        public override string ToString()
        {
            return Param1 + "\t" + Param2;
        }

        //===================
        // Event
        //===================
        private void button_DeleteThis_Click(object sender, EventArgs e)
        {
            DeleteThis(ChildIndex);
        }

        private void button_ToString_Click(object sender, EventArgs e)
        {
            string b = this.ToString();
        }

        private void textBox_Param1_TextChanged(object sender, EventArgs e)
        {
            if (ControlContentsChanged != null) ControlContentsChanged();
        }

        private void textBox_Param2_TextChanged(object sender, EventArgs e)
        {
            if (ControlContentsChanged != null) ControlContentsChanged();
        }
    }
}
