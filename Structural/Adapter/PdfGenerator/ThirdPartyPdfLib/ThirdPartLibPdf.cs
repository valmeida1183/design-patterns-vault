using Structural.Adapter.PdfGenerator.Interface;

namespace Structural.Adapter.PdfGenerator;

// Este é o "Adaptee" a classe que deve ser adaptada pois náo conversa com a classe de alto nível.
public class ThirdPartLibPdf : IThirdPartyPdfLib
{
  public void GenerateThirdPartyPdf(string fileName, string content)
  {
    // TODO Implementação que utiliza uma lib de terceiro para gerar o PDF.

    Console.WriteLine($"O arquivo: {fileName}.pdf foi gerado com sucesso!");
  }
}