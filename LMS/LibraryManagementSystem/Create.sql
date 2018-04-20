create table book (
	bno			char(8) ,
	category	varchar(20),
	title		varchar(40) not null,
	press		varchar(30) not null,
	year		int not null,
	author		varchar(20),
	price		decimal(7,2),
	total		int not null,
	stock		int not null,
	primary key (bno)
); 

create table card(
	cno char(7),
	name varchar(10) not null,
	department  varchar(40),
	type char(1),
	primary key (cno),
	check (type in ('T','G','U','O'))
);

create table admin(
	ano char(6),
	password varchar(20),
	name varchar(10) not null,
	contact varchar(20),
	primary key (ano)
);

create table borrow(
	cno char(7) not null,
	bno char(8) not null,
	borrow_date datetime not null,
	return_date datetime not null,
	admin char(6),
	foreign key (bno) references book on delete cascade on update cascade,
	foreign key (cno) references card on delete cascade on update cascade,
	foreign key (admin) references admin(ano) on update cascade
);