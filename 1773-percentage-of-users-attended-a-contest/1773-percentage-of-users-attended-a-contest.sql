select  r.contest_id , round((count(distinct( r.user_id))/count(distinct(u.user_id)))*100,2) 'percentage' 
from Users u , Register r 
group by r.contest_id  
order by percentage desc ,r.contest_id asc



