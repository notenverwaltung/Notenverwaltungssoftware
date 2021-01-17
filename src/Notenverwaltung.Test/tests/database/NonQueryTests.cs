using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using MvvmCross;
using NUnit.Framework;

namespace Notenverwaltung.Test
{
    [TestFixture]
    public class NonQueryTests : MvxTest
    {
        //private IDatabaseService databaseService;

        //[Test]
        //public void CreateBlog_saves_a_blog_via_context()
        //{
        //    databaseService = Mvx.IoCProvider.Resolve<IDatabaseService>();

        // var mockSet = new Mock<DbSet<GradeModel>>();

        // var mockContext = new Mock<DatabaseContext>(); mockContext.Setup(m =>
        // m.Grades).Returns(mockSet.Object);

        // GradeModel grade = new GradeModel() { Comment = "Test", Grade = 1 };

        // databaseService.SetGrade(grade);

        //    // checking
        //    mockSet.Verify(m => m.Add(It.IsAny<GradeModel>()), Times.Once());
        //    mockContext.Verify(m => m.SaveChanges(), Times.Once());
        //}

        //protected override void AdditionalSetup()
        //{
        //    base.AdditionalSetup();

        //    var databaseService = new DatabaseService();
        //    Ioc.RegisterSingleton<IDatabaseService>(databaseService);
        //}
    }
}