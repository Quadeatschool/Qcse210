
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

        foreach (var skill in _skillTree.GetAllSkills())
        {
            var button = new SkillButton(skill, _progress);
            flowPanel.Controls.Add(button);
        }

            this.Controls.Add(flowPanel); // the oject is attatched to the main form
    }


}