SELECT caregiver_user_id, t3.given_name, t3.surname
FROM [Job_Application] t1
FULL OUTER JOIN [Job] t2 ON t1.job_id = t2.job_id
INNER JOIN [User] t3 ON t1.caregiver_user_id = t3.user_id
WHERE t2.other_requirements LIKE '%Gentle%'