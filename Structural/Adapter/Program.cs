// Essa classe representa a classe de negócio do domínio. Onde o adapter seria consumido.

using Structural.Adapter.PdfGenerator;
using Structural.Adapter.PdfGenerator.Interface;

IThirdPartyPdfLib adaptee = new ThirdPartLibPdf();
IPdfAdapter target = new PdfGeneratorAdapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it`s method.");

target.Generate("MeuPdfTeste");
