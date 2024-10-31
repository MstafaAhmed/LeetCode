select product_name,sum(unit)'unit'
from products p, orders o
where p.product_id=o.product_id and order_date between '2020-2-1'and'2020-2-29'
group by product_name
having sum(unit)>=100
