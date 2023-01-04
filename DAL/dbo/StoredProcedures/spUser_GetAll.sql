CREATE PROCEDURE [dbo].[spUser_GetAll]
	@Id int
AS
begin 
	select * 
	from dbo.[User]
	Where Id = @Id;
end
