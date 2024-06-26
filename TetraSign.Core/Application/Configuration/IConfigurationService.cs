namespace TetraSign.Core.Application.Configuration;

public interface IConfigurationService {

    Task<IEnumerable<ConfigurationDTO>> Find();
    Task<ConfigurationDTO> FindById(string id);
    Task<ConfigurationDTO> Add(ConfigurationDTO configuration);
    Task Update(ConfigurationDTO configuration);
}