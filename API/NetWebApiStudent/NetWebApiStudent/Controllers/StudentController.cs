using NetWebApiStudent.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApiStudent.Controllers
{
    public class StudentController : ApiController
    {
        StudentDBEntities db = new StudentDBEntities();

        public IEnumerable<Student> Get()
        {
            return db.Students.ToList();
        }

        //public Student Get(int id)
        //{
        //    Student student = db.Students.FirstOrDefault(x => x.ID == id);
        //    return student;
        //}

        //HttpResponseMessage 
        /*
         HttpResponseMessage döndüren metotlar gelen isteğin fiiline göre Get,Post,Put,Delete ile beraber kullanılırlar. Kaynağa ulaşıldığı takdirde HttpStatus Code ve httpresponse message olarak xml ve json formatlarından biri halinde veri istemciye gönderilir.
         */

        public HttpResponseMessage Get(int id)//6
        {
            Student student = db.Students.FirstOrDefault(x => x.ID == id);
            if (student != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, student);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı bir öğrenci bulunamadı.");
            }
        }

        //Post
        //parametre boşsa 400 hata mesajını dönsün.
        public HttpResponseMessage Post(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, student);
        }

        //Put
        //parametrede bulunan id boşsa geriye 404 dolu ise ve güncelleme başarılıysa 200 mesajını dönsün.

        public HttpResponseMessage Put(int id,Student student)
        {
            Student updated = db.Students.FirstOrDefault(x => x.ID == id);
            if (updated != null)
            {
                updated.FirstName = student.FirstName;
                updated.LastName = student.LastName;
                updated.Gender = student.Gender;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, $"{id} numaralı öğrenci güncellendi.");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı bir öğrenci bulunamadı");
            }
        }

        //Delete
        //parametrede bulunan id boşsa geriye 404 dolu ise ve güncelleme başarılıysa 200 mesajını dönsün.
        public HttpResponseMessage Delete(int id)//5
        {
          Student deleted=  db.Students.Find(id);
            if (deleted != null)
            {
                db.Students.Remove(deleted);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"{id} numaralı bir öğrenci bulunamadı");
            }
        }

        

    }
}
