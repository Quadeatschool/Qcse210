public class PlayerProgress 
{
    private HashSet<SkillBase> _unlockedSkills = new(); 

   public PlayerProgress() 
   {}

    public bool IsUnlocked(SkillBase skill) => _unlockedSkills.Contains(skill);

    public bool UnlockSkill(SkillBase skill) 
    {           
        //can unlock otherwise false
        if (skill.CanUnlock(this))
        {
            skill.Unlock();
            _unlockedSkills.Add(skill);
            return true;
        }
        return false;
    }



 


}