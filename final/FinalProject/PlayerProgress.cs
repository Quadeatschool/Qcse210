public class PlayerProgress 
{
    private HashSet<SkillBase> unlocked; 

   public PlayerProgress() 
   {}

    public bool CanUnlock(SkillBase skill)
    {
        return true;
    }

    public void UnlockSkill(SkillBase skill)
    {}

    public bool IsUnlocked(SkillBase skill)
    {
        return true;
    }


}