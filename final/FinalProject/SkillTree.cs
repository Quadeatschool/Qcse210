public class SkillTree
{
    private List<SkillBase> _allSkills = new List<SkillBase>();

    public SkillTree(List<SkillBase> allskills)
    {
        _allSkills = allskills;
    }
    public void AddSkill(SkillBase skill) => _allSkills.Add(skill);


    public SkillBase GetSkill(string name) => _allSkills.FirstOrDefault(skill => skill.GetName() == name);

    public List<SkillBase> GetAllSkills() => _allSkills;
    

}