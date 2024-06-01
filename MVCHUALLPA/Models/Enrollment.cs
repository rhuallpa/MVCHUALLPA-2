namespace MVCHUALLPA.Models
{
    public class Enrollment
    {
    
        public int EnrollmentID { get; set; }
      
        public DateTime Date { get; set; }



        public int StudentId { get; set; }
        public Student Student { get; set; }


        public int CourseId { get; set; }
        public Course ? Course { get; set; }


    }
}
