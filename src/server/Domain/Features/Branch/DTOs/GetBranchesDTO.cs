﻿namespace Domain.Features.Branch.DTOs
{
    public class GetBranchesDTO
    {
        public List<BranchDTO> Branches { get; set; } = new List<BranchDTO>();
    }
}