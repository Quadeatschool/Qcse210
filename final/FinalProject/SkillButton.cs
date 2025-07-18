
using System.Windows.Forms;  // Gives access to Button, Form, etc.
using System.Drawing;
using System.CodeDom;        // Gives access to Color, Font, etc.

public class SkillButton : Button
{
    private MainForm _mainForm;
    private SkillBase _skill;
    private PlayerProgress _progress;

    public SkillButton(SkillBase skill, PlayerProgress progress, MainForm mainForm)
    {
        _skill = skill;
        _progress = progress;
        _mainForm = mainForm;
        this.Text = _skill.GetName();

        this.Width = 150;
        this.Height = 50;

        UpdateButtonColor();

        this.Click += (sender, e) =>
        {
            if (_progress.UnlockSkill(_skill))
            {
                UpdateButtonColor(); //changes the color and user progresses a skill
                _mainForm.RefreshAllSkillButtons();
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

    public void RefreshButton()
    {
        UpdateButtonColor();
    }

    public SkillBase GetSkill() 
    {
        return _skill;
    }



}

