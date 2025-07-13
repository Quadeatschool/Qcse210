abstract public class SkillBase
{
    private string _name;
    private string _description;
    private bool _isUnlocked;
    private List<SkillBase> Prerequisites = new List<SkillBase>();

    public SkillBase(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Unlock()
    {
        _isUnlocked = true;
    }


    public virtual bool CanUnlock(PlayerProgress progress)
    {
        Console.WriteLine("try me");
        return false; // or your logic
    }

}