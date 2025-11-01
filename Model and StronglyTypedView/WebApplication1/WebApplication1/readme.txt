//This is a simple ASP.NET Core MVC application demonstrating how to pass multiple models to a view using a ViewModel.

public class DashboardViewModel
{
    public Student StudentInfo { get; set; }
    public Teacher TeacherInfo { get; set; }
}


// controlller me :
public IActionResult Dashboard()
{
    var student = new Student { Id = 1, Name = "Ammar" };
    var teacher = new Teacher { Id = 10, Name = "Ali" };

    var model = new DashboardViewModel
    {
        StudentInfo = student,
        TeacherInfo = teacher
    };

    return View(model);
}

// view me :
@model DashboardViewModel

<h2>Dashboard</h2>
<h3>Student: @Model.StudentInfo.Name</h3>
<h3>Teacher: @Model.TeacherInfo.Name</h3>

