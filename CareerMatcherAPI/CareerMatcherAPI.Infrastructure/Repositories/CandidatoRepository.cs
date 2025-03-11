using CareerMatcherAPI.Domain.Interfaces;
using CareerMatcherAPI.Domain.Entities;
using CareerMatcherAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CareerMatcherAPI.Infrastructure.Repositories;

public class CandidatoRepository : ICandidatoRepository
{
    private readonly AppDbContext _context;
    
    public CandidatoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Candidato>> GetAllCandidatosAsync()
    {
        return await _context.Candidatos.ToListAsync();
    }
    
}