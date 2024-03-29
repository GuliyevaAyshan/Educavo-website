USE [EduCavoDb]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (1, N'College', N'1.jpg', 0, 0)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (2, N'High School', N'13385c96-3863-4813-93a2-cb337a7129cf-04082021170024-2.jpg', 0, 0)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (3, N'Primary', N'afa8b319-a41e-4fe5-a8a7-e3c1477a3847-04082021170031-3.jpg', 0, 0)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (4, N'School', N'27e9aeff-0097-41b3-8dcb-93f2044a1a05-04082021170039-4.jpg', 0, 0)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (5, N'University', N'105cd4b7-0124-417b-a26c-0c5d84a47a3a-04082021170048-5.jpg', 0, 0)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (6, N'General Education', N'a43a0e8c-c8c8-479e-a7f9-0b1c3ade3bed-04082021165805-1.jpg', 2, 1)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (7, N'Computer Science', N'553e6d89-2723-4639-8890-98bb6fcdec68-04082021165819-2.jpg', 3, 1)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (8, N'Civil Engineering', N'33d628a4-0a91-4cc2-b7db-80c5ea633c22-04082021165828-3.jpg', 4, 1)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (9, N'Artificial Intelligence', N'6c4b2ee2-21de-4745-b6fc-1227f0af4ef6-04082021165845-4.jpg', 2, 1)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (10, N'Business Studies', N'9434a610-34bb-43d0-9698-f090677ad963-04082021165853-5.jpg', 3, 1)
INSERT [dbo].[Categories] ([Id], [Name], [Image], [OnlineCategoriesCount], [IsOnline]) VALUES (11, N'Computer Engineering', N'29062a3d-c492-4bb6-9821-40bf2e7b3f4c-04082021165932-6.jpg', 1, 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name], [Surname], [Username], [Email], [Password], [Address], [HasAccount], [Phone], [AddedDate], [Token]) VALUES (4, N'Jessica', NULL, N'Jse', N'jesi@gmail.com', N'$2a$11$TN1WxGaYPvpRvsXtuaNNAuvAxtXjiKj4C7CKIzeRxV5GTNiuyA2mW', NULL, 0, NULL, CAST(N'2021-07-28T13:46:18.0522001' AS DateTime2), NULL)
INSERT [dbo].[Customers] ([Id], [Name], [Surname], [Username], [Email], [Password], [Address], [HasAccount], [Phone], [AddedDate], [Token]) VALUES (5, N'Jessica', NULL, N'Jse', N'jesi@gmail.com', N'$2a$11$4PxxgTpU6CWm5khG2dxki.LwFqYonuLy8ye2I/5pd9Z5tR6hEe3AG', NULL, 0, NULL, CAST(N'2021-07-28T13:46:54.6074474' AS DateTime2), NULL)
INSERT [dbo].[Customers] ([Id], [Name], [Surname], [Username], [Email], [Password], [Address], [HasAccount], [Phone], [AddedDate], [Token]) VALUES (6, N'Anna Sthesia', NULL, N'Jse', N'jesi@gmail.com', N'$2a$11$rkUindWa4z4rSH224aOXE.YasNrHbNnkTMxSRVC9z9fWa.KO1Thsm', NULL, 0, NULL, CAST(N'2021-07-29T03:39:40.2750714' AS DateTime2), NULL)
INSERT [dbo].[Customers] ([Id], [Name], [Surname], [Username], [Email], [Password], [Address], [HasAccount], [Phone], [AddedDate], [Token]) VALUES (12, N'Jeremy', N'Newman', N'Jer', N'jeremy@mail.ru', N'$2a$11$L7ToBAG0NqTonV7qQBSEvuZliXDuQghOKBaZLOfg.UAeYIN74Yw6O', NULL, 0, NULL, CAST(N'2021-08-05T17:59:58.3744996' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Email], [Username], [Password], [AddedDate], [Desc], [Gender], [Image], [IsTeamMember]) VALUES (13, N'Ayshan', N'Gulieva', N'ayshan@mail.ru', N'Admin', N'$2a$11$N4e1jXZDVXNhv6X1yPz5X.DBf.BDTiIyrlRvqFU19xwMa19iaaXwq', CAST(N'2021-08-13T14:35:46.2680000' AS DateTime2), NULL, 0, N'e1c578db-b2dc-4754-8851-7532f2ed4387-13.08.2021.14.35.46-6.jpg', 0)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Email], [Username], [Password], [AddedDate], [Desc], [Gender], [Image], [IsTeamMember]) VALUES (21, N'Avril', N'Gulieva', N'avril@gmail.com', N'ade', N'$2a$11$gocNApShWlv.8HNN2uXba.OwEF1fGfN8i40w/CBYQIOLK/UK102Gy', CAST(N'2021-08-13T15:21:27.8412627' AS DateTime2), N'<p>fwefffe</p>
', 1, N'80deac68-3613-43b0-8db9-2ef79669ac92-13.08.2021.15.21.27-4.jpg', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Blog] ON 

INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (17, N'University while the lovely valley team work', N'5f001a37-ae67-4f0e-b8fe-552a6b5c99cb-13.08.2021.18.49.50-1.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2020-09-14T18:49:00.0000000' AS DateTime2), 5, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (18, N'High school program starting soon 2021', N'b14a3ff6-eaa9-481f-8731-e85731fe4f8b-13.08.2021.19.08.27-2.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2020-09-14T19:08:00.0000000' AS DateTime2), 2, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (19, N'Modern School the lovely valley team work', N'a6c36611-9145-4c03-b2f0-9645d277edd1-13.08.2021.19.09.27-3.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2020-09-14T19:09:00.0000000' AS DateTime2), 3, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (20, N'While the lovely valley team work', N'13b8325c-883f-4644-9993-6c50dec2679d-13.08.2021.19.11.09-4.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2020-10-15T19:10:00.0000000' AS DateTime2), 1, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (21, N'This is a great source of content for anyone…', N'faeaeec3-bc12-4b09-9eaf-de1b93071d12-13.08.2021.19.12.04-5.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2020-10-20T19:11:00.0000000' AS DateTime2), 1, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (22, N'While the lovely valley team work', N'12c84e95-c49c-4fbc-97c1-d4b33a166b69-13.08.2021.19.13.25-6.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2020-10-20T19:12:00.0000000' AS DateTime2), 1, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (23, N'The Expenses You Are Thinking', N'ee8d002d-c50f-4ddd-b714-ae715df336cf-13.08.2021.19.14.39-7.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2021-04-06T19:14:00.0000000' AS DateTime2), 4, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (24, N'This is a great source of content for anyone…', N'b4a21445-0756-4928-bc70-b84e4c31af69-13.08.2021.19.15.18-8.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2021-04-30T19:15:00.0000000' AS DateTime2), 4, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (25, N'Modern School The Lovely Valley Team Work', N'4d729474-f244-41ca-8f99-ece183e2fa66-13.08.2021.19.32.37-1.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2021-08-12T19:31:00.0000000' AS DateTime2), 6, 13, NULL)
INSERT [dbo].[Blog] ([Id], [Title], [Image], [Content], [AddedDate], [CategoryId], [UserId], [CustomerId]) VALUES (26, N'High school program starting soon 2021', N'7764bacd-16cb-4e25-9e7a-606e5b435828-13.08.2021.19.33.23-2.jpg', N'<p>We denounce with righteous indige nation and dislike men who are so beguiled and demo realized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided.</p>
', CAST(N'2021-07-28T19:33:00.0000000' AS DateTime2), 7, 13, NULL)
SET IDENTITY_INSERT [dbo].[Blog] OFF
GO
SET IDENTITY_INSERT [dbo].[CourseTypes] ON 

INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (1, N'Backend')
INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (2, N'CSS')
INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (3, N'Frontend')
INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (4, N'General')
INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (6, N'Photography')
INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (7, N'Technology')
INSERT [dbo].[CourseTypes] ([Id], [Types]) VALUES (8, N'Web Development')
SET IDENTITY_INSERT [dbo].[CourseTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[DurationTimes] ON 

INSERT [dbo].[DurationTimes] ([Id], [Times]) VALUES (1, N'5+')
INSERT [dbo].[DurationTimes] ([Id], [Times]) VALUES (2, N'10+')
INSERT [dbo].[DurationTimes] ([Id], [Times]) VALUES (3, N'15+')
SET IDENTITY_INSERT [dbo].[DurationTimes] OFF
GO
SET IDENTITY_INSERT [dbo].[PriceLevels] ON 

INSERT [dbo].[PriceLevels] ([Id], [Levels]) VALUES (1, N'Free')
INSERT [dbo].[PriceLevels] ([Id], [Levels]) VALUES (2, N'Paid')
SET IDENTITY_INSERT [dbo].[PriceLevels] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillLevels] ON 

INSERT [dbo].[SkillLevels] ([Id], [Name]) VALUES (1, N'Beginner')
INSERT [dbo].[SkillLevels] ([Id], [Name]) VALUES (2, N'Intermediate')
INSERT [dbo].[SkillLevels] ([Id], [Name]) VALUES (3, N'Expert')
SET IDENTITY_INSERT [dbo].[SkillLevels] OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (11, CAST(N'2020-09-15T00:00:00.0000000' AS DateTime2), N'c547597d-a361-4e4f-aac8-c034e76f4914-31.07.2021.15.21.15-1.jpg', NULL, N'Become a PHP Master and Make Money Fast', N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.

Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.', 245, 1, CAST(55.00 AS Decimal(18, 2)), 10, 1, 0, 1, 8, 1, 2, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>&nbsp;</h3>

<h3>Requirements</h3>

<p>&nbsp;</p>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (12, CAST(N'2020-07-12T00:00:00.0000000' AS DateTime2), N'67a4cfe0-1505-44cd-b180-7ed2255b682c-31.07.2021.15.24.38-2.jpg', NULL, N'Learning jQuery Mobile for Beginners', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 245, 1, CAST(55.00 AS Decimal(18, 2)), 15, 2, 3, 3, 8, 2, 2, 2, N'<h3>&nbsp;</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (13, CAST(N'2019-04-12T00:00:00.0000000' AS DateTime2), N'c9769be7-412d-40ca-b994-3099e15ae19a-31072021200919-3.jpg', NULL, N'The Art of Black and White Photography', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 240, 1, CAST(55.00 AS Decimal(18, 2)), 10, 2, 1, 1, 6, 1, 2, 3, N'<h3>&nbsp;</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (14, CAST(N'2020-09-15T00:00:00.0000000' AS DateTime2), N'8b9a9502-9320-4f04-b6a2-b652da9200d7-13.08.2021.19.46.07-4.jpg', NULL, N'Learn Python – Interactive Python Tutorial', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 245, 1, CAST(55.00 AS Decimal(18, 2)), 10, 3, 2, 3, 7, 1, 2, 2, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (15, CAST(N'2020-07-12T00:00:00.0000000' AS DateTime2), N'311dfa17-d8fc-48de-8859-ada3adc0a436-13.08.2021.19.48.14-5.jpg', NULL, N'Your Complete Guide to Dark Photography', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 245, 1, CAST(55.00 AS Decimal(18, 2)), 10, 2, 0, 4, 4, 2, 2, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (16, CAST(N'2021-07-23T00:00:00.0000000' AS DateTime2), N'0fc64db0-9181-42a1-9905-c2f2659e08b4-13.08.2021.19.49.59-6.jpg', NULL, N'From Zero to Hero with Advance Nodejs', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 245, 1, CAST(56.00 AS Decimal(18, 2)), 5, 1, 1, 2, 4, 3, 2, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (17, CAST(N'2019-04-12T00:00:00.0000000' AS DateTime2), N'7cc7e1ff-0338-46ee-8d8f-f898c0348d1c-13.08.2021.19.51.14-7.jpg', NULL, N'Become a PHP Master and Make Money Fast', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 240, 0, CAST(45.00 AS Decimal(18, 2)), 10, 4, 2, 1, 1, 2, 2, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (18, CAST(N'2021-06-21T00:00:00.0000000' AS DateTime2), N'527bf30c-0185-419e-bae1-0e2513c6f7de-13.08.2021.19.52.41-8.jpg', NULL, N'Introduction to Quantitativ and Qualitative', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 230, 1, CAST(0.00 AS Decimal(18, 2)), 15, 3, 3, 3, 1, 2, 1, 2, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (19, CAST(N'2019-04-12T00:00:00.0000000' AS DateTime2), N'5c961bd3-6fbf-4467-bab0-ad469508cb7e-13.08.2021.19.55.43-1.jpg', NULL, N'Fitness Development Strategy Buildup Laoreet', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 25, 0, CAST(0.00 AS Decimal(18, 2)), 5, 6, 0, 4, 1, 1, 1, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (20, CAST(N'2021-07-23T00:00:00.0000000' AS DateTime2), N'f5e425cc-b2fa-4fe7-83e4-4ebc2a78af7b-13.08.2021.19.57.38-2.jpg', NULL, N'Artificial Intelligence Fundamental Startup Justo', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 25, 1, CAST(40.00 AS Decimal(18, 2)), 10, 6, 1, 2, 1, 2, 2, 2, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (21, CAST(N'2020-07-12T00:00:00.0000000' AS DateTime2), N'c12726cd-f86b-4581-af61-71a7558c7acb-13.08.2021.20.00.14-3.jpg', NULL, N'Computer Science Startup Varius et Commodo', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 25, 1, CAST(35.00 AS Decimal(18, 2)), 15, 6, 1, 1, 1, 1, 2, 2, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (22, CAST(N'2020-09-15T00:00:00.0000000' AS DateTime2), N'3457fb6c-f83a-466a-9e8b-b026a72b7a9a-13.08.2021.20.01.37-4.jpg', NULL, N'Testy & Delicious Food Recipes for Lunch Tellus', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 25, 0, CAST(35.00 AS Decimal(18, 2)), 5, 6, 1, 3, 4, 1, 2, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (23, CAST(N'2019-04-12T00:00:00.0000000' AS DateTime2), N'2cf78ffe-c7f5-427d-8071-c1f6427bd261-13.08.2021.20.04.36-5.jpg', NULL, N'Lawyer Advance Mental Simulator Handle Nulla', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 25, 0, CAST(0.00 AS Decimal(18, 2)), 5, 6, 1, 3, 4, 1, 1, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
INSERT [dbo].[Courses] ([Id], [AddedDate], [Image], [Video], [Title], [Desc], [StudentCount], [Assessments], [Fea], [Duration], [Lectures], [Quizzes], [CategoryId], [CourseTypesId], [SkillLevelId], [PriceLevelId], [DurationTimeId], [WhatLearn], [CustomerId], [UserId]) VALUES (25, CAST(N'2021-06-21T00:00:00.0000000' AS DateTime2), N'fcba8332-888d-4180-b3e4-f31674ce62f0-13.08.2021.20.33.15-6.jpg', NULL, N'Computer Fundamentals Basic Startup Ultricies', N'<p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>

<p>Eleifend euismod pellentesque vel Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus.</p>
', 25, 1, CAST(55.00 AS Decimal(18, 2)), 5, 6, 1, 3, 7, 1, 2, 1, N'<ul>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Sed consequat justo non mauris pretium at tempor justo.</li>
	<li>Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>

<h3>Requirements</h3>

<ul>
	<li>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo</li>
	<li>Ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
	<li>Varius et commodo ut, ultricies vitae velit. Ut nulla tellus.</li>
	<li>Phasellus enim magna, varius et commodo ut.</li>
</ul>
', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Address], [Phone], [Email]) VALUES (1, N'374 William S Canning Blvd, MA 2721, USA', N'(+880)155-69569', N'support@educavoP509@gmail.com')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Team] ON 

INSERT [dbo].[Team] ([Id], [Image], [FullName], [Position], [Info], [Email], [Phone], [TotalStudent], [TotalRating], [TeamOvercoming]) VALUES (1, N'1.jpg', N'Jhon Pedrocas', N'Professor', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat', N'info@yourwebsite.com', N'(+088) 589-8745', 23564, 1254, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur.I was skeptical of SEO and content marketing at first, but the Lorem Ipsum Company not only proved itself financially speaking, but the response I have received from customers is incredible.')
INSERT [dbo].[Team] ([Id], [Image], [FullName], [Position], [Info], [Email], [Phone], [TotalStudent], [TotalRating], [TeamOvercoming]) VALUES (2, N'2.jpg', N'Eliena Rose', N'Chief Instructor', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat', N'info@yourwebsite.com', N'(+088) 589-8745', 25700, 1300, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur.I was skeptical of SEO and content marketing at first, but the Lorem Ipsum Company not only proved itself financially speaking, but the response I have received from customers is incredible.')
INSERT [dbo].[Team] ([Id], [Image], [FullName], [Position], [Info], [Email], [Phone], [TotalStudent], [TotalRating], [TeamOvercoming]) VALUES (3, N'3.jpg', N'Jhon Pedrocas', N'Professor', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat', N'info@yourwebsite.com', N'(+088) 589-8745', 23564, 1400, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur.I was skeptical of SEO and content marketing at first, but the Lorem Ipsum Company not only proved itself financially speaking, but the response I have received from customers is incredible.')
INSERT [dbo].[Team] ([Id], [Image], [FullName], [Position], [Info], [Email], [Phone], [TotalStudent], [TotalRating], [TeamOvercoming]) VALUES (4, N'2.jpg', N'Jhon Pedrocas', N'Professor', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat', N'info@yourwebsite.com', N'(+088) 589-8745', 22456, 1290, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur.I was skeptical of SEO and content marketing at first, but the Lorem Ipsum Company not only proved itself financially speaking, but the response I have received from customers is incredible.')
INSERT [dbo].[Team] ([Id], [Image], [FullName], [Position], [Info], [Email], [Phone], [TotalStudent], [TotalRating], [TeamOvercoming]) VALUES (5, N'3.jpg', N'Jhon Pedrocas', N'Professor', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat', N'info@yourwebsite.com', N'(+088) 589-8745', 24988, 1198, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur.I was skeptical of SEO and content marketing at first, but the Lorem Ipsum Company not only proved itself financially speaking, but the response I have received from customers is incredible.')
INSERT [dbo].[Team] ([Id], [Image], [FullName], [Position], [Info], [Email], [Phone], [TotalStudent], [TotalRating], [TeamOvercoming]) VALUES (6, N'1.jpg', N'Jhon Pedrocas', N'Professor', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat', N'info@yourwebsite.com', N'(+088) 589-8745', 21333, 1080, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur.I was skeptical of SEO and content marketing at first, but the Lorem Ipsum Company not only proved itself financially speaking, but the response I have received from customers is incredible.')
SET IDENTITY_INSERT [dbo].[Team] OFF
GO
SET IDENTITY_INSERT [dbo].[CurriculumTitles] ON 

INSERT [dbo].[CurriculumTitles] ([Id], [Title]) VALUES (1, N'UI/UX Introduction')
INSERT [dbo].[CurriculumTitles] ([Id], [Title]) VALUES (2, N'Color Theory')
INSERT [dbo].[CurriculumTitles] ([Id], [Title]) VALUES (3, N'Basic Typography')
SET IDENTITY_INSERT [dbo].[CurriculumTitles] OFF
GO
SET IDENTITY_INSERT [dbo].[Curriculum] ON 

INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (31, N'What is UI/ UX Design', N'f5820160-e5cc-44c8-8e45-2bc67ce813a3-05.08.2021.04.05.14-sample-mp4-file.mp4', N'35 Minutes', 11, N'collapseOne', 1)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (33, N'What is UI/ UX Design', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'35 Minutes', 11, N'collapseTwo', 1)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (34, N'What is UI/ UX Design', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'35 Minutes', 11, N'collapseThree', 1)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (36, N'What is UI/ UX Design', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'30 Minutes', 12, N'collapseFour', 2)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (37, N'What is UI/ UX Design', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'30 Minutes', 12, N'collapseFive', 2)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (39, N'What is UI/ UX Design?', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'30 Minutes', 12, N'collapseSix', 2)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (40, N'What is UI/ UX Design?', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'40 Minutes', 13, N'collapseSeven', 3)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (41, N'What is UI/ UX Design?', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'40 Minutes', 13, N'collapseEight', 3)
INSERT [dbo].[Curriculum] ([Id], [Subtitle], [Video], [VideoDuration], [CoursesId], [Collapse], [CurriculumTitlesId]) VALUES (42, N'What is UI/ UX Design?', N'https://www.youtube.com/watch?v=kxPCFljwJws', N'40 Minutes', 13, N'collapseNine', 3)
SET IDENTITY_INSERT [dbo].[Curriculum] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Name], [Email], [Message], [BlogId], [CustomerId], [CommentId], [AddedDate]) VALUES (2, NULL, NULL, N'just say hello', 17, 12, NULL, CAST(N'2021-08-14T02:51:08.6415690' AS DateTime2))
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Message], [BlogId], [CustomerId], [CommentId], [AddedDate]) VALUES (3, NULL, NULL, N'gsgggggds', 18, 12, NULL, CAST(N'2021-08-14T13:35:03.1515439' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Reviews] ON 

INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (22, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 12, 11, 1, 4, CAST(N'2021-08-06T02:52:20.4218117' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (23, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 12, 19, 3, 5, CAST(N'2021-08-13T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (24, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 12, 20, 2, 4, CAST(N'2021-07-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (25, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 6, 21, 4, 5, CAST(N'2021-06-09T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (26, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 6, 22, 5, 3, CAST(N'2021-05-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (27, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 5, 23, 6, 5, CAST(N'2021-08-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (29, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 5, 25, 1, 4, CAST(N'2021-05-09T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (32, N'Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus.', 12, 14, 1, 4, CAST(N'2021-08-14T01:30:07.3465610' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (33, N'sPhasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium ', 12, 16, 1, 3, CAST(N'2021-08-14T01:49:59.1937552' AS DateTime2))
INSERT [dbo].[Reviews] ([Id], [Text], [CustomerId], [CoursesId], [TeamId], [Rating], [AddedDate]) VALUES (34, N'fgsryryry', 12, 12, 1, 3, CAST(N'2021-08-14T13:34:17.9138043' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Reviews] OFF
GO
SET IDENTITY_INSERT [dbo].[FaqTitles] ON 

INSERT [dbo].[FaqTitles] ([Id], [Title]) VALUES (1, N'Kindergarten')
INSERT [dbo].[FaqTitles] ([Id], [Title]) VALUES (2, N'Primary School')
INSERT [dbo].[FaqTitles] ([Id], [Title]) VALUES (3, N'High School')
INSERT [dbo].[FaqTitles] ([Id], [Title]) VALUES (4, N'College/University')
SET IDENTITY_INSERT [dbo].[FaqTitles] OFF
GO
SET IDENTITY_INSERT [dbo].[Faqs] ON 

INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (1, N'What do you mean by item and end product?', N'Aenean massa. Cum sociis natoque penatibus et magnis dis partu rient to montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellen of the tesque services Donec quam felis, ultricies nec, pellentesque eu, pretium quis,pede justo, of fringilla vel, aliquet nec', N'collapseOne', 1)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (6, N'What does non-exclusive mean?', N' Aenean massa. Cum sociis natoque penatibus et magnis dis partu rient to montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellen of the tesque services Donec quam felis, ultricies nec, pellentesque eu, pretium quis,pede justo, of fringilla vel, aliquet nec', N'collapseTwo', 1)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (7, N'What are some examples of permitted end products?', N'Aenean massa. Cum sociis natoque penatibus et magnis dis partu rient to montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellen of the tesque services Donec quam felis, ultricies nec, pellentesque eu, pretium quis,pede justo, of fringilla vel, aliquet nec.', N'collapseThree', 1)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (8, N'What if I have an emergency?', N'Hematology, also spelled haematology, is the branch of medicine concerned with the study of the cause, prognosis, treatment, and prevention of diseases related to blood. It involves treating diseases that affect the production of blood and its components, such as blood cells, hemoglobin, blood proteins, bone marrow, platelets, blood vessels, spleen, and the mechanism of coagulation.', N'collapseFour', 2)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (9, N'What if my regular doctor is unavailable?', N'Hematology, also spelled haematology, is the branch of medicine concerned with the study of the cause, prognosis, treatment, and prevention of diseases related to blood. It involves treating diseases that affect the production of blood and its components, such as blood cells, hemoglobin, blood proteins, bone marrow, platelets, blood vessels, spleen, and the mechanism of coagulation.', N'collapseFive', 2)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (10, N'What should I bring to my first appointment?', N'Hematology, also spelled haematology, is the branch of medicine concerned with the study of the cause, prognosis, treatment, and prevention of diseases related to blood. It involves treating diseases that affect the production of blood and its components, such as blood cells, hemoglobin, blood proteins, bone marrow, platelets, blood vessels, spleen, and the mechanism of coagulation.', N'collapseSix', 2)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (11, N'How does the normal heart work?', N'The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.', N'collapseSeven', 3)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (12, N'What are the heart valves?', N'The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.', N'collapseEight', 3)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (13, N'Can a child acquire a heart problem?', N'The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.', N'collapseNine', 3)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (14, N'What is Education?', N'Orthopedics (alternatively, orthopaedics) is a specialty focused on the diagnosis and treatment of conditions, disorders, diseases and injuries of the muscles, bones, joints, tendons, ligaments, and nerves.', N'collapseTen', 4)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (17, N'What is the difference between a sprain and a fracture?', N'The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.', N'collapseEleven', 4)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (18, N'What is an Advanced Practitioner?', N'The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.', N'collapseTwelve', 4)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (19, N'What is distance education?', N'Lorem ipsum dolor sit amet, consectetur adipiscing
                                                elit. Ut elit tellus, luctus nec ullamcorper mattis,
                                                pulvinar dapibus leo.', N'collapsefour', 2)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (20, N'What is the transfer application process?', N'Lorem ipsum dolor sit amet, consectetur adipiscing
                                                elit. Ut elit tellus, luctus nec ullamcorper mattis,
                                                pulvinar dapibus leo.', N'collapseThree', 3)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (21, N'Does Educavo offer free courses?', N' Lorem ipsum dolor sit amet, consectetur adipiscing
                                                elit. Ut elit tellus, luctus nec ullamcorper mattis,
                                                pulvinar dapibus leo.', N'collapseTwo', 1)
INSERT [dbo].[Faqs] ([Id], [Questions], [Description], [Collapse], [FaqTitlesId]) VALUES (22, N'What are the                                                requirements ?', N' Lorem ipsum dolor sit amet, consectetur adipiscing                                                elit. Ut elit tellus, luctus nec ullamcorper mattis,                                                pulvinar dapibus leo.', N'collapseOne', 4)
SET IDENTITY_INSERT [dbo].[Faqs] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Name]) VALUES (1, N'Accounting')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (2, N'Reading')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (3, N'Writing')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (4, N'Speaking')
INSERT [dbo].[Skills] ([Id], [Name]) VALUES (5, N'Listening')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillToTeams] ON 

INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (1, 1, 1, CAST(95.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (2, 1, 2, CAST(85.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (3, 1, 3, CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (4, 1, 4, CAST(75.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (5, 2, 1, CAST(93.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (6, 2, 2, CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (7, 2, 3, CAST(84.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (8, 2, 4, CAST(75.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (9, 3, 1, CAST(90.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (10, 3, 2, CAST(88.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (11, 3, 3, CAST(78.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (12, 3, 4, CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (13, 4, 1, CAST(90.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (14, 4, 2, CAST(87.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (15, 4, 3, CAST(79.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (16, 4, 4, CAST(77.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (17, 5, 1, CAST(99.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (18, 5, 2, CAST(95.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (19, 5, 3, CAST(89.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (20, 5, 4, CAST(98.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (21, 6, 1, CAST(78.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (22, 6, 2, CAST(89.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (23, 6, 3, CAST(87.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (24, 6, 4, CAST(77.00 AS Decimal(18, 2)))
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId], [Persentage]) VALUES (25, 4, 4, CAST(16.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[SkillToTeams] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (1, N'https://www.facebook.com', N'fa fa-facebook')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (2, N'https://www.twitter.com', N'fa fa-twitter')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (3, N'https://www.linkedin.com', N'fa fa-linkedin')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (4, N'https://www.google.com', N'fa fa-google-plus')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (5, N'https://www.facebook.com', N'fa fa-facebook-square')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (6, N'https://www.twitter.com', N'fa fa-twitter-square')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (7, N'https://www.linkedin.com', N'fa fa-linkedin-square')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (8, N'https://www.github.com', N'fa fa-github')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (9, N'https://www.instagram.com', N'fa fa-instagram')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (10, N'https://www.google.com', N'fa fa-google-plus-square')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (11, N'https://www.pinterest.com', N'fa fa-pinterest-p')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (12, N'https://www.twitter.com', N'fa fa-twitter')
INSERT [dbo].[Socials] ([Id], [Link], [Icon]) VALUES (13, N'https://www.facebook.com', N'fa fa-facebook')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialToTeams] ON 

INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (5, 1, 5)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (6, 1, 6)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (9, 1, 7)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (10, 1, 8)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (11, 2, 5)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (12, 2, 6)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (13, 2, 7)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (14, 2, 8)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (15, 3, 5)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (16, 3, 6)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (17, 3, 7)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (18, 3, 8)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (19, 1, 1)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (20, 1, 2)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (21, 1, 3)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (22, 1, 4)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (23, 2, 1)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (24, 2, 2)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (25, 2, 3)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (26, 2, 4)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (27, 3, 1)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (28, 3, 2)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (29, 3, 3)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (30, 3, 4)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (31, 4, 5)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (33, 4, 6)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (34, 4, 7)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (35, 4, 8)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (36, 4, 1)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (37, 4, 2)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (38, 4, 3)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (39, 4, 4)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (40, 5, 5)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (41, 5, 6)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (42, 5, 7)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (43, 5, 8)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (44, 5, 1)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (45, 5, 2)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (46, 5, 3)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (47, 5, 4)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (48, 6, 5)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (49, 6, 6)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (50, 6, 7)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (51, 6, 8)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (52, 6, 1)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (53, 6, 2)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (54, 6, 3)
INSERT [dbo].[SocialToTeams] ([Id], [TeamId], [SocialId]) VALUES (55, 6, 4)
SET IDENTITY_INSERT [dbo].[SocialToTeams] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamToCourses] ON 

INSERT [dbo].[TeamToCourses] ([Id], [TeamId], [CourseId]) VALUES (1, 1, 11)
INSERT [dbo].[TeamToCourses] ([Id], [TeamId], [CourseId]) VALUES (2, 2, 11)
INSERT [dbo].[TeamToCourses] ([Id], [TeamId], [CourseId]) VALUES (3, 2, 12)
INSERT [dbo].[TeamToCourses] ([Id], [TeamId], [CourseId]) VALUES (4, 2, 13)
INSERT [dbo].[TeamToCourses] ([Id], [TeamId], [CourseId]) VALUES (5, 1, 11)
SET IDENTITY_INSERT [dbo].[TeamToCourses] OFF
GO
SET IDENTITY_INSERT [dbo].[FaqToCourses] ON 

INSERT [dbo].[FaqToCourses] ([Id], [CourseId], [FaqId]) VALUES (2, 11, 1)
INSERT [dbo].[FaqToCourses] ([Id], [CourseId], [FaqId]) VALUES (5, 11, 6)
INSERT [dbo].[FaqToCourses] ([Id], [CourseId], [FaqId]) VALUES (6, 11, 7)
SET IDENTITY_INSERT [dbo].[FaqToCourses] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210712220835_start', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713100713_changes', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713113553_changeses', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713114339_chan', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210714204548_blogd', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210714204624_blogdss', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717093756_onlinecourses', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717100255_coursety', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717100621_courseskill', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717100707_courseskil', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717102324_timtmtm', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717195942_onetomanychanges', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717204533_curriculumaded', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717212828_cdurdtime', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717213843_hommmmm', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210717214942_categedhduu', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210718224423_fagcollapse', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720171228_aboutgag', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720171442_aboutg', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720172022_aboutgll', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720172412_abo', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720172518_abodd', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720224732_studdddfeed', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720231644_whathappen', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720234237_event', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210720235210_init', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210721000408_event', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210721003703_eventbgc', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722123328_teamsosial', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722125659_retinggg', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722131101_retingg', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722131609_retinggtotal', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722132450_totalstudent', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722134823_teamovercom', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722135239_totalratsss', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722155857_faqz', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722172051_faqrelationnl', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722172303_faqrela', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210722172837_init', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210723200107_commentrel', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210725163009_jhdgjd', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210725225142_curricul', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210725233849_curricultitled', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210726000429_init', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210726001316_curtitle', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210726143144_courdetail', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210726195652_contactmessages', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210727104206_init', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210727133948_customerusername', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210728211221_pricelevel', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210728223108_coursetypes', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210728223246_coursettt', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210729145435_username', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210729193152_contact', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210731103925_init', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210802001508_phonee', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210803233347_jsgass', N'3.1.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210804142339_userddg', N'3.1.16')
GO
SET IDENTITY_INSERT [dbo].[About] ON 

INSERT [dbo].[About] ([Id], [Video], [Title], [Desc], [Students], [CGPA], [Graduates]) VALUES (2, N'0578d9d4-fb6e-4794-b5dd-382b2d7691d9-03.08.2021.02.42.53-sample-mp4-file.mp4', N'The End Result of All True Learning', N'<p>The key to success is to appreciate how people learn, understand the thought process that goes into instructional design, what works well, and a range of differen</p>
', 5, CAST(3.50 AS Decimal(18, 2)), 96)
INSERT [dbo].[About] ([Id], [Video], [Title], [Desc], [Students], [CGPA], [Graduates]) VALUES (4, N'af3b8bd4-6aba-4703-9d3c-6a4e28ef8ec3-30.07.2021.03.30.25-sample-mp4-file.mp4', N'About anything', N'vfgergergergrege', 23, CAST(45.00 AS Decimal(18, 2)), 32)
SET IDENTITY_INSERT [dbo].[About] OFF
GO
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([Id], [Title], [SubTitle], [Date], [BackgColor]) VALUES (1, N'Educational Technology and Mobile Accessories Learning', N'Math & English', CAST(N'2020-06-20T00:00:00.0000000' AS DateTime2), N'bgc1')
INSERT [dbo].[Events] ([Id], [Title], [SubTitle], [Date], [BackgColor]) VALUES (3, N'Educational Technology and Mobile Accessories Learning', N'Math & English', CAST(N'2020-06-21T00:00:00.0000000' AS DateTime2), N'bgc2')
INSERT [dbo].[Events] ([Id], [Title], [SubTitle], [Date], [BackgColor]) VALUES (5, N'Educational Technology and Mobile Accessories Learning', N'Math & English
', CAST(N'2020-06-22T00:00:00.0000000' AS DateTime2), N'bgc3')
INSERT [dbo].[Events] ([Id], [Title], [SubTitle], [Date], [BackgColor]) VALUES (6, N'Educational Technology and Mobile Accessories Learning', N'Math & English', CAST(N'2020-06-23T00:00:00.0000000' AS DateTime2), N'bgc4')
INSERT [dbo].[Events] ([Id], [Title], [SubTitle], [Date], [BackgColor]) VALUES (7, N'Educational Technology and Mobile Accessories Learning', N'Math & English', CAST(N'2020-06-24T00:00:00.0000000' AS DateTime2), N'bgc1')
INSERT [dbo].[Events] ([Id], [Title], [SubTitle], [Date], [BackgColor]) VALUES (8, N'Educational Technology and Mobile Accessories Learning', N'Math & English', CAST(N'2020-06-25T00:00:00.0000000' AS DateTime2), N'bgc2')
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[Galleries] ON 

INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (1, N'4dbef371-a7d0-45d3-8292-2ee5b7feb917-13.08.2021.18.39.05-1.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (2, N'0ead3194-8c10-42fd-b289-dce0db081354-13.08.2021.18.39.10-2.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (3, N'355fcca2-98cc-44ae-8b26-48cf254222f7-13.08.2021.18.39.17-3.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (4, N'13a9b6d1-5d02-4f78-b35e-a9805d509e32-13.08.2021.18.39.22-4.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (5, N'37a9b9ca-5169-44b2-a524-7b66280f871d-13.08.2021.18.39.28-5.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (6, N'fed10e42-e2c9-47d1-9c9c-9d0e41e2cc72-13.08.2021.18.39.33-6.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (7, N'0765b143-2b08-48fe-a5ba-1448b284083d-13.08.2021.18.39.39-7.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (8, N'0a4aa48c-7f9c-4360-8500-6eae6bd45da6-13.08.2021.18.39.46-8.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (9, N'ba3100cf-e117-4a02-99d0-c436b33a323d-13.08.2021.18.39.52-9.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (10, N'184e6f54-a14b-47d9-ae66-dda47a8fe29a-13.08.2021.18.40.00-10.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (11, N'0d6d085a-b664-4e4a-89c5-72af10326674-13.08.2021.18.40.07-11.jpg')
INSERT [dbo].[Galleries] ([Id], [Image]) VALUES (12, N'cc0eaa3b-71ed-4f06-a562-374de3dd73e1-13.08.2021.18.40.13-12.jpg')
SET IDENTITY_INSERT [dbo].[Galleries] OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([Id], [Name], [Email], [Subject], [AddedDate], [MessageText], [Phone]) VALUES (4, N'Jeremy', N'jeremy@mail.ru', N'2ff22fvewfwef', CAST(N'2021-08-02T04:16:28.0366024' AS DateTime2), N'feffefefef', NULL)
INSERT [dbo].[Messages] ([Id], [Name], [Email], [Subject], [AddedDate], [MessageText], [Phone]) VALUES (5, N'Jeremy', N'jeremy@mail.ru', N'hi hello', CAST(N'2021-08-02T04:18:34.1856188' AS DateTime2), N'dwddwdqw', N'1525156')
INSERT [dbo].[Messages] ([Id], [Name], [Email], [Subject], [AddedDate], [MessageText], [Phone]) VALUES (6, N'Jeremy', N'jeremy@mail.ru', N'w2w', CAST(N'2021-08-02T04:20:17.7937628' AS DateTime2), N'w2ww2', N'221244')
INSERT [dbo].[Messages] ([Id], [Name], [Email], [Subject], [AddedDate], [MessageText], [Phone]) VALUES (7, N'Jeremy', N'jeremy@mail.ru', N'hi hello', CAST(N'2021-08-14T13:36:16.0316579' AS DateTime2), N'grwgrgg', N'1525156')
SET IDENTITY_INSERT [dbo].[Messages] OFF
GO
SET IDENTITY_INSERT [dbo].[OfferStates] ON 

INSERT [dbo].[OfferStates] ([Id], [Image], [Title], [Desc]) VALUES (5, NULL, N'
20% Offer Running - Join Today', N'We denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of your moment, so blinded by desire those who fail in their duty through weakness. These cases are perfectly simple and easy every pleasure is to be welcomed and every pain avoided.')
SET IDENTITY_INSERT [dbo].[OfferStates] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Title], [Desc], [Image]) VALUES (4, N'eayryaeryry', N'<p>aeryraueuetuetititiiyriyy gkgkff</p>
', N'4ff4d0fe-9a77-4b92-8f9e-61a55ab06ffc-14.08.2021.02.28.31-5.jpg')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentsFeedbacks] ON 

INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (1, N'2fdab403-736a-4d92-b0ec-d9ed328e0819-06.08.2021.03.46.46-1.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (2, N'6bcfc084-9a0f-4230-b7aa-072b495e1a87-06.08.2021.03.46.52-1.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (4, N'f2a186ed-d664-4b45-81a4-4055e9c69140-06.08.2021.03.47.00-3.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (5, N'70d72bfe-b673-4d8b-8b8c-0c705ba4a4fd-06.08.2021.03.47.16-1.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (6, N'57f45c12-f6a9-4d7b-82de-ff1c06c6e786-06.08.2021.03.47.22-8.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (7, N'bb71b1da-cc1d-4f7b-bc1b-a9f9a0a382d2-06.08.2021.03.47.30-2.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (8, N'7e5da5f4-375d-457b-8514-c0a671f04a81-06.08.2021.03.47.36-1.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (9, N'0981f1aa-b7a6-4c13-aa3a-68ad3ebc8de5-06.08.2021.03.47.43-4.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (10, N'5170fa4c-44f1-47e7-ace7-cd5f56da1f18-06.08.2021.03.47.56-6.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran ', N'Student', 5)
INSERT [dbo].[StudentsFeedbacks] ([Id], [Image], [Text], [FullName], [Position], [Rating]) VALUES (11, N'13367be3-5096-4d9b-89b0-a381b3c1597b-06.08.2021.03.42.55-1.png', N'The charms of pleasure of the moment so blinded by desire that they cannot foresee the pain and trouble that are bound ensue and equal blame belongs to those who fail in their duty.', N'Saiko Najran ', N'Student', 5)
SET IDENTITY_INSERT [dbo].[StudentsFeedbacks] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscribe] ON 

INSERT [dbo].[Subscribe] ([Id], [Email], [AddedDate]) VALUES (2, N'ayshanigu@code.edu.az', CAST(N'2021-07-21T16:41:19.3651634' AS DateTime2))
INSERT [dbo].[Subscribe] ([Id], [Email], [AddedDate]) VALUES (5, N'elon@mail.ru', CAST(N'2021-07-21T16:46:34.6332748' AS DateTime2))
INSERT [dbo].[Subscribe] ([Id], [Email], [AddedDate]) VALUES (6, N'admin@gmail.com', CAST(N'2021-07-21T16:56:09.0440733' AS DateTime2))
INSERT [dbo].[Subscribe] ([Id], [Email], [AddedDate]) VALUES (9, N'elon@mail.ru', CAST(N'2021-08-14T13:41:14.9615930' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Subscribe] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([Id], [Image], [Text], [FullName], [Position]) VALUES (1, N'19d96ece-4cf6-42da-aa43-311f813eaad7-13.08.2021.15.41.59-1.png', N'Professional, responsive, and able to keep up with
                            ever-changing demand and tight deadlines: That’s how I would
                            describe Jeramy and his team at The Lorem Ipsum Company. When
                            it comes to content marketing, you’ll definitely get the
                            5-star treatment from the Lorem Ipsum Company.', N'Mahadi Monsura', N'Student')
INSERT [dbo].[Testimonials] ([Id], [Image], [Text], [FullName], [Position]) VALUES (2, N'bd738ad8-2e12-43ba-bc2a-c171c086fbe5-13.08.2021.15.42.04-2.png', N'Professional, responsive, and able to keep up with
                            ever-changing demand and tight deadlines: That’s how I would
                            describe Jeramy and his team at The Lorem Ipsum Company. When
                            it comes to content marketing, you’ll definitely get the
                            5-star treatment from the Lorem Ipsum Company.', N'Alex Fenando', N'English Teacher')
INSERT [dbo].[Testimonials] ([Id], [Image], [Text], [FullName], [Position]) VALUES (3, N'd74fcfee-759c-40d4-bc5a-350f67dd51c7-13.08.2021.15.42.11-3.png', N'Professional, responsive, and able to keep up with
                            ever-changing demand and tight deadlines: That’s how I would
                            describe Jeramy and his team at The Lorem Ipsum Company. When
                            it comes to content marketing, you’ll definitely get the
                            5-star treatment from the Lorem Ipsum Company.', N'Mahadi Monsura', N'Student')
INSERT [dbo].[Testimonials] ([Id], [Image], [Text], [FullName], [Position]) VALUES (4, N'8b072429-c9d9-45b9-b97b-6434ff793661-13.08.2021.15.42.19-4.png', N'Professional, responsive, and able to keep up with
                            ever-changing demand and tight deadlines: That’s how I would
                            describe Jeramy and his team at The Lorem Ipsum Company. When
                            it comes to content marketing, you’ll definitely get the
                            5-star treatment from the Lorem Ipsum Company.', N'Alex Fenando', N'English Teacher')
INSERT [dbo].[Testimonials] ([Id], [Image], [Text], [FullName], [Position]) VALUES (5, N'a7b14c39-472a-4043-969d-8a8e71db091b-13.08.2021.15.42.29-3.png', N'Professional, responsive, and able to keep up with
                            ever-changing demand and tight deadlines: That’s how I would
                            describe Jeramy and his team at The Lorem Ipsum Company. When
                            it comes to content marketing, you’ll definitely get the
                            5-star treatment from the Lorem Ipsum Company.', N'Losis Dcosta', N'Math Teacher')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
