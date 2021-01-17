using System.ComponentModel.DataAnnotations;

namespace Notenverwaltung.Core.Services
{
    // nur bei klassen
    [System.AttributeUsage(System.AttributeTargets.Class,
                           AllowMultiple = false)
    ]
    public class ExcelTable : System.Attribute
    {
        public int TableIndex { get; private set; }

        public string TableName { get; private set; }

        public ExcelTable(string tableName, int tableIndex = 0)
        {
            this.TableName = tableName;
            this.TableIndex = tableIndex;
        }
    }
}