using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlPanelViewSet;

namespace ControlSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserControlPanelView UserControlPanel;

        private void Form1_Load(object sender, EventArgs e)
        {
            List<IPanelChildUserControl> subFormList = new List<IPanelChildUserControl>();
            subFormList.Add(new UserControlA());
            subFormList.Add(new UserControlB());

            UserControlPanel = new UserControlPanelView(panel1, textBox1, subFormList.ToArray());
            UserControlPanel.AddChildUserControl(new UserControlA());
        }

        private void button_AddPanel_Click(object sender, EventArgs e)
        {
            UserControlPanel.AddChildUserControl(new UserControlA());
        }

        private void button_AddPanelB_Click(object sender, EventArgs e)
        {
            UserControlPanel.AddChildUserControl(new UserControlB());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControlPanel.ChildUserControlsStoreToTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControlPanel.ChildUserControlsCreateFromTextBox();
        }
    }
}
