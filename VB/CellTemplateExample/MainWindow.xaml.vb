Imports Microsoft.VisualBasic
Imports System.Windows

Namespace CellTemplateExample
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.LoadDocument("vlookup.xlsx")
'			#Region "#celltemplate_code"
			spreadsheetControl1.CellTemplate = TryCast(spreadsheetControl1.TryFindResource("FormulaTemplate"), DataTemplate)
'			#End Region ' #celltemplate_code
		End Sub
	End Class
End Namespace
