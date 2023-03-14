using ACSC.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSC.Services
{
    public interface IntStudentService
    {
        Task<List<studentobj>> GetStudentobjs();

        Task<int> AddStudent(studentobj studentobj);

        Task<int> RemoveStudent(studentobj studentobj);

        Task<int> UpdateStudent(studentobj studentobj);
    }
}
