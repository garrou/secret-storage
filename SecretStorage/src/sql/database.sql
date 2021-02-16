DROP DATABASE IF EXISTS secretstorage;

CREATE DATABASE secretstorage;

USE secretstorage;

CREATE TABLE users (
    id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE images (
    userId INT UNSIGNED NOT NULL,
    picture BLOB(65535) NOT NULL,
    PRIMARY KEY(userId)
);

CREATE TABLE gologin (
    id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    password VARCHAR(255) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE logs (
    userId INT UNSIGNED NOT NULL,
    lastConnection DATETIME NOT NULL,
    PRIMARY KEY(userId)
);

INSERT INTO gologin (password) VALUES ('????n????:b??????]Z?????:?l?');

ALTER TABLE users AUTO_INCREMENT = 1;
ALTER TABLE images AUTO_INCREMENT = 1;
ALTER TABLE logs AUTO_INCREMENT = 1;

/* 

FOR TESTS

INSERT INTO users (name, password) VALUES ('test', 'test');
INSERT INTO users (name, password) VALUES ('admin', 'admin');

INSERT INTO images (userId, picture) VALUES ('1', 'user.png');
INSERT INTO images (userId, picture) VALUES ('2', 'user.png');

INSERT INTO logs (userId, lastConnection) VALUES ('1', NOW());
INSERT INTO logs (userId, lastConnection) VALUES ('2', NOW());

*/