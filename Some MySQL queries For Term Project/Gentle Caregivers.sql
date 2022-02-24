select caregiver_user_id
from job_application t1
CROSS JOIN job t2 ON t1.job_id = t2.job_id
WHERE t2.other_requirements LIKE '%Gentle%';