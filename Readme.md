<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602937/18.1.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E459)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* **[MySqlDataSource.cs](./CS/MySqlDataSource.cs) (VB: [MySqlDataSource.vb](./VB/MySqlDataSource.vb))**
<!-- default file list end -->
# How to provide custom names for the Field List data items


<p>This example demonstrates how to use the <strong>IDisplayNameProvider </strong>interface (which substituted the <strong>IDataDictionary </strong>interface starting with the 11.2 XtraReports version) to change the names of the Field List items shown in both the Visual Studio and End-User report designers. </p><p>This example shows implementation of the <strong>IDisplayNameProvider</strong> interface for the <strong>DevExpress.DataAccess.Sql.SqlDataSource</strong> class, which allows the Field List to automatically retrieve the custom names from a data source that implements this interface.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E667">Best Practices of Implementing the IDataDictionary Interface for a Business Object</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E2706">How to provide custom icons for the Field List in the End-User Designer</a>.</p>

<br/>


