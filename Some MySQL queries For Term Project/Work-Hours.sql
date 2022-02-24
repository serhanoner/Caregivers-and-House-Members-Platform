SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, SUM(t1.work_hours) as TotalWorkHours
FROM appointment t1, user t2
WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED'
GROUP BY t1.caregiver_user_id
order by t1.caregiver_user_id ASC;