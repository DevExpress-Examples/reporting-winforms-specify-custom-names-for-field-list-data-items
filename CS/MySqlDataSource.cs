#region #Usings
using System;
using DevExpress.Data;
using DevExpress.DataAccess.Sql;
// ...
#endregion #Usings

namespace docCustomDataItemsNames
{

    #region #SqlDataSource
    public class MySqlDataSource : SqlDataSource, IDisplayNameProvider
    {
        public MySqlDataSource() {
        }

        public MySqlDataSource(SqlDataSource copyFrom) {
            this.LoadFromXml(copyFrom.SaveToXml());
        }

        // ...
        string IDisplayNameProvider.GetDataSourceDisplayName() {
            // Substitute the default datasource display name
            // with a custom one.
            return "Northwind Traders";
        }

        string IDisplayNameProvider.GetFieldDisplayName(string[] fieldAccessors) {
            // Get a field name form the data member's name. 
            string fieldName = fieldAccessors[fieldAccessors.Length - 1];

            // Hide the data member if its name ends with 'ID'.
            if (fieldName.EndsWith("ID")) {
                return null;
            }

            // Hide the 'Products' table, because its fields are accessible 
            // via the 'CategoriesProducts' relation only.
            if (fieldAccessors[0].StartsWith("Products")) {
                return null;
            }

            // Insert spaces between separate words of a field name.
            return ChangeNames(fieldName);
        }
        public string ChangeNames(string name) {
            string result = string.Empty;
            bool isPrevLow = false;

            foreach (char symb in name) {
                // Check if a character is of upper case.
                // To avoid spaces inside abbreviations, 
                // check if the previous character is of upper case, too.
                if (Char.IsUpper(symb) && isPrevLow) {
                    result += " " + symb;
                }
                else {
                    result += symb;
                }
                isPrevLow = Char.IsLower(symb);
            }
            return result;
        }
        // ...
    }
    #endregion #SqlDataSource
}
