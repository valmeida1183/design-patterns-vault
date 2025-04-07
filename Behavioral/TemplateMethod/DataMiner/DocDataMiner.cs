namespace Behavioral.TemplateMethod.DataMiner;

public class DocDataMiner : DataMiner
{
  protected override string OpenFile(string filePath)
  {
    return @"...file content DOC";
  }

  protected override IEnumerable<string> ExtractData(string fileContent)
  {
    return ["Raw Doc data ...."];
  }

  protected override IEnumerable<string> ParseData(IEnumerable<string> rawData)
  {
    return ["Parsed Doc data ...."];
  }
}