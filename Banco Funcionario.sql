create database empresa;
use empresa;
create table FUNCIONARIO
(
id_f int auto_increment,
nome_f varchar(200) not null,
sexo_f char(1) not null,
carTrab_f varchar(50) not null,
dataNasc_f datetime not null,
tel_fix_f varchar(12) not null,
tel_cel_f varchar(12) not null,
email_f varchar(200) not null,
UF_f char(2) not null,
cid_f varchar(200) not null,
bair_f varchar(200) not null,
log_f varchar(200) not null,
num_f int not null,
comp_f varchar(3000),
primary key (id_f)
);
