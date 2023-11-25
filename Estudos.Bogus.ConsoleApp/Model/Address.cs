namespace Estudos.Bogus.ConsoleApp.Model;

public class Address
{
    /// <summary>
    /// Tipo de Logradouro
    /// </summary>
    public string StreetSuffix { get; set; } = string.Empty;

    /// <summary>
    /// Logradouro
    /// </summary>
    public string StreetName { get; set; } = string.Empty;

    /// <summary>
    /// Número
    /// </summary>
    public string BuildingNumber { get; set; } = string.Empty;

    /// <summary>
    /// Complemento
    /// </summary>
    public string SecondaryAddress { get; set; } = string.Empty;

    /// <summary>
    /// CEP
    /// </summary>
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Bairro ou Condado
    /// </summary>
    public string County { get; set; } = string.Empty;

    /// <summary>
    /// Município
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Estado
    /// </summary>
    public string State { get; set; } = string.Empty;

    /// <summary>
    /// Pais
    /// </summary>
    public string Country { get; set; } = string.Empty;

}
