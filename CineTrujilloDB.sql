--Creamos la Base de Datos--
CREATE DATABASE CineTrujilloDB;
USE CineTrujilloDB;

--Tabla Usuarios--
SELECT * FROM Usuarios;

INSERT INTO Usuarios(Nombre, Correo, Password)
VALUES ('Banner Alfredo', 'banner@gmail.com' , 12345);

--Tabla Peliculas--
SELECT * FROM Peliculas;

INSERT INTO Peliculas (Titulo, Sinopsis, Genero, Duracion, Clasificacion, ImagenUrl)
VALUES 
('Inception', 'Un ladrón que posee la tecnología para meterse en los sueños de otros...',
	'Ciencia Ficción', '148 min', 'B', 'https://m.media-amazon.com/images/M/MV5BMjExMjkwNTQ0Nl5BMl5BanBnXkFtZTcwNTY0OTk1Mw@@._V1_.jpg'),
('The Dark Knight', 'Batman se enfrenta al Joker, un criminal que busca el caos...',
	'Acción', '152 min', 'B', 'https://play-lh.googleusercontent.com/auIs5tjWlLYaFPGClZOJ7m5YVbnX6uBvz0X02r8TkwFKdzE53ww2MqWSS9gU0YNqoYwvpg'),
('Parasite', 'Una familia pobre se infiltra en el hogar de una familia rica...',
	'Suspenso', '132 min', 'C', 'https://www.revistaclinicacontemporanea.org/jats_files/1989-9912-cc-11-2-e16-gf01.jpg'),
('Interstellar', 'Exploradores viajan a través de un agujero de gusano...',
	'Ciencia Ficción', '169 min', 'A', 'https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg'),
('Toy Story', 'Un muñeco vaquero se siente amenazado por un nuevo juguete...',
	'Animación', '81 min', 'AA', 'https://es.web.img2.acsta.net/c_310_420/pictures/14/03/17/10/20/509771.jpg');

--Tabla Funciones--
SELECT * FROM Funciones;

INSERT INTO Funciones (IdPelicula, Sala, Horario)
VALUES
(1, 2, '2026-04-27 20:00:00'),
(1, 1, '2026-04-27 15:00:00'),
(2, 2, '2026-04-27 18:00:00'),
(3, 1, '2026-04-27 20:30:00'),
(4, 3, '2026-04-28 17:00:00'),
(5, 2, '2026-04-28 19:00:00');

--Tabla Asientos--
SELECT * FROM Asientos;

INSERT INTO Asientos (IdFuncion, Numero, Estado)
VALUES
-- Función 6
(6, 'A1', 'Disponible'),
(6, 'A2', 'Disponible'),
(6, 'A3', 'Disponible'),
(6, 'A4', 'Disponible'),
(6, 'A5', 'Disponible'),
(6, 'A6', 'Disponible'),
(6, 'B1', 'Disponible'),
(6, 'B2', 'Disponible'),
(6, 'B1', 'Disponible'),
(6, 'B2', 'Disponible'),

-- Función 1
(1, 'A1', 'Disponible'),
(1, 'A2', 'Disponible'),
(1, 'A3', 'Ocupado'),

-- Función 2
(2, 'A1', 'Disponible'),
(2, 'A2', 'Ocupado'),

-- Función 3
(3, 'B1', 'Disponible'),
(3, 'B2', 'Disponible'),

-- Función 4
(4, 'C1', 'Disponible'),
(4, 'C2', 'Ocupado'),

-- Función 5
(5, 'D1', 'Disponible'),
(5, 'D2', 'Disponible');

SELECT * FROM Compras;