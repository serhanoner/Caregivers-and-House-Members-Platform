select caregiver_user_id
from [Job_Application] t1
FULL OUTER JOIN [Job] t2 ON t1.job_id = t2.job_id
WHERE t2.other_requirements LIKE '%Gentle%';