﻿namespace WSS.Models.DTOs.PartieDTOs
{
    public class PartieUpdateDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; } = null!;
        public int? Inaltime { get; set; }
        public int Lungime { get; set; } = 0!;
        public string? GradDificultate { get; set; }
        public Guid StatiuneID { get; set; }
    }
}
