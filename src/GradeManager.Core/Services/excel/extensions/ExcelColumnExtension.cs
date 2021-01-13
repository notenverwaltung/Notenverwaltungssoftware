using System;
using System.Linq.Expressions;
using System.Reflection;

namespace GradeManager.Core.Services
{
    public static class ExcelExtension
    {
        /// <summary>
        /// Gets the index of the excel column. LINQ Expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public static string GetExcelColumnIndex<T>(Expression<Func<T>> expression)
        {
            var property = ((MemberExpression)expression.Body).Member.Name;

            return typeof(T)
                .GetProperty(property)
                .GetCustomAttribute<ExcelColumn>()
                .ColumnIndex
                .ToString();
        }

        /// <summary>
        /// Gets the name of the excel column. LINQ Expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public static string GetExcelColumnName<T>(Expression<Func<T>> expression)
        {
            var body = expression.Body as MemberExpression;

            var property = body.Member.Name;
            var declaringType = body.Member.DeclaringType;

            return declaringType
                .GetProperty(property)
                .GetCustomAttribute<ExcelColumn>()
                .ColumnName
                .ToString();
        }

        /// <summary>
        /// Gets the name of the excel column. Reflection Expression.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns></returns>
        //public static string GetExcelColumnName(object target, string propertyName)
        //{
        //    var property = target.GetType().GetProperty(propertyName).Name;

        //    return typeof(Subject)
        //        .GetProperty(property)
        //        .GetCustomAttribute<ExcelColumn>()
        //        .ColumnName
        //        .ToString();
        //}
    }
}