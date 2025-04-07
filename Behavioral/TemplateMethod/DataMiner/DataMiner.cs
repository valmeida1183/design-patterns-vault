namespace Behavioral.TemplateMethod.DataMiner;

public abstract class DataMiner
{

  // Esse é de fato o método template, definindo o fluxo exato a ser executado e permitindo a personalização de alguns passos deste fluxo.
  public void Mine(string filePath)
  {
    var fileContent = OpenFile(filePath);
    var rawData = ExtractData(fileContent);
    var parsedData = ParseData(rawData);
    var analyzedData = AnalyzeData(parsedData);
    SendReport(analyzedData);
  }

  protected abstract string OpenFile(string filePath);
  protected abstract IEnumerable<string> ExtractData(string fileContent);
  protected abstract IEnumerable<string> ParseData(IEnumerable<string> rawData);

  private IEnumerable<string> AnalyzeData(IEnumerable<string> parsedData)
  {
    return [$"Analysed Pdf data: ...."];
  }

  private void SendReport(IEnumerable<string> analyzedData)
  {
    Console.WriteLine("Sending report...");
  }
}