abstract public class SkillBase
{
    private string _name;
    private string _description;
    private bool _isUnlocked;
    private List<SkillBase> _prerequisites = new List<SkillBase>();

    //---------------------getters
    public bool GetIsUnlocked() => _isUnlocked;
    public List<SkillBase> GetPrerequisites() => _prerequisites;

    public SkillBase(string name, string description, bool isUnlocked, List<SkillBase> prerequisites)
    {
        _name = name;
        _description = description;
        _isUnlocked = isUnlocked;
        _prerequisites = prerequisites;
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