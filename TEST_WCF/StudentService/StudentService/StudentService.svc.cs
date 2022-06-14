using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        public void AddStudent(StudentContract studentContract)
        {
            StudentDBEntities dBEntities = new StudentDBEntities();

            dBEntities.Students.Add(
                new Student 
                {
                    StudentID = dBEntities.Students.Count() + 1,
                    FirstName = studentContract.FirstName,
                    LastName = studentContract.LastName,
                    PhoneNumber = studentContract.PhoneNumber,
                    Email = studentContract.Email,
                });
            dBEntities.SaveChanges();
        }

        public void DoWork()
        {
        }

        public List<StudentContract> GetAllStudent()
        {
            StudentDBEntities dBEntities = new StudentDBEntities();

            var result = dBEntities.Students.Select(s => new StudentContract
            {
                StudentID = s.StudentID,
                FirstName = s.FirstName,
                LastName = s.LastName,
                PhoneNumber = s.PhoneNumber,
                Email = s.Email
            }).ToList();

            return result;
        }
    }
}
