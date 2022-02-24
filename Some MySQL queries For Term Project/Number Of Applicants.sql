SELECT DISTINCT t1.job_id, t2.given_name, t2.surname, t1.required_caregiving_type, COUNT(t3.caregiver_user_id) as NumberOfApplicants
FROM job t1, user t2, job_application t3
WHERE t2.user_id = t1.member_user_id and t1.job_id = t3.job_id
GROUP BY t1.job_id, t3.job_id
order by t1.job_id ASC;