using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class ChapterDS
    {
        private Context _context;

        public ChapterDS(Context context){
            _context = context;
        }

        public List<Chapter> Get(){
            return _context.Chapters.ToList();
        }

        public Chapter? Get(long Id){
            return _context.Chapters.Find(Id);
        }

        public Chapter? Insert(Chapter chapter){
            _context.Chapters.Add(chapter);
            _context.SaveChanges();
            return chapter;
        }
        public Chapter? Update(Chapter chapter){
            var chapterDbo = _context.Chapters.Find(chapter.Id);

            if(chapterDbo == null) return null;

            chapterDbo.Name = chapter.Name;
            chapterDbo.IdCourse = chapter.IdCourse;
            
            _context.SaveChanges();
            return chapterDbo;
        }
        public bool Delete(long Id){
            var chapterDbo = _context.Chapters.Find(Id);
            if(chapterDbo == null) return false;

            _context.Chapters.Remove(chapterDbo);
            _context.SaveChanges();
            return true;
        }
    }
}