using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form5 : Form
    {
        /// <summary>Инициализация формы</summary>
        public Form5() => InitializeComponent();

        /// <summary>Переменная для сохранения ID</summary>
        public int GetDelExIndex => (int)DelExIndex.Value;
    }
}
