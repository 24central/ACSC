using ACSC.NewFolder1;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSC.Services
{
    public class StudentService : IntStudentService
    {
        private SQLiteAsyncConnection _dbConnection;
    
        public StudentService() { 
        
        SetUpDb();
        
        }

        private async void SetUpDb() {
            if (_dbConnection == null)
            {
                string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "student.db1");
                _dbConnection = new SQLiteAsyncConnection(dbpath);
                await _dbConnection.CreateTableAsync<studentobj>();
            }
        
        }

        public Task<int> AddStudent(studentobj studentobj)
        {
            return _dbConnection.InsertAsync(studentobj);
        }

        public async Task<List<studentobj>> GetStudentobjs()
        {
            var StudentList = await _dbConnection.Table<studentobj>().ToListAsync();
            return StudentList;
        }

        public Task<int> RemoveStudent(studentobj studentobj)
        {
            return _dbConnection.DeleteAsync(studentobj);
        }

        public Task<int> UpdateStudent(studentobj studentobj)
        {
            return _dbConnection.UpdateAsync(studentobj);
        }
    }
}
