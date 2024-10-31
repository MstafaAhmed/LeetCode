SELECT y.id'Id'
FROM Weather x,Weather y
where dateDiff(y.recordDate,x.recordDate)=1 and x.Temperature<y.Temperature 