using soru_cevap.Models;
using soru_cevap.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace soru_cevap.Controllers
{
    public class UserController : ApiController
    {
        QAPortalDBEntities db = new QAPortalDBEntities();
        uyg04.ViewModel.SonucModel sonuc = new uyg04.ViewModel.SonucModel();
        // Sadece SonucModel.cs uyg04 den alınmıştır.


        [HttpGet]
        [Route("api/questions")]

        public QuestionModel QuestionById(int QuestionID)
        {
            QuestionModel kayit = db.Questions.Where(s => s.QuestionID == QuestionID).Select(x => new
                QuestionModel()
            {

                QuestionID = x.QuestionID,
                Title = x.Title,
                DateAsked = x.CreatedAt






            }).FirstOrDefault();
            return kayit;






        }

        [HttpPost]
        [Route("api/soruekle")]
        public uyg04.ViewModel.SonucModel SoruEkle(QuestionModel model)
        {
            Questions yeni = new Questions();
            yeni.QuestionID = model.QuestionID;
            db.Questions.Add(yeni);


            return sonuc;


        }

        [HttpDelete]
        [Route("api/sorusil")]

        public uyg04.ViewModel.SonucModel SoruSil(int QuestionID)
        {
            Questions kayit = db.Questions.Where(s => s.QuestionID == QuestionID).FirstOrDefault(); 
            if (kayit == null)
            { 
                sonuc.islem = false; 
                sonuc.mesaj = "Soru Bulunamadı!"; 
                return sonuc; 
            }

            db.Questions.Remove(kayit); 
            db.SaveChanges(); 
            sonuc.islem = true; 
            sonuc.mesaj = "Soru Silindi"; 
            return sonuc;
        }


        [HttpGet]
        [Route("api/answers")]

        public AnswerModel AnswersById(int AnswerID)
        {
            AnswerModel kayit = db.Answers.Where(s => s.AnswerID == AnswerID).Select(x => new
                AnswerModel()
            {

                AnswerID = x.AnswerID,
                QuestionID = x.QuestionID,
                DateAnswered = x.CreatedAt






            }).FirstOrDefault();
            return kayit;






        }

        [HttpPost]
        [Route("api/cevapekle")]
        public uyg04.ViewModel.SonucModel CevapEkle(AnswerModel model)
        {
            Answers yeni = new Answers();
            yeni.AnswerID = model.AnswerID;
            db.Answers.Add(yeni);


            return sonuc;


        }

        [HttpDelete]
        [Route("api/cevapsil")]

        public uyg04.ViewModel.SonucModel CevapSil(int AnswerID)
        {
            Answers kayit = db.Answers.Where(s => s.AnswerID == AnswerID).FirstOrDefault();
            if (kayit == null)
            {
                sonuc.islem = false;
                sonuc.mesaj = "Cevap Bulunamadı!";
                return sonuc;
            }

            db.Answers.Remove(kayit);
            db.SaveChanges();
            sonuc.islem = true;
            sonuc.mesaj = "Cevap Silindi";
            return sonuc;
        }

        [HttpGet]
        [Route("api/users")]

        public UserModel UserById(int UserID)
        {
            UserModel kayit = db.Users.Where(s => s.UserID == UserID).Select(x => new
                UserModel()
            {

                UserID = x.UserID,
                UserName = x.UserName,
                Email = x.Email,
                Password = x.Password
                






            }).FirstOrDefault();
            return kayit;






        }

        [HttpPost]
        [Route("api/kayıtekle")]
        public uyg04.ViewModel.SonucModel ÜyeEkle(UserModel model)
        {
            Users yeni = new Users();
            yeni.UserID = model.UserID;
            db.Users.Add(yeni);


            return sonuc;


        }

        [HttpDelete]
        [Route("api/kayıtsil")]

        public uyg04.ViewModel.SonucModel ÜyeSil(int UserID)
        {
            Users kayit = db.Users.Where(s => s.UserID == UserID).FirstOrDefault();
            if (kayit == null)
            {
                sonuc.islem = false;
                sonuc.mesaj = "Üye Bulunamadı!";
                return sonuc;
            }

            db.Users.Remove(kayit);
            db.SaveChanges();
            sonuc.islem = true;
            sonuc.mesaj = "Üye Silindi";
            return sonuc;
        }






    }













    


}
