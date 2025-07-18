using System.Collections.Generic;

public static class SkillFactory
{

    public static SkillTree CreateDefaultTree()
    {

        var rootSkills = CreateRootSkills();
        var midSkills = CreateMidLevelSkills(rootSkills);
        var advancedSkills = CreateAdvancedSkills(midSkills);
        var expertSkills = CreateExpertSkills(advancedSkills);
 

        var allSkills = new List<SkillBase>();
        allSkills.AddRange(rootSkills);
        allSkills.AddRange(midSkills);
        allSkills.AddRange(advancedSkills);
        allSkills.AddRange(expertSkills);


        return new SkillTree(allSkills);
    }

    private static List<SkillBase> CreateRootSkills()
    {
        var variables = new Skill("Variables", "Learn variables", false, new List<SkillBase>());
        var inputOutput = new Skill("Input/Output", "Learn basic input output", false, new List<SkillBase>());
        return new List<SkillBase> { variables, inputOutput };
    }


    private static List<SkillBase> CreateMidLevelSkills(List<SkillBase> rootSkills)
    {
        var variables = rootSkills.Find(skill => skill.GetName() == "Variables");
        var inputOutput = rootSkills.Find(skill => skill.GetName() == "Input/Output");

        var loops = new Skill("Loops", "LeftRightAlignment for/while loops", false, new List<SkillBase> { variables, inputOutput });
        var conditionals = new Skill("Conditionals", "Learn if/else branching", false, new List<SkillBase> { variables, inputOutput });

        return new List<SkillBase> { loops, conditionals };
    }

    private static List<SkillBase> CreateAdvancedSkills(List<SkillBase> midSkills)
    {
        var loops = midSkills.Find(skill => skill.GetName() == "Loops");
        var conditionals = midSkills.Find(skill => skill.GetName() == "Conditionals");

        var methods = new Skill("Methods", "Create reusable methods", false, new List<SkillBase> { loops, conditionals });
        return new List<SkillBase> { methods };
    }

    private static List<SkillBase> CreateExpertSkills(List<SkillBase> advancedSkills)
    {
        var methods = advancedSkills.Find(skill => skill.GetName() == "Methods");

        var oop = new Skill("OOP", "Object-Oriented Programming", false, new List<SkillBase> { methods });
        var algorithms = new Skill("Algorithms", "Learn basic algorithms", false, new List<SkillBase> { methods });

        return new List<SkillBase> { oop, algorithms };
    }
    

}
