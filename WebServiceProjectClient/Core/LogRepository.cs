using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class LogRepository
    {
        List<IRoom> _roomRepository = new List<IRoom>();
        private static RoomRepository _instance = new RoomRepository();
        public static RoomRepository Instance { get { return _instance; } }
    }
}
