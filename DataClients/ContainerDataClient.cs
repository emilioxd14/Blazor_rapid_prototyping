using FH_Kufstein_Blazor_WebAppProject.Models;

namespace FH_Kufstein_Blazor_WebAppProject.DataClients;

public class ContainerDataClient
{
    private readonly List<ContainerData> _containers = [
        new ContainerData { 
            Id = 1, 
            Name = $"Container {new Random().Next(0, 200)}",
            DateTime = DateTime.Now, 
            Location = "Gorleben", 
            ContainerType = "Castor",
            Capacity = 5000, 
            CurrentLevel = new Random().Next(1000, 5000), 
            Measurements = [$"{DateTime.UtcNow}, Temperature: {new Random().Next(0, 50)}C, RadioActivity: {new Random().Next(200, 1000)}mSV"] 
        },
        new ContainerData { 
            Id = 2, 
            Name = $"Container {new Random().Next(0, 200)}",
            DateTime = DateTime.Now, 
            Location = "Gorleben", 
            ContainerType = "Castor",
            Capacity = 5000, 
            CurrentLevel = new Random().Next(1000, 5000), 
            Measurements = [$"{DateTime.UtcNow}, Temperature: {new Random().Next(0, 50)}C, RadioActivity: {new Random().Next(200, 1000)}mSV"] 
        },
        new ContainerData { 
            Id = 3, 
            Name = $"Container {new Random().Next(0, 200)}",
            DateTime = DateTime.Now, 
            Location = "Gorleben", 
            ContainerType = "Lead Lined",
            Capacity = 5000, 
            CurrentLevel = new Random().Next(1000, 5000), 
            Measurements = [$"{DateTime.UtcNow}, Temperature: {new Random().Next(0, 50)}C, RadioActivity: {new Random().Next(200, 1000)}mSV"] 
        },
        new ContainerData { 
            Id = 4, 
            Name = $"Container {new Random().Next(0, 200)}",
            DateTime = DateTime.Now, 
            Location = "Gorleben", 
            ContainerType = "Stainless Steel", 
            Capacity = 5000, 
            CurrentLevel = new Random().Next(1000, 5000),
            Measurements = [$"{DateTime.UtcNow}, Temperature: {new Random().Next(0, 50)}C, RadioActivity: {new Random().Next(200, 1000)}mSV"] 
        },
        new ContainerData { 
            Id = 5, 
            Name = $"Container {new Random().Next(0, 200)}",
            DateTime = DateTime.Now, 
            Location = "Gorleben", 
            ContainerType = "Lead lined Composite", 
            Capacity = 5000, 
            CurrentLevel = new Random().Next(1000, 5000),
            Measurements = [$"{DateTime.UtcNow}, Temperature: {new Random().Next(0, 50)}C, RadioActivity: {new Random().Next(200, 1000)}mSV"] 
        }
    ];

    // Método para obtener todos los contenedores desde la UI
    public List<ContainerData> GetContainers()
    {
        return _containers;
    }

    public void AddContainer(ContainerData newContainer)
    {
        // Generar un ID secuencial automático basado en el ID más alto existente
        int nextId = _containers.Any() ? _containers.Max(c => c.Id) + 1 : 1;
        newContainer.Id = nextId;
        
        // Inicializar un set de mediciones por defecto para cumplir con la estructura
        newContainer.Measurements = [
            DateTime.UtcNow + ", Temperature: 22C, RadioActivity: 250mSV"
        ];

        _containers.Add(newContainer);
    }
    public void DeleteContainerData(int id)
    {
        var containerToRemove = _containers.FirstOrDefault(c => c.Id == id);
        if (containerToRemove != null)
        {
            _containers.Remove(containerToRemove);
        }
    }

    public void UpdateContainer(ContainerData updatedContainer)
    {
        var existing = _containers.FirstOrDefault(c => c.Id == updatedContainer.Id);
        if (existing != null)
        {
            existing.Name = updatedContainer.Name;
            existing.DateTime = updatedContainer.DateTime;
            existing.Location = updatedContainer.Location;
            existing.ContainerType = updatedContainer.ContainerType;
            existing.Capacity = updatedContainer.Capacity;
            existing.CurrentLevel = updatedContainer.CurrentLevel;
            existing.Measurements = updatedContainer.Measurements;
        }
    }
}