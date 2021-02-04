using System.Collections.Generic;

namespace Notenverwaltung.Core.Services
{
    /// <summary>
    /// ClassSheet.
    /// </summary>
    public class ClassSheet
    {
        public List<Deutsch> Deutsch { get; set; }

        public List<Englisch> Englisch { get; set; }

        public List<Ethik> Ethik { get; set; }

        public List<GesamtEj> GesamtEj { get; set; }

        public List<GesamtHj> GesamtHj { get; set; }

        public List<Kunst> Kunst { get; set; }

        public List<Lehrer> Lehrer { get; set; }

        public List<Mathe> Mathe { get; set; }

        public List<Musik> Musik { get; set; }

        public string Name { get; set; }

        public List<Religion> Religion { get; set; }

        public List<Sachkunde> Sachkunde { get; set; }

        public List<Sport> Sport { get; set; }

        public List<Werken> Werken { get; set; }
    }
}