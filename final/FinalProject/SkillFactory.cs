using System.Dynamic;

public class SkillFactory
{

    public SkillFactory()
    {}

    public static SkillTree CreateDefaultTree()
    {
        var variables = new Skill("Variables", "Intro to variables", false, new List<SkillBase>());
        var loops = new Skill("Loops", "Learn loops", false, new List<SkillBase> { variables });
        var allSkills = new List<SkillBase> { variables, loops };
        return new SkillTree(allSkills);
    }

}
