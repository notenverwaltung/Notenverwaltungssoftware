namespace Notenverwaltung.Core.Services
{
    [ExcelTable(tableName: "Gesamt-HJ", tableIndex: 11)]
    public class GesamtHj : Total
    {
        public GesamtHj()
        {
        }

        public GesamtHj(Total total) : base(total)
        {
        }
    }
}