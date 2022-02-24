SELECT given_name, surname
FROM user t1
CROSS JOIN job t2 ON t1.user_id = t2.member_user_id 
CROSS JOIN member t3 ON t1.user_id = t3.member_user_id
WHERE t2.required_caregiving_type = 'Elderly Care'
AND t3.house_rules = 'No pets.' ;
