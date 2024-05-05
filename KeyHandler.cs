using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P_As_AutoClicker
{
    public class KeyHandler
    {
        public static void AskNewKey(out Keys newKey)
        {
            newKey = Keys.None;
            AskKeyForm newAskKeyForm = new AskKeyForm();
            Keys capturedKey = newKey; // Capture the out parameter value
            newAskKeyForm.FormClosing += (s, args) => { capturedKey = newAskKeyForm.newKey; };
            newAskKeyForm.ShowDialog();
            newKey = capturedKey; // Assign the captured value back to the out parameter
        }
    }

}
