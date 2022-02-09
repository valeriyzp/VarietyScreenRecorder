using System;
using System.Windows.Forms;

namespace VarietyScreenRecorder.Window_GE
{
    public partial class WindowGE_GetText : Form
    {
        public bool isSet { get; set; } = false;

        public WindowGE_GetText(string Text, string ActiveText)
        {
            this.Icon = Properties.Resources.Logo;

            InitializeComponent();

            l_Text.Text = Text;
            tb_TextValue.Text = ActiveText;
        }

        private void tb_TextValue_TextChanged(object sender, EventArgs e)
        {
            if (tb_TextValue.Text == "")
                b_Set.Enabled = false;
            else
                b_Set.Enabled = true;
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
