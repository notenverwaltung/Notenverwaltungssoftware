using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeManager.Core.Services
{
    public interface IDatabaseService
    {
        bool SetGrade(GradeModel grade);
    }
}