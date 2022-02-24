SELECT given_name, surname
FROM user t1
CROSS JOIN appointment t2 ON t1.user_id = t2.member_user_id OR t1.user_id = t2.caregiver_user_id
WHERE t2.status = 'ACCEPTED';
