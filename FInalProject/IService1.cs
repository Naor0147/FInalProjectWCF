using FInalProject.classes;
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
        User Login(string username, string password);

        //bool
        [OperationContract]
        bool HasUsername(string username);
        [OperationContract]
        bool RegisterUser(User user);
        [OperationContract]
        bool ValidateUser(User user);
        [OperationContract]
        bool AddStats(LevelStats levelStats);

        //user
        [OperationContract]
        User FindUser(string username);
       

        //List<User>
        [OperationContract]
        List<User> GetUsers();

      
        

        [OperationContract]
        LevelStats GetLevelStatsById(int id);


        //List<LevelStats> 
        [OperationContract]
        List<LevelStats> GetLevelStats();

        [OperationContract]
        List<LevelStats> GetLevelStatsPerUser(string Name);

        [OperationContract]
        List<LevelStats> GetLevelStatsByLevelId(int LevelId);


        //List<UserAndLevel>
        [OperationContract]
        List<UserAndLevel> GetAvgScore();



        //New
        [OperationContract]
        
        List<AvgStats2> GetAvgScore2();
        [OperationContract]

        List<CompletedLevelsQuery> GetCompletedLevelsQuery();
        [OperationContract]

        bool DeleteUser(string name);


        [OperationContract]
        bool UpdateUser(string CurrentUsername , string NewUsername, string password, int YearBorn, string Mail);


        //tester if the service update 
        [OperationContract]
        int test();
        // test if the update of the service reference works 
        [OperationContract]
        bool black();

    }



}
