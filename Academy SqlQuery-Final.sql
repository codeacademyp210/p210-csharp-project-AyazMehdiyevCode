----CREATE DATABASE MyAcademy;


CREATE TABLE [Classroom] (
	ID_room int IDENTITY(1,1) PRIMARY KEY,
	Name_room nvarchar(50) NOT NULL,
	Capacity int NOT NULL,
	Status_room bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Position] (
	ID_pos int IDENTITY(1,1) PRIMARY KEY,
	Name_pos nvarchar(50) NOT NULL,
	Status_pos bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Education_Program] (
	ID_edu int IDENTITY(1,1) PRIMARY KEY,
	Name_edu nvarchar(50) NOT NULL,
	Price decimal(10,2) NOT NULL,
	Status_edu bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Academy_info] (
	ID_academy int IDENTITY(1,1) PRIMARY KEY,
	Name_academy nvarchar(50) NOT NULL,
	phone_academy nvarchar(50) NOT NULL,
	email_academy nvarchar(50) NOT NULL,
	Adress_academy nvarchar(150) NOT NULL,
	Status_academy bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Task_Group] (
	ID_task_gr int IDENTITY(1,1) PRIMARY KEY,
	GroupID int NOT NULL,
	TaskID int NOT NULL,
	Status_task_gr bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Group] (
	ID_group int IDENTITY(1,1) PRIMARY KEY,
	Name_group nvarchar(50) NOT NULL,
	ClassroomID int NOT NULL,
	EducationID int NOT NULL,
	Status_group bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Task] (
	ID_task int IDENTITY(1,1) PRIMARY KEY,
	Name_task nvarchar(50) NOT NULL,
	DeadLine date NOT NULL,
	Status_task bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Scores] (
	ID_score int IDENTITY(1,1) PRIMARY KEY,
	TaskID int NOT NULL,
	StudentID int NOT NULL,
	Score decimal(10,2),
	Status_score bit NOT NULL DEFAULT '1'
)
GO
CREATE TABLE [Student] (
	ID_stud int IDENTITY(1,1) PRIMARY KEY,
	Name_stud nvarchar(50) NOT NULL,
	Surname_stud nvarchar(50) NOT NULL,
	Email_stud nvarchar(50) NOT NULL,
	Phone_stud nvarchar(50) NOT NULL,
	Fee decimal(10,2) NOT NULL,
	GroupID int NOT NULL,
	Status_stud bit NOT NULL DEFAULT '1'
)

GO
CREATE TABLE [Employee_Group] (
	ID_em_group int IDENTITY(1,1) PRIMARY KEY,
	EmpoleeID int NOT NULL,
	GroupID int NOT NULL
)
GO
CREATE TABLE [Employee] (
	ID_emp int IDENTITY(1,1) PRIMARY KEY,
	Name_emp nvarchar(50) NOT NULL,
	Surname_emp nvarchar(50) NOT NULL,
	Email_emp nvarchar(50) NOT NULL,
	Phone_emp nvarchar(50) NOT NULL,
	Speciality_emp nvarchar(50) NOT NULL,
	PositionID int NOT NULL,
	StartTime date NOT NULL,
	Salary decimal(10,2) NOT NULL,
	Status_emp bit NOT NULL DEFAULT '1'
)
GO



ALTER TABLE [Task_Group] WITH CHECK ADD CONSTRAINT [Task_Group_fk0] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID_group])
ON UPDATE CASCADE
GO
ALTER TABLE [Task_Group] CHECK CONSTRAINT [Task_Group_fk0]
GO
ALTER TABLE [Task_Group] WITH CHECK ADD CONSTRAINT [Task_Group_fk1] FOREIGN KEY ([TaskID]) REFERENCES [Task]([ID_task])
ON UPDATE CASCADE
GO
ALTER TABLE [Task_Group] CHECK CONSTRAINT [Task_Group_fk1]
GO

ALTER TABLE [Group] WITH CHECK ADD CONSTRAINT [Group_fk0] FOREIGN KEY ([ClassroomID]) REFERENCES [Classroom]([ID_room])
ON UPDATE CASCADE
GO
ALTER TABLE [Group] CHECK CONSTRAINT [Group_fk0]
GO
ALTER TABLE [Group] WITH CHECK ADD CONSTRAINT [Group_fk1] FOREIGN KEY ([EducationID]) REFERENCES [Education_Program]([ID_edu])
ON UPDATE CASCADE
GO
ALTER TABLE [Group] CHECK CONSTRAINT [Group_fk1]
GO


ALTER TABLE [Scores] WITH CHECK ADD CONSTRAINT [Scores_fk0] FOREIGN KEY ([TaskID]) REFERENCES [Task]([ID_task])
ON UPDATE CASCADE
GO
ALTER TABLE [Scores] CHECK CONSTRAINT [Scores_fk0]
GO
ALTER TABLE [Scores] WITH CHECK ADD CONSTRAINT [Scores_fk1] FOREIGN KEY ([StudentID]) REFERENCES [Student]([ID_stud])
ON UPDATE CASCADE
GO
ALTER TABLE [Scores] CHECK CONSTRAINT [Scores_fk1]
GO

ALTER TABLE [Student] WITH CHECK ADD CONSTRAINT [Student_fk0] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID_group])
ON UPDATE CASCADE
GO
ALTER TABLE [Student] CHECK CONSTRAINT [Student_fk0]
GO

ALTER TABLE [Employee_Group] WITH CHECK ADD CONSTRAINT [Employee_Group_fk0] FOREIGN KEY ([EmpoleeID]) REFERENCES [Employee]([ID_emp])
ON UPDATE CASCADE
GO
ALTER TABLE [Employee_Group] CHECK CONSTRAINT [Employee_Group_fk0]
GO
ALTER TABLE [Employee_Group] WITH CHECK ADD CONSTRAINT [Employee_Group_fk1] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID_group])
ON UPDATE CASCADE
GO
ALTER TABLE [Employee_Group] CHECK CONSTRAINT [Employee_Group_fk1]
GO

ALTER TABLE [Employee] WITH CHECK ADD CONSTRAINT [Employee_fk0] FOREIGN KEY ([PositionID]) REFERENCES [Position]([ID_pos])
ON UPDATE CASCADE
GO
ALTER TABLE [Employee] CHECK CONSTRAINT [Employee_fk0]
GO

