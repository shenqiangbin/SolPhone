using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZaiPangWin
{
    public static class FormExten
    {
        public static void SetNormalSetting(this Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            //不能改变大小
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;                        
        }
    }
}
