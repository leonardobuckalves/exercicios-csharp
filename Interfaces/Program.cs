using Interfaces;

SalvarXml salvarXml = new SalvarXml();
SalvarJson salvarJson = new SalvarJson();

salvarXml.Salvar();
salvarJson.Salvar();

salvarXml.Nome();
salvarJson.Nome();

ISalvar compactarArquivo = new SalvarXml();
compactarArquivo.Compactar();