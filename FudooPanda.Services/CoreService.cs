using FudooPanda.Sqlite.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda.Services
{
    public class CoreService : ICoreService
    {
        public CoreService()
        {
            
        }

        void ICoreService.InitDatabase()
        {
            FudooDatabase.Init();
        }
    }
}
