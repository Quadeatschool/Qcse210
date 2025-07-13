public class SkillTree
{
    private List<SkillBase> allSkills = new List<SkillBase>();

    public void AddSkill(SkillBase skill)
    {
        allSkills.Add(skill);
    }

    public SkillBase GetSkill(string name, SkillBase skill)
    {
        // Example implementation
        // return allSkills.FirstOrDefault(s => s.Name == name);
        return skill;
    }
}