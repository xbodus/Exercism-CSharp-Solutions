class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        //Copy of last weeks count
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        // Last weeks count is last in first out. Today's value is the last value in the array
        return this.birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        // Increment the last value in the array that represents today's value
        this.birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int count in this.birdsPerDay)
        {
            if (count == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // Catch checks that exceed the number of stored values in this.birdsPerDay
        if (numberOfDays > this.birdsPerDay.Length)
        {
            numberOfDays = this.birdsPerDay.Length;
        };
        
        int total = 0;
        for (int i = numberOfDays - 1; i >= 0; i--)
        {
            total += this.birdsPerDay[i];
        };
        return total;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int count in this.birdsPerDay)
        {
            if (count >= 5)
            {
                busyDays += 1;
            };
        };
        return busyDays;
    }
}
