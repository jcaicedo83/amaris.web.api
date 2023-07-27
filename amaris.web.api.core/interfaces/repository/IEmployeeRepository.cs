using amaris.web.api.core.dto;

namespace amaris.web.api.core.interfaces.repository
{
    public interface IEmployeeRepository
    {
        List<Employee> Get();
        Employee Get(int id);
    }
}