using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace soru_cevap.ViewModel
{
    public class AnswerModel
    {
        public int AnswerID { get; set; }
        public string Description { get; set; }
        public DateTime DateAnswered { get; set; }
        public int UserID { get; set; }
        public UserModel User { get; set; }
        public int QuestionID { get; set; }
        public QuestionModel Question { get; set; }
    }
}