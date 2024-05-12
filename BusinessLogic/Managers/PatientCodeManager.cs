
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPB.BusinessLogic.Models;

namespace UPB.BusinessLogic.Managers
{
    public class PatientCodeManager
    {
        List<PatientCode> codigos;
        public PatientCodeManager()
        {
            codigos = new List<PatientCode>();
        }

        public List<PatientCode> GetCodigos()
        {
            return codigos;
        }
        public string GetById(int id)
        {
            PatientCode cod = codigos.Find(x => x.CI == id);
            return GenerarCodigo(cod);
        }
        public string CreateCode(string nombre, string apellido, int ci)
        {
            PatientCode code = new PatientCode(nombre, apellido, ci);
            codigos.Add(code);
            
            return GenerarCodigo(code);
        }
        public void UpdateCode(string nombre, string apellido, int ci)
        {
            PatientCode codigo = codigos.Find(x => x.CI == ci);
            codigo.Name = nombre;
            codigo.LastName = apellido;
        }
        public void DeleteCode(int ci)
        {
            PatientCode codigo = codigos.Find(x => x.CI == ci);
            codigos.Remove(codigo);
        }

        private string GenerarCodigo(PatientCode patientCode)
        {
            char inicialNom;
            char inicialApe;
            string ci;
            string codigo;

            inicialNom = patientCode.Name[0];
            inicialApe = patientCode.LastName[0];
            ci = $"{patientCode.CI}";
            codigo = $"{inicialNom}{inicialApe}-{ci}";

            return codigo;
        }


    }
}
