using BerserkerTech.Models.DTOs;

namespace BerserkerTech.Services.OrderLogic.Interfaces
{
    public interface IRequestService
    {
        public void CreateRequest(string clientId, string computerId);
        public List<Request> GetAll();
        public Request GetOne(string requestId);
        public void MarkAsCompleted(string requestId);
        //Computer builder
        public void AssignBuilder(string requestId,string builderId);
        public void DeleteRequest(string requestId);
        public void EditRequest(string request, Request newRequest);
    }
}
