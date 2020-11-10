using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string value1 = File.ReadAllText("../students.csv");
            

            String [] arr = value1.Split("\n");
            int successCnt = 0;
           
            ArrayList failedList = new ArrayList();

            using (var db = new BloggingDbContext())
            {
                for (int i = 1; i < arr.Length-1; i++) {
                    String[] idScores = arr[i].Split(",");
                    var subjectScores = db.StudentSubjects.Where(s => s.StudentId == Int32.Parse(idScores[0]) && s.SubjectId== Int32.Parse(idScores[1])).FirstOrDefault();

                    if (subjectScores != null)
                    {
                        subjectScores.subjectScore = Int32.Parse(idScores[2]);
                        db.SaveChanges();
                        successCnt++;
                    }
                    else {
                        failedList.Add(arr[i]);
                       
                    }

                }
            }

            Console.WriteLine("Success cnt= " + successCnt);
            Console.WriteLine("Failed cnt= " + failedList.Count);
            Console.WriteLine("StudentId,SubjectId,Score");
            for (int i = 0; i < failedList.Count; i++) {
                Console.WriteLine(failedList[i]); 
            }

            Console.ReadLine();
        }
    }

    public class BloggingDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                       

            for (int i = 1; i <=5; i++)
            {
                modelBuilder.Entity<Subject>().HasData(
                    new Subject { Name = "subj "+i, SubjectId = i }

       );
            }

            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Student>().HasData(
                    new Student { Name = "Student " + i, StudentId = i }

       ); }

            int id = 1;
            Random r = new Random();
            for (int i = 1; i <=50; i++)
            {
                int sId = r.Next(1, 4);
                modelBuilder.Entity<StudentSubject>().HasData(
                    
                    new StudentSubject { StudentSubjectId = id, SubjectId = sId, StudentId = i },
                    new StudentSubject { StudentSubjectId = id + 1, SubjectId = sId+1, StudentId = i }



       );
                id += 2;
            }
                
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=SchoolDb;Integrated security=true;");
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<StudentSubject> Subjects { get; set; }
    }

    public class StudentSubject
    {
        public int StudentSubjectId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int subjectScore { get; set; }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public List<StudentSubject> Students { get; set; }
    }

}
