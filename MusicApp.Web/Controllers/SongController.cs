using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicApp.BusinessLogic.DBModel;
using MusicApp.Domain.Entities.Music;

namespace MusicApp.Web.Controllers
{
    public class SongController : Controller
    {
        private readonly SongContext _context = new SongContext(); // Initialize SongContext

        public ActionResult GetImage(int id)
        {
            byte[] imageData = null;
            var image = _context.Songs.FirstOrDefault(i => i.Id == id);
            if (image != null)
            {
                imageData = image.Image; // Assume ImageData is the byte array field in your database
            }
            return imageData != null ? File(imageData, "image/jpeg") : null;
        }

        public ActionResult GetSong(int id)
        {
            byte[] songData = null;
            var song = _context.Songs.FirstOrDefault(i => i.Id == id);
            if (song != null)
            {
                songData = song.Mp3File;
            }
            return songData != null ? File(songData, "audio/mpeg") : null;
        }

        public ActionResult GetSongs()
        {
            var songs = _context.Songs.Select(s => new
            {
                Id = s.Id,
                Title = s.Title // assuming you have a Title field
            }).ToList();

            return Json(songs, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Play(int id)
        {
            var audioFile = _context.Songs.Find(id);
            if (audioFile == null)
            {
                return HttpNotFound();
            }

            // Returnează fișierul sub forma de content binar cu tipul MIME corect
            return File(audioFile.Mp3File, "audio/mpeg", audioFile.Mp3FileName);
        }

        private string ConvertBinaryToAudioFile(byte[] audioData)
        {
            // Implementează logica de conversie a datelor binare în fișier audio (.mp3)
            // Aici trebuie să utilizezi o bibliotecă sau să implementezi propriul algoritm pentru conversie

            // După ce ai convertit datele binare în fișier audio, salvează fișierul în sistemul de fișiere și returnează calea către fișier
            string filePath = "~/Vendor/audio/test.mp3"; // Exemplu de cale către fișierul audio
            return filePath;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: Song
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Player()
        {
            return View();
        }
    }
}