CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin 
	select * from dbo.[User]
end
