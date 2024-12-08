using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Application.Services.Entities
{
    public class Choice : BaseEntity
    {
        [Key]
        public int ChoiceID { get; set; }
        public int QuestionID { get; set; }
        public string DisplayText { get; set; }
    }


    public class choisEDto
    {
        public int ChoiceID { get; set; }
        public int QuestionID { get; set; }
        public string DisplayText { get; set; }

      
        public DateTime? CreatedOn { get; set; }

     
        public DateTime? ModifiedOn { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
