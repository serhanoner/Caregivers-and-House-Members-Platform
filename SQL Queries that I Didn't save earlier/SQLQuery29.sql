SELECT J.job_id, J.required_caregiving_type, J.date_posted
FROM [Job] J
INNER JOIN [Member] M ON M.member_user_id = J.member_user_id
INNER JOIN [Caregiver] C ON C.caregiving_type = J.required_caregiving_type
GROUP BY J.job_id, J.required_caregiving_type,J.date_posted
ORDER BY J.job_id;