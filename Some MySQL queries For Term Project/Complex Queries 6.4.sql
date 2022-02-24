WITH totalSalary(caregiver_user_id, firstname, surname, total) as
    (SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname,
		sum(t1.hourly_rate)
    FROM caregiver t1, user t2
    GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname),
    
caregiverAverage(caregiver_user_id, firstname, surname, total_work_hours, avgSalary) as 
    (SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, 
		t1.work_hours, avg(t3.hourly_rate)
	FROM appointment t1, user t2, caregiver t3
	WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED'
	GROUP BY t1.caregiver_user_id
	order by t1.caregiver_user_id ASC )
    
SELECT  t5.caregiver_user_id, t5.firstname, t5.surname, t5.total*t6.total_work_hours as TotalEarnings
FROM totalSalary t5
INNER JOIN caregiverAverage t6 on t5.caregiver_user_id = t6.caregiver_user_id
WHERE t5.total > t6.avgSalary AND t5.firstname = t6.firstname ;