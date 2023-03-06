using Linq.Examples.Entities;

IList<Student> studentList = new List<Student>()
{
    new Student () {StudentID= 1, Age = 19, StudentName = "David", StandardID = 1},
    new Student () {StudentID= 2,Age = 20, StudentName = "Juan", StandardID= 1},
    new Student () {StudentID= 3,Age = 21, StudentName = "María", StandardID = 2},
    new Student () {StudentID= 4,Age = 14, StudentName = "Pedro", StandardID= 2}, 
    new Student () {StudentID= 5, Age= 21,StudentName = "Carlos"}
};


IList<Standard> standardList = new List<Standard>() {
    new Standard () { StandardID = 1, StandardName = "Standard 1"},
    new Standard () {StandardID = 2, StandardName = "Standard 2"},
    new Standard () {StandardID = 3, StandardName = "Standard 3"}
};

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var test = studentList.Where(x => (x.Age >= 18 && x.StandardID > 0)).Select(x => x.StudentName);

var teenStudentsName = from s in studentList
                       where s.Age > 12 && s.Age < 20
                       select new { s.StudentName };

var studentsGroupBy = from s in studentList
                      where s.Age > 12 && s.Age < 20
                      group s by s.StandardID into sg //Nueva variable donde se asignará el resultado del gorup by
                      orderby sg.Key
                      select new
                      {
                          StandardID = sg.Key,
                          Items = sg
                      };

var studentWithStandard = from tableStudent in studentList
                          join tableStandard in standardList
                          on tableStudent.StandardID equals tableStandard.StandardID
                          select new
                          {
                              StandardName = tableStandard.StandardName,
                              StudentName = tableStudent.StudentName
                          };


foreach ( var student in studentWithStandard)
{
    Console.WriteLine("The student: " + student.StudentName + " is in: " + student.StandardName);
}

Console.ReadKey();

