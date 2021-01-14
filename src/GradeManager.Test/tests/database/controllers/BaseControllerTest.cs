using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeManager.Test
{
    public class BaseControllerTest : MvxTest
    {
        protected DbContextOptions<DatabaseContext> ContextOptions { get; }

        protected BaseControllerTest(DbContextOptions<DatabaseContext> contextOptions)
        {
            ContextOptions = contextOptions;

            //Seed();
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();
        }

        /// <summary>
        /// Seeds this instance.
        /// </summary>
        //private void Seed()
        //{
        //    using (var context = new DatabaseContext(ContextOptions))
        //    {
        //        context.Database.EnsureDeleted();
        //        context.Database.EnsureCreated();

        // //var one = new Item("ItemOne"); //one.AddTag("Tag11"); //one.AddTag("Tag12");
        // //one.AddTag("Tag13");

        // //var two = new Item("ItemTwo");

        // //var three = new Item("ItemThree"); //three.AddTag("Tag31");
        // //three.AddTag("Tag31"); //three.AddTag("Tag31"); //three.AddTag("Tag32");
        // //three.AddTag("Tag32");

        // //context.AddRange(one, two, three);

        //        //context.SaveChanges();
        //    }
        //}
    }
}