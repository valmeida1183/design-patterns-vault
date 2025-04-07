using Behavioral.TemplateMethod.DataMiner;

var docDataMiner = new DocDataMiner();
var csvDataMiner = new CsvDataMiner();
var pdfDataMiner = new PdfDataMiner();

docDataMiner.Mine("test\test.doc");
docDataMiner.Mine("test\test.csv");
docDataMiner.Mine("test\test.pdf");