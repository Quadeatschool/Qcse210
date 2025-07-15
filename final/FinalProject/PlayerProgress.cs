public class PlayerProgress 
{
    private HashSet<SkillBase> unlocked; 

   public PlayerProgress() 
   {}

    public bool CanUnlock(SkillBase skill)
    {
        return true;
    }

    public bool UnlockSkill(SkillBase skill)
    {           
        //can unlock otherwise false
        if (skill.CanUnlock(this))
        {
            skill.Unlock();
            return true;
        }
        return false;
    }

    public bool IsUnlocked(SkillBase skill)
    {
        return true;
    }


}