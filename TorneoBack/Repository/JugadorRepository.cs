﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneoApi.Models;

namespace TorneoBack.Repository
{
    public interface IJugadorRepository
    {
        void Add(Jugador jugador);
        void Delete(int id);
        Jugador Get(int id);
        IEnumerable<Jugador> GetAll();
        void Update(Jugador jugador);
    }
    internal class JugadorRepository : IJugadorRepository
    {
        public void Add(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Jugador Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jugador> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Jugador jugador)
        {
            throw new NotImplementedException();
        }
    }
}