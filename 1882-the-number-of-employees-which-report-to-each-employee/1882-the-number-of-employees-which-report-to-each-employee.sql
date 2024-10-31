select e.employee_id,e.name,count(m.reports_to)'reports_count',round(avg(m.age))'average_age' from Employees e,Employees m where e.employee_id=m.reports_to group by employee_id order by employee_id
