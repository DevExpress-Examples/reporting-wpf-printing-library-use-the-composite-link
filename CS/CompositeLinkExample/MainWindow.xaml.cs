using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
// ...

namespace CompositeLinkExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void printButton_Click(object sender, RoutedEventArgs e) {
            List<TemplatedLink> links = new List<TemplatedLink>();
            links.Add(new PrintableControlLink((TableView)categoriesGrid.View));
            links.Add(new PrintableControlLink((TableView)productsGrid.View));

            CompositeLink compositeLink = new CompositeLink(links);
            PrintHelper.ShowRibbonPrintPreview(this, compositeLink);
        }
    }
}
