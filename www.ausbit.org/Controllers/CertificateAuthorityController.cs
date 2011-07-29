using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.ausbit.org.Models;

namespace www.ausbit.org.Controllers
{
    public class CertificateAuthorityController : Controller
    {
        //
        // GET: /CertificateAuthority/

        public ActionResult Index(string level = "Root")
        {
            var myCerts = new Certs();
            var roots = from root in myCerts.certs
                         where root.Level == level
                         select root;

            return View(model:roots);
        }

        //
        // GET: /CertificateAuthority/Details/5

        public ActionResult Details(string id)
        {
            var myCerts = new Certs();

            var cert = (from root in myCerts.certs
                        where root.Thingerprint == id
                        select root).First();

            return View(model:cert);
        }

        public ActionResult Download(string id)
        {
            var myCerts = new Certs();

            var cert = (from root in myCerts.certs
                        where String.Format("{0}.cer",root.Thingerprint) == id
                        select root).First();


            return new FileContentResult(System.Text.Encoding.ASCII.GetBytes(cert.Data), "application/x-x509-ca-certificate");
        }

        public ActionResult RootCert()
        {
            var myCerts = new Certs();
            var root = (from aRoot in myCerts.certs
                         where aRoot.Level == "Root"
                         select aRoot).First();

            return RedirectToAction("Download", new { id = String.Format("{0}.cer", root.Thingerprint) });
        }


        //
        // GET: /CertificateAuthority/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CertificateAuthority/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CertificateAuthority/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CertificateAuthority/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CertificateAuthority/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CertificateAuthority/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
