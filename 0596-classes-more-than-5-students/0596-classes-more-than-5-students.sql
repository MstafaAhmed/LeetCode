select distinct class from courses group by class having (count(distinct student)>= 5) order by class
 
