class Contract
{
    private string name;
    private int days;
    private int kilo;

    public Contract(string name, int days, int kilo)
    {
        this.name = name;
        this.days = days;
        this.kilo = kilo;
    }

    public int getDays()
    {
        return days;
    }

    public int getKilo()
    {
        return kilo;
    }

    public string getName()
    {
        return name;
    }
}

class Vehicle
{
    protected string id;
    protected Contract contract;

    public Vehicle(string name, int days, int kilo, string id)
    {
        this.contract = new Contract(name, days, kilo);
        this.id = id;
    }

    public virtual double Payment()
    {
        return 60 * contract.getDays() + contract.getKilo() * 2;
    }
}

class Car : Vehicle
{
    private int seats;

    public Car(string name, int days, int kilo, string id, int seats) : base(name, days, kilo, id)
    {
        this.seats = seats;
    }
}

class Truck : Vehicle
{
    private int max;

    public Truck(string name, int days, int kilo, string id, int max) : base(name, days, kilo, id)
    {
        this.max = max;
    }

    public override double Payment()
    {
        return base.Payment() + 500;
    }
}

class Motorcycle : Vehicle
{
    private bool offRoad;

    public Motorcycle(string name, int days, int kilo, string id, bool offRoad) : base(name, days, kilo, id)
    {
        this.offRoad = offRoad;
    }

    public override double Payment()
    {
        return base.Payment() / 2.0; 
    }
}
