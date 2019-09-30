create proc EmployeeAddOrEdit
@EmployeeId int,
@Name varchar(50),
@Position varchar(50),
@Age int,
@Salary int
	as
		if @EmployeeId = 0 
			insert into tblEmployee(Name,Position,Age,Salary) 
							values (@Name,@Position,@Age,@Salary);

		else
			update tblEmployee set Name = @Name,
								   Position = @Position,
								   Age = @Age,
								   Salary = @Salary 
								   where EmployeeId = @EmployeeId;