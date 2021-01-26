create database BDCourse
use BDCourse

create table ������
(ID������ int not null identity,
[����� ������] varchar(50) not null,
constraint CS_PK primary key (ID������))

Insert into ������ ([����� ������]) values ('�-791')
Insert into ������ ([����� ������]) values ('�-792')
Insert into ������ ([����� ������]) values ('�-793')
Insert into ������ ([����� ������]) values ('�-794')
Insert into ������ ([����� ������]) values ('�-795')

create table �������
(ID������� int not null identity,
�������� varchar(50) not null,
constraint CS_PK1 primary key (ID�������))

Insert into ������� (��������) values ('�����')
Insert into ������� (��������) values ('��������')
Insert into ������� (��������) values ('����')
Insert into ������� (��������) values ('���')
Insert into ������� (��������) values ('��������������')

create table ����������
(ID���������� int not null identity,
ID������ int not null,
ID������� int not null,
constraint CS_PK2 primary key (ID����������),
constraint CS_FK foreign key(ID������) references ������(ID������) on delete cascade on update cascade,
constraint CS_FK1 foreign key(ID�������) references �������(ID�������) on delete cascade on update cascade)

Insert into ���������� (ID������, ID�������) values (1, 1)
Insert into ���������� (ID������, ID�������) values (1, 2)
Insert into ���������� (ID������, ID�������) values (1, 3)
Insert into ���������� (ID������, ID�������) values (2, 1)
Insert into ���������� (ID������, ID�������) values (2, 3)
Insert into ���������� (ID������, ID�������) values (3, 4)
Insert into ���������� (ID������, ID�������) values (3, 5)
Insert into ���������� (ID������, ID�������) values (4, 1)
Insert into ���������� (ID������, ID�������) values (4, 3)
Insert into ���������� (ID������, ID�������) values (5, 2)
Insert into ���������� (ID������, ID�������) values (5, 5)

create table ������� 
(ID������� int not null identity,
������� varchar(50) not null,
��� varchar(50) not null,
�������� varchar(50) not null,
[���� ��������] varchar(10) not null,
ID������ int not null,
constraint CS_PK3 primary key(ID�������),
constraint CS_FK2 foreign key(ID������) references ������(ID������) on delete cascade on update cascade)

Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('Ը�����', '���������', '���������', '21.08.2001', 1)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('�����', '�����', '������������', '01.01.2000', 1)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('������', '�����', '����������', '10.03.2002', 1)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('�������', '��������', 'ϸ������', '20.05.2001', 2)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('��������', '�������', '���������', '16.07.2002', 2)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('������', '��', '���������', '17.08.2001', 2)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('Ը�����', '�������', '���������', '21.01.2001', 3)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('�������', '������', '���������', '30.10.2000', 3)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('������', '�������', '�����������', '21.08.1999', 3)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('��������', '�������', '����������', '06.10.2000', 4)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('��������', '����������', '��������', '15.07.2002', 4)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('�������', '������', '��������', '21.06.2001', 4)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('������', '�������', '��������', '19.05.2000', 5)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('�������', '������', '���������', '21.03.2001', 5)
Insert into ������� (�������, ���, ��������, [���� ��������], ID������) values ('��������', '�������', '������������', '20.01.2001', 5)

create table ������ 
(ID������ int not null identity,
���� varchar(10) not null,
������ int,
��� varchar(1),
�������� varchar(3),
��������� varchar(3),
ID������� int not null,
ID������� int not null,
constraint CS_PK4 primary key(ID������),
constraint CS_FK3 foreign key(ID�������) references �������(ID�������) on delete cascade on update cascade,
constraint CS_FK4 foreign key(ID�������) references �������(ID�������) on delete cascade on update cascade)

Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 5, NULL, '��', '��', 1, 1)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 3, NULL, '���', '���', 2, 2)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 3, NULL, '��', '��', 9, 1)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 6, NULL, '��', '��', 3, 3)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', NULL, '�', '���', '��', 5, 5)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 8, NULL, '���', '��', 7, 2)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 4, NULL, '��', '��', 6, 1)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 0, NULL, '��', '���', 4, 4)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 4, NULL, '���', '��', 8, 5)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 6, NULL, '��', '���', 3, 3)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 10, NULL, '���', '��', 10, 2)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', NULL, '�', '��', '��', 8, 1)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 7, NULL, '��', '���', 3, 4)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 8, NULL, '���', '��', 9, 3)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 4, NULL, '��', '��', 3, 2)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 6, NULL, '���', '���', 2, 1)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', NULL, '�', '��', '��', 2, 1)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 9, NULL, '��', '��', 5, 5)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', 4, NULL, '��', '���', 4, 3)
Insert into ������ (����, ������, ���, ��������, ���������, ID�������, ID�������) values ('20.01.2001', NULL, '�', '��', '��', 4, 2)