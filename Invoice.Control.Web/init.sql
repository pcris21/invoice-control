
USE master
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'InvoiceControl')
  BEGIN
    CREATE DATABASE InvoiceControl
  END
  GO

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Auth')
  BEGIN
    CREATE DATABASE Auth
  END

CREATE LOGIN AppInvoiceControl WITH PASSWORD = '_dev@2023'
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE NAME = N'AppInvoiceControl')
BEGIN
    CREATE USER AppInvoiceControl FOR LOGIN AppInvoiceControl   
END;
GO

USE InvoiceControl
EXEC sp_addrolemember 'db_owner', 'AppInvoiceControl';
GO

USE Auth
EXEC sp_addrolemember 'db_owner', 'AppInvoiceControl';
GO