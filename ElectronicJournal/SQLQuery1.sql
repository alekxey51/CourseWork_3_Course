create database BDCourse
use BDCourse

create table Группа
(IDгруппы int not null identity,
[Номер группы] varchar(50) not null,
constraint CS_PK primary key (IDгруппы))

Insert into Группа ([Номер группы]) values ('Т-791')
Insert into Группа ([Номер группы]) values ('Т-792')
Insert into Группа ([Номер группы]) values ('Т-793')
Insert into Группа ([Номер группы]) values ('Т-794')
Insert into Группа ([Номер группы]) values ('Т-795')

create table Предмет
(IDпредмет int not null identity,
Название varchar(50) not null,
constraint CS_PK1 primary key (IDпредмет))

Insert into Предмет (Название) values ('КПиЯП')
Insert into Предмет (Название) values ('Практика')
Insert into Предмет (Название) values ('ТРПО')
Insert into Предмет (Название) values ('ЗКИ')
Insert into Предмет (Название) values ('Алгоритмизация')

create table Расписание
(IDрасписание int not null identity,
IDгруппы int not null,
IDпредмет int not null,
constraint CS_PK2 primary key (IDрасписание),
constraint CS_FK foreign key(IDгруппы) references Группа(IDгруппы) on delete cascade on update cascade,
constraint CS_FK1 foreign key(IDпредмет) references Предмет(IDпредмет) on delete cascade on update cascade)

Insert into Расписание (IDгруппы, IDпредмет) values (1, 1)
Insert into Расписание (IDгруппы, IDпредмет) values (1, 2)
Insert into Расписание (IDгруппы, IDпредмет) values (1, 3)
Insert into Расписание (IDгруппы, IDпредмет) values (2, 1)
Insert into Расписание (IDгруппы, IDпредмет) values (2, 3)
Insert into Расписание (IDгруппы, IDпредмет) values (3, 4)
Insert into Расписание (IDгруппы, IDпредмет) values (3, 5)
Insert into Расписание (IDгруппы, IDпредмет) values (4, 1)
Insert into Расписание (IDгруппы, IDпредмет) values (4, 3)
Insert into Расписание (IDгруппы, IDпредмет) values (5, 2)
Insert into Расписание (IDгруппы, IDпредмет) values (5, 5)

create table Студент 
(IDстудент int not null identity,
Фамилия varchar(50) not null,
Имя varchar(50) not null,
Отчество varchar(50) not null,
[Дата рождения] varchar(10) not null,
IDгруппы int not null,
constraint CS_PK3 primary key(IDстудент),
constraint CS_FK2 foreign key(IDгруппы) references Группа(IDгруппы) on delete cascade on update cascade)

Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Фёдоров', 'Станислав', 'Артемович', '21.08.2001', 1)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Орлов', 'Борис', 'Богуславович', '01.01.2000', 1)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Рожков', 'Иосиф', 'Онисимович', '10.03.2002', 1)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Антонов', 'Илларион', 'Пётрович', '20.05.2001', 2)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Вишняков', 'Георгий', 'Еремеевич', '16.07.2002', 2)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Чернов', 'Ян', 'Тимурович', '17.08.2001', 2)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Фёдоров', 'Харитон', 'Созонович', '21.01.2001', 3)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Баранов', 'Виктор', 'Иринеевич', '30.10.2000', 3)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Зайцев', 'Аввакум', 'Альбертович', '21.08.1999', 3)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Дмитриев', 'Аверьян', 'Дмитриевич', '06.10.2000', 4)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Субботин', 'Иннокентий', 'Максович', '15.07.2002', 4)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Горшков', 'Максим', 'Максович', '21.06.2001', 4)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Иванов', 'Вальтер', 'Авдеевич', '19.05.2000', 5)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Дроздов', 'Роберт', 'Мэлорович', '21.03.2001', 5)
Insert into Студент (Фамилия, Имя, Отчество, [Дата рождения], IDгруппы) values ('Беспалов', 'Велорий', 'Серапионович', '20.01.2001', 5)

create table Журнал 
(IDжурнал int not null identity,
Дата varchar(10) not null,
Оценка int,
Нка varchar(1),
Практика varchar(3),
Отработка varchar(3),
IDстудент int not null,
IDпредмет int not null,
constraint CS_PK4 primary key(IDжурнал),
constraint CS_FK3 foreign key(IDстудент) references Студент(IDстудент) on delete cascade on update cascade,
constraint CS_FK4 foreign key(IDпредмет) references Предмет(IDпредмет) on delete cascade on update cascade)

Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 5, NULL, 'Да', 'Да', 1, 1)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 3, NULL, 'Нет', 'Нет', 2, 2)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 3, NULL, 'Да', 'Да', 9, 1)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 6, NULL, 'Да', 'Да', 3, 3)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', NULL, 'Н', 'Нет', 'Да', 5, 5)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 8, NULL, 'Нет', 'Да', 7, 2)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 4, NULL, 'Да', 'Да', 6, 1)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 0, NULL, 'Да', 'Нет', 4, 4)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 4, NULL, 'Нет', 'Да', 8, 5)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 6, NULL, 'Да', 'Нет', 3, 3)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 10, NULL, 'Нет', 'Да', 10, 2)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', NULL, 'Н', 'Да', 'Да', 8, 1)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 7, NULL, 'Да', 'Нет', 3, 4)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 8, NULL, 'Нет', 'Да', 9, 3)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 4, NULL, 'Да', 'Да', 3, 2)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 6, NULL, 'Нет', 'Нет', 2, 1)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', NULL, 'Н', 'Да', 'Да', 2, 1)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 9, NULL, 'Да', 'Да', 5, 5)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', 4, NULL, 'Да', 'Нет', 4, 3)
Insert into Журнал (Дата, Оценка, Нка, Практика, Отработка, IDстудент, IDпредмет) values ('20.01.2001', NULL, 'Н', 'Да', 'Да', 4, 2)