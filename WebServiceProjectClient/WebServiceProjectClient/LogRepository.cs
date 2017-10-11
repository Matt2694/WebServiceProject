using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProjectClient
{
    class LogRepository
    {
        List<IzingaService.Log> _logRepository = new List<IzingaService.Log>();
        private static LogRepository _instance = new LogRepository();
        public static LogRepository Instance { get { return _instance; } }

        public void Add(IzingaService.Log newLog)
        {
            _logRepository.Add(newLog);
        }

        public List<IzingaService.Log> Get()
        {
            return _logRepository;
        }

        public List<IzingaService.Log> Get(string filterType1, string filterValue1, string filterType2, string filterValue2)
        {
            if (filterValue1.Length != 0 && filterValue1 != null)
            {

            }
        }

        public List<IzingaService.Log> Search(string filterType1, string filterValue1, List<IzingaService.Log> listToSearch)
        {
            switch (filterType1)
            {
                case "Tid": break;
                case "ID": break;
                case "Alarm": break;
                case "Navn": break;
                case "Afdeling": break;
                case "Bolig": break;
                case "Afmeldt": break;
                case "Personale": break;
            }
        }
    }
}
