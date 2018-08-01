using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.ReleationshipEntities;
using System.Linq;
using System.Runtime.Serialization;
using GameStore.Application.DTOS.Games;

namespace GameStore.Application.ViewModels
{
    public class GameListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Score { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}