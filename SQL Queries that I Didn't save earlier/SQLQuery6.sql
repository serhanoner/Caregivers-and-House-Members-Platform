DROP TABLE Appointment;

CREATE TABLE Appointment(
  appointment_id INT NOT NULL,
  caregiver_user_id INT NOT NULL,
  member_user_id INT NOT NULL,
  appointment_date_time datetime not null,
  work_hours INT NOT NULL,
  status VARCHAR(15) NOT NULL,
  
  primary key(appointment_id),

  CONSTRAINT fk_appointment_member_member_user_id 
    FOREIGN KEY (member_user_id) REFERENCES member(member_user_id)
    on update no action
    on delete no action,
    
  CONSTRAINT fk_appointment_caregiver_caregiver_user_id 
    FOREIGN KEY (caregiver_user_id) REFERENCES caregiver(caregiver_user_id)
    on update no action
    on delete no action 

  );
       