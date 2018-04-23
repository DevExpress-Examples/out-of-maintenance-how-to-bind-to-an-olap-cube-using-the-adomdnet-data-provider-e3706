using System.Windows;
using DevExpress.XtraPivotGrid;

namespace DXPivotGrid_ADOMD {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // Creates an ADOMD.NET datasource object that will be used
            // to access OLAP data.
            PivotGridAdomdDataSource ds = new PivotGridAdomdDataSource();

            // Configures a data connection.
            // Specifies a string that encapsulates connection parameters 
            // required to access the desired OLAP cube.
            // The DataHelper.GetCubePath static method returns the path to a local cube file
            // that will serve as a datasource.
            ds.ConnectionString = "Provider=msolap;Data Source=" + DataHelper.GetCubePath() +
                                  ";Initial Catalog=Northwind;Cube Name=Northwind";

            // Assigns the configured ADOMD.NET datasource object to the pivot grid.
            pivotGridControl1.DataSource = ds;
        }
    }
}
