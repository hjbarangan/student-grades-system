Real-World Programming Problem: Student Grades System

create a C# program for managing student grades using encapsulation, methods, and arrays.

Prompt the user to enter total number of students.
The system will display menu
    [1] Enroll Students
    [2] Enter Student Grades
    [3] Show Student Grades
    [4] Show Top Student
    [5] Exit

Allow the user to enter his/her choice[1-5]
Allow the user to enroll students with the validation that is must not exceed the total number of students
Allow the user to choose if he/she want to "Enter Again" another student [Y/N], if Y, use will enroll another student else N, go back to menu.
Allow the user t0 enter students grades for the following subject: Science, Math, English
Allow the user to choose if he/she want to "Enter Again" another student grades [Y/N], if Y, use will enroll another student grades else N, go back to menu.
Display the student report showing names, grades in each subject and average
Display the top-performing student.
allow the user to exit[5]

Sample Output:
--------------------------------------

Enter total students: 3

Welcome to the Student Grades System!
[1]Enroll Students
[2]Enter Student Grades
[3]Show Student Grades
[4]Show Top Student
[5]Exit
Enter Choice: 1

Enroll Student
Enter student name: John Cena
Enter Again[Y/N]: Y

Enter student name: John Travolta
Enter Again[Y/N]: Y

Enter student name: Johnny  Depp
Enter Again[Y/N]: Y

Error: Cannot exceed total number of students

Welcome to the Student Grades System!
[1]Enroll Students
[2]Enter Student Grades
[3]Show Student Grades
[4]Show Top Student
[5]Exit
Enter Choice: 2

Enter Student Grades

Student: John Cena
Enter grade for Science: 85
Enter grade for Math: 85
Enter grade for English: 85
Enter Again[Y/N]: N

Welcome to the Student Grades System!
[1]Enroll Students
[2]Enter Student Grades
[3]Show Student Grades
[4]Show Top Student
[5]Exit
Enter Choice: 3

Student Grades
Name            Science        Math    English        Ave.
John Cena        85            85        85            0
John Travolta    0            0        0            0
Johnny  Depp    0            0        0            0

Welcome to the Student Grades System!
[1]Enroll Students
[2]Enter Student Grades
[3]Show Student Grades
[4]Show Top Student
[5]Exit
Enter Choice: 4

Top Student: John Cena

Welcome to the Student Grades System!
[1]Enroll Students
[2]Enter Student Grades
[3]Show Student Grades
[4]Show Top Student
[5]Exit
Enter Choice: 5

Bye!

