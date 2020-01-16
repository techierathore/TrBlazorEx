using SQLite;
using System.Collections.Generic;
using System.IO;

namespace SQLiteEx.Data
{
    public class EmpDataAccess
    {
        SQLiteConnection dbConn;
        public EmpDataAccess()
        {
            dbConn = GetConnection();
            // create the table(s)  
            dbConn.CreateTable<Employee>();
        }
        SQLiteConnection GetConnection()
        {
            var sqliteFilename = "SQLiteEx.db3";
            string dbPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(dbPath, sqliteFilename);
            if (!File.Exists(path)) File.Create(path);
            var conn = new SQLiteConnection(path);
            // Return the database connection 
            return conn;
        }
        public List<Employee> GetAllEmployees()
        {
            return dbConn.Query<Employee>("Select * From [Employee]");
        }
        public int SaveEmployee(Employee aEmployee)
        {
            return dbConn.Insert(aEmployee);
        }
        public int DeleteEmployee(Employee aEmployee)
        {
            return dbConn.Delete(aEmployee);
        }
        public int EditEmployee(Employee aEmployee)
        {
            return dbConn.Update(aEmployee);
        }
    }
}
