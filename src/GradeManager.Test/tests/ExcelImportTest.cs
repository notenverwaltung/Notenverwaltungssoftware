using GradeManager.Core.Services;
using MvvmCross;
using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GradeManager.Test
{
    [TestFixture]
    public class ExcelImportTest : MvxTest
    {
        private IExcelService excelService;

        [Test]
        public void ReadExcelTest()
        {
            excelService = Mvx.IoCProvider.Resolve<IExcelService>();

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith("Klasse4a.xlsx"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                excelService.OpenFile(stream);
            }
            excelService.ReadNoteTables();
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            var excelService = new ExcelService();
            Ioc.RegisterSingleton<IExcelService>(excelService);
        }
    }
}