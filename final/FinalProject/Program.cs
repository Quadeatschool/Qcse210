using System;
using System.Windows.Forms;

internal static class Program
{

    // static void TestByRef(int x, ref string name)
    // {
    //     x++;
    //     name += "+ betty";
    //      Console.WriteLine($"In Main: {x}, {name}");



    //     }

    // int x = 10;
    // string name = "bob ";

    // TestByRef(x, ref name);

    // Console.WriteLine($"In Main: {x}, {name}");



    static void Main(string[] args)
    {
        Console.WriteLine("This is the final project.");

        //endows a nice a good looking UI style
        Application.EnableVisualStyles();

        // Default text rendering a WinForms Standard
        Application.SetCompatibleTextRenderingDefault(false);

        //launch it
        Application.Run(new MainForm());

        // var variables = new Skill("Variables", "intro to variables", false, new List<SkillBase>());
        // var progress = new PlayerProgress();

        // Console.WriteLine($"Before unlocking: {variables.GetIsUnlocked()}");
        // progress.UnlockSkill(variables);
        // Console.WriteLine($"After unlocking: {variables.GetIsUnlocked()}");

        // //explore fields and elements {}


        // var loops = new Skill("Loops", "learn loops", false, new List<SkillBase> { variables });
        // var skillList = new List<SkillBase> { variables, loops };
        // var tree = new SkillTree(skillList);

        // var foundSkill = tree.GetSkill("Loops");
        // Console.WriteLine($"Found skill: {foundSkill.GetName()}");


        // var skillTree = SkillFactory.CreateDefaultTree();
        // Console.WriteLine($"Total skill: {skillTree.GetAllSkills().Count}");

        // //get skills grom Skilltree
        // var variableSkill = skillTree.GetSkill("Variables");
        // var loopsSkill = skillTree.GetSkill("Loops");

        // Console.WriteLine($"Variables unlocked? {progress.isUnlocked(variableSkill)}");
        // Console.WriteLine($"Loops skill unlocked? {progress.isUnlocked(loopsSkill)}");

        // progress.UnlockSkill(variableSkill);

        // Console.WriteLine($"Variables unlocked? {progress.isUnlocked(variableSkill)}");
        // Console.WriteLine($"Loops can now unlock? {loops.CanUnlock(progress)}");
        

    }
}