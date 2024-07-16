using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int battery = 100;
    private int driven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => this.battery <= 0 || (this.battery - this.batteryDrain) < 0; 

    public int DistanceDriven() => this.driven;

    public void Drive()
    {
        if(!BatteryDrained())
        {
            this.driven += this.speed;
            this.battery -= this.batteryDrain;           
        }
    }
    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;        
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        //See max distance can drive;
        while (!car.BatteryDrained())
        {
            car.Drive();            
        }
        return car.DistanceDriven() >= this.distance;
    }
}