using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSnake
{
    internal static class CustomMessageBox
    {
        public static void Show()
        {
            using (CustomMessageForm form = new CustomMessageForm())
            {
                form.ShowDialog();
            }
        }
        public static string? Show(string header, string mainText, string defaultText)
        {
            using (CustomMessageForm form = new CustomMessageForm())
            {
                form.Text = header;
                form.MainText = mainText;
                form.TextBoxText = defaultText;
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    return form.TextBoxText;
                }
                else return null;
            }
        }
    }
}
