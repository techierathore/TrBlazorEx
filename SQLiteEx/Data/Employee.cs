using SQLite;

namespace SQLiteEx.Data
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public long EmpId
        { get; set; }
        [NotNull]
        public string EmpName
        { get; set; }
        public string Designation
        { get; set; }
        public string Department
        { get; set; }
        public string Qualification
        { get; set; }
    }
}
