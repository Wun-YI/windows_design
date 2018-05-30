using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EnglishTest
{
    internal class Program
    {
        /// <summary>
        /// new新的model和form1
        /// </summary>
        private static void Main()
        {
            DictionaryModel dictionaryModel = new DictionaryModel();
            TestModel testModel = new TestModel(dictionaryModel);
            PresentationModel presentationModel = new PresentationModel(testModel);
            Form form = new UserForm(presentationModel);
            Application.Run(form);
        }
    }
}