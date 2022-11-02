using System.Runtime.CompilerServices;

internal class Personal
{
    private String personalName;
    private int personalSalery;

    public Personal(String personalName, int personalSalery)
    {
        this.personalName=personalName;
        this.personalSalery = personalSalery;
    }

    public Personal()
    {
        this.personalSalery = 0;
        this.personalName = "";
    }

    public void SetPersonal(String pn, int ps) 
    {
        this.personalName = pn;
        this.personalSalery = ps;
    }
    public (String, int) GetPersonal()
    {
        return (this.personalName, this.personalSalery);
    }
    public String GetPersonName() { return this.personalName; }
    public int GetSalary() { return this.personalSalery; }

}