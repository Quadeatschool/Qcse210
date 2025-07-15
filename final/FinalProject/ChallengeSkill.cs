public class ChallengeSkill : SkillBase
{
    public ChallengeSkill(string name, string description, bool isUnlocked, List<SkillBase> prerequisites) : base(name, description, isUnlocked, prerequisites)
    {
        
    }

    public override bool CanUnlock(PlayerProgress progress)
    {
        // your logic here
        return false;
    }

    private bool WasQuestionCorrect()
    {
        // your logic here
        return false;
    }
}