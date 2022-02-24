CREATE VIEW JobsAndJobApplications
	AS

	SELECT DISTINCT t1.job_id, t1.required_caregiving_type , t1.date_posted, t2.given_name as PostedBy,
		t2.surname PostedBySurname,
        t3.date_applied as DateApplied, t4.hourly_rate as CaregiverHourlyRate, t4.caregiving_type as CaregiverType
	FROM [Job] t1
	INNER JOIN [User] t2 ON t1.member_user_id = t2.user_id
	FULL OUTER JOIN [Job_Application] t3
	FULL OUTER JOIN [Caregiver] t4 ON t3.caregiver_user_id = t4.caregiver_user_id
	CROSS JOIN [Member] t5 ON t1.member_user_id = t5.member_user_id
	WHERE t1.job_id = t3.job_id;
