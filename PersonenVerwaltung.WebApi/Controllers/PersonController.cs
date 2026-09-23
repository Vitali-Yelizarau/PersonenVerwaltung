using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PersonenVerwaltung.DataAccess;
using PersonenVerwaltung.DataAccess.Models;
using PersonenVerwaltung.WebApi.Configuration;
using PersonenVerwaltung.WebApi.DTOs;

namespace PersonenVerwaltung.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController(PersonenVerwaltungContext context, IOptions<PersonListSettings> personListOptions) : ControllerBase
{
    /* 
     * Sicherheitsbegrenzung: maximale Anzahl der Datensätze pro Abfrage.
     * Konfigurierbar über appsettings.json (PersonListSettings:MaxRecords),
     * um übermäßige Last bei sehr großen Ergebnismengen zu vermeiden.
     */
    private readonly int _maxPersonsLimit = personListOptions.Value.MaxRecords;
    private readonly PersonenVerwaltungContext _context = context;

    [HttpGet]
    public async Task<ActionResult<List<PersonListItemDto>>> GetPersons([FromQuery] string? name)
    {
        var query = _context.People.AsQueryable();

        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(p => p.Name.Contains(name));
        }

        var result = await query.OrderBy(x => x.PersonId)
                                .Take(_maxPersonsLimit)
                                .Select(p => new PersonListItemDto
                                {
                                    PersonId = p.PersonId,
                                    Name = p.Name,
                                    Vorname = p.Vorname,
                                    Geburtsdatum = p.Geburtsdatum
                                }
                                        )
                                .ToListAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PersonDetailDto>> GetPersonById(int id)
    {
        var person = await _context.People.AsQueryable()
                                   .Include(p => p.Anschrifts)
                                   .Include(p => p.Telefonverbindungs)
                                   .FirstOrDefaultAsync(p => p.PersonId == id);

        if (person is null)
        {
            return NotFound();
        }

        var dto = new PersonDetailDto
        {
            PersonId = person.PersonId,
            Name = person.Name,
            Vorname = person.Vorname,
            Geburtsdatum = person.Geburtsdatum,
            Anschriften = [.. person.Anschrifts.Select(a => new AnschriftDto
            {
                Plz = a.Plz,
                Ort = a.Ort,
                Strasse = a.Strasse,
                Hausnummer = a.Hausnummer
            })],
            Telefonnummern = [.. person.Telefonverbindungs.Select(t => t.Nummer)]
        };

        return Ok(dto);
    }

    [HttpPut("{id}/name")]
    public async Task<IActionResult> UpdatePersonName(int id, [FromBody] UpdatePersonNameDto dto)
    {
        var person = await _context.People.FindAsync(id);

        if (person is null)
        {
            return NotFound();
        }

        person.Name = dto.Name;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // Hinweis: POST- und DELETE-Endpunkte sind in der Aufgabenstellung nicht explizit gefordert.
    // Sie wurden hinzugefügt, um eine vollständige REST-Ressource (CRUD) anzubieten.
    [HttpPost]
    public async Task<ActionResult<PersonDetailDto>> CreatePerson([FromBody] CreatePersonDto dto)
    {
        if (dto.Anschriften is null || dto.Anschriften.Count == 0)
        {
            return BadRequest("Mindestens eine Anschrift ist erforderlich.");
        }

        var telefonnummern = dto.Telefonnummern?.Where(n => !string.IsNullOrWhiteSpace(n)).ToList() ?? [];
        if (telefonnummern.Count == 0)
        {
            return BadRequest("Mindestens eine Telefonnummer ist erforderlich.");
        }

        var person = new Person
        {
            Name = dto.Name,
            Vorname = dto.Vorname,
            Geburtsdatum = dto.Geburtsdatum
        };

        foreach (var anschrift in dto.Anschriften)
        {
            person.Anschrifts.Add(new Anschrift
            {
                Plz = anschrift.Plz,
                Ort = anschrift.Ort,
                Strasse = anschrift.Strasse,
                Hausnummer = anschrift.Hausnummer
            });
        }

        foreach (var nummer in telefonnummern)
        {
            person.Telefonverbindungs.Add(new Telefonverbindung { Nummer = nummer.Trim() });
        }

        _context.People.Add(person);
        await _context.SaveChangesAsync();

        var result = new PersonDetailDto
        {
            PersonId = person.PersonId,
            Name = person.Name,
            Vorname = person.Vorname,
            Geburtsdatum = person.Geburtsdatum,
            Anschriften = [.. person.Anschrifts.Select(a => new AnschriftDto
            {
                Plz = a.Plz,
                Ort = a.Ort,
                Strasse = a.Strasse,
                Hausnummer = a.Hausnummer
            })],
            Telefonnummern = [.. person.Telefonverbindungs.Select(t => t.Nummer)]
        };

        return CreatedAtAction(nameof(GetPersonById), new { id = person.PersonId }, result);
    }

    // Wichtig: Die mit der Adresse und der Telefonnummer verknüpften Fremdschlüssel wurden ohne CASCADE (NO ACTION) angelegt.
    // Daher müssen vor dem Löschen eines Personeneintrags die abhängigen Einträge explizit gelöscht werden.
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var person = await _context.People
            .Include(p => p.Anschrifts)
            .Include(p => p.Telefonverbindungs)
            .FirstOrDefaultAsync(p => p.PersonId == id);

        if (person is null)
        {
            return NotFound();
        }

        _context.Anschrifts.RemoveRange(person.Anschrifts);
        _context.Telefonverbindungs.RemoveRange(person.Telefonverbindungs);
        _context.People.Remove(person);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}