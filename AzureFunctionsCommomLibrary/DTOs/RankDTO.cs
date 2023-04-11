namespace AzureFunctionsCommomLibrary.DTOs;

public record struct RankDTO(decimal Score, DayOfWeek DayOfWeek, DateTime Date);
