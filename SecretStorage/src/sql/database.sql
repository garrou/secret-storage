DROP DATABASE IF EXISTS secretstorage;

CREATE DATABASE secretstorage;

DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS images;
DROP TABLE IF EXISTS profiles;

USE secretstorage;

CREATE TABLE users (
    id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE images (
    userId INT UNSIGNED NOT NULL,
    picture VARCHAR(255) NOT NULL,
    PRIMARY KEY(userId)
);

INSERT INTO users (name, password) VALUES ('admin', '123456');
INSERT INTO users (name, password) VALUES ('adrien', '987654');

INSERT INTO images (userid, picture) VALUES ('1', 'user.png');
INSERT INTO images (userid, picture) VALUES ('2', 'user.png');
