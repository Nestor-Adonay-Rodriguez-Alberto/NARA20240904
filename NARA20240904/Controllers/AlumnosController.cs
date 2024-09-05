﻿using Microsoft.AspNetCore.Mvc;
using NARA20240904.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NARA20240904.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        // Registros De Alumnos:
        static List<Alumnos> Lista_Alumnos = new List<Alumnos>();


        // ******* Endponit De La API ********

        // GET : Obtener Todos Los Registros:
        [HttpGet]
        public IEnumerable<Alumnos> Get()
        {
            return Lista_Alumnos;
        }


        // GET : Obtener Un Registro Con Ese ID:
        [HttpGet("{id}")]
        public Alumnos Get(int id)
        {
            Alumnos Objeto_Obtenido = Lista_Alumnos.FirstOrDefault(x => x.IdAlumno == id);
            return Objeto_Obtenido;
        }
    }
}
