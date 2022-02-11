create database evdekiBakicim;
use evdekiBakicim;

create table user(
user_id int(11) not null auto_increment,
email varchar(50) not null,
given_name varchar(50) not null,
surname varchar(50) not null,
city varchar(50) not null,
phone_number varchar(20) not null,
profile_description text not null,
password varchar(50) not null,

primary key (user_id),
unique (email)
);


CREATE TABLE caregiver (
  `caregiver_user_id` INT(11) NOT NULL,
  `photo` text NOT NULL,
  `gender` char(1) not null,
  `caregiving_type` varchar(50) not null,
  `hourly_rate` decimal(10,2),
  
  CONSTRAINT fk_caregiver_user_user_id 
    FOREIGN KEY (caregiver_user_id) REFERENCES user(user_id)
    on update cascade
    on delete cascade
  );


CREATE TABLE member(
  `member_user_id` INT(11) NOT NULL,
  `house_rules` text NOT NULL,
  
  CONSTRAINT fk_member_user_user_id 
    FOREIGN KEY (member_user_id) REFERENCES user(user_id)
    on update cascade
    on delete cascade
  );


CREATE TABLE job(
  `job_id` INT(11) NOT NULL auto_increment,
  `member_user_id` INT(11) NOT NULL,
  `required_caregiving_type` varchar(50) not null,
  `other_requirements` text not null,
  `date_posted` date not null,
  
  primary key(`job_id`),
  
  CONSTRAINT fk_job_member_member_user_id 
    FOREIGN KEY (member_user_id) REFERENCES member(member_user_id)
    on update cascade
    on delete cascade
  );


CREATE TABLE job_application(
  `caregiver_user_id` INT(11) NOT NULL,
  `job_id` INT(11) not null,
  `date_applied` date not null,
  
  CONSTRAINT fk_job_application_job_job_id 
    FOREIGN KEY (job_id) REFERENCES job(job_id)
    on update cascade
    on delete cascade,
    
  CONSTRAINT fk_job_application_caregiver_caregiver_user_id 
    FOREIGN KEY (caregiver_user_id) REFERENCES caregiver(caregiver_user_id)
    on update cascade
    on delete cascade
  
  );

CREATE TABLE appointment(
  `appointment_id` INT(11) NOT NULL auto_increment,
  `caregiver_user_id` INT(11) NOT NULL,
  `member_user_id` INT(11) NOT NULL,
  `appointment_date_time` datetime not null,
  `work_hours` INT(11) NOT NULL,
  `status` VARCHAR(15) NOT NULL,
  
  primary key(`appointment_id`),
  
  CONSTRAINT fk_appointment_member_member_user_id 
    FOREIGN KEY (member_user_id) REFERENCES member(member_user_id)
    on update cascade
    on delete cascade,
    
  CONSTRAINT fk_appointment_caregiver_caregiver_user_id 
    FOREIGN KEY (caregiver_user_id) REFERENCES caregiver(caregiver_user_id)
    on update cascade
    on delete cascade        
  
  );



CREATE TABLE address(
  `member_user_id` INT(11) NOT NULL,
  `house_number` varchar(50) not null,
  `street` varchar(50) not null,
  `town` varchar(50) not null,
  
  CONSTRAINT fk_address_member_member_user_id 
    FOREIGN KEY (member_user_id) REFERENCES member(member_user_id)
    on update cascade
    on delete cascade
    
  );



# INSERTIONS

# into user table first
insert into user values(1 ,'a.yilmaz@yahoo.com','Ayse','Yilmaz', 'Edirne', '535-323-5252',
							'New to caregiving', 'ayse1234');
insert into user(email, given_name, surname, city, phone_number, profile_description, password) 
values('acetinkaya.gmail.com','Ahmet','Cetinkaya', 'Istanbul','532-993-0117',
'Likes to give care to old people', 'acetinkaya');
 
 
insert into user values(3, 'd.karaca@hotmail.com','Damla','Karaca', 'Ankara', 
'535-123-0121', 'More than 5 years of experience in caregiving', '12345678');

insert into user values(4 ,'altinosman@gmail.com','Osman','Altin', 'Istanbul', 
'533-993-0642', 'Just a guy who needs caregiving', 'osman0642');

insert into user values(5 ,'ali.yilmaz@hotmail.com','Ali','Yilmaz', 'Istanbul', 
'532-572-4312', 'A dad with a lot on his hands and needs help taking care of kids', '46mngrk3');

insert into user values(6 ,'pinaryilmaz@hotmail.com','Pinar','Yilmaz', 'Ankara', 
'535-553-4351', 'In need of caregiving', 'pnrylmz');
insert into user values(7 ,'celikmustafa@gmail.com','Mustafa','Celik', 'Izmir', 
'534-642-4531', 'New to caregiving', 'musfsfsa');
insert into user values(8 ,'eminedemir@hotmail.com','Emine','Demir', 'Istanbul', 
'533-721-3704', 'In need of caregiving', 'demire43');
insert into user values(9 ,'elifbusra@gmail.com','Elif','Busra', 'Istanbul', 
'532-248-8754', 'More than 5 years of experience in caregiving', 'busra343mf');
insert into user values(10 ,'kayahatice55@hotmail.com','Hatice','Kaya', 'Ankara', 
'535-463-6328', 'Likes to give care to old people', 'kayahat43');


insert into user values(11 ,'kocakzeynep@gmail.com','Zeynep','Kocak', 'Istanbul', 
'533-231-9843', 'Likes to give care to old people', 'kocak3843');
insert into user values(12 ,'m.karaca@hotmail.com','Mehmet','Karaca', 'Ankara', 
'532-463-6093', 'More than 5 years of experience in caregiving', 'karacamehmet4343');

insert into user values(13 ,'atesmahmut@gmail.com','Mahmut','Ates', 'Istanbul', 
'533-127-6842', 'Just a guy who needs caregiving', 'mahmutfire66');
insert into user values(14 ,'hasan.yilmaz@hotmail.com','Hasan','Yilmaz', 'Istanbul', 
'535-528-1167', 'A dad with a lot on his hands and needs help taking care of kids', 'hasan1985');

insert into user values(15 ,'huseyin.yilmazer@gmail.com','Hüseyin','Yilmazer', 'Ankara', 
'532-685-5371', 'In need of caregiving', 'hsynankara06');
insert into user values(16 ,'mozturk@gmail.com','Murat','Ozturk', 'Izmir', 
'532-464-1752', 'New to caregiving', 'ozturk35murat');

insert into user values(17 ,'emrek@hotmail.com','Emre','Kubra', 'Istanbul', 
'533-353-5313', 'In need of caregiving', 'kubraemre4542');
insert into user values(18 ,'ibrkaya@gmail.com','brahim','Kaya', 'Istanbul', 
'533-5311-5313', 'More than 5 years of experience in caregiving', 'kaya.ibrahim1988');

insert into user values(19 ,'demiromer@hotmail.com','Ömer','Demir', 'Ankara', 
'535-138-6422', 'Likes to give care to old people', '64demiromer');
insert into user values(20 ,'duygusahin@gmail.com','Duygu','Sahin', 'Ankara', 
'532-224-2461', 'Likes to give care to old people', 'duyguadae3');
 
 
 # into caregiver table
insert into caregiver values(1, 'photos/a.yilmaz.png', 'F', 'Baby Sitter', 7.50);
insert into caregiver values(2, 'photos/a.cetinkaya.png', 'M', 'Elderly Care', 9.50);
insert into caregiver values(3, 'photos/d.karaca.png', 'F', 'Baby Sitter', 10);
insert into caregiver values(7, 'photos/m.celik.png', 'M', 'Baby Sitter', 9.50);
insert into caregiver values(9, 'photos/e.busra.png', 'F', 'Baby Sitter', 10);
insert into caregiver values(10, 'photos/h.kaya.png', 'F', 'Elderly Care', 7.50);
insert into caregiver values(11, 'photos/z.kocak.png', 'F', 'Elderly Care', 9.50);
insert into caregiver values(12, 'photos/m.karaca.png', 'M', 'Baby Sitter', 7.0);
insert into caregiver values(16, 'photos/m.ozturk.png', 'M', 'Baby Sitter', 11.2);
insert into caregiver values(18, 'photos/i.kaya.png', 'M', 'Baby Sitter', 9.3);
insert into caregiver values(19, 'photos/o.demir.png', 'F', 'Elderly Care', 6.4);
insert into caregiver values(20, 'photos/d.sahin.png', 'F', 'Elderly Care', 5.3);

# forgot the primary key of caregiver table;

ALTER TABLE `caregiver`
  ADD PRIMARY KEY (`caregiver_user_id`);

# insertions to the member table;

insert into member values(4, 'No pets.');
insert into member values(6, 'No pets.');
insert into member values(13, 'No pets.');
insert into member values(14, 'No pets.');
insert into member values(5, 'No allowed to touch the fridge.');
insert into member values(8, 'No allowed to touch the fridge.');
insert into member values(15, 'No allowed to touch the fridge.');
insert into member values(17, 'No allowed to touch the fridge.');

# forgot the primary key of member table;

ALTER TABLE `member`
  ADD PRIMARY KEY (`member_user_id`);
  
# forgot the primary key of address table;

ALTER TABLE `address`
  ADD PRIMARY KEY (`member_user_id`);

#insertion into address table;
insert into address values(4, 4570, 'Bayrampasa Street', 'Istanbul');
insert into address values(5, 241, 'Fahrettin Kerim Gokay Street', 'Istanbul');
insert into address values(6, 4214, 'Arjantin Street', 'Ankara');
insert into address values(8, 5313, 'Kadirgalar Street' ,'Istanbul');
insert into address values(13, 513 ,'Cumhuriyet Street' ,'Istanbul');
insert into address values(14, 517,'Kalamis Street', 'Istanbul');
insert into address values(15, 442,'Tunali Hilmi Street', 'Ankara');
insert into address values(17, 724, 'Kalamis Street','Istanbul');

#insertion into job table;

insert into job values(1, 4, 'Elderly Care', 'Someone who is energetic that can 
assist me in doing activity work around
the house. Must be available during weekdays', '2021-01-01' );

insert into job values(2, 5, 'Baby Sitter', 'Gentle and capable of handling very
active kids on weekends', '2021-01-02' );

insert into job values(3, 6, 'Elderly Care', 'I need someone to look after my
grandmother during weekends', '2021-01-03');

insert into job values(4, 13, 'Elderly Care', 'I need someone to look after my
dad during weekends', '2021-01-04');

insert into job values(5, 17, 'Baby Sitter', 'I need someone to look after my
kids during weekends', '2021-01-05');




# insertions into job_application table;

insert into job_application values(2, 1, '2021-01-03');
insert into job_application values(10, 1, '2021-01-04');
insert into job_application values(12, 2, '2021-01-05');
insert into job_application values(16, 2, '2021-01-06');
insert into job_application values(20, 3, '2021-01-07');
insert into job_application values(7, 4, '2021-01-08');
insert into job_application values(19, 5, '2021-01-011');


# insertions into appointment table;
SET FOREIGN_KEY_CHECKS=0;
insert into appointment values(1, 2, 4, '2021-01-07 08:30:00', 5, 'ACCEPTED');
insert into appointment values(2, 10, 6, '2021-01-15 09:00:00', 3,'ACCEPTED');
insert into appointment values(3, 9, 5, '2021-01-12 10:30:00', 6, 'ACCEPTED');
insert into appointment values(4, 10, 4, '2021-01-10 11:00:00', 8, 'DECLINED');
insert into appointment values(5, 20, 6, '2021-01-11 11:30:00', 4, 'ACCEPTED');
insert into appointment values(6, 9, 17, '2021-01-12 12:00:00', 8, 'DECLINED');



Update caregiver SET hourly_rate = hourly_rate * 1.1 WHERE hourly_rate >= 9;
SET SQL_SAFE_UPDATES = 0;
Update caregiver SET hourly_rate = hourly_rate + 0.5 WHERE hourly_rate < 9;


# deletions;
DELETE t1 
FROM job t1
INNER JOIN member t2 ON t1.member_user_id = t2.member_user_id
INNER JOIN user t3 ON t2.member_user_id = t3.user_id
WHERE t3.given_name='Pinar' and t3.surname = 'Yilmaz';



# deleting members who live in Kadirgalar Street;
delete t1
from user t1
INNER JOIN member t2 ON t1.user_id = t2.member_user_id
INNER JOIN address t3 ON t2.member_user_id = t3.member_user_id
WHERE t3.street = 'Kadirgalar Street';
