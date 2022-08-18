using System;
using System.Collections.Generic;

namespace DevFreela.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; private set; }

        public List<UserSkillInputModel> Skills { get; set; }
        public List<NewProjectInputModel> OwnedProjects { get; set; }
        public List<NewProjectInputModel> FreelanceProjects { get; set; }
    }

    public class UserSkillInputModel
    {
        public UserSkillInputModel(int idUser, int idSkill)
        {
            IdUser = idUser;
            IdSkill = idSkill;
        }

        public int IdUser { get; set; }
        public int IdSkill { get; set; }
    }
}
