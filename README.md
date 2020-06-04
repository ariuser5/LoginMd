# LoginMd
A c# login module.

Configuration:
- Make sure your SQL Server has the "Server authentication" property set to "SQL Server and Windows Authentication mode".
- To create the database structure along with the initial data, execute the SQL script from file "SQLQuery1.sql" in a new query inside SQL Server Management Studio.
- The database connection string is stored inside LoginMd project's app.config file and it may require to edit the "Server" value of the connection string.

  Ex:
<connectionStrings>
	<add name="DBKey"
			 connectionString="Server=<YOUR_SERVER_NAME>;Database=MyDB;User Id=loginmd;Password=123;"
			 providerName="System.Data.SqlClient" />
</connectionStrings>

Usage:
- Currently assigned users are:
{	
	username: adm,
	password: 123
}
{	
	username: usr,
	password: 321
}
- With these credentials, the login will be successful.