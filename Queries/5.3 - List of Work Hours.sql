SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, 
		t1.work_hours as TotalWorkHours

    FROM [Appointment] t1, [User] t2, [Caregiver] t3
    WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED' AND t3.caregiving_type = 'Baby Sitter'

    GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname, t1.work_hours
    order by t1.caregiver_user_id ASC;
