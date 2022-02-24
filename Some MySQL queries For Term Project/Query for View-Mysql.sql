drop view JobsAndJobApplications;

CREATE VIEW JobsAndJobApplications AS
SELECT DISTINCT t1.job_id, t1.required_caregiving_type , t1.date_posted, t2.given_name as PostedBy,
		t2.surname PostedBySurname,
        # t2.given_name as AppliedBy, t2.surname as AppliedBySurname,
        t3.date_applied as DateApplied, t4.hourly_rate as CaregiverHourlyRate, t4.caregiving_type as CaregiverType
FROM job t1
INNER JOIN user t2 ON t1.member_user_id = t2.user_id
CROSS JOIN job_application t3
CROSS JOIN caregiver t4 ON t3.caregiver_user_id = t4.caregiver_user_id
CROSS JOIN member t5 ON t1.member_user_id = t5.member_user_id
WHERE t1.job_id = t3.job_id
ORDER BY t1.job_id;

SELECT * FROM JobsAndJobApplications;
