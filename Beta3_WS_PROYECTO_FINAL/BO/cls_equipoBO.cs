﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_equipoBO
    {
        private int id_equipo;
        private string nombre_equipo;
        private int cant_jugadores;
        private int part_jugados;
        private string goleador;
        private int ranking;
        private int part_ganados;
        private int part_perdidos;
        private int id_convocatoria;
        private string nombre_expulsado;


        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public string Nombre_equipo { get => nombre_equipo; set => nombre_equipo = value; }
        public int Cant_jugadores { get => cant_jugadores; set => cant_jugadores = value; }
        public int Part_jugados { get => part_jugados; set => part_jugados = value; }
        public string Goleador { get => goleador; set => goleador = value; }
        public int Ranking { get => ranking; set => ranking = value; }
        public int Part_ganados { get => part_ganados; set => part_ganados = value; }
        public int Part_perdidos { get => part_perdidos; set => part_perdidos = value; }
        public int Id_convocatoria { get => id_convocatoria; set => id_convocatoria = value; }
        public string Nombre_expulsado { get => nombre_expulsado; set => nombre_expulsado = value; }
    }
}
