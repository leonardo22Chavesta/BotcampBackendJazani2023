﻿using AutoMapper;
using Jazani.Application.Generals.Dtos.MineralTypes;
using Jazani.Domain.Generals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Application.Generals.Dtos.Minerals
{
    public class MineralDto
    {
        public int Id { get; set; }
        public MineralTypeSimpleDto MineralType { get; set; }
        public string Name { get; set; } = default;
        public string? Description { get; set; }
        public string? Symbol { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }

    }
}
