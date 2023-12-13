<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602937/18.1.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E459)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to provide custom names for the Field List data items

This example demonstrates how to use the `IDisplayNameProvider` interface to change the names of the Field List items shown in both the Visual Studio and End-User report designers. 

This example shows an implementation of the `IDisplayNameProvider` interface for the **DevExpress.DataAccess.Sql.SqlDataSource** class, which allows the Field List to automatically retrieve the custom names from a data source that implements this interface.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MySqlDataSource.cs](./CS/MySqlDataSource.cs) (VB: [MySqlDataSource.vb](./VB/MySqlDataSource.vb))

## More Examples

- [Reporting for WinForms - Custom Icons for the Field List Items in the End-User Designer](https://github.com/DevExpress-Examples/reporting-winforms-custom-icons-field-list)
