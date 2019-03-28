# CopyDB
CopyDatabases is a short application that was made to allow for automatic exporting and importing of LIVE databases.
The goal for the application is to minimize the time required for this process by making it fully automated.

## Installation
For the application to work you will need to install Microsofts SqlPackage.
This is the tool that is used to Export and Import databases to any SQL Server.
You can download the package using the link below or by using the MSI located in the CopyDB folder.

Download: [DACFramework]https://www.microsoft.com/en-us/download/details.aspx?id=57784

Be sure to install the 64-bit version as it will affect where SqlPackage is installed.
The application points to the 64-bit SqlPackage path by default.  This is fine since it will only be used within a development environment.

##SSMS
When importing to a database with a security login instead of using windows authentication, the server role "sysdamdmin" must be assigned
This is required when importing as the login will be used to drop the database, then create it.
Since only the functionality to import using Windows Authentication is available initially, this will not be a problem...yet.