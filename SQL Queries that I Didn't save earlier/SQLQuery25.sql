SELECT AVG(t1.hourly_rate) as HourlyRate, t2.work_hours as WorkHours, AVG((t1.hourly_rate)*t2.work_hours) as AverageOfEarnings
FROM [Caregiver] t1
INNER JOIN [Appointment] t2 ON t1.caregiver_user_id = t2.caregiver_user_id 
WHERE t2.status = 'ACCEPTED'
GROUP BY t2.work_hours;