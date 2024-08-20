//using NetFundamentos.Common.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Pessoa p = new Pessoa();

//p.Name = "Marco";
//p.Idade = 50;
//p.Apresentar();

// Console.WriteLine ("----------------------");
// Calculadora calc = new Calculadora();

// calc.Somar(10,30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
// calc.Potencia (3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada (9);
// Console.WriteLine ("----------------------");


// int numero = 10;

// Console.WriteLine (numero);

// Console.WriteLine ("incrementando o 10");
// //numero = numero +1;
// numero ++;

// //numero = numero -1;
// numero --;

// Console.WriteLine (numero);
// Console.WriteLine ("----------------------");

/********************************************************* */

//Operador NOT   ! - Negação /********** */
// bool choveu = true;
// bool estaTarde = true;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine ("Vou pedalar");
// }
// else
// {
//     Console.WriteLine ("vou noutro dia");
// }

//************************************* */
// Operador Lógico && (and)
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media>=7)
// {
//     Console.WriteLine ("Aprovado!");
// }
// else
// {
//     Console.WriteLine ("Reprovado!");
// }


//Operadores Lógicos  ||  - - - - - - - - - - -  -
// Operador OR

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoResponsavel)
// {
//     Console.WriteLine ("Entrada liberada");
// }
// else{
//     Console.WriteLine ("entrada NÃO Liberada");
// }


//*************************************** */
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine ();  //ESPERA UM COMANDO DO TECLADO

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine ("vogal");
//         break;

//     default:
//         Console.WriteLine ("Não é uma vogal");
//         break;

// }

//****************************************************** */

// if (letra =="a" || 
//     letra =="e" ||
//     letra =="i" ||
//     letra =="o" ||
//     letra =="u")
// {
//     Console.WriteLine ("Vogal");
// }
// else{
//     Console.WriteLine ("Não é uma Vogal");
// }


// ***************************************
// OPERADORES CONDICIONAIS

// int quantidadeEmEstoque = 10;
// int quantidadeCompra=0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine ($"É possível realizar a venda ? {possivelVenda}");

// // IF ALINHADO

// if(quantidadeCompra == 0)
// {
//     Console.WriteLine ("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("-----------------");
//     Console.WriteLine("Venda Realizada.");
//      Console.WriteLine("-----------------");
// }
// else{
    
//     Console.WriteLine("-----------------");
//     Console.WriteLine("Desculpa, não tenho suficiente");
//      Console.WriteLine("-----------------");
// }










// //***************************** */
// //Operadores de Atribuição

// // int a="5"; // erro XXXX
// // Console.WriteLine(a);

// //Converter variável para outro tipo de variável
// //Cast - Casting
// // Converter Int para String
// int a = Convert.ToInt32("5");
// Console.WriteLine(a);

// //Converter Int para String:
// int b = int.Parse("5");
// Console.WriteLine (b);

// //Diferença entre Parse E Convert
// //  CONVERT "null" vai dar zero.
// int c = Convert.ToInt32(null);
// Console.WriteLine(c);

// //   Atenção !!!!
// // - PARSE não aceita "null"   XXX

// //******************************* */
// //Conversão para String

// int inteiro=5;
// string d = inteiro.ToString();
// Console.WriteLine(d);

// //******************************* */
// // Cast Implícito
// // Conversão implícita

// int f=35353;
// double g=f;

// long h=f;
// long j=long.MaxValue;

// Console.WriteLine(f);
// Console.WriteLine(h);
// Console.WriteLine(j);

// //******************************* */
// // Ordem dos operadores

// double m = 4/2+2;
// Console.WriteLine(m);

// m=4/(2+2);
// Console.WriteLine(m);

// //********************************** */

// //CONVERTENDO DE MANEIRA SEGURA //
// //NÃO DEIXA O PROGRAMA PARAR EM CASO...
// // ..DE DAR ERRO NUMA LINHA !

// string n = "15-";
// int o;
// int.TryParse (n, out o);

// Console.WriteLine(o);
// Console.WriteLine ("Conversaão com sucesso");


// //************************************
// // Operador de Atribuição
//     // int a=10;
//     // int b=15;

//     // int c=a+b;
    
//     // c+=5;

//     // Console.WriteLine (c);

// //********************************** */

// // *********************************************
// // Console.WriteLine(dataAtual);

// // DateTime dataNova = DateTime.Now.AddDays(5);
// // Console.WriteLine(dataNova);

// // Console.WriteLine(dataNova.ToString("dd/MM/yyyy HH:mm"));




// //PessoaFisica pessoa1 = new PessoaFisica(); //NEW , estou agora transformando a Class em OBjeto - Pessoa1

// //PessoaFisicaCopia q = new PessoaFisicaCopia();//NEW , estou agora transformando a Class em OBjeto - Pessoa1


// //pessoa1.Nome = "Marco";
// //pessoa1.Idade = 20;
// //pessoa1.Apresentar();

// //--------------------------------------

// // string apresentacao = "Olá, estou aqui";
// // int quantidade = 1;
// // double altura = 1.80;
// // decimal preco = 1.80M;
// // bool condicao = true;

// // Console.WriteLine(apresentacao);
// // Console.WriteLine("Valor da variável: " + apresentacao);
// // Console.WriteLine("Valor da variável: " + quantidade);
// // Console.WriteLine("Valor da variável: " + altura.ToString("0.00"));
// // Console.WriteLine("Valor da variável: " + preco);
// // Console.WriteLine("Valor da variável: " + condicao);


//''