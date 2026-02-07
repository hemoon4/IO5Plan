namespace IO5Plan.Input;

public class Teachers
{
    public string Name { get; set; }
    public string Id { get; set; }
    private List<Lesson> _lessons;

    public Teachers(string id, string name)
    {
        Id = id;
        Name = name;
        _lessons = new List<Lesson>();
    }

    public IReadOnlyList<Lesson> Lessons => _lessons.AsReadOnly();

    public bool AddLesson(Lesson lesson)
    {
        if (HasConflict(lesson))
        {
            return false;
        }

        _lessons.Add(lesson);
        return true;
    }

    public bool RemoveLesson(Lesson lesson)
    {
        return _lessons.Remove(lesson);
    }

    private bool HasConflict(Lesson newLesson)
    {
        foreach (var existingLesson in _lessons)
        {
            if (LessonsOverlap(existingLesson, newLesson))
            {
                return true;
            }
        }
        return false;
    }

    private bool LessonsOverlap(Lesson lesson1, Lesson lesson2)
    {
        if (lesson1.DayOfWeek != lesson2.DayOfWeek)
        {
            return false;
        }

        return lesson1.StartTime < lesson2.EndTime && lesson2.StartTime < lesson1.EndTime;
    }

    public List<Lesson> GetLessonsForDay(DayOfWeek day)
    {
        return _lessons.Where(l => l.DayOfWeek == day).OrderBy(l => l.StartTime).ToList();
    }
}