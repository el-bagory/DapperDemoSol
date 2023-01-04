CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
AS
begin 
	delete  
	from dbo.[User]
	Where Id = @Id;
end
