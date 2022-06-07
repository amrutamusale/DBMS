Create database SampleD2;
Drop database SampleD2;
use SampleD1

--Create table
/*
create table <TABLE NAME>(<columns> data-type)
*/
create table sample(id int, name varchar(200))
 
insert into sample values(1, 'Amu 1');
insert into sample values(2, 'Amu 2');
insert into sample valueS(3, 'Amu 3');
insert into sample values(4, 'Amu 4');

alter table sample Add int salary;
alter table sample Drop column salary;
delete from sample where id =1;

select * from sample
update sample set name = 'Amruta' where id=2;



