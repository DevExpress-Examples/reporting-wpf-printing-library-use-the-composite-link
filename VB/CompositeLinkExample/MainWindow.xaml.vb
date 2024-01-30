Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing

' ...
Namespace CompositeLinkExample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub printButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim links As List(Of TemplatedLink) = New List(Of TemplatedLink)()
            links.Add(New PrintableControlLink(CType(Me.categoriesGrid.View, TableView)))
            links.Add(New PrintableControlLink(CType(Me.productsGrid.View, TableView)))
            Dim compositeLink As CompositeLink = New CompositeLink(links)
            PrintHelper.ShowRibbonPrintPreview(Me, compositeLink)
        End Sub
    End Class
End Namespace
