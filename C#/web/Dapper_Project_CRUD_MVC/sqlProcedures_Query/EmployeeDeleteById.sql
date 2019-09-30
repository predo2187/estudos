create proc EmployeeDeleteById
@EmployeeId int as delete from tblEmployee where EmployeeId = @EmployeeId;