public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationMinutes / distance;
    }
}