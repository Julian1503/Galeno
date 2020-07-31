using System.Collections.Generic;
using System.Threading;
using Galeno.Dominio.Entidades;

namespace Galeno.Infraestructura.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Galeno.Infraestructura.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(Galeno.Infraestructura.DataContext context)
        {
            //  This method will be called after migrating to the latest version.
            var dias = new List<Dia>
            {
                new Dia
                {
                    Id=1,
                    Descripcion = "Lunes"
                },
                new Dia
                {
                    Id=2,
                    Descripcion = "Martes"
                }, new Dia
               {
                   Id=3,
                   Descripcion = "Miercoles"
               },
               new Dia
               {
                   Id=4,
                   Descripcion = "Jueves"
               },
               new Dia
               {
                   Id=5,
                   Descripcion = "Viernes"
               },
               new Dia
               {
                   Id=6,
                   Descripcion = "Lunes a viernes"
               },
               new Dia
               {
                   Id=7,
                   Descripcion = "Sabado"
               },
               new Dia
               {
                   Id = 8,
                   Descripcion = "Sujeto a acuerdo previo con el especialista"
               },
            };
            dias.ForEach(x=>context.Dias.AddOrUpdate(x));
            var localidades = new List<Localidad>
            {
                new Localidad
                {
                    Id=1,
                    Descripcion = "San Miguel de Tucumán"
                },
                new Localidad
                {
                    Id=2,
                    Descripcion = "Aguilares"
                }
            };
            localidades.ForEach(x => context.Localidades.AddOrUpdate(x));
            var especialidades = new List<Especialidad>
            {
                new Especialidad
                {
                    Id=1,
                    Descripcion = "Flebologia"
                },
                new Especialidad
                {
                    Id=2,
                    Descripcion = "Endocrinologia"
                },
                
                new Especialidad
                {
                    Id=3,
                    Descripcion = "Ecografia"
                },
                new Especialidad
                {
                    Id=4,
                    Descripcion = "Neurologia"
                },
                new Especialidad
                {
                    Id=5,
                    Descripcion = "Clinico"
                },
                new Especialidad
                {
                    Id=6,
                    Descripcion = "Dermatologia"
                },
                new Especialidad
                {
                    Id=7,
                    Descripcion = "Ginecologia"
                },
                new Especialidad
                {
                    Id=8,
                    Descripcion = "Traumatologia"
                },
                new Especialidad
                {
                    Id=9,
                    Descripcion = "Cirugia Gral"
                },
                new Especialidad
                {
                    Id=10,
                    Descripcion = "Proctologia"
                },
                new Especialidad
                {
                    Id=11,
                    Descripcion = "Cardiologia"
                },
                new Especialidad
                {
                    Id=12,
                    Descripcion = "Neumonologia"
                },
                new Especialidad
                {
                    Id=13,
                    Descripcion = "Urologia"
                },
                new Especialidad
                {
                    Id=14,
                    Descripcion = "Psicologia"
                },
                new Especialidad
                {
                    Id=15,
                    Descripcion = "Gastroenterologia"
                },
                new Especialidad
                {
                    Id=16,
                    Descripcion = "Cirugia Cardiovascular"
                },
                new Especialidad
                {
                    Id=17,
                    Descripcion = "Pediatria"
                },
                new Especialidad
                {
                    Id=18,
                    Descripcion = "Odontologia"
                },
            };
            especialidades.ForEach(x => context.Especialidades.AddOrUpdate(x));
            var establecimiento = new List<Establecimiento>
            {
                new Establecimiento
                {
                    Id = 1,
                    IdLocalidad = 1,
                    Direccion = "Av. Belgrano 2970",
                    RazonSocial = "Sanatorio Galeno S.C.E.I"
                },
                new Establecimiento
                {
                    Id = 2,
                    IdLocalidad = 1,
                    Direccion = "Jujuy 111",
                    RazonSocial = "Sanatorio C.I.M.S.A"
                },
                new Establecimiento
                {
                    Id = 3,
                    IdLocalidad = 1,
                    Direccion = "Av. Mitre 268",
                    RazonSocial = "Sanatorio Central S.R.L"
                },
                new Establecimiento
                {
                    Id = 4,
                    IdLocalidad = 2,
                    Direccion = "Av. Mitre 263",
                    RazonSocial = "Sanatorio Mitre S.R.L"
                },
            };
            establecimiento.ForEach(x => context.Establecimientos.AddOrUpdate(x));
            var prestadores = new List<Prestador>
            {
                new Prestador
                {
                    Id = 1,
                    Apellido = "Agüero Avila",
                    Nombre = "Marcelo"
                },
                new Prestador
                {
                    Id = 2,
                    Apellido = "Escodamaglia",
                    Nombre = "Sergio"
                },
                new Prestador
                {
                    Id = 3,
                    Apellido = "Chavez",
                    Nombre = "Nilda"
                },
                new Prestador
                {
                    Id = 4,
                    Apellido = "Cabral",
                    Nombre = "Clelia"
                },
                new Prestador
                {
                    Id = 5,
                    Apellido = "Benaglio",
                    Nombre = "Horacio"
                },
                new Prestador
                {
                    Id = 6,
                    Apellido = "Gimenez",
                    Nombre = "Nazareno"
                }, new Prestador
                {
                    Id = 7,
                    Apellido = "Venturini",
                    Nombre = "Arturo"
                }, new Prestador
                {
                    Id = 8,
                    Apellido = "Baza",
                    Nombre = "David"
                }, new Prestador
                {
                    Id = 9,
                    Apellido = "Frau",
                    Nombre = "Daniel"
                },
                new Prestador
                {
                    Id = 10,
                    Apellido = "Argañaraz",
                    Nombre = "Carmen"
                },

                new Prestador
                {
                    Id = 11,
                    Apellido = "Valde lico",
                    Nombre = "Guillermo"
                },

                new Prestador
                {
                    Id = 12,
                    Apellido = "Fernandez",
                    Nombre = "Silvio"
                },

                new Prestador
                {
                    Id = 13,
                    Apellido = "Quiroga",
                    Nombre = "Adrian"
                },

                new Prestador
                {
                    Id = 14,
                    Apellido = "Juarez",
                    Nombre = "Pablo"
                },

                new Prestador
                {
                    Id = 15,
                    Apellido = "Figueroa",
                    Nombre = "Ricardo"
                },

                new Prestador
                {
                    Id = 16,
                    Apellido = "Lazarte",
                    Nombre = "Jorge"
                },

                new Prestador
                {
                    Id = 17,
                    Apellido = "Gerez",
                    Nombre = "Liliana"
                },

                new Prestador
                {
                    Id = 18,
                    Apellido = "Neme",
                    Nombre = "Graciela"
                },

                new Prestador
                {
                    Id = 19,
                    Apellido = "Tobias Teruel",
                    Nombre = "Oscar"
                },

                new Prestador
                {
                    Id = 20,
                    Apellido = "Lopez",
                    Nombre = "Lorena"
                },

                new Prestador
                {
                    Id = 21,
                    Apellido = "Perpignal",
                    Nombre = "Luisa"
                },

                new Prestador
                {
                    Id = 22,
                    Apellido = "Silva",
                    Nombre = "Enzo"
                },

                new Prestador
                {
                    Id = 23,
                    Apellido = "Mena",
                    Nombre = "Vicente"
                },
                new Prestador
                {
                    Id = 24,
                    Apellido = "Canseco",
                    Nombre = "Ricardo"
                }
                ,
                new Prestador
                {
                    Id = 25,
                    Apellido = "Gómez",
                    Nombre = "Sergio"
                },
                new Prestador
                {
                    Id = 26,
                    Apellido = "Mena",
                    Nombre = "Hernán"
                },
                new Prestador
                {
                    Id = 27,
                    Apellido = "Ramos",
                    Nombre = "Hernández"
                },
                new Prestador
                {
                    Id = 28,
                    Apellido = "Robles",
                    Nombre = "Chavez"
                },
                new Prestador
                {
                    Id = 29,
                    Apellido = "Nieto",
                    Nombre = "Silva"
                },
                new Prestador
                {
                    Id = 30,
                    Apellido = "Brodesen",
                    Nombre = "Liliana"
                },
                new Prestador
                {
                    Id = 31,
                    Apellido = "Jaime",
                    Nombre = "Sebastian"
                },
                new Prestador
                {
                    Id = 32,
                    Apellido = "Fernandez",
                    Nombre = "Gómez"
                },
                new Prestador
                {
                    Id = 33,
                    Apellido = "Erbetta",
                    Nombre = "Ruben Julio"
                },
                new Prestador
                {
                    Id = 34,
                    Apellido = "Andjel",
                    Nombre = "Germán Alejandro"
                },
                new Prestador
                {
                    Id = 35,
                    Apellido = "Saracho",
                    Nombre = "Victor Manuel"
                }, new Prestador
                {
                    Id = 36,
                    Apellido = "Raskosky",
                    Nombre = "Luis Raul"
                },
                new Prestador
                {
                    Id = 37,
                    Apellido = "Azcárate Pacheres",
                    Nombre = "Aníbal"
                },
                new Prestador
                {
                    Id = 38,
                    Apellido = "Zelada",
                    Nombre = "Fernando"
                },
                new Prestador
                {
                    Id = 39,
                    Apellido = "Michel",
                    Nombre = "  Jhony"
                },
                new Prestador
                {
                    Id = 40,
                    Apellido = "Rojas",
                    Nombre = "Adrian"
                },
                new Prestador
                {
                    Id = 41,
                    Apellido = "Ruiz Diaz",
                    Nombre = "Hector"
                },
                new Prestador
                {
                    Id = 42,
                    Apellido = "Ale",
                    Nombre = "Pablo"
                },
                new Prestador
                {
                    Id = 43,
                    Apellido = "Ale Levin",
                    Nombre = "Walter"
                },
                new Prestador
                {
                    Id = 44,
                    Apellido = "Paz",
                    Nombre = "Claudio"
                },
                new Prestador
                {
                    Id = 45,
                    Apellido = "Brito",
                    Nombre = "Guillermo"
                },
                new Prestador
                {
                    Id = 46,
                    Apellido = "Martinez",
                    Nombre = "Fabian"
                },
                new Prestador
                {
                    Id = 47,
                    Apellido = "Triguero",
                    Nombre = "Felix"
                },
                new Prestador
                {
                    Id = 48,
                    Apellido = "Raya",
                    Nombre = "Jose"
                },
                new Prestador
                {
                    Id = 49,
                    Apellido = "Suarez",
                    Nombre = "Jorge"
                },
                new Prestador
                {
                    Id = 50,
                    Apellido = "Alonso",
                    Nombre = "Gustavo"
                },
                new Prestador
                {
                    Id = 51,
                    Apellido = "Campero",
                    Nombre = "Silvia Graciela"
                },
                new Prestador
                {
                    Id = 52,
                    Apellido = "Romaño",
                    Nombre = "Murga"
                },
                new Prestador
                {
                    Id = 53,
                    Apellido = "Juan Ramon",
                    Nombre = "Cecilia"
                },
                new Prestador
                {
                    Id = 54,
                    Apellido = "Rovarini",
                    Nombre = "Ana"
                },
                new Prestador
                {
                    Id = 55,
                    Apellido = "Chehade",
                    Nombre = "Wadi"
                },
                new Prestador
                {
                    Id = 56,
                    Apellido = "Almeida",
                    Nombre = "Maria"
                },
                new Prestador
                {
                    Id = 57,
                    Apellido = "Perez Ordoñes",
                    Nombre = "Veronica"
                },
                new Prestador
                {
                    Id = 58,
                    Apellido = "Alvarez",
                    Nombre = "Carlos"
                },
                new Prestador
                {
                    Id = 59,
                    Apellido = "Fernandez",
                    Nombre = "Alvaro"
                },
                new Prestador
                {
                    Id = 60,
                    Apellido = "Perez",
                    Nombre = "Mulki"
                },
                new Prestador
                {
                    Id = 61,
                    Apellido = "Martinez",
                    Nombre = "Javier"
                },
                new Prestador
                {
                    Id = 62,
                    Apellido = "Avellaneda",
                    Nombre = "Maria"
                },
                new Prestador
                {
                    Id = 63,
                    Apellido = "Fierro",
                    Nombre = "Jorge"
                },
                new Prestador
                {
                    Id = 64,
                    Apellido = "Ledesma",
                    Nombre = "Jesus Emiliano"
                },
                new Prestador
                {
                    Id = 65,
                    Apellido = "Fadel",
                    Nombre = "Julio"
                }
            };
            prestadores.ForEach(x => context.Prestadores.AddOrUpdate(x));
            var prestadorEspecialidades = new List<PrestadorEspecialidad>
            {
                new PrestadorEspecialidad
                {
                    Id = 1,
                    IdEspecialidad = 1,
                    IdPrestador = 1
                },
                new PrestadorEspecialidad
                {
                    Id = 2,
                    IdEspecialidad = 1,
                    IdPrestador = 2
                },
                new PrestadorEspecialidad
                {
                    Id = 3,
                    IdEspecialidad = 2,
                    IdPrestador =3
                },
                new PrestadorEspecialidad
                {
                    Id = 4,
                    IdEspecialidad =2,
                    IdPrestador = 4
                },
                new PrestadorEspecialidad
                {
                    Id = 5,
                    IdEspecialidad = 3,
                    IdPrestador =5
                },
                new PrestadorEspecialidad
                {
                    Id = 6,
                    IdEspecialidad = 4,
                    IdPrestador = 6
                },
                new PrestadorEspecialidad
                {
                    Id = 7,
                    IdEspecialidad = 5,
                    IdPrestador = 7
                },
                new PrestadorEspecialidad
                {
                    Id = 8,
                    IdEspecialidad = 6,
                    IdPrestador =8
                },
                new PrestadorEspecialidad
                {
                    Id = 9,
                    IdEspecialidad = 7,
                    IdPrestador = 9
                },
                new PrestadorEspecialidad
                {
                    Id = 10,
                    IdEspecialidad = 7,
                    IdPrestador = 10
                },
                new PrestadorEspecialidad
                {
                    Id = 11,
                    IdEspecialidad = 8,
                    IdPrestador =11
                },
                new PrestadorEspecialidad
                {
                    Id = 12,
                    IdEspecialidad =8 ,
                    IdPrestador =12
                },
                new PrestadorEspecialidad
                {
                    Id = 13,
                    IdEspecialidad = 8,
                    IdPrestador =13
                },
                new PrestadorEspecialidad
                {
                    Id = 14,
                    IdEspecialidad =8 ,
                    IdPrestador =14
                },
                new PrestadorEspecialidad
                {
                    Id = 15,
                    IdEspecialidad = 9,
                    IdPrestador =15
                },
                new PrestadorEspecialidad
                {
                    Id = 16,
                    IdEspecialidad = 9,
                    IdPrestador = 16
                },
                new PrestadorEspecialidad
                {
                    Id = 17,
                    IdEspecialidad = 10,
                    IdPrestador = 17
                },
                new PrestadorEspecialidad
                {
                    Id = 18,
                    IdEspecialidad = 11,
                    IdPrestador = 18
                },
                new PrestadorEspecialidad
                {
                    Id = 19,
                    IdEspecialidad = 11,
                    IdPrestador = 19
                },
                new PrestadorEspecialidad
                {
                    Id = 20,
                    IdEspecialidad = 11,
                    IdPrestador = 20
                },
                new PrestadorEspecialidad
                {
                    Id = 21,
                    IdEspecialidad = 12,
                    IdPrestador = 21
                },
                new PrestadorEspecialidad
                {
                    Id = 22,
                    IdEspecialidad = 13,
                    IdPrestador = 22
                },
                new PrestadorEspecialidad
                {
                    Id = 23,
                    IdEspecialidad = 5,
                    IdPrestador = 23
                },
                new PrestadorEspecialidad
                {
                    Id = 24,
                    IdEspecialidad = 14,
                    IdPrestador = 24
                },
                new PrestadorEspecialidad
                {
                    Id = 25,
                    IdEspecialidad = 9,
                    IdPrestador = 25
                },
                new PrestadorEspecialidad
                {
                    Id = 26,
                    IdEspecialidad = 9,
                    IdPrestador = 26
                },
                new PrestadorEspecialidad
                {
                    Id = 27,
                    IdEspecialidad = 7,
                    IdPrestador = 27
                },
                new PrestadorEspecialidad
                {
                    Id = 28,
                    IdEspecialidad = 7,
                    IdPrestador = 28
                },
                new PrestadorEspecialidad
                {
                    Id = 29,
                    IdEspecialidad = 7,
                    IdPrestador = 29
                },
                new PrestadorEspecialidad
                {
                    Id = 30,
                    IdEspecialidad = 15,
                    IdPrestador = 30
                },
                new PrestadorEspecialidad
                {
                    Id = 31,
                    IdEspecialidad = 13,
                    IdPrestador = 31
                },
                new PrestadorEspecialidad
                {
                    Id = 32,
                    IdEspecialidad = 13,
                    IdPrestador = 32
                },
                new PrestadorEspecialidad
                {
                    Id = 33,
                    IdEspecialidad = 16,
                    IdPrestador = 33
                },
                new PrestadorEspecialidad
                {
                    Id = 34,
                    IdEspecialidad = 4,
                    IdPrestador = 34
                },
                new PrestadorEspecialidad
                {
                    Id = 35,
                    IdEspecialidad = 11,
                    IdPrestador = 35
                },
                new PrestadorEspecialidad
                {
                    Id = 36,
                    IdEspecialidad = 9,
                    IdPrestador = 36
                },
                new PrestadorEspecialidad
                {
                    Id = 37,
                    IdEspecialidad = 5,
                    IdPrestador = 37
                },
                new PrestadorEspecialidad
                {
                    Id = 38,
                    IdEspecialidad = 3,
                    IdPrestador = 38
                },
                new PrestadorEspecialidad
                {
                    Id = 39,
                    IdEspecialidad = 9,
                    IdPrestador = 39
                },
                new PrestadorEspecialidad
                {
                    Id = 40,
                    IdEspecialidad = 9,
                    IdPrestador = 40
                },
                new PrestadorEspecialidad
                {
                    Id = 41,
                    IdEspecialidad = 13,
                    IdPrestador = 41
                },
                new PrestadorEspecialidad
                {
                    Id = 42,
                    IdEspecialidad = 8,
                    IdPrestador = 42
                },
                new PrestadorEspecialidad
                {
                    Id = 43,
                    IdEspecialidad = 8,
                    IdPrestador = 43
                },
                new PrestadorEspecialidad
                {
                    Id = 44,
                    IdEspecialidad = 8,
                    IdPrestador = 44
                },
                new PrestadorEspecialidad
                {
                    Id = 45,
                    IdEspecialidad = 17,
                    IdPrestador = 45
                },
                new PrestadorEspecialidad
                {
                    Id = 46,
                    IdEspecialidad = 11,
                    IdPrestador = 46
                },
                new PrestadorEspecialidad
                {
                    Id = 47,
                    IdEspecialidad = 12,
                    IdPrestador = 47
                },
                new PrestadorEspecialidad
                {
                    Id = 48,
                    IdEspecialidad = 11,
                    IdPrestador = 48
                },
                new PrestadorEspecialidad
                {
                    Id = 49,
                    IdEspecialidad = 11,
                    IdPrestador = 49
                },
                new PrestadorEspecialidad
                {
                    Id = 50,
                    IdEspecialidad = 12,
                    IdPrestador = 50
                },
                new PrestadorEspecialidad
                {
                    Id = 51,
                    IdEspecialidad = 6,
                    IdPrestador = 51
                },
                new PrestadorEspecialidad
                {
                    Id = 52,
                    IdEspecialidad = 15,
                    IdPrestador = 52
                },
                new PrestadorEspecialidad
                {
                    Id = 53,
                    IdEspecialidad = 15,
                    IdPrestador = 53
                },
                new PrestadorEspecialidad
                {
                    Id = 54,
                    IdEspecialidad = 12,
                    IdPrestador = 54
                },
                new PrestadorEspecialidad
                {
                    Id = 55,
                    IdEspecialidad = 17,
                    IdPrestador = 55
                },
                new PrestadorEspecialidad
                {
                    Id = 56,
                    IdEspecialidad = 17,
                    IdPrestador = 56
                },
                new PrestadorEspecialidad
                {
                    Id = 57,
                    IdEspecialidad = 17,
                    IdPrestador = 57
                },
                new PrestadorEspecialidad
                {
                    Id = 58,
                    IdEspecialidad = 16,
                    IdPrestador = 58
                },
                new PrestadorEspecialidad
                {
                    Id = 59,
                    IdEspecialidad = 16,
                    IdPrestador = 59
                },
                new PrestadorEspecialidad
                {
                    Id = 60,
                    IdEspecialidad = 18,
                    IdPrestador = 60
                },
                new PrestadorEspecialidad
                {
                    Id = 61,
                    IdEspecialidad = 11,
                    IdPrestador = 61
                },
                new PrestadorEspecialidad
                {
                    Id = 62,
                    IdEspecialidad = 17,
                    IdPrestador = 62
                },
                new PrestadorEspecialidad
                {
                    Id = 63,
                    IdEspecialidad = 9,
                    IdPrestador = 63
                },
                new PrestadorEspecialidad
                {
                    Id = 64,
                    IdEspecialidad = 11,
                    IdPrestador = 64
                },
                new PrestadorEspecialidad
                {
                    Id = 65,
                    IdEspecialidad = 8,
                    IdPrestador = 65
                },
            };
            prestadorEspecialidades.ForEach(x => context.PrestadorEspecialidades.AddOrUpdate(x));
            var prestadorEstablecimiento = new List<PrestadorEstablecimiento>
            {
                new PrestadorEstablecimiento
                {
                    Id = 1,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 1
                },
                new PrestadorEstablecimiento
                {
                    Id = 2,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 2
                },
                new PrestadorEstablecimiento
                {
                    Id = 3,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 3
                },
                new PrestadorEstablecimiento
                {
                    Id = 4,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 4
                },
                new PrestadorEstablecimiento
                {
                    Id = 5,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 5
                },
                new PrestadorEstablecimiento
                {
                    Id = 6,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 6
                },
                new PrestadorEstablecimiento
                {
                    Id = 7,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 7
                },
                new PrestadorEstablecimiento
                {
                    Id = 8,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 8
                },
                new PrestadorEstablecimiento
                {
                    Id = 9,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 9
                },
                new PrestadorEstablecimiento
                {
                    Id = 10,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 10
                },
                new PrestadorEstablecimiento
                {
                    Id = 11,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 11
                },
                new PrestadorEstablecimiento
                {
                    Id = 12,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 12
                },
                new PrestadorEstablecimiento
                {
                    Id = 13,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 13
                },
                new PrestadorEstablecimiento
                {
                    Id = 14,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 14
                },
                new PrestadorEstablecimiento
                {
                    Id = 15,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 15
                },
                new PrestadorEstablecimiento
                {
                    Id = 16,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 16
                },
                new PrestadorEstablecimiento
                {
                    Id = 17,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 17
                },
                new PrestadorEstablecimiento
                {
                    Id = 18,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 18
                },
                new PrestadorEstablecimiento
                {
                    Id = 19,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 19
                },
                new PrestadorEstablecimiento
                {
                    Id = 20,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 20
                },
                new PrestadorEstablecimiento
                {
                    Id = 21,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 21
                },
                new PrestadorEstablecimiento
                {
                    Id = 22,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 22
                },
                new PrestadorEstablecimiento
                {
                    Id = 23,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 23
                },
                new PrestadorEstablecimiento
                {
                    Id = 24,
                    IdEstablecimiento = 3,
                    IdPrestadorEspecialidad = 24
                },
                new PrestadorEstablecimiento
                {
                    Id = 25,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 25
                },
                new PrestadorEstablecimiento
                {
                    Id = 26,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 26
                },
                new PrestadorEstablecimiento
                {
                    Id = 27,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 27
                },
                new PrestadorEstablecimiento
                {
                    Id = 28,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 28
                },
                new PrestadorEstablecimiento
                {
                    Id = 29,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 29
                },
                new PrestadorEstablecimiento
                {
                    Id = 30,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 30
                },
                new PrestadorEstablecimiento
                {
                    Id = 31,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 31
                },
                new PrestadorEstablecimiento
                {
                    Id = 32,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 32
                },
                new PrestadorEstablecimiento
                {
                    Id = 33,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 33
                },
                new PrestadorEstablecimiento
                {
                    Id = 34,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 34
                },
                new PrestadorEstablecimiento
                {
                    Id = 35,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 35
                },
                new PrestadorEstablecimiento
                {
                    Id = 36,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 36
                },
                new PrestadorEstablecimiento
                {
                    Id = 37,
                    IdEstablecimiento = 2,
                    IdPrestadorEspecialidad = 37
                },
                new PrestadorEstablecimiento
                {
                    Id = 38,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 38
                },
                new PrestadorEstablecimiento
                {
                    Id = 39,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 39
                },
                new PrestadorEstablecimiento
                {
                    Id = 40,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 40
                },
                new PrestadorEstablecimiento
                {
                    Id = 41,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 41
                },
                new PrestadorEstablecimiento
                {
                    Id = 42,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 42
                },
                new PrestadorEstablecimiento
                {
                    Id = 43,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 43
                },
                new PrestadorEstablecimiento
                {
                    Id = 44,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 44
                },
                new PrestadorEstablecimiento
                {
                    Id = 45,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 45
                },
                new PrestadorEstablecimiento
                {
                    Id = 46,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 46
                },
                new PrestadorEstablecimiento
                {
                    Id = 47,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 47
                },
                new PrestadorEstablecimiento
                {
                    Id = 48,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 48
                },
                new PrestadorEstablecimiento
                {
                    Id = 49,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 49
                },
                new PrestadorEstablecimiento
                {
                    Id = 50,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 50
                },
                new PrestadorEstablecimiento
                {
                    Id = 51,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 51
                },
                new PrestadorEstablecimiento
                {
                    Id = 52,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 52
                },
                new PrestadorEstablecimiento
                {
                    Id =53 ,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 53
                },
                new PrestadorEstablecimiento
                {
                    Id = 54,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 54
                },
                new PrestadorEstablecimiento
                {
                    Id = 55,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 55
                },
                new PrestadorEstablecimiento
                {
                    Id = 56,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 57
                },
                new PrestadorEstablecimiento
                {
                    Id = 57,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 57
                },
                new PrestadorEstablecimiento
                {
                    Id = 58,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 58
                },
                new PrestadorEstablecimiento
                {
                    Id = 59,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 59
                },
                new PrestadorEstablecimiento
                {
                    Id = 60,
                    IdEstablecimiento = 1,
                    IdPrestadorEspecialidad = 60
                },
                new PrestadorEstablecimiento
                {
                    Id = 61,
                    IdEstablecimiento = 4,
                    IdPrestadorEspecialidad = 61
                },
                new PrestadorEstablecimiento
                {
                    Id = 62,
                    IdEstablecimiento = 4,
                    IdPrestadorEspecialidad = 62
                },
                new PrestadorEstablecimiento
                {
                    Id = 63,
                    IdEstablecimiento = 4,
                    IdPrestadorEspecialidad = 63
                },
                new PrestadorEstablecimiento
                {
                    Id = 64,
                    IdEstablecimiento = 4,
                    IdPrestadorEspecialidad = 64
                },
                new PrestadorEstablecimiento
                {
                    Id = 65,
                    IdEstablecimiento = 4,
                    IdPrestadorEspecialidad = 65
                }
            };
            prestadorEstablecimiento.ForEach(x => context.PrestadorEstablecimientos.AddOrUpdate(x));
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
