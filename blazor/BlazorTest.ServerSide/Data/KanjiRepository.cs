using BlazorTest.ServerSide.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.ServerSide.Data;

public interface IKanjiRepository
{
    Task<List<Kanji>> GetKanjis();
    Task<Kanji> GetKanji(Guid id);
    Task<bool> AddKanji(Kanji kanji);
}

public class KanjiRepository : IKanjiRepository
{
    private readonly AppDbContext db;

    public KanjiRepository(AppDbContext db)
    {
        this.db = db;
    }
    
    public Task<List<Kanji>> GetKanjis()
    {
        return db.Kanjis
            .Include(k => k.Readings)
            .ToListAsync();
    }

    public Task<Kanji> GetKanji(Guid id)
    {
        return db.Kanjis
            .Include(k => k.Readings)
            .Where(k => k.Id == id)
            .SingleAsync();
    }

    public async Task<bool> AddKanji(Kanji kanji)
    {
        // TODO: Validation
        
        kanji.Id = Guid.NewGuid();
        db.Kanjis.Add(kanji);
        var written = await db.SaveChangesAsync();
        return written > 0;
    }
}
