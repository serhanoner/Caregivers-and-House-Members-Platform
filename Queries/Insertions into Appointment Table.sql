ALTER TABLE [Appointment]
      NOCHECK CONSTRAINT ALL;
GO


insert into [Appointment] values(1, 2, 4, '2021-01-07 08:30:00', 5, 'ACCEPTED');
insert into [Appointment] values(2, 10, 6, '2021-01-15 09:00:00', 3,'ACCEPTED');
insert into [Appointment] values(3, 9, 5, '2021-01-12 10:30:00', 6, 'ACCEPTED');
insert into [Appointment] values(4, 10, 4, '2021-01-10 11:00:00', 8, 'DECLINED');
insert into [Appointment] values(5, 20, 6, '2021-01-11 11:30:00', 4, 'ACCEPTED');
insert into [Appointment] values(6, 9, 17, '2021-01-12 12:00:00', 8, 'DECLINED');


ALTER TABLE [Appointment]
    CHECK CONSTRAINT ALL;
GO