CREATE DATABASE StudentManagement


CREATE TABLE Courses
(
	CourseId int primary key identity(1,1),
	CourseName nvarchar(200) not null,
	CreditHours int,
	[Status] int not null,
	Author nvarchar(200),
	CreatedAt datetime,
	UpdateAt datetime,
	Updatedby int,

)

CREATE TABLE Roles
(
	RoleId int primary key identity(1,1),
	RoleName nvarchar(200) not null,
	CreatedAt datetime,
	UpdateAt datetime,
	Updatedby int,

)


CREATE TABLE Students
(
	StudentId int primary key identity(1,1),
	FirstName nvarchar(200) not null,
	LastName nvarchar(200) not null,
	Email nvarchar(200) not null,
	[Password] nvarchar(200) not null,
	RegistrationStatus int not null,
	CourseId int foreign key references Courses(CourseId),
	CreatedAt datetime,
	UpdateAt datetime,
	Updatedby int,

)

CREATE TABLE [Status]
(
	StatusId int primary key identity(1,1),
	[Name] nvarchar(200) not null,
	CreatedAt datetime,
	UpdateAt datetime,
	Updatedby int,

)


CREATE TABLE Users
(
	UserId int primary key identity(1,1),
	FirstName nvarchar(200) not null,
	LastName nvarchar(200) not null,
	Email nvarchar(200) not null,
	[Password] nvarchar(200) not null,
	IsSuperAdmin bit,
	IsAdmin bit,
	RoleId int foreign key references Roles(RoleId),
	[Status] int not null,
	CreatedAt datetime,
	UpdateAt datetime,
	Updatedby int,
)


CREATE TABLE Invites
(
	InviteId int primary key identity(1,1),
	StudentName nvarchar(max) not null,
	StudentEmail nvarchar(200),
	SentDate datetime not null,
	InviteLink nvarchar(max) not null,
	SentBy int not null,
	[Status] int not null,
	CreatedAt datetime null,
	UpdatedAt datetime null,
	Updateby datetime null,
)





