select distinct activity_date 'day' , count(distinct(user_id))'active_users' from Activity where activity_date <= '2019-7-27' AND activity_date > '2019-6-27' group by activity_date


