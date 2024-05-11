using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UPB.BusinessLogic.Models;
using UPB.BusinessLogic.Managers;


namespace UPB.practicaCerti1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientCodeController : ControllerBase
    {
        private PatientCodeManager patientCodeManager;
        public PatientCodeController(PatientCodeManager pcm)
        {
            patientCodeManager = pcm;
        }
        [HttpGet]
        public List<PatientCode> Get()
        {
            return patientCodeManager.GetCodigos();
        }
        [HttpGet]
        [Route("{ci}")]
        public string Get(int ci)
        {
            return patientCodeManager.GetById(ci);
        }
        [HttpPost]

        public string Post([FromBody] PatientCode patientCode)
        {

            return patientCodeManager.CreateCode(patientCode.Name, patientCode.LastName, patientCode.CI);
        }
        [HttpPut]
        [Route("{ci}")]
        public void Put(int ci, PatientCode patientCode)
        {
            patientCodeManager.UpdateCode(patientCode.Name, patientCode.LastName, ci);
        }
        [HttpDelete]
        [Route("{ci}")]
        public void Delete(int ci)
        {
            patientCodeManager.DeleteCode(ci);
        }

    }
}
