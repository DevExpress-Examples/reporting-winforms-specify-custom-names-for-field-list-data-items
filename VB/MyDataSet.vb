#Region "#Usings"
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.Data
' ...
#End Region ' #Usings

Namespace docCustomDataItemsNames
#Region "#DataSet"
Friend Class MyDataSet
    Inherits nwindDataSet
    Implements IDisplayNameProvider
' ...
    Private Function GetDataSourceDisplayName() As String _
    Implements IDisplayNameProvider.GetDataSourceDisplayName
        ' Substitute the default datasource display name
        ' with a custom one.
        Return "Northwind Traders"
    End Function

    Private Function GetFieldDisplayName(ByVal fieldAccessors() As String) As String _
    Implements IDisplayNameProvider.GetFieldDisplayName
        ' Get a field name form the data member's name. 
        Dim fieldName As String = fieldAccessors(fieldAccessors.Length - 1)

        ' Hide the data member if its name ends with 'ID'.
        If fieldName.EndsWith("ID") Then
            Return Nothing
        End If

        ' Hide the 'Products' table, because its fields are accessible 
        ' via the 'CategoriesProducts' table only.
        If fieldAccessors(0).StartsWith("Products") Then
            Return Nothing
        End If

        ' Insert spaces between separate words of a field name.
        Return ChangeNames(fieldName)
    End Function
    Public Function ChangeNames(ByVal name As String) As String
        Dim result As String = String.Empty
        Dim isPrevLow As Boolean = False

        For Each symb As Char In name
            ' Check if a character is of upper case.
            ' To avoid spaces inside abbreviations, 
            ' check if the previous character is of upper case, too.
            If Char.IsUpper(symb) AndAlso isPrevLow Then
                result &= " " & symb
            Else
                result &= symb
            End If
            isPrevLow = Char.IsLower(symb)
        Next symb
        Return result
    End Function
' ...
End Class
#End Region ' #DataSet
End Namespace
