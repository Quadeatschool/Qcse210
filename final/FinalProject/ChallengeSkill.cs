public class ChallengeSkill : SkillBase
{
    public ChallengeSkill(string name, string description) : base(name, description)
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