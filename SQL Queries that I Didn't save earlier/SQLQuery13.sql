SELECT given_name, surname
FROM [User] t1
FULL OUTER JOIN [Job] t2 ON t1.user_id = t2.member_user_id 
FULL OUTER JOIN [Member] t3 ON t1.user_id = t3.member_user_id
WHERE t2.required_caregiving_type = 'Elderly Care'
AND t3.house_rules = 'No pets.' ;