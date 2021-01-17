using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using MvvmCross;
using NUnit.Framework;

namespace Notenverwaltung.Test
{
    [TestFixture]
    public class AsyncQueryTests : MvxTest
    {
        //private IDatabaseService databaseService;

        //[TestMethod]
        //public async Task GetAllBlogsAsync_orders_by_name()
        //{
        //    var data = new List<Blog>
        //    {
        //        new Blog { Name = "BBB" },
        //        new Blog { Name = "ZZZ" },
        //        new Blog { Name = "AAA" },
        //    }.AsQueryable();

        // var mockSet = new Mock<DbSet<Blog>>(); mockSet.As<IDbAsyncEnumerable<Blog>>()
        // .Setup(m => m.GetAsyncEnumerator()) .Returns(new
        // TestDbAsyncEnumerator<Blog>(data.GetEnumerator()));

        // mockSet.As<IQueryable<Blog>>() .Setup(m => m.Provider) .Returns(new
        // TestDbAsyncQueryProvider<Blog>(data.Provider));

        // mockSet.As<IQueryable<Blog>>().Setup(m =>
        // m.Expression).Returns(data.Expression); mockSet.As<IQueryable<Blog>>().Setup(m
        // => m.ElementType).Returns(data.ElementType);
        // mockSet.As<IQueryable<Blog>>().Setup(m =>
        // m.GetEnumerator()).Returns(data.GetEnumerator());

        // var mockContext = new Mock<BloggingContext>(); mockContext.Setup(c =>
        // c.Blogs).Returns(mockSet.Object);

        // var service = new BlogService(mockContext.Object); var blogs = await
        // service.GetAllBlogsAsync();

        //    Assert.AreEqual(3, blogs.Count);
        //    Assert.AreEqual("AAA", blogs[0].Name);
        //    Assert.AreEqual("BBB", blogs[1].Name);
        //    Assert.AreEqual("ZZZ", blogs[2].Name);
        //}

        //protected override void AdditionalSetup()
        //{
        //    base.AdditionalSetup();

        //    var databaseService = new DatabaseService();
        //    Ioc.RegisterSingleton<IDatabaseService>(databaseService);
        //}
    }
}