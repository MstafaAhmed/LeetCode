select  u.name,sum(t.amount)as'balance'
from Users u ,Transactions  t
where t.account =u.account    
group by u.name  
having sum(t.amount)>10000