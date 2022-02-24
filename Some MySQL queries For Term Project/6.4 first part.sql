(SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname,
		sum(t1.hourly_rate)
    FROM caregiver t1, user t2
    GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname);