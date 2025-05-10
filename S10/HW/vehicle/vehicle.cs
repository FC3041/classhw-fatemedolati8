public interface I_vehicle
{
    public int capacity();
    public double Pollutant();
    public double area();
    public string type();
}

public class bike:I_vehicle
{
    public string m_fule;
    public bike(string fule)
    {
        m_fule=fule;
    }
    public int capacity()
    {
        return 2;
    }
    public double Pollutant()
    {
        if(m_fule=="benzin")
        {
            return 160;
        }
        if(m_fule=="gaz")
        {
            return 130;
        }
        if(m_fule=="bargh")
        {
            return 10;
        }
        return 0;
    }
    public double area()
    {
        return 1.6;
    }
    public string type()
    {
        return "bike";
    }

}
public class car:I_vehicle
{
    public string m_fule;
    public car(string fule)
    {
        m_fule=fule;
    }
    public int capacity()
    {
        return 5;
    }
    public double Pollutant()
    {
        if(m_fule=="benzin")
        {
            return 200;
        }
        if(m_fule=="gaz")
        {
            return 150;
        }
        if(m_fule=="bargh")
        {
            return 50;
        }
        return 0;
    }
    public double area()
    {
        return 8;
    }
    public string type()
    {
        return "car";
    }
}

public class bus:I_vehicle
{
    public string m_fule;
    public int m_capacity;
    public bus(string fule,int capacity)
    {
        m_fule=fule;
        m_capacity=capacity;
    }
    public int capacity()
    {
        return m_capacity;
    }
    public double Pollutant()
    {
        if(m_fule=="benzin")
        {
            return 2500;
        }
        if(m_fule=="gaz")
        {
            return 1800;
        }
        if(m_fule=="bargh")
        {
            return 500;
        }
        return 0;
    }
    public double area()
    {
        return 30;
    }
    public string type()
    {
        return "bus";
    }
}