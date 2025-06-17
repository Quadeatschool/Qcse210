class PoliceMan : Person
{

    private double _hourlyWage;

    private int _hoursWorked;
    private string _weapons;
    public PoliceMan(string firstName, string lastName, int age, string weapons, double _hourlyWage)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }

    public override string GetPersonInformation()
    {
        return $"Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }

        return pay;

    }
}

