using SisBank;

Conta contaGuilherme = new Conta();
contaGuilherme.nome = "Guilherme Ramos";
contaGuilherme.agencia = 4002;
contaGuilherme.conta = "89225851-6";
contaGuilherme.saldo = 10000;
contaGuilherme.cpf = 1125354785;
Console.WriteLine("Saldo = " + contaGuilherme.saldo);

contaGuilherme.Depositar(500);
Console.WriteLine("Saldo após o deposito = " + contaGuilherme.saldo);

contaGuilherme.Sacar(250);
Console.WriteLine("Saldo após o saque = " + contaGuilherme.saldo);
