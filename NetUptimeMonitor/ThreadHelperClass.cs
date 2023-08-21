using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUptimeMonitor
{
    internal class ThreadHelperClass
    {
        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                ThreadHelperClass.SetTextCallback method = new ThreadHelperClass.SetTextCallback(ThreadHelperClass.SetText);
                form.Invoke((Delegate)method, form, ctrl, text);
            }
            else
                ctrl.Text = text;
        }

        private delegate void SetTextCallback(Form f, Control ctrl, string text);
    }
}
