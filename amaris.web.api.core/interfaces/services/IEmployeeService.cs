using amaris.web.api.core.dto;

namespace amaris.web.api.core.interfaces.services
{
    public interface IEmployeeService
    {
        Response Get();
        Response Get(int id);
    }
}