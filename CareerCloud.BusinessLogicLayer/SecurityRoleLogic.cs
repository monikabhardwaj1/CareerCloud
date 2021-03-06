﻿using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SecurityRoleLogic : BaseLogic<SecurityRolePoco>
    {
        public SecurityRoleLogic(IDataRepository<SecurityRolePoco> repository) : base(repository)
        {
        }

        public override void Add(SecurityRolePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(SecurityRolePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        public override void Delete(SecurityRolePoco[] pocos)
        {
            base.Delete(pocos);
        }
        public override List<SecurityRolePoco> GetAll()
        {
            return base.GetAll();
        }

        public override SecurityRolePoco Get(Guid id)
        {
            return base.Get(id);
        }
        protected override void Verify(SecurityRolePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach(SecurityRolePoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Role))
                    exceptions.Add(new ValidationException(800,$"Role Cannot be empty - {poco.Id}"));
            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);

        }
    }
}
