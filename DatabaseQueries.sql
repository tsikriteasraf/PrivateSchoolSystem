Use PrivateSchoolSystem;
GO
--All courses,trainers,students,assignments
SELECT * FROM Courses
SELECT * FROM Trainers
SELECT * FROM Students
SELECT * FROM Assignments
--trainers per course
SELECT t.First_Name,t.Last_Name,c.Title FROM Trainers t
inner join TrainerCourses tc
on t.Id = tc.Trainer_Id
inner join Courses c
on c.Id = tc.Course_Id
--students per course
SELECT s.FirstName,s.LastName,c.Title FROM Students s
inner join StudentCourses sc
on s.Id = sc.Student_Id
inner join Courses c
on c.Id = sc.Course_Id
--assignments per course
SELECT a.Title, c.Title FROM Assignments a
inner join Courses c 
On c.Id = a.Course_Id
--assignments per student per course
SELECT s.FirstName, s.LastName, c.Title as [Course Title], a.Title as [Assingmnet Title] FROM Students s
inner join StudentCourses sc
on s.Id = sc.Student_Id
inner join Courses c
on c.Id = sc.Course_Id
inner join Assignments a
on a.Course_Id = c.Id
--students with more than one course
SELECT s.FirstName as [First Name], s.LastName as [Last Name], Count(sc.Course_Id) AS [Number of Courses] FROM StudentCourses sc
inner join Students s on sc.Student_Id = s.Id
inner join Courses c on sc.Course_Id = c.Id
GROUP BY s.Id, s.FirstName, s.LastName HAVING
count(sc.Course_Id) > 1
