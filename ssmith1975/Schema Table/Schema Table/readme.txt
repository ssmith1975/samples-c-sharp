
****************************
         READ ME
****************************

INSTRUCTIONS

(1) Create dbo.authors table using script in authors.sql (see ss_AuthorsTableSchema.png screenshot)

(3) Add some data into the dbo.authors table (see ss_AuthorsTableData.png screenshot)

(4) Create ConnectionStrings.config pointing to your database where dbo.authors is created

For example:
<?xml version="1.0" encoding="utf-8" ?>

  <connectionStrings>
    <add  name="Default"
          providerName ="System.Data.SqlClient"
          connectionString="[YOUR CONNECTION STRING]" />
  </connectionStrings> 

NOTE: If any an error occurs regarding ConnectionStrings.config not found when running the app, select the ConnectionSTrings.config file in Visual Studios Solution Explorer, right-click the file name, click Properties, and make sure the settings for "Copy to Output Directory" is set to anything other than "Do not copy".

(5) Build solution 

(6) Run app 

