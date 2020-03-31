-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-03-22 07:12:20.376

drop table Student


-- tables
-- Table: Enrollment
CREATE TABLE EnrollmentN (
    IdEnrollment int  NOT NULL,
    Semester int  NOT NULL,
    IdStudy int  NOT NULL,
    StartDate date  NOT NULL,
    CONSTRAINT Enrollment_pk PRIMARY KEY  (IdEnrollment)
);

-- Table: Student
CREATE TABLE StudentN (
    IndexNumber nvarchar(100)  NOT NULL,
    FirstName nvarchar(100)  NOT NULL,
    LastName nvarchar(100)  NOT NULL,
    BirthDate date  NOT NULL,
    IdEnrollment int  NOT NULL,
    CONSTRAINT Student_pkN PRIMARY KEY  (IndexNumber)
);

-- Table: Studies
CREATE TABLE StudiesN (
    IdStudy int  NOT NULL,
    Name nvarchar(100)  NOT NULL,
    CONSTRAINT Studies_pkN PRIMARY KEY  (IdStudy)
);

-- foreign keys
-- Reference: Enrollment_Studies (table: Enrollment)
ALTER TABLE EnrollmentN ADD CONSTRAINT Enrollment_StudiesN
    FOREIGN KEY (IdStudy)
    REFERENCES StudiesN (IdStudy);

-- Reference: Student_Enrollment (table: Student)
ALTER TABLE StudentN ADD CONSTRAINT Student_Enrollment
    FOREIGN KEY (IdEnrollment)
    REFERENCES EnrollmentN (IdEnrollment);

-- End of file.
insert into StudiesN values (1,'IT');
insert into EnrollmentN values (1,1,1,'12/12/2015');
insert into StudentN values ('s18693','Halina','Jajeworowa','12/12/2015',1);

select * from StudentN;
select * from EnrollmentN;
select * from StudiesN;

select StudentN.FirstName, StudentN.LastName, EnrollmentN.Semester from StudentN
inner join EnrollmentN on StudentN.IdEnrollment = EnrollmentN.IdEnrollment
where StudentN.IndexNumber = 's18693';

select StudiesN.IdStudy from StudiesN where StudiesN.Name = 'IT';

go
create procedure findStudiesN
@id int
as
select * from StudiesN
where StudiesN.IdStudy = @id;

exec findStudiesN 1