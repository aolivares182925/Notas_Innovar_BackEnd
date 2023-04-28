using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChapterController: ControllerBase
    {
        private Context _context;
        public ChapterController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<Chapter> Get(){
            return _context.Chapters.Include(Ch => Ch.Exams).ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public Chapter? Get(long id){
            var chapter = _context.Chapters.Find(id);
            return chapter;
        }

        //Insert Beer
        [HttpPost]
        public Chapter Insert(Chapter chapter){
            _context.Chapters.Add(chapter);
            _context.SaveChanges();
            return chapter;
        }

        //Update beer
        [HttpPut]
        public Chapter? Update(Chapter chapter){
            var chapterDbo = _context.Chapters.Find(chapter.Id);

            if(chapterDbo == null) return null;

            chapterDbo.Name = chapter.Name;

            _context.SaveChanges();
            return chapterDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var chapterDbo = _context.Chapters.Find(id);
            if(chapterDbo==null) return false;

            _context.Chapters.Remove(chapterDbo);
            _context.SaveChanges();
            return true;
        }
 
    }
}