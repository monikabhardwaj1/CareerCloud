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
    public class Applicant : IApplicant
    {
        public void AddApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic logic = new ApplicantEducationLogic(repo);
            logic.Add(pocos);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic logic = new ApplicantJobApplicationLogic(repo);
            logic.Add(pocos);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic logic = new ApplicantProfileLogic(repo);
            logic.Add(pocos);
        }

        public void AddApplicantResume(ApplicantResumePoco[] pocos)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic logic = new ApplicantResumeLogic(repo);
            logic.Add(pocos);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic logic = new ApplicantSkillLogic(repo);
            logic.Add(pocos);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic logic = new ApplicantWorkHistoryLogic(repo);
            logic.Add(pocos);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic logic = new ApplicantEducationLogic(repo);
            return logic.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic logic = new ApplicantJobApplicationLogic(repo);
            return logic.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic logic = new ApplicantProfileLogic(repo);
           return  logic.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic logic = new ApplicantResumeLogic(repo);
            return  logic.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic logic = new ApplicantSkillLogic(repo);
            return logic.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic logic = new ApplicantWorkHistoryLogic(repo);
            return logic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string id)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic logic = new ApplicantEducationLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string id)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic logic = new ApplicantJobApplicationLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string id)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic logic = new ApplicantProfileLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public ApplicantResumePoco GetSingleApplicantResume(string id)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic logic = new ApplicantResumeLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string id)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic logic = new ApplicantSkillLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string id)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic logic = new ApplicantWorkHistoryLogic(repo);
            return logic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic logic = new ApplicantEducationLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic logic = new ApplicantJobApplicationLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic logic = new ApplicantProfileLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] pocos)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic logic = new ApplicantResumeLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic logic = new ApplicantSkillLogic(repo);
            logic.Delete(pocos);
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic logic = new ApplicantWorkHistoryLogic(repo);
            logic.Delete(pocos);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            EFGenericRepository<ApplicantEducationPoco> repo = new EFGenericRepository<ApplicantEducationPoco>(false);
            ApplicantEducationLogic logic = new ApplicantEducationLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            EFGenericRepository<ApplicantJobApplicationPoco> repo = new EFGenericRepository<ApplicantJobApplicationPoco>(false);
            ApplicantJobApplicationLogic logic = new ApplicantJobApplicationLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            EFGenericRepository<ApplicantProfilePoco> repo = new EFGenericRepository<ApplicantProfilePoco>(false);
            ApplicantProfileLogic logic = new ApplicantProfileLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] pocos)
        {
            EFGenericRepository<ApplicantResumePoco> repo = new EFGenericRepository<ApplicantResumePoco>(false);
            ApplicantResumeLogic logic = new ApplicantResumeLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            EFGenericRepository<ApplicantSkillPoco> repo = new EFGenericRepository<ApplicantSkillPoco>(false);
            ApplicantSkillLogic logic = new ApplicantSkillLogic(repo);
            logic.Update(pocos);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            EFGenericRepository<ApplicantWorkHistoryPoco> repo = new EFGenericRepository<ApplicantWorkHistoryPoco>(false);
            ApplicantWorkHistoryLogic logic = new ApplicantWorkHistoryLogic(repo);
            logic.Update(pocos);
        }
    }
}
