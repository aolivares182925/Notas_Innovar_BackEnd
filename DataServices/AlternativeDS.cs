using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class AlternativeDS
    {
        private Context _context;

        public AlternativeDS(Context context){
            _context = context;
        }

        public List<Alternative> Get(){
            return _context.Alternatives.ToList();
        }

        public Alternative? Get(long Id){
            return _context.Alternatives.Find(Id);
        }

        public Alternative? Insert(Alternative alternative){
            _context.Alternatives.Add(alternative);
            _context.SaveChanges();
            return alternative;
        }
        public Alternative? Update(Alternative alternative){
            var alternativeDbo = _context.Alternatives.Find(alternative.Id);

            if(alternativeDbo == null) return null;

            alternativeDbo.Alternative1 = alternative.Alternative1;
            alternativeDbo.Alternative2 = alternative.Alternative2;
            alternativeDbo.Alternative3 = alternative.Alternative3;
            alternativeDbo.Alternative4 = alternative.Alternative4;
            alternativeDbo.CorrectAlternative = alternative.CorrectAlternative;


            _context.SaveChanges();
            return alternative;
        }

        
    }
}