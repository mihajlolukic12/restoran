CREATE DATABASE restoran;
create table jela (
	id bigint auto_increment unique,
    ime varchar(50),
    vreme bigint,
    cena bigint,
    primary key (id)
);
create table pica (
	id bigint auto_increment unique,
    ime varchar(50),
    cena bigint,
    primary key (id)
);
