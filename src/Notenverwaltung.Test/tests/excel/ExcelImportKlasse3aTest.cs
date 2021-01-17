using MvvmCross;
using Notenverwaltung.Core.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Notenverwaltung.Test
{
    [TestFixture]
    public class ExcelImportKlasse3aTest : MvxTest
    {
        private List<Deutsch> deutsch = new List<Deutsch>();
        private List<Englisch> englisch = new List<Englisch>();
        private List<Ethik> ethik = new List<Ethik>();
        private IExcelService excelService;
        private List<GesamtEj> gesamtEj = new List<GesamtEj>();
        private List<GesamtHj> gesamtHj = new List<GesamtHj>();
        private List<Kunst> kunst = new List<Kunst>();
        private List<Lehrer> lehrer = new List<Lehrer>();
        private List<Mathe> mathe = new List<Mathe>();
        private List<Musik> musik = new List<Musik>();
        private List<Religion> religion = new List<Religion>();
        private List<Sachkunde> sachkunde = new List<Sachkunde>();
        private List<Sport> sport = new List<Sport>();
        private List<Werken> werken = new List<Werken>();

        [SetUp]
        public void ReadExcelTest()
        {
            excelService = Mvx.IoCProvider.Resolve<IExcelService>();

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("Klasse3a.xlsx"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                excelService.OpenFile(stream);
            }
            excelService.ReadTables();

            mathe = excelService.GetMathe();
            deutsch = excelService.GetDeutsch();
            sachkunde = excelService.GetSachkunde();
            englisch = excelService.GetEnglisch();
            kunst = excelService.GetKunst();
            werken = excelService.GetWerken();
            musik = excelService.GetMusik();
            sport = excelService.GetSport();
            ethik = excelService.GetEthik();
            religion = excelService.GetReligion();
            gesamtHj = excelService.GetGesamtHj();
            gesamtEj = excelService.GetGesamtEj();
            lehrer = excelService.GetLehrer();
        }

        [Test]
        public void Subject_Test()
        {
            //// mathe
            //var fredFalkner = mathe.Where(s => s.Nachname == "Falkner").First();
            //Assert.AreEqual(fredFalkner.T1, 1);
            //Assert.AreEqual(fredFalkner.T10, null);
            //Assert.AreEqual(fredFalkner.MwK, 2.5);

            //// deutsch
            //var gritHumlein = deutsch.Where(s => s.Nachname == "Humlein").First();
            //Assert.AreEqual(gritHumlein.T1, 1);
            //Assert.AreEqual(gritHumlein.T10, null);
            //Assert.AreEqual(gritHumlein.MwK, 1.5);

            //// sachkunde
            //var haraldRegen = sachkunde.Where(s => s.Nachname == "Regen").First();
            //Assert.AreEqual(haraldRegen.T1, 1);
            //Assert.AreEqual(haraldRegen.T10, null);
            //Assert.AreEqual(haraldRegen.MwK, 1.0);

            //// englisch
            //var reneHerzberg = englisch.Where(s => s.Nachname == "Herzberg").First();
            //Assert.AreEqual(reneHerzberg.T1, 2);
            //Assert.AreEqual(reneHerzberg.T10, null);
            //Assert.AreEqual(reneHerzberg.MwK, 1.0);

            //// englisch
            //var steveRost = englisch.Where(s => s.Nachname == "Rost").First();
            //Assert.AreEqual(steveRost.T1, 4);
            //Assert.AreEqual(steveRost.T10, null);
            //Assert.AreEqual(steveRost.MwK, 3.0);

            //// kunst
            //var hannesLohmeyer = kunst.Where(s => s.Nachname == "Lohmeyer").First();
            //Assert.AreEqual(hannesLohmeyer.T1, 2);
            //Assert.AreEqual(hannesLohmeyer.T10, null);
            //Assert.AreEqual(hannesLohmeyer.MwK, null);

            //// werken
            //var jennyWeigelt = werken.Where(s => s.Nachname == "Weigelt").First();
            //Assert.AreEqual(jennyWeigelt.T1, 3);
            //Assert.AreEqual(jennyWeigelt.T10, null);
            //Assert.AreEqual(jennyWeigelt.MwK, 4.0);

            //// musik
            //var bjonLattermann = musik.Where(s => s.Nachname == "Lattermann").First();
            //Assert.AreEqual(bjonLattermann.T1, 1);
            //Assert.AreEqual(bjonLattermann.T10, null);
            //Assert.AreEqual(bjonLattermann.MwK, 2.0);

            //// sport
            //var elviraDucker = sport.Where(s => s.Nachname == "Ducker").First();
            //Assert.AreEqual(elviraDucker.T1, 3);
            //Assert.AreEqual(elviraDucker.T10, null);
            //Assert.AreEqual(elviraDucker.MwK, null);

            //// ethik
            //var felixKruse = ethik.Where(s => s.Nachname == "Kruse").First();
            //Assert.AreEqual(felixKruse.T1, 2);
            //Assert.AreEqual(felixKruse.T10, null);
            //Assert.AreEqual(felixKruse.MwK, 2.0);

            //// religion
            //var enricoGrundmann = religion.Where(s => s.Nachname == "Grundmann").First();
            //Assert.AreEqual(enricoGrundmann.T1, 2);
            //Assert.AreEqual(enricoGrundmann.T10, null);
            //Assert.AreEqual(enricoGrundmann.MwK, 2.0);

            //// gesamtHj
            //var theresaAnders = gesamtHj.Where(s => s.Nachname == "Anders").First();
            //Assert.AreEqual(theresaAnders.Mathe, 3);
            //Assert.AreEqual(theresaAnders.Musik, 0);
            //Assert.AreEqual(theresaAnders.MwS, 0.3);

            //// gesamtEj
            //var sinaHorst = gesamtEj.Where(s => s.Nachname == "Horst").First();
            //Assert.AreEqual(sinaHorst.Mathe, 0);
            //Assert.AreEqual(sinaHorst.Musik, 0);
            //Assert.AreEqual(sinaHorst.MwS, 0.0);
        }

        [Test]
        public void Teacher_Test()
        {
            //// Lehrer
            //var brittaWagner = lehrer.Where(l => l.Nachname == "Wagner").First();
            //Assert.AreEqual(brittaWagner.Klassenleiter, true);
            //Assert.AreEqual(brittaWagner.Kuerzel, "Wag");
            //Assert.AreEqual(brittaWagner.Anrede, "Frau");

            //var karstenBlacksmith = lehrer.Where(l => l.Nachname == "Blacksmith").First();
            //Assert.AreEqual(karstenBlacksmith.Klassenleiter, false);
            //Assert.AreEqual(karstenBlacksmith.Kuerzel, "Bla");
            //Assert.AreEqual(karstenBlacksmith.Anrede, "Herr");
        }

        [Test]
        public void Total_Test()
        {
            //// gesamtHj
            //var theresaAnders = gesamtHj.Where(s => s.Nachname == "Anders").First();
            //Assert.AreEqual(theresaAnders.Mathe, 3);
            //Assert.AreEqual(theresaAnders.Musik, 0);
            //Assert.AreEqual(theresaAnders.MwS, 0.3);

            //// gesamtEj
            //var sinaHorst = gesamtEj.Where(s => s.Nachname == "Horst").First();
            //Assert.AreEqual(sinaHorst.Mathe, 0);
            //Assert.AreEqual(sinaHorst.Musik, 0);
            //Assert.AreEqual(sinaHorst.MwS, 0.0);
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            var excelService = new ExcelService();
            Ioc.RegisterSingleton<IExcelService>(excelService);
        }
    }
}