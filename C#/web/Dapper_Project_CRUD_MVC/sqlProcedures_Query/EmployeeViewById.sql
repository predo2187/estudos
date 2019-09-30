create proc EmployeeViewById
@EmployeeId int as select * from tblEmployee where EmployeeId = @EmployeeId;
	