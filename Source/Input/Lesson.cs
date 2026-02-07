namespace IO5Plan.Input;

public class Lesson
{
    public string Subject { get; set; }
    public string ClassGroup { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string Room { get; set; }

    public Lesson(string subject, string classGroup, DayOfWeek dayOfWeek, TimeSpan startTime, TimeSpan endTime, string room = "")
    {
        Subject = subject;
        ClassGroup = classGroup;
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
        Room = room;
    }

    public override string ToString()
    {
        return $"{Subject} - {ClassGroup} ({DayOfWeek} {StartTime:hh\\:mm}-{EndTime:hh\\:mm})";
    }
}