create user manager;
grant all on all table in schema public to manager;
alter user manager;

create database account_system;
\c account_system;
create sequence id_daily_account
    start with 1
    increment by 1
    cache 1;
create table daily_account(
    id integer default nextval('id_daily_account'::regclass) not null,
    name character varying(20) not null,
    money_total integer default 0 not null,
    date_time date default now(),
    remarks character varying default ''::character varying not null,
    additional_number1 character varying,     
    additional_number2 character varying,     
    additional_number3 character varying     
);
create sequence id_products_seq
    start with 1
    increment by 1
    cache 1;
create table products(
    id integer default nextval('id_products_seq'::regclass) not null,
    name character varying(20) default ''::character varying not null,
    teika integer default 0 not null
);
insert into daily_account (name,money_total,remarks) values
 ('yusuke',10000,'今日は使い過ぎた。'),
 ('yudai',30000,'腹減った'),
 ('takasi',5000,'眠い'),
 ('yuri',9000,'寝坊した。'),
 ('akira',0,'寝てた。'),
 ('yuma',1000,'金欠'),
 ('masaya',10000,'やばい。'),
 ('ryo',500,'節約成功');

 insert into products (name,teika) values 
 ('パソコン',321132),
 ('リンゴ',242),
 ('バナナ',223),
 ('バナナ',24),
 ('バナナ',2645),
 ('バナナ',872),
 ('チーズ',424),
 ('バナナ',7654),
 ('牛乳',2344),
 ('バナナ',75032),
 ('携帯',234),
 ('Kindle',898),
 ('バナナ',657),
 ('バナナ',85209),
 ('バナナ',223),
 ('バナナ',2343),
 ('コーラ',140);