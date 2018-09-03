using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class System : ISystem
    {
        public void AddSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            logic.Add(pocos);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            logic.Add(pocos);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            return logic.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
             EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            return logic.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string id)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            return logic.Get(id);
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string id)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            return logic.Get(id);
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            EFGenericRepository<SystemCountryCodePoco> repo = new EFGenericRepository<SystemCountryCodePoco>(false);
            SystemCountryCodeLogic logic = new SystemCountryCodeLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            EFGenericRepository<SystemLanguageCodePoco> repo = new EFGenericRepository<SystemLanguageCodePoco>(false);
            SystemLanguageCodeLogic logic = new SystemLanguageCodeLogic(repo);
            logic.Update(pocos);
        }
    }
}
