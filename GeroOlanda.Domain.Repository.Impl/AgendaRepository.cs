﻿using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository.Impl.GeroDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository.Impl
{
    public class AgendaRepository : IAgendaRepository
    {
        protected GeroOlandaDbContext _context;

        public AgendaRepository(GeroOlandaDbContext context)
        {
            _context = context;
        }
        public AgendaRepository()
        {

        }

        public AgendaDTO CriarDadosAgenda(AgendaDTO agendaDTO)
        {
            Agenda agenda = new Agenda
            {
                Id_Agenda = agendaDTO.Id_Agenda,
                Titulo = agendaDTO.Titulo,
                Descricao = agendaDTO.Descricao,
                Observacoes = agendaDTO.Observacoes,
                Detalhes = agendaDTO.Detalhes,
                flagExibir = agendaDTO.flagExibir
            };
            _context.Add(agenda);
            _context.SaveChanges();
            return agendaDTO;
        }
        public IList<AgendaDTO> ConsultarDadosAgenda(int idIntervencao, string Descricao)
        {
            IList<AgendaDTO> agendaDTO = new List<AgendaDTO>();
            var result = _context.Agenda.AsQueryable().Where(e => e.Id_Agenda == idIntervencao).ToList();
            var queryListaDados = RangeDados(result);

            return queryListaDados;
        }

        public IList<AgendaDTO> RetornoDados(int idUsuario)
        {
            IList<AgendaDTO> agendaDTO = new List<AgendaDTO>();
            var result = _context.Agenda.AsQueryable().Where(e => e.Id_Agenda == idUsuario).ToList();
            var queryListaDados = RangeDados(result);
            return queryListaDados;
        }
        private IList<AgendaDTO> RangeDados(IList<Agenda> dtoList)
        {
            AgendaDTO agendaDTO = new AgendaDTO();
            IList<AgendaDTO> ExibicaoAgendaDTO = new List<AgendaDTO>();
            foreach (var itemAgenda in dtoList )
            {

                agendaDTO.Id_Agenda = itemAgenda.Id_Agenda;
                agendaDTO.Titulo = itemAgenda.Titulo;
                agendaDTO.Descricao = itemAgenda.Descricao;
                agendaDTO.Observacoes = itemAgenda.Observacoes;
                agendaDTO.Detalhes = itemAgenda.Detalhes;
                agendaDTO.flagExibir = itemAgenda.flagExibir;
                ExibicaoAgendaDTO.Add(agendaDTO);
            }

            return ExibicaoAgendaDTO;
        }
        //Remove um usuario especifico da base.
        public string RemoveDaBase(int idUsuario)
        {
            var result = _context.Agenda.Where(e => e.Id_Agenda == idUsuario).FirstOrDefault();
            _context.Agenda.Attach(result);
            _context.Agenda.Remove(result);
            _context.SaveChanges();

            return result.ToString();
        }
    }
}
