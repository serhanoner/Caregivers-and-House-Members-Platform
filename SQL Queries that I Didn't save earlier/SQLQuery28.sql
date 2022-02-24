SELECT AVG(t1.hourly_rate) as AveragePay, t3.work_hours as WorkHours, (AVG(t1.hourly_rate)*t3.work_hours) as AverageOfEarnings
FROM [Caregiver] t1, [Appointment] t3
WHERE t3.status = 'ACCEPTED' 
GROUP BY (t3.work_hours);