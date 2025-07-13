public class Skill : SkillBase
{
    public Skill(string name, string description) : base(name, description)
    {
    }

    public override bool CanUnlock(PlayerProgress progress)
    {
        // your logic here
        return false;
    }
}