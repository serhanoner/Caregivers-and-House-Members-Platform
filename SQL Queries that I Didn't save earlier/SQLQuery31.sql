SELECT	t2.given_name as CaregiverName, t2.surname, 
		 t3.hourly_rate as HourlyRate,
        t1.appointment_id,  t1.appointment_date_time, t1.status,
        t1.work_hours as WorkHours,
        t1.work_hours*t3.hourly_rate as TotalEarnings
	FROM [Appointment] t1, [User] t2, [Caregiver] t3, [Job_Application] t4
	WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED' AND t1.caregiver_user_id = t3.caregiver_user_id
	GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname, t3.hourly_rate, t1.appointment_id, t1.appointment_date_time, t1.work_hours, t1.status
	order by t1.appointment_id ASC;