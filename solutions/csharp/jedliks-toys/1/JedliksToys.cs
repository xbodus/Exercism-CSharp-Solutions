class RemoteControlCar
{
    private int _carBattery = 100; // Drains 1% every 20m
    private int _metersDriven; // Initializes with default 0
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _carBattery == 0 ? "Battery empty" : $"Battery at {_carBattery}%";
    }

    public void Drive()
    {
        if (_carBattery > 0)
        {   
            _metersDriven += 20;
            _carBattery--;
        }
    }
}
