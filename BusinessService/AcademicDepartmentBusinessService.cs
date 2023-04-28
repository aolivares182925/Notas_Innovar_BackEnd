using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class AcademicDepartmentBusinessService
    {
        private AcademicDepartmentDataService _acDeDataService;
        public AcademicDepartmentBusinessService(AcademicDepartmentDataService acDeDataService){
            _acDeDataService = acDeDataService;
        }
        public List<AcademicDepartment> Get(){
            var acDeList = _acDeDataService.Get();
            return acDeList;
        }

        public AcademicDepartment? Get(long id){
            var beer = _acDeDataService.Get(id);
            return beer;
        }

        public AcademicDepartment? Insert(AcademicDepartment acDe){
            var acDeInserted = _acDeDataService.Insert(acDe);
            return acDeInserted;
        }

        public AcademicDepartment? Update(AcademicDepartment acDe){
            return _acDeDataService.Update(acDe);
        }

        public bool Delete(long id){
            return _acDeDataService.Delete(id);
        }

        public List<AcademicDepartment> GetADByName(string name){
            return _acDeDataService.GetADByName(name);
        }

        public List<AcademicDepartment> GetADWhitProfSchools(){
            return _acDeDataService.GetADWhitProfSchools();
        }

        public List<string> GetAcDeNames(){
            //Get all bers
            var acDeList = _acDeDataService.Get();

            //Get beer names
            //Whit foreach
            List<string> acDeNames = new List<string>();
            foreach(var acDe in acDeList){
                acDeNames.Add(acDe.Name);
            }        

            return acDeNames;
        }

        public List<string> GetAcDeNamesUpperCase(){
            var AcDeNames = GetAcDeNames();
            List<string> AcDeNamesUpper = new List<string>();
            foreach(var beerName in AcDeNames){
                AcDeNamesUpper.Add(beerName.ToUpper());
            }
            return AcDeNamesUpper;
        }

    }
}