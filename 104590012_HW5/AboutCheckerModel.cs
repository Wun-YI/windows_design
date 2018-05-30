using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest
{
    internal class AboutCheckerModel
    {
        // 打開
        public void Open()
        {
            AboutCheckerModelForm view = new AboutCheckerModelForm();
            view.ShowDialog();
        }
    }
}