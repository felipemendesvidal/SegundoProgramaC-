namespace segundoPOO
{
    public class Alunos
    {
         //classes
        public string nome;
        public float idade;
        public string rg;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;

        //metodos
        /// <summary>
        ///     mostra o valor da media final do aluno
        /// </summary>
        /// <returns>Valor da media</returns>
        public float verMedia(){
            return mediaFinal;
        }
        /// <summary>
        ///     Calcula e mostra valor da mensalidade do aluno
        /// </summary>
        /// <returns> valor da mesalidade</returns>
        public float verMensalidade(){
          float valorCalculado = valorMensalidade;

            if(bolsista == true){
                valorCalculado = valorMensalidade - (valorMensalidade * percentual /100);
            }
            return valorCalculado;
        }
    }
}