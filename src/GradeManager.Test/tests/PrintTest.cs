using Data.Models;
using GradeManager.WPF.UI.Services;
using MvvmCross;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GradeManager.Test
{
    [TestFixture]
    public class PrintTest : MvxTest
    {
        private IPrintService printService;

        [Test]
        public void ReadExcelTest()
        {
            printService = Mvx.IoCProvider.Resolve<IPrintService>();

            DataGrid dataGrid = new DataGrid();
            List<GradeModel> grades = new List<GradeModel>();
            grades.Add(new GradeModel() { Id = 1, Grade = 2, Abbreviation = "-", GradeEnum = Data.Enums.GradeEnum.Einzelnote });
            grades.Add(new GradeModel() { Id = 2, Grade = 5, Abbreviation = "+", GradeEnum = Data.Enums.GradeEnum.Einzelnote });

            dataGrid.ItemsSource = grades;

            // TODO: mock .ShowDialog() for testing
            //printService.PrintVisual(dataGrid, "Notenverwaltung-Test");
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            var printService = new PrintService();
            Ioc.RegisterSingleton<IPrintService>(printService);
        }
    }
}