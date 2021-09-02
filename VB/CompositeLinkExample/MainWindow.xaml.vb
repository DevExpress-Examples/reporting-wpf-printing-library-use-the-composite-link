Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
' ...

Namespace CompositeLinkExample
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub printButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim links As New List(Of TemplatedLink)()
			links.Add(New PrintableControlLink(CType(categoriesGrid.View, TableView)))
			links.Add(New PrintableControlLink(CType(productsGrid.View, TableView)))

			Dim compositeLink As New CompositeLink(links)
			PrintHelper.ShowRibbonPrintPreview(Me, compositeLink)
		End Sub
	End Class
End Namespace
