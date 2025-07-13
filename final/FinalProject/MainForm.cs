class MainForm 
{
    private SkillTree _tree;
    private PlayerProgress _progress;
    private Dictionary<SkillBase, SkillButton> _buttonMap;

    public MainForm(SkillTree tree, PlayerProgress progress, Dictionary<SkillBase, SkillButton> buttonMap)
    {
        _tree = tree;
        _progress = progress;
        _buttonMap = buttonMap;
    }
}