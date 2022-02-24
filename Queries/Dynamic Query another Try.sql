SELECT J.job_id, J.required_caregiving_type, 
           CAST(J.other_requirements AS NVARCHAR(200)) OtherRequirements, J.date_posted, 
		   Ja.date_applied as DateApplied, 

                U.given_name as AppliedBy, U.surname AppliedSurname, 
                C.hourly_rate as CaregiverHourlyRate, C.caregiving_type as CaregiverType 
                
                FROM [Job] J 
               
                INNER JOIN [Member] M ON M.member_user_id = J.member_user_id 
                INNER JOIN [Caregiver] C ON C.caregiving_type = J.required_caregiving_type 
                INNER JOIN [User] U ON C.caregiver_user_id = U.user_id--OR U.user_id = M.member_user_id 
                     
                INNER JOIN [Job_Application] Ja ON Ja.caregiver_user_id = C.caregiver_user_id 

                WHERE J.required_caregiving_type LIKE '%BABY%' OR J.other_requirements LIKE '%BABY%' 
                 AND Ja.caregiver_user_id = C.caregiver_user_id 

                GROUP BY J.job_id, J.required_caregiving_type, CAST(J.other_requirements AS NVARCHAR(200)), 
                 J.date_posted, U.given_name, U.surname, C.hourly_rate, C.caregiving_type, Ja.date_applied
                ORDER BY J.job_id ;