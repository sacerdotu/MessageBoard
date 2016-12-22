﻿CREATE TABLE tblComment
(
CommentID int IDENTITY(1,1) PRIMARY KEY,
UserID INT ,
FK_tblPost INT FOREIGN KEY REFERENCES tblPost(PostID) NULL,
MainComment INT FOREIGN KEY REFERENCES tblComment(CommentID) NULL,
CommentContent NVARCHAR(1000) NOT NULL,
IsBlocked BIT NOT NULL,
PostDate DATE NOT NULL, 
    CONSTRAINT [FK_tblComment_tblUser] FOREIGN KEY (UserID) REFERENCES tblUser(UserID), 
);