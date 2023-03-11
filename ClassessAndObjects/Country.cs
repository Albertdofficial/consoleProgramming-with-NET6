
public class Country
{
    public string Name { set; get; }

    public int population { set; get; }

    public string president { set; get; }

    private double _avgSalary { set; get; }

    public void setAvgSalary(double salary)
    {
        _avgSalary = salary;

    }

    public double getAvgSalary()
    {
        return _avgSalary;
    }

    public void getCountryData()
    {
        WriteLine($"President is: {president}");
        WriteLine($"Country name is: {Name}");
        WriteLine($"Average salary is: {_avgSalary}");
    }

}

