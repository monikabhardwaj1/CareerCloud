using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic (IDataRepository<CompanyProfilePoco> repository) : base(repository)
        { }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        public override void Delete(CompanyProfilePoco[] pocos)
        {
            base.Delete(pocos);
        }
        public override List<CompanyProfilePoco> GetAll()
        {
            return base.GetAll();
        }

        public override CompanyProfilePoco Get(Guid id)
        {
            return base.Get(id);
        }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach(CompanyProfilePoco poco in pocos)
            {
                if (String.IsNullOrEmpty(poco.CompanyWebsite))
                    exceptions.Add(new ValidationException (600,$"Valid websites must end with the following extensions – '.ca', '.com', '.biz' - {poco.Id}"));
                else if (!(poco.CompanyWebsite.EndsWith(".ca") || poco.CompanyWebsite.EndsWith(".com") || poco.CompanyWebsite.EndsWith(".biz")))
                    exceptions.Add(new ValidationException(600, $"Valid websites must end with the following extensions – '.ca', '.com', '.biz' - {poco.Id}"));

                //string pattern = "[0-9][0-9][0-9][-][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
                //Regex reg = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
                //if (String.IsNullOrEmpty(poco.ContactPhone))
                //    exceptions.Add(new ValidationException(601,$"Must correspond to a valid phone number (e.g. 416-555-1234) - {poco.Id}"));
                //else if (reg.Matches(poco.ContactPhone).Count > 0)
                //    exceptions.Add(new ValidationException(601, $"Must correspond to a valid phone number (e.g. 416-555-1234) - {poco.Id}"));

                if (string.IsNullOrEmpty(poco.ContactPhone))
                {
                    exceptions.Add(new ValidationException(601, $"Must correspond to a valid phone number (e.g. 416-555-1234) - {poco.Id}"));
                }
                else
                {
                    string[] phoneComponents = poco.ContactPhone.Split('-');
                    if (phoneComponents.Length < 3)
                        exceptions.Add(new ValidationException(601, $"Must correspond to a valid phone number (e.g. 416-555-1234) - {poco.Id}"));

                    else if (phoneComponents[0].Length < 3 || phoneComponents[1].Length < 3 || phoneComponents[2].Length < 3)
                        exceptions.Add(new ValidationException(601, $"Must correspond to a valid phone number (e.g. 416-555-1234) - {poco.Id}"));
                }

            }

            if (exceptions.Count > 0)
                throw new AggregateException(exceptions);
        }
    }
}
