using System;
using System.Windows.Forms;

namespace VarietyScreenRecorder.Window_GE
{
    public partial class WindowGE_GetSize : Form
    {
        public bool isSet { get; set; } = false;

        public WindowGE_GetSize(string Text, int StartValue)
        {
            this.Icon = Properties.Resources.Logo;

            InitializeComponent();

            l_Text.Text = Text;
            nud_Size.Value = StartValue;
        }

        private void b_Set_Click(object sender, EventArgs e)
        {
            isSet = true;
            this.Close();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
