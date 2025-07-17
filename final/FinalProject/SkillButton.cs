
using System.Windows.Forms;  // Gives access to Button, Form, etc.
using System.Drawing;
using System.CodeDom;        // Gives access to Color, Font, etc.

public class SkillButton : Button
{
    private SkillBase _skill;
    private PlayerProgress _progress;

    public SkillButton(SkillBase skill, PlayerProgress progress)
    {
        _skill = skill;
        _progress = progress;
        this.Text = _skill.GetName();

        this.Width = 150;
        this.Height = 50;

        UpdateButtonColor();

        this.Click += (sender, e) =>
        {
            if (_progress.UnlockSkill(_skill))
            {
                UpdateButtonColor();
            }
        };
    }

    private void UpdateButtonColor()
    {
        if (_skill.GetIsUnlocked())
        {
            this.BackColor = Color.LightGreen;
            this.Enabled = false;
        }
        else if (_skill.CanUnlock(_progress))
        {
            this.BackColor = Color.Yellow;
            this.Enabled = true;
        }
        else
        {
            this.BackColor = Color.Gray;
            this.Enabled = false;
        }
    }

    public void UpdateState(PlayerProgress progress)
    {

    }
}

