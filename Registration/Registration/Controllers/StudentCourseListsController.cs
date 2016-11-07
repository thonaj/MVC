using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Registration;

namespace Registration.Controllers
{
    public class StudentCourseListsController : Controller
    {
        private RegistrationDBEntities db = new RegistrationDBEntities();

        // GET: StudentCourseLists
        public ActionResult Index()
        {
            var studentCourseLists = db.StudentCourseLists.Include(s => s.Course).Include(s => s.Student);
            return View(studentCourseLists.ToList());
        }

        // GET: StudentCourseLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentCourseList studentCourseList = db.StudentCourseLists.Find(id);
            if (studentCourseList == null)
            {
                return HttpNotFound();
            }
            return View(studentCourseList);
        }

        // GET: StudentCourseLists/Create
        public ActionResult Create()
        {
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName");
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName");
            return View();
        }

        // POST: StudentCourseLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentCourseID,studentID,courseID,active")] StudentCourseList studentCourseList)
        {
            if (ModelState.IsValid)
            {
                db.StudentCourseLists.Add(studentCourseList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", studentCourseList.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", studentCourseList.studentID);
            return View(studentCourseList);
        }

        // GET: StudentCourseLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentCourseList studentCourseList = db.StudentCourseLists.Find(id);
            if (studentCourseList == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", studentCourseList.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", studentCourseList.studentID);
            return View(studentCourseList);
        }

        // POST: StudentCourseLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentCourseID,studentID,courseID,active")] StudentCourseList studentCourseList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentCourseList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", studentCourseList.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "firstName", studentCourseList.studentID);
            return View(studentCourseList);
        }

        // GET: StudentCourseLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentCourseList studentCourseList = db.StudentCourseLists.Find(id);
            if (studentCourseList == null)
            {
                return HttpNotFound();
            }
            return View(studentCourseList);
        }

        // POST: StudentCourseLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentCourseList studentCourseList = db.StudentCourseLists.Find(id);
            db.StudentCourseLists.Remove(studentCourseList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
