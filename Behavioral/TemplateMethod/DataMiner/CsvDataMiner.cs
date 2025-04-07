namespace Behavioral.TemplateMethod.DataMiner;

public class CsvDataMiner : DataMiner
{
  protected override string OpenFile(string filePath)
  {
    return @"...file content CSV";
  }

  protected override IEnumerable<string> ExtractData(string fileContent)
  {
    return ["Raw CSV data ...."];
  }

  protected override IEnumerable<string> ParseData(IEnumerable<string> rawData)
  {
    return ["Parsed CSV data ...."];
  }
}