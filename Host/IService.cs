using System.Collections.Generic;
using System.ServiceModel;

namespace Host
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        void AddClient(int num);

        [OperationContract]
        List<GameGrid> GetBoard();
        [OperationContract]
        GameGrid Move(int id, int num);
        [OperationContract]
        GameGrid OponentPos(int id);

        [OperationContract]
        bool CheckCl();
        [OperationContract]
        bool CheckMove(int num);
        [OperationContract]
        bool CheckIfWon(int num);

        [OperationContract]
        void DelClient(int num);
    }
}