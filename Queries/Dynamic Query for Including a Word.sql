SELECT J.job_id, J.required_caregiving_type, CAST(J.other_requirements AS NVARCHAR(200)) OtherRequirements, J.date_posted, 
	JA.date_applied,
	U.given_name as AppliedBy, U.surname AppliedBySurname,
	C.hourly_rate as CaregiverHourlyRate, C.caregiving_type as CaregiverType
FROM [Job] J
INNER JOIN [Member] M ON M.member_user_id = J.member_user_id
INNER JOIN [Caregiver] C ON C.caregiving_type = J.required_caregiving_type
INNER JOIN [User] U ON C.caregiver_user_id = U.user_id --OR U.user_id = M.member_user_id
INNER JOIN [Job_Application] JA ON JA.caregiver_user_id = C.caregiver_user_id
WHERE J.required_caregiving_type LIKE '%Baby%' OR J.other_requirements LIKE '%Baby%' 
GROUP BY J.job_id, J.required_caregiving_type, CAST(J.other_requirements AS NVARCHAR(200)), 
		J.date_posted, U.given_name, U.surname, C.hourly_rate, C.caregiving_type, JA.date_applied
ORDER BY J.job_id;