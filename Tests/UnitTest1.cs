namespace IO5PlanTests;

using IO5Plan.Input;

public class TeachersTests
{
    private Teachers _teacher;

    [SetUp]
    public void Setup()
    {
        _teacher = new Teachers("T001", "Jan Kowalski");
    }


    [Test]
    public void AddLesson_ShouldAddLessonSuccessfully()
    {
        var lesson = new Lesson("Matematyka", "1A", DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(9, 0, 0), "101");

        var result = _teacher.AddLesson(lesson);

        Assert.That(result, Is.True);
        Assert.That(_teacher.Lessons, Has.Count.EqualTo(1));
        Assert.That(_teacher.Lessons[0], Is.EqualTo(lesson));
    }


    [Test]
    public void AddLesson_ShouldRejectConflictingLesson_OverlappingTime()
    {
        var lesson1 = new Lesson("Matematyka", "1A", DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(9, 30, 0), "101");
        var lesson2 = new Lesson("Fizyka", "1B", DayOfWeek.Monday, new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), "102");

        _teacher.AddLesson(lesson1);
        var result = _teacher.AddLesson(lesson2);

        Assert.That(result, Is.False);
        Assert.That(_teacher.Lessons, Has.Count.EqualTo(1));
    }

    [Test]
    public void AddLesson_ShouldRejectConflictingLesson_LessonInsideAnother()
    {
        var lesson1 = new Lesson("Matematyka", "1A", DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(11, 0, 0), "101");
        var lesson2 = new Lesson("Fizyka", "1B", DayOfWeek.Monday, new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), "102");

        _teacher.AddLesson(lesson1);
        var result = _teacher.AddLesson(lesson2);

        Assert.That(result, Is.False);
        Assert.That(_teacher.Lessons, Has.Count.EqualTo(1));
    }

    [Test]
    public void AddLesson_ShouldAllowLessonsOnDifferentDays()
    {
        var lesson1 = new Lesson("Matematyka", "1A", DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(9, 0, 0), "101");
        var lesson2 = new Lesson("Fizyka", "1B", DayOfWeek.Tuesday, new TimeSpan(8, 0, 0), new TimeSpan(9, 0, 0), "102");

        var result1 = _teacher.AddLesson(lesson1);
        var result2 = _teacher.AddLesson(lesson2);

        Assert.That(result1, Is.True);
        Assert.That(result2, Is.True);
        Assert.That(_teacher.Lessons, Has.Count.EqualTo(2));
    }


    [Test]
    public void GetLessonsForDay_ShouldReturnEmptyListForDayWithNoLessons()
    {
        var lessons = _teacher.GetLessonsForDay(DayOfWeek.Monday);

        Assert.That(lessons, Is.Empty);
    }

    [Test]
    public void GetLessonsForDay_ShouldReturnLessonsForSpecificDay()
    {
        var lesson1 = new Lesson("Matematyka", "1A", DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(9, 0, 0), "101");
        var lesson2 = new Lesson("Fizyka", "1B", DayOfWeek.Tuesday, new TimeSpan(8, 0, 0), new TimeSpan(9, 0, 0), "102");
        var lesson3 = new Lesson("Chemia", "2A", DayOfWeek.Monday, new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), "103");

        _teacher.AddLesson(lesson1);
        _teacher.AddLesson(lesson2);
        _teacher.AddLesson(lesson3);

        var mondayLessons = _teacher.GetLessonsForDay(DayOfWeek.Monday);

        Assert.That(mondayLessons, Has.Count.EqualTo(2));
        Assert.That(mondayLessons[0], Is.EqualTo(lesson1));
        Assert.That(mondayLessons[1], Is.EqualTo(lesson3));
    }
}
