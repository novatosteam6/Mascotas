﻿using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
           // Console.WriteLine("Hello Dueño!");
           // AddDueno();

           // Console.WriteLine("Hello Veterinario!");
           // AddVeterinario();

           // Console.WriteLine("Hello Mascota!");
           // AddMascota();

            //Console.WriteLine("Dueño con id 3!");
           // BuscarDueno(3);

            //Console.WriteLine("Todos los dueños!");
            //ListarDuenos();

            //Console.WriteLine("Mascota con id 2!");
            //BuscarMascota(3);

            //Console.WriteLine("Todas las mascotas!");
            //ListarMascotas();

           // AsignarVeterinario(3, 10);
           // AsignarDueno(3, 7);


        }




        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Cedula = "1212",
                Nombres = "Pedro",
                Apellidos = "Perez",
                Direccion = "calle falsa 123",
                Telefono = "1234567891",
                Correo = "pedroperez@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

         private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Cedula = "1212",
                Nombres = "jose",
                Apellidos = "Sanchez",
                Direccion = "casa blanca",
                Telefono = "1234567891",
                TarjetaProfesional = "23432561"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }



         private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Canela",
                Color = "Blanco",
                Especie = "Felino",
                Raza = "Angora",
            };
            _repoMascota.AddMascota(mascota);
        }



        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Cedula + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }


        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }


        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza);
        }


        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Color + " " + m.Especie + " " + m.Raza);
            }
        }

        private static void AsignarVeterinario(int idMascota, int idVeterinario)
        {
            var veterinario = _repoMascota.AsignarVeterinario(idMascota, idVeterinario);
            Console.WriteLine(veterinario.Nombres);
        
        }

        private static void AsignarDueno(int idMascota, int idDueno)
        {
            var dueno = _repoMascota.AsignarDueno(idMascota, idDueno);
            Console.WriteLine(dueno.Nombres);
        
        }

    }
}
