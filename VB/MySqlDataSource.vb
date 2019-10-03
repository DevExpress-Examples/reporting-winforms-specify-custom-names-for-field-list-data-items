#Region "#Usings"
Imports System
Imports DevExpress.Data
Imports DevExpress.DataAccess.Sql
' ...
#End Region ' #Usings

Namespace docCustomDataItemsNames

	#Region "#SqlDataSource"
	Public Class MySqlDataSource
		Inherits SqlDataSource
		Implements IDisplayNameProvider

		Public Sub New()
		End Sub

		Public Sub New(ByVal copyFrom As SqlDataSource)
			Me.LoadFromXml(copyFrom.SaveToXml())
		End Sub

		' ...
		Private Function IDisplayNameProvider_GetDataSourceDisplayName() As String Implements IDisplayNameProvider.GetDataSourceDisplayName
			' Substitute the default datasource display name
			' with a custom one.
			Return "Northwind Traders"
		End Function

		Private Function IDisplayNameProvider_GetFieldDisplayName(ByVal fieldAccessors() As String) As String Implements IDisplayNameProvider.GetFieldDisplayName
			' Get a field name form the data member's name. 
			Dim fieldName As String = fieldAccessors(fieldAccessors.Length - 1)

			' Hide the data member if its name ends with 'ID'.
			If fieldName.EndsWith("ID") Then
				Return Nothing
			End If

			' Hide the 'Products' table, because its fields are accessible 
			' via the 'CategoriesProducts' relation only.
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
	#End Region ' #SqlDataSource
End Namespace
