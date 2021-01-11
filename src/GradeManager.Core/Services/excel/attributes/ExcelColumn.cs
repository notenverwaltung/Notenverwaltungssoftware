using System.ComponentModel.DataAnnotations;

namespace GradeManager.Core.Services
{
    // nur bei fields
    [System.AttributeUsage(System.AttributeTargets.Property,
                           AllowMultiple = false)
    ]
    public class ExcelColumn : System.Attribute
    {
        public string ColumnIndex { get; private set; }

        public string ColumnName { get; private set; }

        public ExcelColumn(string columnName, [StringLength(1)] string columnIndex = null)
        {
            this.ColumnName = columnName;
            this.ColumnIndex = columnIndex;
        }
    }
}