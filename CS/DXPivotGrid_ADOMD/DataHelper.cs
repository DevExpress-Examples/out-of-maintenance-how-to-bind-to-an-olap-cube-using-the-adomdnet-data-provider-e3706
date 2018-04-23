using System;
using System.Reflection;
using DevExpress.XtraPivotGrid;

namespace DXPivotGrid_ADOMD {
    public static class DataHelper {
        public static String GetCubePath() {
            Assembly assembly = Assembly.GetAssembly(typeof(PivotGridAdomdDataSource));
            Version version = assembly.GetName().Version;
            String textVersion = version.Major.ToString() + "." + version.Minor.ToString();
            String path = "C:\\Users\\Public\\Documents\\DevExpress 20" + textVersion +
                " Demos\\Components\\Data\\Northwind.cub";
            if (!System.IO.File.Exists(path)) {
                throw new Exception("Cannot find the Northwind cube. " +
                    "Please ensure that the DXperience Suite is installed properly.");
            }
            return path;
        }
    }
}
