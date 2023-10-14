# NetPinProc.Game.Sqlite
---

NetPinProc.Game Controller with Sqlite entity framework database using `net6.0;net7.0`

## About

This holds all machine data, adjustments, audits, machine items switches instead of the `machine.json`

The NetProcDbContext can create a `MachineConfiguration` for use in a game the same way it is when loaded from the usual json file.

## How to use / customize
---

### SQL Data init
---
Edit the sql files in `SqlNetProc` to suit your machine. These files are by machine type (just a split by P3-ROC board).

### Dependency Injection Service
---
You can use the `AddNetProcDataContext` to add to the service collection.

### Code use
---

In code you would then use `InitializeDatabase` on the `NetProcDbContext` which will seed the database and create a new sqlite file `netproc.db`

To load the P-ROC device with the machine config from your data use `GetMachineConfiguration` on the `NetProcDbContext`.

### Game use
---

Derive from `NetProcDataGameController` that overrides some game events and has methods for setting data audits.

## Creating migrations
---

Make changes to the models to add columns then create a migration.

Open terminal on the project and run.

- `dotnet ef migrations add NameOfMigration`

[License](LICENSE.md)