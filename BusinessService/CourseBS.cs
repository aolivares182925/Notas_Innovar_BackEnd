using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class CourseBS
    {
        private CourseDS _courseDS;
        public CourseBS(CourseDS courseDS){
            _courseDS = courseDS;
        }
        public List<Course> Get(){
            var alternativeList = _courseDS.Get();
            return alternativeList;
        }

        public Course? Get(long id){
            var alternative = _courseDS.Get(id);
            return alternative;
        }

        public Course? Insert(Course acDe){
            var acDeInserted = _courseDS.Insert(acDe);
            return acDeInserted;
        }

        public Course? Update(Course acDe){
            return _courseDS.Update(acDe);
        }

        public bool Delete(long id){
            return _courseDS.Delete(id);
        }

    }
}