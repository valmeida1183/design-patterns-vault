using Structural.Adapter.PdfGenerator.Interface;

namespace Structural.Adapter.PdfGenerator;

public class PdfGeneratorAdapter : IPdfAdapter
{
  private readonly IThirdPartyPdfLib _thirdPartLibPdf;

  public PdfGeneratorAdapter(IThirdPartyPdfLib thirdPartyPdfLib)
  {
    _thirdPartLibPdf = thirdPartyPdfLib;
  }

  public void Generate(string fileName)
  {
    var content = @"Some fixed content or content from anywhere";

    _thirdPartLibPdf.GenerateThirdPartyPdf(fileName, content);
  }
}