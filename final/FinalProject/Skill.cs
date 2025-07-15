public class Skill : SkillBase
{
    public Skill(string name, string description, bool isUnlocked, List<SkillBase> prerequisites) : base(name, description, isUnlocked, prerequisites)
    {
        
    }

    public override bool CanUnlock(PlayerProgress progress)
    {
        
        return GetPrerequisites().All(p => p.GetIsUnlocked());
    }
}