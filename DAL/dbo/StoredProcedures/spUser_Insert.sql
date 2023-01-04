CREATE PROCEDURE [dbo].[spUser_Insert]
	@FName nvarchar(50),
	@LName nvarchar(50)
as
begin
	insert into dbo.[User] ( FName, Lname)
	Values ( @FName, @LName)
end
