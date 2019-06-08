--Tabla categoria
create table categoria(
	idcategoria int primary key identity,
	nombre varcharr(50) not null unique,
	descripcion varchar(256) null,
	condicion bit default(1)
);

--Tabla Articulo
create table articulo(
	idarticulo int primary key identity,
	idcategoria int not null,
	codigo varchar(50) null,
	nombre varchar(100) not null unique,
	precio_venta decimal(11,2) not null,
	stock int not null,
	descripcion varchar(256) null,
	condicion bit default(1),
	foreign key (idcategoria) references categoria(idcategoria)
)

--Tabla Persona
create table persona(
	idpersona int primary key identity,
	tipo_persona varchar(20) not null,
	nombre varchar(100) not null,
	tipo_documento varchar(20) null,
	num_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) null
)

--Tabla Rol
create table rol(
	idrol int primary key identity,
	nombre varchar(30) not null,
	descripcion varchar(100) null,
	condicion bit default(1)
)

--Tabla Usuario
create table usuario(
	idusuario int primary key identity,
	idrol int not null,
	nombre varchar(100) not null,
	tipo_documento varchar(20) null,
	num_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) not null,
	password_hash verbinary not null,
	password_salt verbinary not null,
	condicion bit default(1),
	foreign key (idrol) references rol (idrol)
)

--Tabla Ingreso
create table ingreso(
	idingreso int primary key identity,
	idproveedor int not null,
	idusuario int not null,
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) null,
	num_comprobante varchar(10) not null,
	fecha_hora datetime not null,
	impuesto decimal(4,2) not null,
	total decimal(11,2) not null,
	estado varchar(20) not null,
	foreign key (idpproveedor) references persona(idpersona),
	foreign key (idusuario) references usuario (idusuario)
)

--Tabla Detalle_Ingreso
create table detalle_ingreso(
	iddetalle_ingreso int primary key identity,
	idingreso int not null,
	idarticulo int not null,
	cantidad int not null,
	precio decimal(11,2) not null,
	foreign key (idingreso) references ingreso(idingreso) on delete cascade,
	foreign key (idarticulo) references articulo(idarticulo)
)

--Tabla Venta
create table venta(
	idventa int primary key identity,
	idcliente int not null,
	idusuario int not null,
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) null,
	num_comprobante varchar(10) not null,
	fecha_hora datetime not null,
	impuesto decimal(4,2) not null,
	total decimal(11,2) not null,
	estado varchar(20) not null,
	foreign key (idcliente) references persona(idpersona),
	foreign key (idusuario) references usuario(idusuario)
)

--Tabla Detalle_Venta
create table detalle_venta(
	iddetalle_venta int primary key identity,
	idventa int not null,
	idarticulo int not null,
	cantidad int not null,
	precio decimal(11,2) not null,
	descuento decimal(11,2) not null,
	foreign key (idventa) references venta(idventa) on delete cascade,
	foreign key (idarticulo) references articulo(idarticulo)
)