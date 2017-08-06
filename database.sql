create user manager;
grant all on all table in schema public to manager;
alter user manager;

create database account_system;
create sequence id_daily_account
    start with 1
    increment by 1
    cache 1;
create table daily_account(
    id integer default nextval('id_daily_account'::regclass) not null,
    name character varying(20) not null,
    money_total integer default 0 not null,
    date_time date default now(),
    remarks character varying default ''::character varying not null
);
insert into daily_account (name,money_total,remarks) values
 ('yusuke',10000,'今日は使い過ぎた。'),
 ('yuya',500,'節約成功');