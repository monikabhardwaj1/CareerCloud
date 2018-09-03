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
    public class Security : ISecurity
    {
        public void AddSecurityLogin(SecurityLoginPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic logic = new SecurityLoginLogic(repo);
            logic.Add(pocos);
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic logic = new SecurityLoginsLogLogic(repo);
            logic.Add(pocos);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic logic = new SecurityLoginsRoleLogic(repo);
            logic.Add(pocos);
        }

        public void AddSecurityRole(SecurityRolePoco[] pocos)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic logic = new SecurityRoleLogic(repo);
            logic.Add(pocos);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic logic = new SecurityLoginLogic(repo);
            return logic.GetAll();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic logic = new SecurityLoginsLogLogic(repo);
            return logic.GetAll();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic logic = new SecurityLoginsRoleLogic(repo);
            return logic.GetAll();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic logic = new SecurityRoleLogic(repo);
            return logic.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string id)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic logic = new SecurityLoginLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic logic = new SecurityLoginsLogLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic logic = new SecurityLoginsRoleLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public SecurityRolePoco GetSingleSecurityRole(string id)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic logic = new SecurityRoleLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic logic = new SecurityLoginLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic logic = new SecurityLoginsLogLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic logic = new SecurityLoginsRoleLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] pocos)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic logic = new SecurityRoleLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginPoco> repo = new EFGenericRepository<SecurityLoginPoco>(false);
            SecurityLoginLogic logic = new SecurityLoginLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsLogPoco> repo = new EFGenericRepository<SecurityLoginsLogPoco>(false);
            SecurityLoginsLogLogic logic = new SecurityLoginsLogLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            EFGenericRepository<SecurityLoginsRolePoco> repo = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            SecurityLoginsRoleLogic logic = new SecurityLoginsRoleLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] pocos)
        {
            EFGenericRepository<SecurityRolePoco> repo = new EFGenericRepository<SecurityRolePoco>(false);
            SecurityRoleLogic logic = new SecurityRoleLogic(repo);
            logic.Update(pocos);
        }
    }
}
