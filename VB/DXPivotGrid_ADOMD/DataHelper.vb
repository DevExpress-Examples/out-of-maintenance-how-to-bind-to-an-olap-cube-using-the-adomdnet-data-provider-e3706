Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports DevExpress.XtraPivotGrid

Namespace DXPivotGrid_ADOMD
	Public NotInheritable Class DataHelper
		Private Sub New()
		End Sub
		Public Shared Function GetCubePath() As String
			Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(PivotGridAdomdDataSource))
			Dim version As Version = [assembly].GetName().Version
			Dim textVersion As String = version.Major.ToString() & "." & version.Minor.ToString()
			Dim path As String = "C:\Users\Public\Documents\DevExpress 20" & textVersion & " Demos\Components\Data\Northwind.cub"
			If (Not System.IO.File.Exists(path)) Then
				Throw New Exception("Cannot find the Northwind cube. " & "Please ensure that the DXperience Suite is installed properly.")
			End If
			Return path
		End Function
	End Class
End Namespace
