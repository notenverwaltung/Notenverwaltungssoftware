using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Controllers
{
    public interface ILectureshipController
    {
        Task<Lectureship> DeleteLectureship(Guid id);

        Task<Lectureship> GetLectureship(Guid id);

        Task<IEnumerable<Lectureship>> GetLectureships();

        Task<Lectureship> PostLectureship(Lectureship Lectureship);

        Task PutLectureship(Guid id, Lectureship Lectureship);
    }
}