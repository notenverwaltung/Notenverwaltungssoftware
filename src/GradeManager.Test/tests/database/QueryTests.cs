using Data;
using Data.Models;
using GradeManager.Core.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using MvvmCross;
using NUnit.Framework;

namespace GradeManager.Test
{
    [TestFixture]
    public class QueryTests : InMemoryControllerTest
    {
        //private IDatabaseService databaseService;

        [Test]
        public void CreateGradTest()
        {
            //databaseService = Mvx.IoCProvider.Resolve<IDatabaseService>();

            //var mockSet = new Mock<DbSet<GradeModel>>();

            //var context = new TestContext();

            //var service = new BlogService(context);

            //var mockContext = new Mock<DatabaseContext>();
            //mockContext.Setup(m => m.Grades).Returns(mockSet.Object);

            //GradeModel grade = new GradeModel()
            //{
            //    Comment = "Test",
            //    Grade = 1
            //};

            //databaseService.SetGrade(grade);

            // checking
            //mockSet.Verify(m => m.Add(It.IsAny<GradeModel>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();

            //var context = new DatabaseContext();
            //var databaseService = new DatabaseService(context);
            //Ioc.RegisterSingleton<IDatabaseService>(databaseService);
        }
    }
}