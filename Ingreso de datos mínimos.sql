use Seguridad

insert into Usuarios values
('Pablo Gil', 'p', 'gil.a.pablo@gmail.com', 1, 'p')

insert into Grupos values
('Administrador'),
('Usuario')

insert into UsuariosGrupos values
(1,1),
(2,1),
(2,2)

insert into Modulos values
('Seguridad'),
('Auditorias')

insert into Permisos values
('Alta'),
('Baja'),
('Modifica'),
('Consulta')

insert into Formularios values
('FrmPerfiles','Gestion de Perfiles',1),
('FrmGrupos', 'Gestion de Grupos',1),
('FrmUsuarios','Gestion de Usuarios',1),
('FrmAuditorias','Gestion de Auditorías',2)

insert into Perfiles values
(1,1,1),
(1,2,1),
(1,3,1),
(1,4,1)