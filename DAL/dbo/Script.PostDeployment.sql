if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FName, LName)
	Values ('Admin','Admin' ), ('ITAdmin', 'ITAdmin');
end
