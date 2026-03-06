using System.Security.Cryptography.X509Certificates;

namespace API_CICD.Service
{
   

    public interface IAdditionService
    {

        int AdditionService(int nb1, int nb2);



    }
    

    public class AddService : IAdditionService
    {
        public int AdditionService(int nb1, int nb2)
        {
           
             return nb1 + nb2;

                
        }

     
    }

}
