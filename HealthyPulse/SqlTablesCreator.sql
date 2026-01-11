create table Patients (
Id int identity primary key,
FirstName nvarchar (100) not null,
Lastname nvarchar (100) not null,
DateOfBirth date not null
);

create table Doctors(
Id int identity primary key,
FirstName nvarchar (100) not null,
Lastname nvarchar (100) not null,
DateOfBirth date not null,
DayStartOfWork date not null
);

create table MeasurementTypes(
Id int identity primary key,
Name nvarchar (100) not null,
Unit nvarchar (50) not null
);

create table Equipment(
Id int identity primary key,
ModelName nvarchar(100) not null,
MeasurementType int not null,
foreign key (MeasurementType) references  MeasurementTypes(Id)
);

create table Measurements(
Id int identity primary key,
PatientId int not null,
DoctorId int not null,
EquipmentId int not null,
MeasurementTypeId int not null,
MeasurementValue nvarchar(max) not null
foreign key (PatientId) references Patients(Id),
foreign key (DoctorId) references Doctors(Id),
foreign key (EquipmentId) references Equipment(Id),
foreign key (MeasurementTypeId) references MeasurementTypes(Id),
);