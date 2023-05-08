using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace soru_cevap.ViewModel
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<QuestionModel> Questions { get; set; }
        public ICollection<AnswerModel> Answers { get; set; }
    }
}