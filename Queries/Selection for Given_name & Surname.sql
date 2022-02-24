SELECT given_name, surname
FROM [User] t1
FULL OUTER JOIN [Appointment] t2 ON t1.user_id = t2.member_user_id OR t1.user_id = t2.caregiver_user_id
WHERE t2.status = 'ACCEPTED';
