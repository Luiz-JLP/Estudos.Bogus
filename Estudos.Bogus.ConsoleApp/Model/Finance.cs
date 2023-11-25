using Bogus.DataSets;

namespace Estudos.Bogus.ConsoleApp.Model;

public class Finance
{
    /// <summary>
    /// Número da Conta
    /// </summary>
    public string Account { get; set; } = string.Empty; 

    /// <summary>
    /// Tipo de Conta
    /// </summary>
    public string AccountName { get; set; } = string.Empty;

    /// <summary>
    /// Saldo da Conta
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Tipo de Transação
    /// </summary>
    public string TransactionType { get; set; } = string.Empty;

    /// <summary>
    /// Moeda
    /// </summary>
    public Currency? Currency { get; set; }

    /// <summary>
    /// Número do Cartão de Crédito
    /// </summary>
    public string CreditCardNumber { get; set; } = string.Empty;

    /// <summary>
    /// Código de Segurança
    /// </summary>
    public string CreditCardCvv { get; set; } = string.Empty;

    /// <summary>
    /// Carteira de Bitcoin
    /// </summary>
    public string BitcoinAddress { get; set; } = string.Empty;

    /// <summary>
    /// Carteira de Ethereum
    /// </summary>
    public string EthereumAddress { get; set; } = string.Empty;

    /// <summary>
    /// Generates an ABA routing number with valid check digit.
    /// </summary>
    public string RoutingNumber { get; set; } = string.Empty;

    /// <summary>
    /// Código Identificador do Banco
    /// </summary>
    public string Bic { get; set; } = string.Empty;

    /// <summary>
    /// International Bank Account Number
    /// </summary>
    public string Iban { get; set; } = string.Empty;
}
