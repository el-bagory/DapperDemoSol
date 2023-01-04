CREATE PROCEDURE [dbo].[spUser_GetDelet]
	@Id int
AS
begin 
	delete  
	from dbo.[User]
	Where Id = @Id;
end
