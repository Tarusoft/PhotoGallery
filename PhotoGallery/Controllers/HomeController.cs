using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoGallery.Models;

namespace PhotoGallery.Controllers
{
public class HomeController : Controller
{
    // GET: Home
    public ActionResult Index()
    {        
            var photoGalleryModel = new List<PhotoGalleryModel>();

            photoGalleryModel.Add(new PhotoGalleryModel() { ImageName = "02da51eea6e8094ad64ead7e49aba578", ImagePath = "Images\\02da51eea6e8094ad64ead7e49aba578.jpg" });
            photoGalleryModel.Add(new PhotoGalleryModel() { ImageName = "2011_singer_porsche_911_300_1920x1080", ImagePath = "Images\\2011_singer_porsche_911_300_1920x1080.jpg" });
            photoGalleryModel.Add(new PhotoGalleryModel() { ImageName = "2feae2d8-a612-4ea7-b7d7-4fe5af249b69", ImagePath = "Images\\2feae2d8-a612-4ea7-b7d7-4fe5af249b69.jpg" });
            photoGalleryModel.Add(new PhotoGalleryModel() { ImageName = "download", ImagePath = "Images\\download.jpg" });
            photoGalleryModel.Add(new PhotoGalleryModel() { ImageName = "gallery-1433525772-roa070115fea-singer09b", ImagePath = "Images\\gallery-1433525772-roa070115fea-singer09b.jpg" });
            photoGalleryModel.Add(new PhotoGalleryModel() { ImageName = "singer-porsche-911_3366036k", ImagePath = "Images\\singer-porsche-911_3366036k.jpg" });

            return View(photoGalleryModel);//Json(photoGalleryModel, JsonRequestBehavior.AllowGet);

        }
}
}