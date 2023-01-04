CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FName nvarchar(50),
	@LName nvarchar(50)
as
begin
	Update dbo.[User] 
	set FName = @FName, Lname =@LName
	where Id = @Id;
end
