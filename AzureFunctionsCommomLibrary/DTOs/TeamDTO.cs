namespace AzureFunctionsCommomLibrary.DTOs;

public readonly record struct TeamDTO(decimal Score, List<PlayerDTO> Players);
