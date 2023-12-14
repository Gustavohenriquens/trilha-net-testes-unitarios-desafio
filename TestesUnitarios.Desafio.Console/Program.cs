using TestesUnitarios.Desafio.Console.Services;

ValidacoesString validacoesString = new ValidacoesString();

validacoesString.RetornarQuantidadeCaracteres("Gustavo");

validacoesString.ContemCaractere( "Guga é bom demais", "Guga");

validacoesString.TextoTerminaCom("Ele é otimo", "otimo");


ValidacoesLista validacoesLista = new ValidacoesLista();

List<int> listaOriginal = new List<int> { 5, -1, -8, 9 };
List<int> listaSemNegativos = validacoesLista.RemoverNumerosNegativos(listaOriginal);


List<int> listaNumero = new List<int> { 5, -1, -8, 9 };
int numeroParaProcurar = 9;
bool contemNumero = validacoesLista.ListaContemDeterminadoNumero(listaNumero, numeroParaProcurar);


List<int> listaParaMultiplicar = new List<int> { 5, 7, 8, 9 };
int fatorDeMultiplicacao = 2;
List<int> listaMultiplicada = validacoesLista.MultiplicarNumerosLista(listaParaMultiplicar, fatorDeMultiplicacao);


List<int> listaParaMaiorNumero = new List<int> { 5, -1, -8, 9 };
int maiorNumero = validacoesLista.RetornarMaiorNumeroLista(listaParaMaiorNumero);


List<int> listaParaMenorNumero = new List<int> { 5, -1, -8, 9 };
int menorNumero = validacoesLista.RetornarMenorNumeroLista(listaParaMenorNumero);