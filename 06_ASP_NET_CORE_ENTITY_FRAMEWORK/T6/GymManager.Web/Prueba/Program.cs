using DataAccess.StoredProcedures;
using DataAccess.StoredProcedures.Entities;


StoredProcedure storedProcedure = new StoredProcedure();

var recordSale = storedProcedure.RecordSale(1, 1);
Console.WriteLine(recordSale.Id);
