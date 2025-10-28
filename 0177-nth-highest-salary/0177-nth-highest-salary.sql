CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    if @N <=0 return null;
    RETURN (
        select distinct salary from employee
        order by salary desc
        offset @N-1 rows
        fetch next 1 rows only

    );
END