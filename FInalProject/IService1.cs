using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FInalProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool HasUsername(string username);
        [OperationContract]
        bool RegisterUser(User user);
        [OperationContract]
        bool ValidateUser(User user);
        [OperationContract]
        List<User> GetUsers();
    }

  
    
}
