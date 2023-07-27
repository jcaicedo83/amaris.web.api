using amaris.web.api.core.dto;
using amaris.web.api.core.interfaces.repository;
using amaris.web.api.core.interfaces.services;

namespace amaris.web.api.business
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repo = repository;
        }

        public Response Get(int id)
        {
            Response _response = new Response { Ok = false, Content = null, Message = string.Empty };

            try
            {
                _response.Content = _repo.Get(id);
                _response.Ok = ((Employee)_response.Content)!=null;
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
            }
            return _response;
        }

        public Response Get()
        {
            Response _response = new Response { Ok = false, Content = null, Message = string.Empty };

            try
            {
                _response.Content = _repo.Get();

                _response.Ok = ((List<Employee>)_response.Content).Count>0;
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}