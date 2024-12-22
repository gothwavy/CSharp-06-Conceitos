namespace _06_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Ryan = new Aluno();
            Ryan.Mensagem();
            // O objeto nao precisa acessar as informacoes dos atributos ou utilizar o metodo media diretamente, entao ao usar private, restringimos o acesso do objeto a fim de deixar o codigo mais intuivo.
        }
    }
}
