using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQLbtl.Models;

namespace PTPMQLbtl.Controllers
{
    public class DanhmuchangsController : Controller
    {
        private PTPMQLDB db = new PTPMQLDB();
        // GET: Danhmuchangs
        public ActionResult Index()
        {
            return View(db.Danhmuchangs.ToList());
        }

        // GET: Danhmuchangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            if (danhmuchang == null)
            {
                return HttpNotFound();
            }
            return View(danhmuchang);
        }

        // GET: Danhmuchangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Danhmuchangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mathang,Tenhang,Donvitinh,Dongia")] Danhmuchang danhmuchang)
        {
            if (ModelState.IsValid)
            {
                db.Danhmuchangs.Add(danhmuchang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhmuchang);
        }

        // GET: Danhmuchangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            if (danhmuchang == null)
            {
                return HttpNotFound();
            }
            return View(danhmuchang);
        }

        // POST: Danhmuchangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mathang,Tenhang,Donvitinh,Dongia")] Danhmuchang danhmuchang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhmuchang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhmuchang);
        }

        // GET: Danhmuchangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            if (danhmuchang == null)
            {
                return HttpNotFound();
            }
            return View(danhmuchang);
        }

        // POST: Danhmuchangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            db.Danhmuchangs.Remove(danhmuchang);
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
        //upload file
        private void UploadFile(HttpPostedFileBase file)
        {
            //dat ten cho file
            string _FileName = "DanhMucHang.xlsx";
            //duong dan luu file
            string _path = Path.Combine(Server.MapPath("~/Uploads/Excels"), _FileName);
            //luu file len server
            file.SaveAs(_path);
            //doc du lieu tu file excel
            DataTable dt = ReadDataFromExcelFile(_path);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Danhmuchang kh = new Danhmuchang();            
                kh.Tenhang = dt.Rows[1][0].ToString();
                kh.Donvitinh = dt.Rows[1][1].ToString();
                db.Danhmuchangs.Add(kh);
                db.SaveChanges();
            }
            //return View(Index);
            
        }
        //download file
        public ActionResult DownloadFile()
        {
            //duong dan chua file muon download
            string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/Excels/";
            //chuyen file sang dang byte
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "FileMau.xlsx");
            //ten file khi download ve
            string fileName = "FileDownLoad.xlsx";
            //tra ve file
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
       
        

        private void CopyDataByBulk(object p)
        {
            throw new NotImplementedException();
        }
        //doc file excel tra ve du lieu dang datatable
        public DataTable ReadDataFromExcelFile(string filepath)
        {
            string connectionString = "";
            string fileExtention = filepath.Substring(filepath.Length - 4).ToLower();
            if (fileExtention.IndexOf("xlsx") == 0)
            {
                connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + filepath + ";Extended Properties=\"Excel 12.0 Xml;HDR=NO\"";
            }
            else if (fileExtention.IndexOf("xls") == 0)
            {
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0";
            }

            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch
            {
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }

        //copy large data from datatable to sqlserver
        private void CopyDataByBulk(DataTable dt)
        {
            //lay ket noi voi database luu trong file webconfig
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PTPMQLDB"].ConnectionString);
            SqlBulkCopy bulkcopy = new SqlBulkCopy(con);
            bulkcopy.DestinationTableName = "Danhmuchangs";
            bulkcopy.ColumnMappings.Add(0, "Mathang");
            bulkcopy.ColumnMappings.Add(1, "Tenhang");
           
            con.Open();
            bulkcopy.WriteToServer(dt);
            con.Close();
        }

        //upload file excel
        [HttpPost]
        public ActionResult Uploadfileexcel(HttpPostedFileBase file)
        {
            try
            {
                //upload file thanh cong va file co du lieu
                if (file.ContentLength > 0)
                {
                    ViewBag.ThongBao = "Upload file than cong";
                 
               }
            }
            catch (Exception ex)
            {
                //neu upload file that bai
                ViewBag.ThongBao = "Upload file that bai";
            }
            return View("Index");
        }
    }
}
