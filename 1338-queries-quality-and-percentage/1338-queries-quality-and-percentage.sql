select query_name ,round(sum((rating/position))/count(query_name),2)'quality',round(AVG(rating<3)*100,2)'poor_query_percentage'
from queries 
WHERE query_name IS NOT NULL
group by query_name