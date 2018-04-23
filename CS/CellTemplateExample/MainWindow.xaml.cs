using System.Windows;

namespace CellTemplateExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            spreadsheetControl1.LoadDocument("vlookup.xlsx");
            #region #celltemplate_code
            spreadsheetControl1.CellTemplate = 
                spreadsheetControl1.TryFindResource("FormulaTemplate") as DataTemplate;
            #endregion #celltemplate_code
        }
    }
}
