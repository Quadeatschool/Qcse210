
using System.Windows.Forms;  // Gives access to Button, Form, etc.
using System.Drawing;        // Gives access to Color, Font, etc.

public class SkillButton : Button
{
    private SkillBase _skill;

    public SkillButton(SkillBase skill)
    {
        _skill = skill;
    }

    public void UpdateState(PlayerProgress progress)
    {

    }
}

