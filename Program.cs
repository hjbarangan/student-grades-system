using System;

class Student {
    private string name;
    private double scienceGrade;
    private double mathGrade;
    private double englishGrade;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public double ScienceGrade {
        get { return scienceGrade; }
        set { scienceGrade = value; }
    }

    public double MathGrade {
        get { return mathGrade; }
        set { mathGrade = value; }
    }

    public double EnglishGrade {
        get { return englishGrade; }
        set { englishGrade = value; }
    }

    public double CalculateAverage() {
        return (scienceGrade + mathGrade + englishGrade) / 3;
    }
}

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter total number of students:");
        int totalStudents = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[totalStudents];
        int studentCount = 0;
        Console.WriteLine("\nWELCOME TO THE STUDENTS GRADES SYSTEM:");
        int choice;
        do {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("[1] Enroll Students");
            Console.WriteLine("[2] Enter Student Grades");
            Console.WriteLine("[3] Show Student Grades");
            Console.WriteLine("[4] Show Top Student");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    if (studentCount < totalStudents) {
                        EnrollStudent(students, studentCount);
                        studentCount++;
                    } else {
                        Console.WriteLine("Maximum number of students enrolled.");
                    }
                    break;
                case 2:
                    EnterStudentGrades(students, studentCount);
                    break;
                case 3:
                    ShowStudentGrades(students, studentCount);
                    break;
                case 4:
                    ShowTopStudent(students, studentCount);
                    break;
                case 5:
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }

    static void EnrollStudent(Student[] students, int index) {
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();
        students[index] = new Student();
        students[index].Name = name;
        Console.WriteLine("Student enrolled successfully.");
    }

    static void EnterStudentGrades(Student[] students, int count) {
        if (count == 0) {
            Console.WriteLine("No students enrolled yet.");
            return;
        }

        for (int i = 0; i < count; i++) {
            Console.WriteLine($"Enter grades for {students[i].Name}:");
            Console.Write("Science Grade: ");
            students[i].ScienceGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Math Grade: ");
            students[i].MathGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("English Grade: ");
            students[i].EnglishGrade = Convert.ToDouble(Console.ReadLine());
        }
    }

    static void ShowStudentGrades(Student[] students, int count) {
        if (count == 0) {
            Console.WriteLine("No students enrolled yet.");
            return;
        }

        Console.WriteLine("Student Grades:");
        for (int i = 0; i < count; i++) {
            Console.WriteLine($"Name: {students[i].Name}, Science: {students[i].ScienceGrade}, Math: {students[i].MathGrade}, English: {students[i].EnglishGrade}, Average: {students[i].CalculateAverage()}");
        }
    }

    static void ShowTopStudent(Student[] students, int count) {
        if (count == 0) {
            Console.WriteLine("No students enrolled yet.");
            return;
        }

        double maxAverage = double.MinValue;
        int topStudentIndex = -1;

        for (int i = 0; i < count; i++) {
            double avg = students[i].CalculateAverage();
            if (avg > maxAverage) {
                maxAverage = avg;
                topStudentIndex = i;
            }
        }

        Console.WriteLine($"Top Performing Student:");
        Console.WriteLine($"Name: {students[topStudentIndex].Name}, Average: {students[topStudentIndex].CalculateAverage()}");
    }
}
