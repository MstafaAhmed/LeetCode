select max(salary)'SecondHighestSalary'from employee where salary !=(select maX(salary)from employee)
