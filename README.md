# FiLogger.API
.NET Core 2.2 Web API for Finance and Insurance logging.
<h3>Info</h3>
<p>
  In its current form this API serves as a boilerplate template for the FiLogger project.
  Logging, AES Encryption, Service to controller Mapping, MStest, Versioning and Swagger have all been setup and configured.
  So this should serve as a nice launch pad for the rest of the project.
</p>

<h3>Setup</h3>

<p>
The setup is very simple at its current stage. The API follows the EF code first pattern and the migrations have already been applied, so to scaffold a local DB, just use the update-database command in the package manager.
This will create DB with the name FiLogger, you can change this by changing the connection string in the app setting JSON
</p>

<p>
  If the 'SeedDbOnCreate' option is set to true in the app settings, the DB will be scaffolded along with some dummy data.
  If you would prefer to use an in memory database, just set the 'UseInMemoryDatabase' to true in the appsetttings.  
</p>
<p>
  Once the database is all ready to go, just build and run. This should load you up a Swagger UI where you can have a play around with the end points :)
</p>

