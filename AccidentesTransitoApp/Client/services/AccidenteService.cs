using System.Collections.Generic;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.JSInterop;

public class AccidenteService
{
    private const string StorageKey = "accidentes"; // Clave para el LocalStorage
    private readonly ILocalStorageService _localStorage;

    public AccidenteService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task<List<Accidente>> GetAccidentesAsync() // Asegúrate que el nombre sea este
    {
        var accidentes = await _localStorage.GetItemAsync<List<Accidente>>(StorageKey);
        return accidentes ?? new List<Accidente>(); // Retorna una lista vacía si no hay datos
    }

public async Task AddAccidenteAsync(Accidente accidente)
    {
        var accidentes = await GetAccidentesAsync();
        accidentes.Add(accidente);
        await _localStorage.SetItemAsync(StorageKey, accidentes);
    }

    public async Task UpdateAccidenteAsync(Accidente accidente)
    {
        var accidentes = await GetAccidentesAsync();
        var index = accidentes.FindIndex(a => a.Fecha == accidente.Fecha && a.Descripcion == accidente.Descripcion); // Puedes usar un ID único si lo tienes
        if (index != -1)
        {
            accidentes[index] = accidente;
            await _localStorage.SetItemAsync(StorageKey, accidentes);
        }
    }
  
    public async Task DeleteAccidenteAsync(Accidente accidente)
    {
        var accidentes = await GetAccidentesAsync();
        accidentes.Remove(accidente);
        await _localStorage.SetItemAsync(StorageKey, accidentes);
    }
}
