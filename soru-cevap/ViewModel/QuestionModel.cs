using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace soru_cevap.ViewModel
{
    public class QuestionModel
    {
        public int QuestionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAsked { get; set; }
        public bool IsAnswered { get; set; }
        public int UserID { get; set; }
        public UserModel User { get; set; }
        public ICollection<AnswerModel> Answers { get; set; }
    }
}