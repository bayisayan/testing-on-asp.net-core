using Microsoft.AspNetCore.Mvc;
using Rocky.Models;
using System.Collections.Generic;

namespace Rocky.Controllers
{
    public class QuezController : Controller
    {
        public IActionResult Index()
        {
            List<Quez> questions = new List<Quez>()
            {
                 new  Quez(){
                  QuestionNumber=1, Options= new List<QuestionOption> {
                   new QuestionOption(){  Index=1, Option="A"},
                   new QuestionOption(){  Index=2, Option="B"},
                   new QuestionOption(){  Index=3, Option="C"},
                  },
                   RightAnswer = 2
                 },
                 new  Quez(){
                  QuestionNumber=2, Options= new List<QuestionOption> {
                   new QuestionOption(){  Index=1, Option="Kity"},
                   new QuestionOption(){  Index=2, Option="Lily"},
                   new QuestionOption(){  Index=3, Option="Jack"},
                  },
                   RightAnswer = 1
                 },
                  new  Quez(){
                  QuestionNumber=3, Options= new List<QuestionOption> {
                   new QuestionOption(){  Index=1, Option="FF"},
                   new QuestionOption(){  Index=2, Option="LL"},
                   new QuestionOption(){  Index=3, Option="OO"},
                  },
                   RightAnswer = 3
                 },
            };
            return View(questions);
        }
    }
}
