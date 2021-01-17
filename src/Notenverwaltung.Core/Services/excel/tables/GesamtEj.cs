namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Gesamt-EJ", tableIndex: 12)]
    public class GesamtEj : Total
    {
        public GesamtEj()
        {
        }

        public GesamtEj(Total total) : base(total)
        {
        }
    }
}