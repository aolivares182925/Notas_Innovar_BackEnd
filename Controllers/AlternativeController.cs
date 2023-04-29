using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.BusinessService;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlternativeController:ControllerBase
    {
        private AlternativeBS _AlternativeBS;
        public AlternativeController(AlternativeBS AlternativeBS)
        {
            _AlternativeBS = AlternativeBS;
        }
        //Get todos
        [HttpGet]
        public List<Alternative> Get(){
            return _AlternativeBS.Get();
        }
        //Get by id
        [HttpGet("{id}")]
        public Alternative? Get(long id){
            return _AlternativeBS.Get(id);
        }
        //Insert Beer
        [HttpPost]
        public Alternative? Insert(Alternative acDe){
            return _AlternativeBS.Insert(acDe);
        }

        //Update beer
        [HttpPut]
        public Alternative? Update(Alternative acDe){
            return _AlternativeBS.Update(acDe);
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            return _AlternativeBS.Delete(id);
        }

    }
}