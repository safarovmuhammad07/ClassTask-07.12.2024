using System;
using System.Collections.Generic;
using Infrastructure.Models;
using Infrastructure.Services;
        static void Main()
        {
            var courseService = new CourseService();
            var groupService = new GroupService();
            var mentorService = new MentorService();
            var mentorGroupsService = new MentorGroupsService();
            var studentService = new StudentService();
            var studentGroupsService = new StudentGroupsService();

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Courses");
                Console.WriteLine("2. Groups");
                Console.WriteLine("3. Mentors");
                Console.WriteLine("4. Mentor Groups");
                Console.WriteLine("5. Students");
                Console.WriteLine("6. Student Groups");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CourseMenu(courseService);
                        break;
                    case "2":
                        GroupMenu(groupService);
                        break;
                    case "3":
                        MentorMenu(mentorService);
                        break;
                    case "4":
                        MentorGroupsMenu(mentorGroupsService);
                        break;
                    case "5":
                        StudentMenu(studentService);
                        break;
                    case "6":
                        StudentGroupsMenu(studentGroupsService);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CourseMenu(CourseService courseService)
        {
            while (true)
            {
                Console.WriteLine("\nCourse Menu:");
                Console.WriteLine("1. View All Courses");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Update Course");
                Console.WriteLine("4. Delete Course");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var courses = courseService.GetCourses();
                        foreach (var course in courses)
                            Console.WriteLine($"{course.CourseId} - {course.CourseName}: {course.CourseDescription}");
                        break;
                    case "2":
                        Console.Write("Enter Course Name: ");
                        var courseName = Console.ReadLine();
                        Console.Write("Enter Course Description: ");
                        var courseDescription = Console.ReadLine();
                        var newCourse = new Courses { CourseName = courseName, CourseDescription = courseDescription };
                        Console.WriteLine(courseService.AddCourse(newCourse) ? "Course added." : "Failed to add course.");
                        break;
                    case "3":
                        Console.Write("Enter Course ID to update: ");
                        var updateCourseId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Course Name: ");
                        var newCourseName = Console.ReadLine();
                        Console.Write("Enter New Course Description: ");
                        var newCourseDescription = Console.ReadLine();
                        var updatedCourse = new Courses
                        {
                            CourseId = updateCourseId,
                            CourseName = newCourseName,
                            CourseDescription = newCourseDescription
                        };
                        Console.WriteLine(courseService.UpdateCourse(updatedCourse) ? "Course updated." : "Failed to update course.");
                        break;
                    case "4":
                        Console.Write("Enter Course ID to delete: ");
                        var deleteCourseId = Console.ReadLine();
                        Console.WriteLine(courseService.DeleteCourse(deleteCourseId) ? "Course deleted." : "Failed to delete course.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void GroupMenu(GroupService groupService)
        {
            while (true)
            {
                Console.WriteLine("\nGroup Menu:");
                Console.WriteLine("1. View All Groups");
                Console.WriteLine("2. Add Group");
                Console.WriteLine("3. Update Group");
                Console.WriteLine("4. Delete Group");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var groups = groupService.GetGroups();
                        foreach (var group in groups)
                            Console.WriteLine($"{group.GroupId} - {group.GroupName}: {group.GroupDescription}");
                        break;
                    case "2":
                        Console.Write("Enter Group Name: ");
                        var groupName = Console.ReadLine();
                        Console.Write("Enter Group Description: ");
                        var groupDescription = Console.ReadLine();
                        var newGroup = new Groups { GroupName = groupName, GroupDescription = groupDescription };
                        Console.WriteLine(groupService.AddGroup(newGroup) ? "Group added." : "Failed to add group.");
                        break;
                    case "3":
                        Console.Write("Enter Group ID to update: ");
                        var updateGroupId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Group Name: ");
                        var newGroupName = Console.ReadLine();
                        Console.Write("Enter New Group Description: ");
                        var newGroupDescription = Console.ReadLine();
                        var updatedGroup = new Groups
                        {
                            GroupId = updateGroupId,
                            GroupName = newGroupName,
                            GroupDescription = newGroupDescription
                        };
                        Console.WriteLine(groupService.UpdateGroup(updatedGroup) ? "Group updated." : "Failed to update group.");
                        break;
                    case "4":
                        Console.Write("Enter Group ID to delete: ");
                        var deleteGroupId = Console.ReadLine();
                        Console.WriteLine(groupService.DeleteGroup(deleteGroupId) ? "Group deleted." : "Failed to delete group.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void MentorMenu(MentorService mentorService)
        {
            while (true)
            {
                Console.WriteLine("\nMentor Menu:");
                Console.WriteLine("1. View All Mentors");
                Console.WriteLine("2. Add Mentor");
                Console.WriteLine("3. Update Mentor");
                Console.WriteLine("4. Delete Mentor");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var mentors = mentorService.GetMentors();
                        foreach (var mentor in mentors)
                            Console.WriteLine($"{mentor.MentorID} - {mentor.MentorName}, Age: {mentor.MentorAge}, Description: {mentor.MentorDescription}");
                        break;
                    case "2":
                        Console.Write("Enter Mentor Name: ");
                        var mentorName = Console.ReadLine();
                        Console.Write("Enter Mentor Age: ");
                        var mentorAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Mentor Description: ");
                        var mentorDescription = Console.ReadLine();
                        var newMentor = new Mentors { MentorName = mentorName, MentorAge = mentorAge, MentorDescription = mentorDescription };
                        Console.WriteLine(mentorService.AddMentor(newMentor) ? "Mentor added." : "Failed to add mentor.");
                        break;
                    case "3":
                        Console.Write("Enter Mentor ID to update: ");
                        var updateMentorId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Mentor Name: ");
                        var newMentorName = Console.ReadLine();
                        Console.Write("Enter New Mentor Age: ");
                        var newMentorAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Mentor Description: ");
                        var newMentorDescription = Console.ReadLine();
                        var updatedMentor = new Mentors
                        {
                            MentorID = updateMentorId,
                            MentorName = newMentorName,
                            MentorAge = newMentorAge,
                            MentorDescription = newMentorDescription
                        };
                        Console.WriteLine(mentorService.UpdateMentor(updatedMentor) ? "Mentor updated." : "Failed to update mentor.");
                        break;
                    case "4":
                        Console.Write("Enter Mentor ID to delete: ");
                        var deleteMentorId = Console.ReadLine();
                        Console.WriteLine(mentorService.DeleteMentor(deleteMentorId) ? "Mentor deleted." : "Failed to delete mentor.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void MentorGroupsMenu(MentorGroupsService mentorGroupsService)
        {
            while (true)
            {
                Console.WriteLine("\nMentor Groups Menu:");
                Console.WriteLine("1. View All Mentor Groups");
                Console.WriteLine("2. Add Mentor Group");
                Console.WriteLine("3. Update Mentor Group");
                Console.WriteLine("4. Delete Mentor Group");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var mentorGroups = mentorGroupsService.GetMentorGroups();
                        foreach (var group in mentorGroups)
                            Console.WriteLine($"{group.MentorGroupsID} - Mentor ID: {group.MentorID}, Group ID: {group.GroupsID}");
                        break;
                    case "2":
                        Console.Write("Enter Mentor ID: ");
                        var mentorId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Group ID: ");
                        var groupId = int.Parse(Console.ReadLine());
                        var newMentorGroup = new MentorGroups { MentorID = mentorId, GroupsID = groupId };
                        Console.WriteLine(mentorGroupsService.AddMentorGroup(newMentorGroup) ? "Mentor group added." : "Failed to add mentor group.");
                        break;
                    case "3":
                        Console.Write("Enter Mentor Group ID to update: ");
                        var updateMentorGroupId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Mentor ID: ");
                        var newMentorId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Group ID: ");
                        var newGroupId = int.Parse(Console.ReadLine());
                        var updatedMentorGroup = new MentorGroups
                        {
                            MentorGroupsID = updateMentorGroupId,
                            MentorID = newMentorId,
                            GroupsID = newGroupId
                        };
                        Console.WriteLine(mentorGroupsService.UpdateMentorGroup(updatedMentorGroup) ? "Mentor group updated." : "Failed to update mentor group.");
                        break;
                    case "4":
                        Console.Write("Enter Mentor Group ID to delete: ");
                        var deleteMentorGroupId = Console.ReadLine();
                        Console.WriteLine(mentorGroupsService.DeleteMentorGroup(deleteMentorGroupId) ? "Mentor group deleted." : "Failed to delete mentor group.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void StudentMenu(StudentService studentService)
        {
            while (true)
            {
                Console.WriteLine("\nStudent Menu:");
                Console.WriteLine("1. View All Students");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var students = studentService.GetStudents();
                        foreach (var student in students)
                            Console.WriteLine($"{student.StudentId} - {student.FirstName}, Age: {student.Phone}");
                        break;
                    case "2":
                        Console.Write("Enter Student Name: ");
                        var studentName = Console.ReadLine();
                        Console.Write("Enter Student Phone: ");
                        string studentphone = Console.ReadLine();
                        var newStudent = new Students { FirstName = studentName, Phone =  studentphone};
                        Console.WriteLine(studentService.AddStudent(newStudent) ? "Student added." : "Failed to add student.");
                        break;
                    case "3":
                        Console.Write("Enter Student ID to update: ");
                        var updateStudentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Student Name: ");
                        var newStudentName = Console.ReadLine();
                        Console.Write("Enter New Student Age: ");
                        string newStudentAge = Console.ReadLine();
                        var updatedStudent = new Students
                        {
                            StudentId = updateStudentId,
                            FirstName = newStudentName,
                            Phone = newStudentAge
                        };
                        Console.WriteLine(studentService.UpdateStudent(updatedStudent) ? "Student updated." : "Failed to update student.");
                        break;
                    case "4":
                        Console.Write("Enter Student ID to delete: ");
                        var deleteStudentId = Console.ReadLine();
                        Console.WriteLine(studentService.DeleteStudent(deleteStudentId) ? "Student deleted." : "Failed to delete student.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void StudentGroupsMenu(StudentGroupsService studentGroupsService)
        {
            while (true)
            {
                Console.WriteLine("\nStudent Groups Menu:");
                Console.WriteLine("1. View All Student Groups");
                Console.WriteLine("2. Add Student Group");
                Console.WriteLine("3. Update Student Group");
                Console.WriteLine("4. Delete Student Group");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var studentGroups = studentGroupsService.GetStudentGroups();
                        foreach (var group in studentGroups)
                            Console.WriteLine(
                                $"{group.StudentGroupsId} - Student ID: {group.StudentId}, Group ID: {group.GroupId}");
                        break;
                    case "2":
                        Console.Write("Enter Student ID: ");
                        var studentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Group ID: ");
                        var groupId = int.Parse(Console.ReadLine());
                        var newStudentGroup = new StudentGroups { StudentId = studentId, GroupId = groupId };
                        Console.WriteLine(studentGroupsService.AddStudentGroup(newStudentGroup)
                            ? "Student group added."
                            : "Failed to add student group.");
                        break;
                    case "3":
                        Console.Write("Enter Student Group ID to update: ");
                        var updateStudentGroupId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Student ID: ");
                        var newStudentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Group ID: ");
                        var newGroupId = int.Parse(Console.ReadLine());
                        var updatedStudentGroup = new StudentGroups
                        {
                            StudentGroupsId = updateStudentGroupId,
                            StudentId = newStudentId,
                            GroupId = newGroupId
                        };
                        Console.WriteLine(studentGroupsService.UpdateStudentGroup(updatedStudentGroup)
                            ? "Student group updated."
                            : "Failed to update student group.");
                        break;
                    case "4":
                        Console.Write("Enter Student Group ID to delete: ");
                        StudentGroups deleteStudentGroupId = new StudentGroups
                        {
                            StudentGroupsId = int.Parse(Console.ReadLine()),
                            StudentId = int.Parse(Console.ReadLine()),
                            GroupId = int.Parse(Console.ReadLine())
                        };
                        Console.WriteLine(studentGroupsService.DeleteStudentGroup(deleteStudentGroupId)
                            ? "Student group deleted."
                            : "Failed to delete student group.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
