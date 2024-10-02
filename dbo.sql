-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type IN ('U'))
	DROP TABLE [dbo].[__EFMigrationsHistory]
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
  [MigrationId] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProductVersion] nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[__EFMigrationsHistory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241002140517_InitialCreate', N'8.0.8')
GO


-- ----------------------------
-- Table structure for BtcPrices
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BtcPrices]') AND type IN ('U'))
	DROP TABLE [dbo].[BtcPrices]
GO

CREATE TABLE [dbo].[BtcPrices] (
  [Id] bigint  IDENTITY(1,1) NOT NULL,
  [Price] real  NOT NULL,
  [Time] datetime2(7)  NOT NULL,
  [Comment] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[BtcPrices] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of BtcPrices
-- ----------------------------
SET IDENTITY_INSERT [dbo].[BtcPrices] ON
GO

INSERT INTO [dbo].[BtcPrices] ([Id], [Price], [Time], [Comment]) VALUES (N'46', N'1404632.75', N'2024-10-02 16:35:49.0000000', N'1')
GO

INSERT INTO [dbo].[BtcPrices] ([Id], [Price], [Time], [Comment]) VALUES (N'47', N'1404481.125', N'2024-10-02 16:36:19.0000000', N'asd')
GO

INSERT INTO [dbo].[BtcPrices] ([Id], [Price], [Time], [Comment]) VALUES (N'48', N'1402595.875', N'2024-10-02 16:36:49.0000000', N'')
GO

INSERT INTO [dbo].[BtcPrices] ([Id], [Price], [Time], [Comment]) VALUES (N'49', N'1404665.75', N'2024-10-02 16:37:18.0000000', N'')
GO

INSERT INTO [dbo].[BtcPrices] ([Id], [Price], [Time], [Comment]) VALUES (N'50', N'1403222', N'2024-10-02 16:37:48.0000000', N'')
GO

INSERT INTO [dbo].[BtcPrices] ([Id], [Price], [Time], [Comment]) VALUES (N'51', N'1406353.375', N'2024-10-02 16:38:18.0000000', N'')
GO

SET IDENTITY_INSERT [dbo].[BtcPrices] OFF
GO


-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for BtcPrices
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[BtcPrices]', RESEED, 51)
GO


-- ----------------------------
-- Primary Key structure for table BtcPrices
-- ----------------------------
ALTER TABLE [dbo].[BtcPrices] ADD CONSTRAINT [PK_BtcPrices] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

