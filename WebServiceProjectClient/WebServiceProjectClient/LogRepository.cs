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
            List<IzingaService.Log> returnList = new List<IzingaService.Log>();
            if ((filterValue1.Length != 0 && filterValue1 != null) || (filterValue2.Length != 0 && filterValue2 != null))
            {
                List<IzingaService.Log> listToSearch = Search(filterType1, filterValue1, _logRepository);
                returnList = Search(filterType2, filterValue2, listToSearch);
            }
            else
            {
                returnList = _logRepository;
            }
            return returnList;
        }

        public List<IzingaService.Log> Search(string filterType, string filterValue, List<IzingaService.Log> listToSearch)
        {
            List<IzingaService.Log> returnList = new List<IzingaService.Log>();
            switch (filterType)
            {
                case "Tid":
                    foreach(IzingaService.Log log in listToSearch)
                    {
                        if (log.TidValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                case "ID":
                    foreach (IzingaService.Log log in listToSearch)
                    {
                        if (log.IDValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                case "Alarm":
                    foreach (IzingaService.Log log in listToSearch)
                    {
                        if (log.AlarmValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                case "Navn":
                    foreach (IzingaService.Log log in listToSearch)
                    {
                        if (log.NavnValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                case "Afdeling":
                    foreach (IzingaService.Log log in listToSearch)
                    {
                        if (log.AfdelingValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                case "Bolig":
                    foreach (IzingaService.Log log in listToSearch)
                    {
                        if (log.BoligValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                case "Afmeldt":
                    foreach (IzingaService.Log log in listToSearch)
                    {
                        if (log.AfmeldtValue.ToString().Equals(filterValue))
                        {
                            returnList.Add(log);
                        }
                    }
                    break;
                default:
                    returnList = _logRepository;
                    break;
            }
            return returnList;
        }
    }
}
