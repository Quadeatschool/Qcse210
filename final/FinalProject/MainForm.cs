
using System;
using System.Windows.Forms;
public class MainForm : Form
{
    private SkillTree _skillTree;
    private PlayerProgress _progress;


    private Dictionary<SkillBase, SkillButton> _buttonMap;

    public MainForm()
    {
        // _skilltree = tree;
        // _progress = progress;
        // _buttonMap = buttonMap;

        this.Text = "programming Skill Tree";

        _skillTree = SkillFactory.CreateDefaultTree();
        _progress = new PlayerProgress();

        var flowPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill, //fill the window
            AutoScroll = true
        };

        _buttonMap = new Dictionary<SkillBase, SkillButton>();

        this.Controls.Add(flowPanel); //attatched object to the main form

        foreach (var skill in _skillTree.GetAllSkills())
        {
            var button = new SkillButton(skill, _progress, this);
            _buttonMap[skill] = button;
            flowPanel.Controls.Add(button);
        }
    }

    //refresh ui 
    public void RefreshAllSkillButtons()
    {
        foreach (var button in _buttonMap.Values)
        {
            button.RefreshButton();
        }
    }

    
}