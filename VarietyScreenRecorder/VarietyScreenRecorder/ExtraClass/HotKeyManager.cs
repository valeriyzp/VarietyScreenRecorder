using System.Windows.Forms;

namespace VarietyScreenRecorder.ExtraClass
{
    public class HotKeyManager
    {
        public static string GetHotKey(KeyEventArgs e)
        {
            string HotKey = "";

            if (e.Control)
                HotKey += "Ctrl+";

            if (e.Alt)
                HotKey += "Alt+";

            if (e.Shift)
                HotKey += "Shift+";

            HotKey += e.KeyCode;

            return HotKey;
        }

        public static bool isHotKey(KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
                return true;
            else
                return false;
        }
    }
}
