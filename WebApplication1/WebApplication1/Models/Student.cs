using System.ComponentModel.DataAnnotations; //key , required ,MinLength...

namespace WebApplication1.Models
{ 
    public class Student
    {
        public Student()
        {

        }

        public Student(string studentNo, string studentName , string githubLink)
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.githubLink = githubLink;
        }

        [Key] //key值
        public string studentNo { get; set; }

        [Required(ErrorMessage ="姓名不能為空")] 
        public string studentName { get; set; }

        [MinLength(10,ErrorMessage= "長度不得小於10")]
        public string githubLink { get; set; }


    }
}
