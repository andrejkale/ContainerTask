// See https://aka.ms/new-console-template for more information
using ContainerClass;
Student andrii = StudentsMarksLog.CreateStudent("Andrii", "Ivanov", "C#", 5);
Student sergii = StudentsMarksLog.CreateStudent("Sergii", "Ivanov", "C++", 4);
Student aleksii = StudentsMarksLog.CreateStudent("Aleksii", "Petrov", "Java", 3);
Student vasiliy = StudentsMarksLog.CreateStudent("Vasiliy", "Smirnov", "JS", 2);

StudentsMarksLog.AddStudentToLog(andrii);
StudentsMarksLog.AddStudentToLog(sergii);
StudentsMarksLog.AddStudentToLog(aleksii);
StudentsMarksLog.AddStudentToLog(aleksii);
StudentsMarksLog.AddStudentToLog(vasiliy);


StudentsMarksLog.AddMark(andrii, 4);
StudentsMarksLog.AddMark(andrii, 3);
StudentsMarksLog.AddMark(andrii, 1);

StudentsMarksLog.AddMark(sergii, 1);
StudentsMarksLog.AddMark(sergii, 4);
StudentsMarksLog.AddMark(sergii, 5);

StudentsMarksLog.AddMark(aleksii, 5);
StudentsMarksLog.AddMark(aleksii, 4);
StudentsMarksLog.AddMark(aleksii, 3);

StudentsMarksLog.AddMark(vasiliy, 1);
StudentsMarksLog.AddMark(vasiliy, 1);

StudentsMarksLog.PrintStudents();

StudentsMarksLog.RemoveStudent(vasiliy);

StudentsMarksLog.PrintStudents();

