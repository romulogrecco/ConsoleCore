using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        string IJogador.Chuta()
        {
            return "teste chute";
        }

        string IJogador.Corre()
        {
            return "teste corre";
        }

        string IJogador.Passa()
        {
            return "teste passa";
        }
    }
}