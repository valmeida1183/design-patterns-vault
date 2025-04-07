namespace Behavioral.TemplateMethod.DataMiner;

public class PdfDataMiner : DataMiner
{
  protected override string OpenFile(string filePath)
  {
    return @"...file content Pdf";
  }

  protected override IEnumerable<string> ExtractData(string fileContent)
  {
    return ["Raw Pdf data ...."];
  }

  protected override IEnumerable<string> ParseData(IEnumerable<string> rawData)
  {
    return ["Parsed Pdf data ...."];
  }
}