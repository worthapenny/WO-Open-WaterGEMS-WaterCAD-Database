# WO-Open-WaterGEMS-WaterCAD-Database
An example to open up a WaterGEMS, WaterCAD Database using WaterObjects (WO) API

## Main method to open up the model
```c#
DataSource = new IdahoDataSource();
DataSource.SetConnectionProperty(ConnectionProperty.FileName, sqliteFilePath);
DataSource.SetConnectionProperty(ConnectionProperty.ConnectionType, ConnectionType.Sqlite);
DataSource.SetConnectionProperty(ConnectionProperty.EnableSchemaUpdate, false);

DataSource.Open();
```
See the [Form1.cs](/OpenWTRG/Form1.cs) for more details.