CREATE TABLE [dbo].[Users] (
    [User_id] INT NOT NULL,
    [User_name]      VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [Job]    VARCHAR (50) NOT NULL,
    [E_mail]  NVARCHAR(50)          NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([User_id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'权限', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Users', @level2type = N'COLUMN', @level2name = 'E_mail';

