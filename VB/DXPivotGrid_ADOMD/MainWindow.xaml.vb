Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.XtraPivotGrid

Namespace DXPivotGrid_ADOMD
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			' Creates an ADOMD.NET datasource object that will be used
			' to access OLAP data.
			Dim ds As New PivotGridAdomdDataSource()

			' Configures a data connection.
			' Specifies a string that encapsulates connection parameters 
			' required to access the desired OLAP cube.
			' The DataHelper.GetCubePath static method returns the path to a local cube file
			' that will serve as a datasource.
			ds.ConnectionString = "Provider=msolap;Data Source=" & DataHelper.GetCubePath() & _
                ";Initial Catalog=Northwind;Cube Name=Northwind"

			' Assigns the configured ADOMD.NET datasource object to the pivot grid.
			pivotGridControl1.DataSource = ds
		End Sub
	End Class
End Namespace