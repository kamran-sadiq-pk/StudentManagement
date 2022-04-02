USE [StudentManagement]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [CreditHours], [Status], [Author], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (1, N'Solution Architect', 10, 1, N'John Doe', NULL, NULL, NULL)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [CreditHours], [Status], [Author], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (2, N'DBA', 15, 1, N'Mark Hasting', NULL, NULL, NULL)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [CreditHours], [Status], [Author], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (6, N'Azure DevOps', 20, 1, N'Bill Gates', NULL, NULL, NULL)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [CreditHours], [Status], [Author], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (7, N'AWS Network Engineer', 20, 1, N'Jeff', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [Password], [CourseId], [CreatedAt], [UpdateAt], [Updatedby], [RegistrationStatus]) VALUES (1, N'Kamran', N'Sadiq', N'kamransadiq111@hotmail.com', N'123456', 1, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [Password], [CourseId], [CreatedAt], [UpdateAt], [Updatedby], [RegistrationStatus]) VALUES (2, N'Steve', N'Harvy', N'steve@gmail.com', N'123456', 2, NULL, NULL, NULL, 3)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [Password], [CourseId], [CreatedAt], [UpdateAt], [Updatedby], [RegistrationStatus]) VALUES (3, N'Joshua', N'Bendeth', N'Joshua@gmail.com', N'123456', 1, NULL, NULL, NULL, 3)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [Password], [CourseId], [CreatedAt], [UpdateAt], [Updatedby], [RegistrationStatus]) VALUES (4, N'Test', N'test', N'test@gmail.com', N'123456', 7, NULL, NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (1, N'Superadmin', NULL, NULL, NULL)
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (2, N'Admin', NULL, NULL, NULL)
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (3, N'Student', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (1, N'Kamran', N'Sadiq', N'kamransadiq111@gmail.com', N'123456', 1, NULL, 1, 0, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (2, N'Mark', N'Hasting', N'mark@gmail.com', N'123456', NULL, 1, 2, 2, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (6, N'Issac', N'Newtow', N'issac@gmail.com', N'123456', NULL, 1, 2, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (7, N'Neil', N'Armstrong', N'neil@gmail.com', N'123456', NULL, 1, 2, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (8, N'Ibn', N'Sina', N'ibn@gmail.com', N'123456', NULL, 1, 2, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (9, N'Elon ', N'Musk', N'elon@rtest.com', N'123456', NULL, 1, NULL, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (10, N'Steve', N'Jobs', N'steve@apple.com', N'123456', NULL, 1, NULL, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (20, N'Kamran', N'Sadiq', N'kamransadiq111@hotmail.com', N'123456', NULL, NULL, 3, 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Password], [IsSuperAdmin], [IsAdmin], [RoleId], [Status], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (21, N'Test', N'test', N'test@gmail.com', N'123456', NULL, NULL, 3, 1, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Invites] ON 
GO
INSERT [dbo].[Invites] ([InviteId], [StudentName], [StudentEmail], [SentDate], [InviteLink], [SentBy], [Status], [CreatedAt], [UpdatedAt], [Updateby]) VALUES (1, N'Abdul Aziz', N'aziz@gmail.com', CAST(N'2022-03-31T00:00:00.000' AS DateTime), N'google.com', 2, 1, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Invites] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 
GO
INSERT [dbo].[Status] ([StatusId], [Name], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (1, N'Active', NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([StatusId], [Name], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (2, N'InActive', NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([StatusId], [Name], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (3, N'Pending', NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([StatusId], [Name], [CreatedAt], [UpdateAt], [Updatedby]) VALUES (4, N'Process', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
