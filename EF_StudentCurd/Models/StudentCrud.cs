namespace EF_StudentCurd.Models
{
    public class StudentCrud
    {


        ApplicationDbContext context;
        public StudentCrud(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Student> GetStudents()
        {
            return context.Students.Where(x => x.IsActive == 1).ToList();
        }


        public Student GetStudentById(int id)
        {
            var student = context.Students.Where(x => x.Id == id).FirstOrDefault();
            return student;
        }


        public int AddStudent(Student student)
        {
            student.IsActive = 1;
            int result = 0;
            context.Students.Add(student); // add new record in to the DbSet
            result = context.SaveChanges(); // update the change from DbSet to DB
            return result;
        }
        public int UpdateStudent(Student student)
        {

            int result = 0;
            // search from dbset
            var s = context.Students.Where(x => x.Id == student.Id).FirstOrDefault();
            if (s != null)
            {
                s.Name = student.Name; // b object contains old data book obj contains new data
                s.Course = student.Course;
                s.Duration = student.Duration;
                s.IsActive = 1;
                result = context.SaveChanges(); // update the change from DbSet to DB
            }

            return result;
        }
        public int DeleteStudent(int id)
        {


            int result = 0;
            // search from dbset
            var b = context.Students.Where(x => x.Id == id).FirstOrDefault();
            if (b != null)
            {
                b.IsActive = 0;
                result = context.SaveChanges(); // update the change from DbSet to DB
            }


            return result;
        }

    }
}
