using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPulseCheck
{
    internal class ThreadHelperClass
    {

        /// <summary>
        /// This is a helper class to populate data in form controls from another thread.
        /// There is background worker implemented in FormMain.cs.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
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
