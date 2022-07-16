using BerserkerTech.Models.DTOs;
using BerserkerTech.Services.OrderLogic.Interfaces;

namespace BerserkerTech.Services.OrderLogic
{
    public class RequestService : IRequestService
    {
        private readonly DatabaseComunication _databaseComunication;

        public RequestService()
        {
            _databaseComunication = new DatabaseComunication();
        }

        public void CreateRequest(string clientId, string computerId)
        {

            string query = @"Insert into Requests(Id,Builder_Id,Client_Id,Computer_Id,Status)
                             Values(@Id,@Builder_Id,@Client_Id,@Computer_Id,@Status)";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Guid.NewGuid().ToString()},
                {"@Builder_Id", null },
                {"@Client_Id",clientId },
                {"@Computer_Id",computerId },
                {"@Status", "Sent"}
            });

        }
        public void AssignBuilder(string requestId, string builderId)
        {
            string query = @"Update table Requests Set Builder_Id = @Builder_Id
                             where Id = @Id";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id",requestId },
                {"@Builder_Id",builderId }
            });
        }

        public void DeleteRequest(string requestId)
        {
            var query = @"delete from Requests where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", requestId}
            });
        }

        public void EditRequest(string request, Request newComp)
        {
            throw new NotImplementedException();
        }

        public void MarkAsCompleted(string computerId)
        {

            string query = @"Update Requests Set Status = 'Completed'
                             where Computer_Id = @Id";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", computerId },
            });
        }

        public List<Request> GetAll()
        {
            string query = @"Select * from Requests";
            return _databaseComunication.Get<Request>(query, new Dictionary<string, dynamic> { });
        }

        public List<Request> GetAllWithStatus(string status)
        {
            string query = @"Select * from Requests
                             where Status = @Status";
            return _databaseComunication.Get<Request>(query, new Dictionary<string, dynamic> {
                {"@Status" ,status }
            });
        }
        public Request GetOne(string requestId)
        {
            var query = @"Select * from Requests where Id = @Id";
            try
            {
                Request result = new Request();
                result = _databaseComunication.Get<Request>(query, new Dictionary<string, dynamic>
                {
                  {"@Id", requestId}

                })[0];
                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
